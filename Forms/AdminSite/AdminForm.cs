using ManagmentApplication.Helper;
using ManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentApplication.Forms
{
    public partial class AdminForm : Form
    {
        string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
        private readonly OrderProcessingManager _orderManager = new OrderProcessingManager();
        private static readonly object _syncLock = new object();

       // public static bool IsAdminOperationActive { get; private set; } = false;
        public AdminForm()
        {
            InitializeComponent();
            LoadProducts();
            LoadAcceptedOrders();
        }

        private void LoadProducts()
        {
            string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
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

        private void AddProduct(string productName, decimal price, int stock)
        {
            string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
            string query = "INSERT INTO Products (ProductName, Price, Stock) VALUES (@name, @price, @stock)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", productName);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@stock", stock);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla eklendi!");
                        LoadProducts(); // Ürün listesini güncelle
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        private void DeleteProduct(int productId)
        {
            string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
            string query = "DELETE FROM Products WHERE ProductID = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", productId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla silindi!");
                        LoadProducts(); // Ürün listesini güncelle
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        private void UpdateProduct(int productId, string name, decimal price, int stock)
        {
            string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
            string query = "UPDATE Products SET ProductName = @name, Price = @price, Stock = @stock WHERE ProductID = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", productId);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@stock", stock);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla güncellendi!");

                        // Ürün listesini yeniden yükle
                        LoadProducts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (productDgv.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = productDgv.SelectedRows[0];

                
                txtProductName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                nudStock.Value = Convert.ToDecimal(selectedRow.Cells["Stock"].Value);
            }
        }



        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (productDgv.SelectedRows.Count > 0)
            {
                
                int productId = Convert.ToInt32(productDgv.SelectedRows[0].Cells["ProductID"].Value);

                
                string updatedName = txtProductName.Text;
                decimal updatedPrice = Convert.ToDecimal(txtPrice.Text);
                int updatedStock = (int)nudStock.Value;

                UpdateProduct(productId, updatedName, updatedPrice, updatedStock);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!");
            }
        }




        private void EkleButonu_Click(object sender, EventArgs e)
        {
            
            string productName = txtProductName.Text;
            decimal productPrice;
            int productStock;

            // Validate input
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Ürün adı boş olamaz!");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out productPrice) || productPrice <= 0)
            {
                MessageBox.Show("Geçerli bir fiyat girin!");
                return;
            }
            if (nudStock.Value <= 0)
            {
                MessageBox.Show("Stok miktarı 0'dan büyük olmalıdır!");
                return;
            }

            productStock = (int)nudStock.Value;

            
            AddProduct(productName, productPrice, productStock);
        }


        private void SilButonu_Click(object sender, EventArgs e)
        {
            if (productDgv.SelectedRows.Count > 0)
            {
                
                int productId = Convert.ToInt32(productDgv.SelectedRows[0].Cells["ProductID"].Value);

                
                DialogResult dialogResult = MessageBox.Show(
                    "Seçilen ürünü silmek istediğinizden emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    DeleteProduct(productId);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!");
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            GlobalState.IsAdminOperationActive = !GlobalState.IsAdminOperationActive;

            if (GlobalState.IsAdminOperationActive)
                MessageBox.Show("Admin işlemi başladı. Diğer kullanıcı işlemleri durduruldu.");
            else
                MessageBox.Show("Admin işlemi sona erdi. Kullanıcı işlemleri tekrar aktif.");
        }


        private void UpdateOrderAndCustomerBudget(int orderId, int customerId, decimal totalPrice, int quantity, string productName)
        {
            string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Bütçe kontrolü
                        string checkBudgetQuery = "SELECT Budget FROM Customers WHERE CustomerID = @CustomerID";
                        decimal currentBudget = 0;

                        using (SqlCommand checkBudgetCommand = new SqlCommand(checkBudgetQuery, connection, transaction))
                        {
                            checkBudgetCommand.Parameters.AddWithValue("@CustomerID", customerId);
                            currentBudget = Convert.ToDecimal(checkBudgetCommand.ExecuteScalar());
                        }

                        // Stok kontrolü
                        string checkStockQuery = "SELECT Stock FROM Products WHERE ProductName = @ProductName";
                        int currentStock = 0;

                        using (SqlCommand checkStockCommand = new SqlCommand(checkStockQuery, connection, transaction))
                        {
                            checkStockCommand.Parameters.AddWithValue("@ProductName", productName);
                            currentStock = Convert.ToInt32(checkStockCommand.ExecuteScalar());
                        }

                        // Bütçe ve stok yeterli mi?
                        if (currentBudget >= totalPrice && currentStock >= quantity)
                        {
                            // Sipariş durumunu güncelle
                            string updateOrderQuery = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";
                            using (SqlCommand updateOrderCommand = new SqlCommand(updateOrderQuery, connection, transaction))
                            {
                                updateOrderCommand.Parameters.AddWithValue("@OrderStatus", "AcceptedByAdmin");
                                updateOrderCommand.Parameters.AddWithValue("@OrderID", orderId);

                                updateOrderCommand.ExecuteNonQuery();
                            }

                            // Kullanıcı bütçesini güncelle
                            string updateBudgetQuery = "UPDATE Customers SET Budget = Budget - @TotalPrice, TotalSpent = TotalSpent + @TotalPrice WHERE CustomerID = @CustomerID";
                            using (SqlCommand updateBudgetCommand = new SqlCommand(updateBudgetQuery, connection, transaction))
                            {
                                updateBudgetCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                updateBudgetCommand.Parameters.AddWithValue("@CustomerID", customerId);

                                updateBudgetCommand.ExecuteNonQuery();
                            }

                            // Ürün stoğunu güncelle
                            string updateStockQuery = "UPDATE Products SET Stock = Stock - @Quantity WHERE ProductName = @ProductName";
                            using (SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, connection, transaction))
                            {
                                updateStockCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateStockCommand.Parameters.AddWithValue("@ProductName", productName);

                                updateStockCommand.ExecuteNonQuery();
                            }

                            // Loglama işlemi
                            string insertLogQuery = "INSERT INTO Logs (CustomerID, OrderID, LogDate, LogType, LogDetails) VALUES (@CustomerID, @OrderID, @LogDate, @LogType, @LogDetails)";
                            using (SqlCommand insertLogCommand = new SqlCommand(insertLogQuery, connection, transaction))
                            {
                                insertLogCommand.Parameters.AddWithValue("@CustomerID", customerId);
                                insertLogCommand.Parameters.AddWithValue("@OrderID", orderId);
                                insertLogCommand.Parameters.AddWithValue("@LogDate", DateTime.Now);
                                insertLogCommand.Parameters.AddWithValue("@LogType", "Info"); 
                                insertLogCommand.Parameters.AddWithValue("@LogDetails", $"Sipariş onaylandı: OrderID {orderId} - {productName} ürünü");

                                insertLogCommand.ExecuteNonQuery();
                            }

                            
                            transaction.Commit();
                            MessageBox.Show($"Sipariş onaylandı: OrderID {orderId}");
                        }
                        else
                        {
                            string rejectOrderQuery = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";

                            using (SqlCommand rejectOrderCmd = new SqlCommand(rejectOrderQuery, connection, transaction))
                            {
                                rejectOrderCmd.Parameters.AddWithValue("@OrderStatus", "Onaylanmadı");
                                rejectOrderCmd.Parameters.AddWithValue("@OrderID", orderId);
                                rejectOrderCmd.ExecuteNonQuery();
                            }

                            // Loglama işlemi
                            string insertLogQuery = "INSERT INTO Logs (CustomerID, OrderID, LogDate, LogType, LogDetails) VALUES (@CustomerID, @OrderID, @LogDate, @LogType, @LogDetails)";
                            using (SqlCommand insertLogCommand = new SqlCommand(insertLogQuery, connection, transaction))
                            {
                                insertLogCommand.Parameters.AddWithValue("@CustomerID", customerId);
                                insertLogCommand.Parameters.AddWithValue("@OrderID", orderId);
                                insertLogCommand.Parameters.AddWithValue("@LogDate", DateTime.Now);
                                insertLogCommand.Parameters.AddWithValue("@LogType", "Warning"); 
                                if (currentBudget < totalPrice && currentStock >= quantity)
                                {
                                    insertLogCommand.Parameters.AddWithValue("@LogDetails", $"Sipariş reddedildi: Yetersiz bütçe (OrderID: {orderId})");
                                }
                                else if (currentStock < quantity && currentBudget >= totalPrice)
                                {
                                    insertLogCommand.Parameters.AddWithValue("@LogDetails", $"Sipariş reddedildi: Yetersiz stok (OrderID: {orderId})");
                                }
                                else
                                {
                                    insertLogCommand.Parameters.AddWithValue("@LogDetails", $"Sipariş reddedildi: Yetersiz bütçe veya stok (OrderID: {orderId})");
                                }

                                insertLogCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show($"Sipariş onaylanamadı: Yetersiz bütçe veya stok (OrderID: {orderId})");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata loglaması
                    using (SqlCommand insertErrorLogCommand = new SqlCommand("INSERT INTO Logs (CustomerID, OrderID, LogDate, LogType, LogDetails) VALUES (@CustomerID, @OrderID, @LogDate, @LogType, @LogDetails)", new SqlConnection(connectionString)))
                    {
                        insertErrorLogCommand.Parameters.AddWithValue("@CustomerID", customerId);
                        insertErrorLogCommand.Parameters.AddWithValue("@OrderID", orderId);
                        insertErrorLogCommand.Parameters.AddWithValue("@LogDate", DateTime.Now);
                        insertErrorLogCommand.Parameters.AddWithValue("@LogType", "Error"); 
                        insertErrorLogCommand.Parameters.AddWithValue("@LogDetails", $"Hata oluştu: {ex.Message}");

                        insertErrorLogCommand.Connection.Open();
                        insertErrorLogCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }


        private void UpdateDataGridView(object sender, EventArgs e)
        {
            
            var orders = OrderProcessingManager.Instance.GetOrders();

            
            DataTable table = new DataTable();
            table.Columns.Add("OrderID", typeof(int));
            table.Columns.Add("CustomerID", typeof(int));
            table.Columns.Add("CustomerType", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("TotalPrice", typeof(decimal));
            table.Columns.Add("WaitingTime", typeof(int)); // Bekleme süresi
            table.Columns.Add("PriorityScore", typeof(int)); // Öncelik skoru

            // Siparişleri tabloya ekle
            foreach (var order in orders)
            {
                table.Rows.Add(order.OrderID, order.CustomerID, order.CustomerType, order.Quantity, order.ProductName, order.TotalPrice, order.WaitingTime, order.PriorityScore);
            }

            // DataGridView'in veri kaynağını güncelle
            acceptedOrdersByUser.DataSource = table;
        }



        private void LoadAcceptedOrders()
        {
            // Siparişleri veritabanından çekmek için sorgu
            string query = @"
SELECT 
    o.OrderID,
    o.CustomerID,
    c.CustomerType,
    o.Quantity,
    p.ProductName,
    o.TotalPrice
FROM Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
INNER JOIN Products p ON o.ProductID = p.ProductID
WHERE o.OrderStatus = 'AcceptedByUser'";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        
                        DataTable table = new DataTable();
                        table.Columns.Add("OrderID", typeof(int));
                        table.Columns.Add("CustomerID", typeof(int));
                          table.Columns.Add("CustomerType", typeof(string));
                        table.Columns.Add("Quantity", typeof(int));
                        table.Columns.Add("ProductName", typeof(string));
                        table.Columns.Add("TotalPrice", typeof(decimal));

                        while (reader.Read())
                        {
                            var order = new Order
                            {
                                OrderID = reader.GetInt32(0),
                                CustomerID = reader.GetInt32(1),
                                CustomerType = reader.GetString(2),
                                Quantity = reader.GetInt32(3),
                                ProductName = reader.GetString(4),
                                TotalPrice = reader.GetDecimal(5)
                            };

                            _orderManager.AddOrder(order);

                            
                            table.Rows.Add(order.OrderID, order.CustomerID, order.CustomerType, order.Quantity, order.ProductName, order.TotalPrice);
                        }

                        // DataGridView'in veri kaynağını ayarla
                        acceptedOrdersByUser.DataSource = table;

                        // İstenirse bazı sütunları görünmez yapabilir
                        // acceptedOrdersByUser.Columns["OrderID"].Visible = false;
                    }
                }
            }
        }



        private void ApproveNextOrder()
        {
            lock (_syncLock)
            {
                var nextOrder = _orderManager.GetNextOrder();
                if (nextOrder == null)
                {
                    MessageBox.Show("Onaylanacak sipariş yok.");
                    return;
                }

                UpdateOrderAndCustomerBudget(
                    nextOrder.OrderID,
                    nextOrder.CustomerID,
                    nextOrder.TotalPrice,
                    nextOrder.Quantity,
                    nextOrder.ProductName
                );

                _orderManager.RemoveOrder(nextOrder.OrderID);
                LoadAcceptedOrders();
            }
        }

        private void onaylamaButonu_Click(object sender, EventArgs e)
        {
            lock (_syncLock)
            {
                while (true)
                {
                    var nextOrder = _orderManager.GetNextOrder();
                    if (nextOrder == null)
                    {
                        MessageBox.Show("Tüm siparişler onaylandı.");
                        break;
                    }

                    ApproveNextOrder();
                }
            }
        }



    }
}
