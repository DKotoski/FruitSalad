namespace VizuelnoSeminarska
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblInstc = new System.Windows.Forms.Label();
            this.lblNovaIgra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRekordi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Location = new System.Drawing.Point(519, 334);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(162, 44);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            this.lblAbout.MouseEnter += new System.EventHandler(this.lblAbout_MouseEnter);
            this.lblAbout.MouseLeave += new System.EventHandler(this.lblAbout_MouseLeave);
            // 
            // lblInstc
            // 
            this.lblInstc.BackColor = System.Drawing.Color.Transparent;
            this.lblInstc.Location = new System.Drawing.Point(12, 334);
            this.lblInstc.Name = "lblInstc";
            this.lblInstc.Size = new System.Drawing.Size(209, 44);
            this.lblInstc.TabIndex = 2;
            this.lblInstc.Click += new System.EventHandler(this.lblInstc_Click);
            this.lblInstc.MouseEnter += new System.EventHandler(this.lblInstc_MouseEnter);
            this.lblInstc.MouseLeave += new System.EventHandler(this.lblInstc_MouseLeave);
            // 
            // lblNovaIgra
            // 
            this.lblNovaIgra.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaIgra.Location = new System.Drawing.Point(243, 242);
            this.lblNovaIgra.Name = "lblNovaIgra";
            this.lblNovaIgra.Size = new System.Drawing.Size(225, 64);
            this.lblNovaIgra.TabIndex = 3;
            this.lblNovaIgra.Click += new System.EventHandler(this.lblNovaIgra_Click);
            this.lblNovaIgra.MouseEnter += new System.EventHandler(this.lblNovaIgra_MouseEnter);
            this.lblNovaIgra.MouseLeave += new System.EventHandler(this.lblNovaIgra_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(47, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // lblRekordi
            // 
            this.lblRekordi.BackColor = System.Drawing.Color.Transparent;
            this.lblRekordi.Location = new System.Drawing.Point(287, 324);
            this.lblRekordi.Name = "lblRekordi";
            this.lblRekordi.Size = new System.Drawing.Size(153, 54);
            this.lblRekordi.TabIndex = 2;
            this.lblRekordi.Click += new System.EventHandler(this.lblRekordi_Click);
            this.lblRekordi.MouseEnter += new System.EventHandler(this.lblInstc_MouseEnter);
            this.lblRekordi.MouseLeave += new System.EventHandler(this.lblInstc_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VizuelnoSeminarska.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNovaIgra);
            this.Controls.Add(this.lblRekordi);
            this.Controls.Add(this.lblInstc);
            this.Controls.Add(this.lblAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(709, 426);
            this.MinimumSize = new System.Drawing.Size(709, 426);
            this.Name = "Form1";
            this.Text = "Овошна Салата";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblInstc;
        private System.Windows.Forms.Label lblNovaIgra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRekordi;

    }
}

