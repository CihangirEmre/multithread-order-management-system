using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentApplication.Helper
{
    public class GenerateRandomCustomers
    {
        private static Random random = new Random();

        public static void GenerateRandom()
        {
            int customerCount = random.Next(5, 11);
            int premiumCount = 0;
            List<string> names = new List<string>
            {
                "Cihan", "Travis", "Sabancı", "Kanye", "Berker", "Taylor",
                "Ece", "Elif", "Cihangir", "Koç", "Zeynep", "Efil", "İrem"
            };

            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    for (int i = 0; i < customerCount; i++)
                    {
                        string type = premiumCount < 2 ? "Premium" : (random.Next(2) == 0 ? "Standard" : "Premium");
                        if (type == "Premium") premiumCount++;

                        int index = random.Next(names.Count);
                        string fullName = names[index];
                        names.RemoveAt(index);


                        decimal budget = random.Next(500, 3001);

                        int password = 123456;

                        string query = "INSERT INTO Customers (CustomerName, Budget, CustomerType, CustomerPassword) " +
                                       "VALUES (@name, @budget, @type,@password)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@name", fullName);
                            cmd.Parameters.AddWithValue("@budget", budget);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.Parameters.AddWithValue ("@password", password);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("Müşteriler oluşturuldu.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                }
                
            }
            
        }
    }
}
