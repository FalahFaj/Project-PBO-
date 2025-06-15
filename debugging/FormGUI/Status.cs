using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Npgsql;
using debugging.Model;
using debugging.Service;    

namespace debugging
{
    [NotMapped]
    public partial class Status : Form
    {
        private DataTable tabelData = new DataTable();
        private DataView viewData;
        private ServiceAkun serviceAkun; // Added declaration for 'serviceAkun'  

        public Status(ServiceAkun serviceAkun) // Added constructor to initialize 'serviceAkun'  
        {
            this.serviceAkun = serviceAkun;
            InitializeComponent();
        }

        private void Riwayat_Transaksi_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3F51B5");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;

            comboBox1.Items.Add("Semua");
            comboBox1.Items.Add("Beli");
            comboBox1.Items.Add("Sewa");
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewData == null) return;

            string status = comboBox1.SelectedItem.ToString();
            if (status == "Semua")
            {
                viewData.RowFilter = "";
            }
            else
            {
                viewData.RowFilter = $"status = '{status}'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard_admin2 dashboard = new dashboard_admin2(serviceAkun, null); // Fixed constructor call  
            dashboard.Show();
            this.Close();
        }
    }
}
