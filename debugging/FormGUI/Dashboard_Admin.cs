using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using debugging.Service;
using debugging.Model;

namespace Project_PBO_Kel_5
{
    public partial class Dashboard_Admin : Form
    {
        private readonly ServiceAkun serviceAkun;
        private readonly UserLogin akun;
        private readonly ServiceProduk serviceProduk;
        public Dashboard_Admin(ServiceAkun serviceAkun, UserLogin akun)
        {
            InitializeComponent();
            this.serviceAkun = serviceAkun;
            this.akun = akun;
        }

        // Ganti tanggalLabels jadi bulanLabels
        private readonly string[] bulanLabels = new[]
        {
            "Jan", "Feb", "Mar", "Apr", "Mei", "Jun",
            "Jul", "Agu", "Sep", "Okt", "Nov", "Des"
        };

        private ObservableCollection<double> _data = new ObservableCollection<double>();

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 1; i <= 12; i++)
            {
                _data.Add(rand.Next(0, 100));
            }

            cartesianChart1.Series = new List<ISeries>
            {
                new ColumnSeries<double>
                {
                    Values = _data,
                    Name = "Jumlah per Bulan",
                    Fill = new SolidColorPaint(SKColors.DeepSkyBlue)
                }
            };

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Bulan",
                    Labels = bulanLabels,
                    TextSize = 10,
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightGray),
                    LabelsRotation = 0,
                    UnitWidth = 1, // biar 1 label per kolom
                    MinStep = 1
                }
            };

            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Pendapatan",
                    TextSize = 10,
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightGray),
                    UnitWidth = 1,
                    MinStep = 1
                }
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cartesianChart2_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            var dataBeli = new ObservableCollection<double>();
            var dataSewa = new ObservableCollection<double>();

            for (int i = 1; i <= 12; i++)
            {
                dataBeli.Add(rand.Next(20, 100));
                dataSewa.Add(rand.Next(10, 80));
            }

            cartesianChart2.Series = new List<ISeries>
            {
                new ColumnSeries<double>
                {
                    Values = dataBeli,
                    Name = "Beli",
                    Fill = new SolidColorPaint(SKColors.Blue),
                    Stroke = null
                },
                new ColumnSeries<double>
                {
                    Values = dataSewa,
                    Name = "Sewa",
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null
                }
            };

            cartesianChart2.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Bulan",
                    Labels = bulanLabels,
                    LabelsRotation = 0
                }
            };

            cartesianChart2.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Pendapatan"
                }
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
