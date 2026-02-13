using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentApplication.Helper
{
    public class LogHelper
    {
        private static string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
    
        public static void AddLog(int? customerId,int? orderId,string logType, string logDetails)
        {
            string query = @"
            INSERT INTO Logs (CustomerID, OrderID, LogDate, LogType, LogDetails)
            VALUES (@customerID, @orderID, @logDate, @logType, @logDetails)";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                try
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con)) 
                    {
                        command.Parameters.AddWithValue("@customerID", (object)customerId ?? DBNull.Value);
                        command.Parameters.AddWithValue("@orderID", (object)orderId ?? DBNull.Value);
                        command.Parameters.AddWithValue("@logDate", DateTime.Now);
                        command.Parameters.AddWithValue("@logType", logType);
                        command.Parameters.AddWithValue("@logDetails", logDetails);

                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex) { Console.WriteLine($"Loglama sırasında hata oluştu: {ex.Message}"); }
            }
        }
    }
}
