namespace VizuelnoSeminarska
{
    partial class Igra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRekord = new System.Windows.Forms.Button();
            this.lblRekord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.btnGlavnoMeni = new System.Windows.Forms.Button();
            this.lblNivo = new System.Windows.Forms.Label();
            this.btnPauzirajIgra = new System.Windows.Forms.Button();
            this.tmrVreme = new System.Windows.Forms.Timer(this.components);
            this.tmrTopki = new System.Windows.Forms.Timer(this.components);
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnRekord);
            this.panel1.Controls.Add(this.lblRekord);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 360);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnRekord
            // 
            this.btnRekord.Enabled = false;
            this.btnRekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRekord.ForeColor = System.Drawing.Color.Black;
            this.btnRekord.Location = new System.Drawing.Point(198, 316);
            this.btnRekord.Name = "btnRekord";
            this.btnRekord.Size = new System.Drawing.Size(103, 31);
            this.btnRekord.TabIndex = 1;
            this.btnRekord.Text = "Запиши";
            this.btnRekord.UseVisualStyleBackColor = true;
            this.btnRekord.Visible = false;
            this.btnRekord.Click += new System.EventHandler(this.btnRekord_Click);
            this.btnRekord.MouseEnter += new System.EventHandler(this.btnRekord_MouseEnter);
            this.btnRekord.MouseLeave += new System.EventHandler(this.btnRekord_MouseLeave);
            // 
            // lblRekord
            // 
            this.lblRekord.AutoSize = true;
            this.lblRekord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(178)))), ((int)(((byte)(242)))));
            this.lblRekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRekord.ForeColor = System.Drawing.Color.Black;
            this.lblRekord.Location = new System.Drawing.Point(116, 278);
            this.lblRekord.Name = "lblRekord";
            this.lblRekord.Size = new System.Drawing.Size(267, 31);
            this.lblRekord.TabIndex = 0;
            this.lblRekord.Text = "Имате нов рекорд!!!";
            this.lblRekord.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Време :";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.BackColor = System.Drawing.Color.Transparent;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(612, 37);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(72, 24);
            this.lblVreme.TabIndex = 2;
            this.lblVreme.Text = "00 : 00";
            // 
            // btnGlavnoMeni
            // 
            this.btnGlavnoMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.btnGlavnoMeni.Location = new System.Drawing.Point(533, 334);
            this.btnGlavnoMeni.Name = "btnGlavnoMeni";
            this.btnGlavnoMeni.Size = new System.Drawing.Size(148, 41);
            this.btnGlavnoMeni.TabIndex = 3;
            this.btnGlavnoMeni.Text = "Главно Мени";
            this.btnGlavnoMeni.UseVisualStyleBackColor = false;
            this.btnGlavnoMeni.Click += new System.EventHandler(this.btnGlavnoMeni_Click);
            this.btnGlavnoMeni.MouseEnter += new System.EventHandler(this.btnGlavnoMeni_MouseEnter);
            this.btnGlavnoMeni.MouseLeave += new System.EventHandler(this.btnGlavnoMeni_MouseLeave);
            // 
            // lblNivo
            // 
            this.lblNivo.AutoSize = true;
            this.lblNivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNivo.Location = new System.Drawing.Point(555, 201);
            this.lblNivo.Name = "lblNivo";
            this.lblNivo.Size = new System.Drawing.Size(101, 25);
            this.lblNivo.TabIndex = 4;
            this.lblNivo.Text = "Ниво - 1";
            // 
            // btnPauzirajIgra
            // 
            this.btnPauzirajIgra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnPauzirajIgra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPauzirajIgra.Location = new System.Drawing.Point(533, 287);
            this.btnPauzirajIgra.Name = "btnPauzirajIgra";
            this.btnPauzirajIgra.Size = new System.Drawing.Size(148, 41);
            this.btnPauzirajIgra.TabIndex = 5;
            this.btnPauzirajIgra.Text = "Паузирај Игра";
            this.btnPauzirajIgra.UseVisualStyleBackColor = false;
            this.btnPauzirajIgra.Click += new System.EventHandler(this.btnPauzirajIgra_Click);
            this.btnPauzirajIgra.MouseEnter += new System.EventHandler(this.btnPauzirajIgra_MouseEnter);
            this.btnPauzirajIgra.MouseLeave += new System.EventHandler(this.btnPauzirajIgra_MouseLeave);
            // 
            // tmrVreme
            // 
            this.tmrVreme.Interval = 1000;
            this.tmrVreme.Tick += new System.EventHandler(this.tmrVreme_Tick);
            // 
            // tmrTopki
            // 
            this.tmrTopki.Interval = 34;
            this.tmrTopki.Tick += new System.EventHandler(this.tmrTopki_Tick);
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnNovaIgra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovaIgra.Location = new System.Drawing.Point(533, 240);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(148, 41);
            this.btnNovaIgra.TabIndex = 6;
            this.btnNovaIgra.Text = "Нова Игра";
            this.btnNovaIgra.UseVisualStyleBackColor = false;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            this.btnNovaIgra.MouseEnter += new System.EventHandler(this.btnNovaIgra_MouseEnter);
            this.btnNovaIgra.MouseLeave += new System.EventHandler(this.btnNovaIgra_MouseLeave);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(519, 156);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(109, 25);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Овошја: 0";
            // 
            // Igra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VizuelnoSeminarska.Properties.Resources.igrabg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 387);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.btnPauzirajIgra);
            this.Controls.Add(this.lblNivo);
            this.Controls.Add(this.btnGlavnoMeni);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(20, 20);
            this.MaximizeBox = false;
            this.Name = "Igra";
            this.Text = "Овошна Салата";
            this.Load += new System.EventHandler(this.Igra_Load);
            this.ResizeEnd += new System.EventHandler(this.Igra_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Button btnGlavnoMeni;
        private System.Windows.Forms.Label lblNivo;
        private System.Windows.Forms.Button btnPauzirajIgra;
        private System.Windows.Forms.Timer tmrVreme;
        private System.Windows.Forms.Timer tmrTopki;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRekord;
        private System.Windows.Forms.Button btnRekord;
    }
}