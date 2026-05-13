using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_SQL_CC_7_
{
    internal class Program
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;

        static void Main(string[] args)
        {
            //InsertDetails();
            UpdateSalary();
            DisplayDetails();
        }

        static void InsertDetails()
        {
            try
            {
                conn = getConnection();

                cmd = new SqlCommand("InsertionDetail", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpName", "Saran");
                cmd.Parameters.AddWithValue("@EmpSal", 50000);
                cmd.Parameters.AddWithValue("@EmpType", "P");

                cmd.ExecuteNonQuery();

                Console.WriteLine("Inserted Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void UpdateSalary()
        {
            try
            {
                conn = getConnection();
                conn.Open();

                Console.Write("Enter Employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("updatsalary", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empid", id);

                decimal updatedSalary = Convert.ToDecimal(cmd.ExecuteScalar());

                Console.WriteLine("Updated Salary: " + updatedSalary);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void DisplayDetails()
        {
            try
            {
                conn = getConnection();

                cmd = new SqlCommand("SELECT * FROM EmployeeDetail", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine("\nEmpNo\tEmpName\tEmpSal\tEmpType");
                Console.WriteLine("----------------------------------------");

                while (dr.Read())
                {
                    Console.WriteLine(
                        dr["Empno"] + "\t" +
                        dr["EmpName"] + "\t" +
                        dr["EmpSal"] + "\t" +
                        dr["EmpType"]);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static SqlConnection getConnection()
        {
            conn = new SqlConnection(
                "Data Source=ICS-LT-3DT99K3;" +
                "Initial Catalog=Employeesmanagements;" +
                "Integrated Security=True");

            conn.Open();
            return conn;
        }
    }
}