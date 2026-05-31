using System;
using System.Data.SqlClient;

namespace TrainManagementSystem
{
    public class Admin
    {
        string conStr = @"Data Source=ICS-LT-3DT99K3;Initial Catalog=TrainDB;Integrated Security=True";

        // ---------------- ADD TRAIN ----------------
        public void AddTrain()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                Console.Write("Train No: ");
                int tno = int.Parse(Console.ReadLine());

                Console.Write("Train Name: ");
                string name = Console.ReadLine();

                Console.Write("From: ");
                string from = Console.ReadLine();

                Console.Write("To: ");
                string to = Console.ReadLine();

                int sSeats = 0, a2Seats = 0, a3Seats = 0;
                decimal sPrice = 0, a2Price = 0, a3Price = 0;

                Console.WriteLine("Enter Number Of Sleeper Seats:");
                sSeats = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Sleeper seats Price:");
                sPrice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Number Of 2AC Seats:");
                a2Seats = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2AC seats Price:");
                a2Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Number Of Sleeper Seats:");
                a3Seats = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 3AC seats Price:");
                a3Price = decimal.Parse(Console.ReadLine());

                string query = @"INSERT INTO TrainDetail
                                (TrainNo, TrainName, Source, Destination,
                                SleeperSeats, SleeperPrice,
                                AC2Seats, AC2Price,
                                AC3Seats, AC3PriceIsDeleted)
                                VALUE(@tno,@name,@source,@destination,@sSeat,@sPrice, @a2Seat,@a2Price,@a3Seat,@a3Price,0)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@tno", tno);
                cmd.Parameters.AddWithValue("@name", name);

                cmd.Parameters.AddWithValue("@source", from);
                cmd.Parameters.AddWithValue("@destination", to);

                cmd.Parameters.AddWithValue("@sSeat", sSeats);
                cmd.Parameters.AddWithValue("@sPrice", sPrice);

                cmd.Parameters.AddWithValue("@a2Seat", a2Seats);
                cmd.Parameters.AddWithValue("@a2Price", a2Price);

                cmd.Parameters.AddWithValue("@a3Seat", a3Seats);
                cmd.Parameters.AddWithValue("@a3Price", a3Price);

                cmd.ExecuteNonQuery();

                Console.WriteLine("TRAIN ADDED SUCCESSFULLY");
            }
        }

        // ---------------- VIEW TRAIN ----------------
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
                    Console.WriteLine("\n--------------------------------");
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

        // ---------------- DELETE TRAIN ----------------
        public void DeleteTrain()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                Console.Write("Train No: ");
                int tno = int.Parse(Console.ReadLine());

                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM BookingDetail WHERE TrainNo=@tno", con);

                check.Parameters.AddWithValue("@tno", tno);

                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    Console.WriteLine("Cannot delete - bookings exist");
                    return;
                }

                SqlCommand del = new SqlCommand(
                    "UPDATE TrainDetail SET IsDeleted=1 WHERE TrainNo=@tno", con);

                del.Parameters.AddWithValue("@tno", tno);
                del.ExecuteNonQuery();

                Console.WriteLine("TRAIN DELETED SUCCESSFULLY");
            }
        }
    }
}