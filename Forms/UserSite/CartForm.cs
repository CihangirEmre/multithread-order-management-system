using ManagmentApplication.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagmentApplication.Helper;
using System.Data.SqlClient;
using ManagmentApplication.Models;

namespace ManagmentApplication.Forms.UserSite
{
    public partial class CartForm : Form
    {
        private static string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
        private int userIdForSpesificCart; 
        private CartManager cartManager = new CartManager();

        // Constructor to accept the user ID
        public CartForm(int userId)
        {
            InitializeComponent();
            userIdForSpesificCart = userId;
            conditionalID.Text = userIdForSpesificCart.ToString();
            
            LoadCart();
            
        }


        private void LoadCart()
        {
            
            var table = new DataTable();
            table.Columns.Add("OrderID");    
            table.Columns.Add("Ürün Kodu"); 
            table.Columns.Add("Ürün Adı"); 
            table.Columns.Add("Miktar");    
            table.Columns.Add("Fiyat");     
            table.Columns.Add("Toplam");    

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string query = @"
SELECT 
    o.OrderID AS [OrderID], 
    o.ProductID AS [Ürün Kodu],
    p.ProductName AS [Ürün Adı],
    o.Quantity AS [Miktar],
    p.Price AS [Fiyat],
    o.TotalPrice AS [Toplam]
FROM Orders o
INNER JOIN Products p ON o.ProductID = p.ProductID
WHERE o.CustomerID = @CustomerID AND o.OrderStatus = @OrderStatus";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", conditionalID.Text);
                    command.Parameters.AddWithValue("@OrderStatus", "Pending");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table); 
                    }
                }
            }

            
            cartDgv.DataSource = table;

            
            if (cartDgv.Columns["OrderID"] != null)
            {
                cartDgv.Columns["OrderID"].Visible = false;
            }
        }




        private void RemoveFromCart()
        {
            if (cartDgv.SelectedRows.Count > 0)
            {
                
                int selectedOrderId = Convert.ToInt32(cartDgv.SelectedRows[0].Cells["OrderID"].Value);

                
                DialogResult dialogResult = MessageBox.Show(
                    "Seçilen siparişi sepetten çıkarmak istediğinizden emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(
                            "DELETE FROM Orders WHERE OrderID = @OrderID AND CustomerID = @CustomerID",
                            connection))
                        {
                            
                            command.Parameters.AddWithValue("@OrderID", selectedOrderId);
                            command.Parameters.AddWithValue("@CustomerID", UserInfo.LoggedInUserID);

                            
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                
                                string logMessage = $"Order ID {selectedOrderId} sepetten çıkarıldı.";
                                LogHelper.AddLog(UserInfo.LoggedInUserID, null, "Info", logMessage);

                                
                                LoadCart();
                                MessageBox.Show("Sipariş başarıyla sepetten çıkarıldı.");
                            }
                            else
                            {
                                MessageBox.Show("Sipariş sepetten çıkarılamadı. Lütfen tekrar deneyin.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariş seçin.");
            }
        }



        //Sepetten ürün kaldırma
        private void RemoveOrderButton_Click(object sender, EventArgs e)
        {
            if (GlobalState.IsAdminOperationActive)
            {
                MessageBox.Show("Admin işlem yapıyor. Sepetten ürün çıkartamazsınız.");
                return;
            }
            else { RemoveFromCart(); }
            
        }
        //Sepeti Onaylama
        private void ConfirmCartButton_Click(object sender, EventArgs e)
        {
            if (GlobalState.IsAdminOperationActive)
            {
                MessageBox.Show("Admin işlem yapıyor. Sepete ürün ekleyemezsiniz.");
                return;
            }
            else
            { ConfirmCart(); }
        }
        private void ConfirmCart()
        {
            DialogResult dialogResult = MessageBox.Show(
                "Sepetinizdeki tüm ürünleri onaylamak istediğinizden emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        
                        using (SqlCommand command = new SqlCommand(
                            @"SELECT OrderID, CustomerID, p.ProductName, Quantity, TotalPrice 
                      FROM Orders o
                      INNER JOIN Products p ON o.ProductID = p.ProductID
                      WHERE CustomerID = @CustomerID AND OrderStatus IN ('Pending', 'Onaylanmadı')",
                            connection))
                        {
                            command.Parameters.AddWithValue("@CustomerID", conditionalID.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var order = new Order
                                    {
                                        OrderID = reader.GetInt32(0), 
                                        CustomerID = reader.GetInt32(1), 
                                        ProductName = reader.GetString(2), 
                                        Quantity = reader.GetInt32(3), 
                                        TotalPrice = reader.GetDecimal(4) 
                                    };

                                    OrderProcessingManager.Instance.AddOrder(order);
                                }
                            }
                        }

                        // Sipariş durumunu güncelle
                        using (SqlCommand command = new SqlCommand(
                            "UPDATE Orders SET OrderStatus = @OrderStatus WHERE CustomerID = @CustomerID AND OrderStatus IN ('Pending', 'Onaylanmadı')",
                            connection))
                        {
                            command.Parameters.AddWithValue("@OrderStatus", "AcceptedByUser");
                            command.Parameters.AddWithValue("@CustomerID", conditionalID.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Siparişler başarıyla onaylandı.");
                        LoadCart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata oluştu: {ex.Message}");
                    }
                }
            }
        }




    }
}

