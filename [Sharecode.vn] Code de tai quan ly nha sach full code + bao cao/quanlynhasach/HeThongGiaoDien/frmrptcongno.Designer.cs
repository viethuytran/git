namespace quanlynhasach.HeThongGiaoDien
{
    partial class frmrptcongno
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
            this.xembaocaocongno = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // xembaocaocongno
            // 
            this.xembaocaocongno.ActiveViewIndex = -1;
            this.xembaocaocongno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xembaocaocongno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xembaocaocongno.Location = new System.Drawing.Point(0, 0);
            this.xembaocaocongno.Name = "xembaocaocongno";
            this.xembaocaocongno.SelectionFormula = "";
            this.xembaocaocongno.Size = new System.Drawing.Size(292, 273);
            this.xembaocaocongno.TabIndex = 0;
            this.xembaocaocongno.ViewTimeSelectionFormula = "";
            // 
            // frmrptcongno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.xembaocaocongno);
            this.Name = "frmrptcongno";
            this.Text = "Báo cáo công nợ";
            this.ResumeLayout(false);

        }

        #endregion

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer xembaocaocongno;

    }
}