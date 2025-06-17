using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugging
{
    public partial class Gelembung_chat : UserControl
    {
        
        public Gelembung_chat(string pesan, bool dariAdmin, DateTime waktu)
        {
            InitializeComponent();

            lblPesan.Text = pesan;
            lblPesan.ForeColor = Color.Black;
            lblWaktu.Text = waktu.ToLocalTime().ToString("HH:mm");
            lblWaktu.ForeColor = Color.Black;

            lblPesan.MaximumSize = new Size(250, 0);
            lblPesan.AutoSize = true;
            lblWaktu.AutoSize = true;
            panelPesan.BackColor = dariAdmin ? Color.LightGreen : Color.WhiteSmoke;
            //this.Dock = DockStyle.Right;
            this.Margin = new Padding(5);

            lblWaktu.Location = new Point(lblPesan.Left, lblPesan.Bottom + 5);
            if (dariAdmin)
            {
                //panelPesan.BackColor = Color.LightGreen;
                //this.Dock = DockStyle.None;
                this.Anchor = AnchorStyles.Left;
                this.Padding = new Padding(10, 5, 50, 5);
            }
            else
            {
                //panelPesan.BackColor = Color.WhiteSmoke;
                //this.Dock = DockStyle.None;
                this.Anchor = AnchorStyles.Right;
                this.Padding = new Padding(50, 5, 10, 5);
            }
        }
        public Panel GetWrappedPanel(int lebarContainer, bool dariAdmin)
        {
            Panel wrappeer = new Panel();
            wrappeer.Width = lebarContainer;
            wrappeer.Height = this.Height + 10;
            wrappeer.AutoSize = true;
            wrappeer.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.Dock = dariAdmin ? DockStyle.Right : DockStyle.Left;
            if (dariAdmin)
            {
                this.Dock = DockStyle.Left;
            }
            else
            {
                this.Dock = DockStyle.Right;
            }
            wrappeer.Controls.Add(this);
            return wrappeer;
        }

        private void Gelembung_chat_Load(object sender, EventArgs e)
        {

        }

        private void panelPesan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPesan_Click(object sender, EventArgs e)
        {

        }

        private void lblPesan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
