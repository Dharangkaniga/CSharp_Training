using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Globalization;
namespace TrainManagementSystem
{
    public class Customer
    {
        string conStr = @"Data Source=ICS-LT-3DT99K3;Initial Catalog=TrainDB;Integrated Security=True";

        // ---------------- VIEW TRAINS ----------------
        public void ViewTrain()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM TrainDetail WHERE IsDeleted=0", con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("\n-----------------------------");
                    Console.WriteLine($"Train No : {dr["TrainNo"]}");
                    Console.WriteLine($"Name     : {dr["TrainName"]}");
                    Console.WriteLine($"Route    : {dr["Source"]} -> {dr["Destination"]}");

                    Console.WriteLine($"Sleeper  : {dr["SleeperSeats"]} | ₹{dr["SleeperPrice"]}");
                    Console.WriteLine($"2AC      : {dr["AC2Seats"]} | ₹{dr["AC2Price"]}");
                    Console.WriteLine($"3AC      : {dr["AC3Seats"]} | ₹{dr["AC3Price"]}");
                }

                dr.Close();
            }
        }

        // -------BOOKING TICKET-----------

        public void BookTicket()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                Console.Write("Train No: ");
                int tno = int.Parse(Console.ReadLine());

                Console.Write("Passengers (max 3): ");
                int p = int.Parse(Console.ReadLine());

                if (p < 1 || p > 3)
                {
                    Console.WriteLine("Passenger limit is 1 to 3 only");
                    return;
                }

                Console.Write("Enter Travel Date (dd/MM/yyyy): ");
                DateTime travelDate;

                if (!DateTime.TryParseExact(
                        Console.ReadLine(),
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out travelDate))
                {
                    Console.WriteLine("Invalid Date Format");
                    return;
                }

                if (travelDate.Date < DateTime.Today)
                {
                    Console.WriteLine("Travel date cannot be in the past");
                    return;
                }

                Console.WriteLine("Select Class:");
                Console.WriteLine("1. Sleeper");
                Console.WriteLine("2. 2AC");
                Console.WriteLine("3. 3AC");

                int choice = int.Parse(Console.ReadLine());

                string seatCol = "";
                string priceCol = "";
                string travelClass = "";

                switch (choice)
                {
                    case 1:
                        seatCol = "SleeperSeats";
                        priceCol = "SleeperPrice";
                        travelClass = "SLEEPER";
                        break;

                    case 2:
                        seatCol = "AC2Seats";
                        priceCol = "AC2Price";
                        travelClass = "2AC";
                        break;

                    case 3:
                        seatCol = "AC3Seats";
                        priceCol = "AC3Price";
                        travelClass = "3AC";
                        break;

                    default:
                        Console.WriteLine("Invalid Class");
                        return;
                }

                SqlCommand get = new SqlCommand(
                    $"SELECT {seatCol}, {priceCol} FROM TrainDetail WHERE TrainNo=@tno AND IsDeleted=0",
                    con);

                get.Parameters.AddWithValue("@tno", tno);

                SqlDataReader dr = get.ExecuteReader();

                if (!dr.Read())
                {
                    Console.WriteLine("Train not found");
                    dr.Close();
                    return;
                }

                int availableSeats = Convert.ToInt32(dr[0]);
                decimal price = Convert.ToDecimal(dr[1]);

                dr.Close();

                Console.WriteLine("Available Seats : " + availableSeats);

                if (availableSeats < p)
                {
                    Console.WriteLine("Not enough seats available");
                    return;
                }

                decimal amount = p * price;

                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    SqlCommand ins = new SqlCommand(
                        @"INSERT INTO BookingDetail
                (BookDate, TravelDate, TrainNo, TravelClass, Passengers, Amount)
                VALUES
                (GETDATE(), @travelDate, @tno, @cls, @p, @amt);

                SELECT SCOPE_IDENTITY();",
                        con, tx);

                    ins.Parameters.AddWithValue("@travelDate", travelDate);
                    ins.Parameters.AddWithValue("@tno", tno);
                    ins.Parameters.AddWithValue("@cls", travelClass);
                    ins.Parameters.AddWithValue("@p", p);
                    ins.Parameters.AddWithValue("@amt", amount);

                    int bookingId = Convert.ToInt32(ins.ExecuteScalar());

                    SqlCommand upd = new SqlCommand(
                        $"UPDATE TrainDetail SET {seatCol} = {seatCol} - @p WHERE TrainNo=@tno",
                        con, tx);

                    upd.Parameters.AddWithValue("@p", p);
                    upd.Parameters.AddWithValue("@tno", tno);

                    upd.ExecuteNonQuery();

                    tx.Commit();

                    Console.WriteLine("\nBOOKING SUCCESSFUL \n");
                    Console.WriteLine("Booking ID : " + bookingId);
                    Console.WriteLine("Travel Date: " + travelDate.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Class      : " + travelClass);
                    Console.WriteLine("Passengers : " + p);
                    Console.WriteLine("Amount     : ₹" + amount);
                    Console.WriteLine("Remaining Seats : " + (availableSeats - p));
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    Console.WriteLine("BOOKING FAILED");
                    Console.WriteLine(ex.Message);
                }
            }
        }
        // ---------------- CANCEL TICKET ----------------
        public void CancelTicket()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                Console.Write("Booking Id: ");
                int bid = int.Parse(Console.ReadLine());

                SqlCommand get = new SqlCommand(
                    @"SELECT TrainNo, TravelClass, Passengers
              FROM BookingDetail
              WHERE BookingId=@id", con);

                get.Parameters.AddWithValue("@id", bid);

                SqlDataReader dr = get.ExecuteReader();

                if (!dr.Read())
                {
                    Console.WriteLine("Invalid Booking ID");
                    dr.Close();
                    return;
                }

                int tno = Convert.ToInt32(dr["TrainNo"]);
                string travelClass = dr["TravelClass"].ToString();
                int p = Convert.ToInt32(dr["Passengers"]);

                dr.Close();

                string seatCol = "";

                if (travelClass == "SLEEPER")
                    seatCol = "SleeperSeats";
                else if (travelClass == "2AC")
                    seatCol = "AC2Seats";
                else if (travelClass == "3AC")
                    seatCol = "AC3Seats";

                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    
                    SqlCommand upd = new SqlCommand(
                        $"UPDATE TrainDetail SET {seatCol} = {seatCol} + @p WHERE TrainNo=@tno",
                        con, tx);

                    upd.Parameters.AddWithValue("@p", p);
                    upd.Parameters.AddWithValue("@tno", tno);

                    upd.ExecuteNonQuery();

                    
                    SqlCommand refund = new SqlCommand(
                        @"INSERT INTO CancellationDetail
                        (BookingId, NoTickets, RefundAmount)
                        VALUES (@bid, @tickets, @amt)",
                        con, tx);

                    refund.Parameters.AddWithValue("@bid", bid);

                    // If your table has CHECK(NoTickets=1)
                    refund.Parameters.AddWithValue("@tickets", 1);

                    refund.Parameters.AddWithValue("@amt", 900);

                    refund.ExecuteNonQuery();

                   
                    SqlCommand del = new SqlCommand(
                        "DELETE FROM BookingDetail WHERE BookingId=@id",
                        con, tx);

                    del.Parameters.AddWithValue("@id", bid);

                    del.ExecuteNonQuery();

                    tx.Commit();

                    Console.WriteLine("CANCELLATION SUCCESSFUL");
                    Console.WriteLine("Refund Amount : 900");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    Console.WriteLine("CANCEL FAILED");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}