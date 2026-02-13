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
using System.Windows.Forms.DataVisualization.Charting;

namespace ManagmentApplication.Forms.UserSite
{//Görsel olarak daha kullanıcı dostu bir tasarım yapılabilir.!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public partial class Stocks : Form
    {
        private Chart productChart;

        public Stocks()
        {
            
            InitializeComponent();
            InitializeChart();
            LoadProducts();
        }

        private void InitializeChart()
        {
            productChart = new Chart
            {
                Dock = DockStyle.Fill 
            };

            
            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Ürünler" },
                AxisY = { Title = "Stok Miktarı" }
            };
            productChart.ChartAreas.Add(chartArea);

            
            this.Controls.Add(productChart);
        }


        private void LoadProducts()
        {
            string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
            string query = "SELECT ProductName, Stock FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    DisplayChart(table); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        private void DisplayChart(DataTable table)
        {
            
            productChart.Series.Clear();

           
            Series series = new Series
            {
                ChartType = SeriesChartType.Column, 
                IsValueShownAsLabel = true 
            };

            
            foreach (DataRow row in table.Rows)
            {
                string productName = row["ProductName"].ToString();
                int stock = Convert.ToInt32(row["Stock"]);

                
                series.Points.AddXY(productName, stock);

                
                if (stock < 10) 
                {
                    series.Points.Last().Color = Color.Red; 
                }
                else
                {
                    series.Points.Last().Color = Color.Green; 
                }
            }

            
            productChart.Series.Add(series);
        }


    }
}
