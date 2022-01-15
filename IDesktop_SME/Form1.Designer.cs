namespace IDesktop_SME
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlVertical = new System.Windows.Forms.Panel();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panelHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVertical
            // 
            this.pnlVertical.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlVertical.Name = "pnlVertical";
            this.pnlVertical.Size = new System.Drawing.Size(182, 527);
            this.pnlVertical.TabIndex = 0;
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHorizontal.Controls.Add(this.lblHora);
            this.panelHorizontal.Controls.Add(this.lblData);
            this.panelHorizontal.Controls.Add(this.btInfo);
            this.panelHorizontal.Controls.Add(this.btClose);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(182, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(821, 60);
            this.panelHorizontal.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(776, 15);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(37, 31);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btInfo
            // 
            this.btInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInfo.FlatAppearance.BorderSize = 0;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfo.Image = ((System.Drawing.Image)(resources.GetObject("btInfo.Image")));
            this.btInfo.Location = new System.Drawing.Point(734, 16);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(39, 30);
            this.btInfo.TabIndex = 1;
            this.btInfo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(6, 21);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHora.Size = new System.Drawing.Size(166, 38);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "HH:mm:ss:tt";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(202, 35);
            this.lblData.Name = "lblData";
            this.lblData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblData.Size = new System.Drawing.Size(57, 20);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Label2";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 527);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.pnlVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "iDestkop_SME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVertical;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label lblHora;
        internal System.Windows.Forms.Label lblData;
    }
}

