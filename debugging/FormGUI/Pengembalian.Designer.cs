namespace debugging
{
    partial class Pengembalian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpPengembalian = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpPengembalian
            // 
            flpPengembalian.AutoScroll = true;
            flpPengembalian.Dock = DockStyle.Fill;
            flpPengembalian.Location = new Point(0, 0);
            flpPengembalian.Name = "flpPengembalian";
            flpPengembalian.Size = new Size(640, 360);
            flpPengembalian.TabIndex = 0;
            // 
            // Pengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(flpPengembalian);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pengembalian";
            Text = "SubSuvernir";
            Load += Pengembalian_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpPengembalian;
    }
}