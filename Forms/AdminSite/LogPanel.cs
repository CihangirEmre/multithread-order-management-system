using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagmentApplication.Forms.AdminSite
{
    public partial class LogPanel : Form
    {
        private static string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
        private Timer refreshTimer;

        public LogPanel()
        {
            InitializeComponent();
            LoadLogs(); 
            InitializeTimer(); 
        }

        
        private void LoadLogs()
        {
            string query = "SELECT TOP (1000) [LogID], [CustomerID], [OrderID], [LogDate], [LogType], [LogDetails] FROM [EsZamanliSiparisYonetimi].[dbo].[Logs]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    allLogsDGV.DataSource = dataTable; 

                    
                    allLogsDGV.Columns["LogDetails"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    
                    allLogsDGV.Columns["LogDetails"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    
                    allLogsDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }



        // Timer'ı başlatan metod
        private void InitializeTimer()
        {
            // Timer'ı 30 saniye aralıklarla çalışacak şekilde ayarla (30000 ms = 30 saniye)
            refreshTimer = new Timer();
            refreshTimer.Interval = 30000; 
            refreshTimer.Tick += new EventHandler(TimerTick); 
            refreshTimer.Start(); 
        }

        
        private void TimerTick(object sender, EventArgs e)
        {
            LoadLogs(); 
        }
    }
}