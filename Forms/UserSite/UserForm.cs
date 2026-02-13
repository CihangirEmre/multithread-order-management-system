using ManagmentApplication.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ManagmentApplication.Models;
using ManagmentApplication.Forms.UserSite;


namespace ManagmentApplication.Forms
{
    public partial class UserForm : Form
    {
        private System.Windows.Forms.Timer orderStatusTimer;

        private static string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
        CartManager cartManager = new CartManager();
        public UserForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData(UserInfo.LoggedInUserID);
            LoadOrderStatus(UserInfo.LoggedInUserID);
                                                                
            orderStatusTimer = new System.Windows.Forms.Timer
            {
                Interval = 5000, 
                Enabled = true 
            };

            
            orderStatusTimer.Tick += OrderStatusTimer_Tick;

           
            orderStatusTimer.Start();
        }

        private void OrderStatusTimer_Tick(object sender, EventArgs e)
        {
            LoadOrderStatus(UserInfo.LoggedInUserID); 
        }


        //Kullanıcı bilgilerini görüntüleme
        private void LoadCustomerData(int customerID)
        {
            string query = "SELECT CustomerID, CustomerName, CustomerType, Budget, TotalSpent FROM Customers WHERE CustomerID = @customerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerID", customerID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        userDgw.DataSource = table; 
                        userDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        //Sipariş bilgilerini görüntüleme
        private void LoadOrderStatus(int customerID)
        {
            string query = @"
    SELECT o.OrderID, o.ProductID, o.Quantity, o.TotalPrice, o.OrderDate, o.OrderStatus, p.ProductName
    FROM Orders o
    INNER JOIN Products p ON o.ProductID = p.ProductID
    WHERE o.CustomerID = @customerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@customerID", customerID);

                        
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        orderStatusDgv.DataSource = table; 

                        
                        orderStatusDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                       
                        orderStatusDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        
                        orderStatusDgv.ScrollBars = ScrollBars.Both; 
                        orderStatusDgv.AutoResizeColumns();
                        orderStatusDgv.AutoResizeRows();

                        
                        foreach (DataGridViewRow row in orderStatusDgv.Rows)
                        {
                            
                            if (row.Cells["OrderStatus"].Value != DBNull.Value && row.Cells["OrderStatus"].Value != null)
                            {
                                string status = row.Cells["OrderStatus"].Value.ToString();

                                if (status == "Onaylanmadı")
                                {
                                    row.Cells["OrderStatus"].Style.BackColor = Color.IndianRed;
                                    row.Cells["OrderStatus"].Style.ForeColor = Color.Black;
                                    row.Cells["OrderStatus"].ToolTipText = "Order is pending approval.";
                                }
                                else if (status == "AcceptedByUser")
                                {
                                    row.Cells["OrderStatus"].Style.BackColor = Color.LightGreen;
                                    row.Cells["OrderStatus"].Style.ForeColor = Color.Black;
                                    row.Cells["OrderStatus"].ToolTipText = "Order has been accepted by the user.";
                                }
                                else
                                {
                                    
                                    row.Cells["OrderStatus"].Style.BackColor = Color.LightGoldenrodYellow;
                                    row.Cells["OrderStatus"].Style.ForeColor = Color.Black;
                                }
                            }
                            else
                            {
                                
                                row.Cells["OrderStatus"].Style.BackColor = Color.LightGray;
                                row.Cells["OrderStatus"].Style.ForeColor = Color.Black;
                                row.Cells["OrderStatus"].ToolTipText = "No status available.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }





        //Siparişlerin bekleme durumu fonksiyonu
        /*private void ColorizeOrderStatus()
        {
            foreach (DataGridViewRow row in orderStatusDgv.Rows)
            {
                string status = row.Cells["OrderStatus"].Value.ToString();

                switch (status)
                {
                    case "Pending":
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "Processing":
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case "Completed":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        }*/

        //Sepeti Görüntüleme
        private void CartL_Click(object sender, EventArgs e)
        {
            if (GlobalState.IsAdminOperationActive)
            {
                MessageBox.Show("Admin işlem yapıyor. Sepete ürün ekleyemezsiniz.");
                return;
            }
            else {
                if (userDgw.Rows.Count > 0)
                {
                    int userIdForCart = Convert.ToInt32(userDgw.Rows[0].Cells[0].Value);
                    CartForm form = new CartForm(userIdForCart);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Sepet boş!");
                }
            }

            
        }

        //Ürünleri kullanıcıya listeleme
        private void LoadProducts()
        {
           
            string query = "SELECT ProductID, ProductName, Price, Stock FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    productDgv.DataSource = table; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        //Sepete ekleme işlemi
        private void AddToCart()
        {

            if (productDgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in productDgv.SelectedRows)
                {
                    var product = new Product
                    {
                        ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                        ProductName = row.Cells["ProductName"].Value.ToString(),
                        Price = Convert.ToDecimal(row.Cells["Price"].Value),
                        Stock = Convert.ToInt32(row.Cells["Stock"].Value)
                    };

                    int quantity = (int)quantityNumericUpDown.Value;

                    if (quantity > 0 && quantity <= product.Stock)
                    {
                        
                        UserInfo.UserCart.AddToCart(product, quantity);

                        
                        string logMessage = $"{quantity} adet {product.ProductName} sepete eklendi.";
                        LogHelper.AddLog(UserInfo.LoggedInUserID, null, "Info", logMessage);
                        MessageBox.Show(logMessage); // Remove after development

                        
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerID, ProductID, Quantity, TotalPrice) VALUES (@CustomerID, @ProductID, @Quantity, @TotalPrice)", connection))
                            {
                                command.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(userDgw.Rows[0].Cells[0].Value)); // Assuming LoggedInUserID is the CustomerID
                                command.Parameters.AddWithValue("@ProductID", product.ProductID);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@TotalPrice", quantity * product.Price);

                                command.ExecuteNonQuery();
                            }
                        }
                        LoadOrderStatus(UserInfo.LoggedInUserID);
                    }
                    else
                    {
                        
                        string logMessage = $"Yetersiz stok: {quantity} adet {product.ProductName} sepete eklenemedi.";
                        LogHelper.AddLog(UserInfo.LoggedInUserID, null, "Error", logMessage);
                        MessageBox.Show(logMessage); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
            }
        }
        //Sepete ekler
        private void addCartButton_Click(object sender, EventArgs e)
        {
            if (GlobalState.IsAdminOperationActive)
            {
                MessageBox.Show("Admin işlem yapıyor. Sepete ürün ekleyemezsiniz.");
                return;
            }
            else { AddToCart(); }
            
        }
        //Stok formu açar
        private void ProductStockLabel_Click(object sender, EventArgs e)
        {
            if (GlobalState.IsAdminOperationActive)
            {
                MessageBox.Show("Admin işlem yapıyor. Stokları görüntüleyemezsiniz");
                return;
            }
            else
            {
                Stocks stockForm = new Stocks();
                stockForm.ShowDialog();
            }
           
        }

        

    }
}
