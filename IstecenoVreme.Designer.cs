namespace VizuelnoSeminarska
{
    partial class IstecenoVreme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstecenoVreme));
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnZapisi = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtkazi.Location = new System.Drawing.Point(286, 153);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(166, 32);
            this.btnOtkazi.TabIndex = 0;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnGlavnoMeni_Click);
            this.btnOtkazi.MouseEnter += new System.EventHandler(this.btnGlavnoMeni_MouseEnter);
            this.btnOtkazi.MouseLeave += new System.EventHandler(this.btnGlavnoMeni_MouseLeave);
            // 
            // btnZapisi
            // 
            this.btnZapisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnZapisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZapisi.Location = new System.Drawing.Point(12, 153);
            this.btnZapisi.Name = "btnZapisi";
            this.btnZapisi.Size = new System.Drawing.Size(166, 32);
            this.btnZapisi.TabIndex = 0;
            this.btnZapisi.Text = "Запиши";
            this.btnZapisi.UseVisualStyleBackColor = false;
            this.btnZapisi.Click += new System.EventHandler(this.btnNovaIgra_Click);
            this.btnZapisi.MouseEnter += new System.EventHandler(this.btnNovaIgra_MouseEnter);
            this.btnZapisi.MouseLeave += new System.EventHandler(this.btnNovaIgra_MouseLeave);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIme.Location = new System.Drawing.Point(38, 76);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(108, 20);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Вашето Име:";
            // 
            // tbIme
            // 
            this.tbIme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIme.Location = new System.Drawing.Point(152, 73);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(130, 26);
            this.tbIme.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(307, 76);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(351, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // IstecenoVreme
            // 
            this.BackgroundImage = global::VizuelnoSeminarska.Properties.Resources.рекорд;
            this.ClientSize = new System.Drawing.Size(464, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnZapisi);
            this.Controls.Add(this.btnOtkazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IstecenoVreme";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IstecenoVreme_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnZapisi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblScore;

    }
}