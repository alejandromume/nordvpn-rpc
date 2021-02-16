namespace NordVPN_RPC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGoogleSwitch1 = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaMediumCheckBox1 = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaMediumCheckBox3 = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaMediumCheckBox2 = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.Enabled = false;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(124, 126);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(101, 137);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(20, 15);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "IP:";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(-55, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(459, 107);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::NordVPN_RPC.Properties.Resources.nordvpn;
            this.gunaPictureBox1.InitialImage = global::NordVPN_RPC.Properties.Resources.nordvpn;
            this.gunaPictureBox1.Location = new System.Drawing.Point(219, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(82, 75);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaGoogleSwitch1
            // 
            this.gunaGoogleSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaGoogleSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch1.Location = new System.Drawing.Point(290, 133);
            this.gunaGoogleSwitch1.Name = "gunaGoogleSwitch1";
            this.gunaGoogleSwitch1.Size = new System.Drawing.Size(38, 20);
            this.gunaGoogleSwitch1.TabIndex = 3;
            this.gunaGoogleSwitch1.CheckedChanged += new System.EventHandler(this.gunaGoogleSwitch1_CheckedChanged);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::NordVPN_RPC.Properties.Resources.discord;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(124, 369);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(112)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 5;
            this.gunaButton2.Text = "Stop RPC";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::NordVPN_RPC.Properties.Resources.discord;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(124, 312);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Start RPC";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaMediumCheckBox1
            // 
            this.gunaMediumCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaMediumCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaMediumCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox1.Location = new System.Drawing.Point(185, 232);
            this.gunaMediumCheckBox1.Name = "gunaMediumCheckBox1";
            this.gunaMediumCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumCheckBox1.TabIndex = 7;
            this.gunaMediumCheckBox1.CheckedChanged += new System.EventHandler(this.gunaMediumCheckBox1_CheckedChanged);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(10, 166);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(379, 19);
            this.gunaSeparator1.TabIndex = 8;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(101, 234);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 15);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Elapsed Time:";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(119, 207);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Check All:";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // gunaMediumCheckBox3
            // 
            this.gunaMediumCheckBox3.BaseColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox3.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaMediumCheckBox3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaMediumCheckBox3.FillColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox3.Location = new System.Drawing.Point(185, 205);
            this.gunaMediumCheckBox3.Name = "gunaMediumCheckBox3";
            this.gunaMediumCheckBox3.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumCheckBox3.TabIndex = 12;
            this.gunaMediumCheckBox3.CheckedChanged += new System.EventHandler(this.gunaMediumCheckBox3_CheckedChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(127, 260);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(53, 15);
            this.gunaLabel3.TabIndex = 17;
            this.gunaLabel3.Text = "Country:";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaMediumCheckBox2
            // 
            this.gunaMediumCheckBox2.BaseColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaMediumCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaMediumCheckBox2.FillColor = System.Drawing.Color.White;
            this.gunaMediumCheckBox2.Location = new System.Drawing.Point(185, 258);
            this.gunaMediumCheckBox2.Name = "gunaMediumCheckBox2";
            this.gunaMediumCheckBox2.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumCheckBox2.TabIndex = 16;
            this.gunaMediumCheckBox2.CheckedChanged += new System.EventHandler(this.gunaMediumCheckBox2_CheckedChanged_1);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(7, 440);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel6.TabIndex = 18;
            this.gunaLabel6.Text = "RPC Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(75, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Que fue";
            this.notifyIcon1.BalloonTipTitle = "Pana";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaProgressBar1.Location = new System.Drawing.Point(129, 440);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.gunaProgressBar1.Size = new System.Drawing.Size(149, 13);
            this.gunaProgressBar1.TabIndex = 21;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.stopRPCToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(124, 70);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.connectToolStripMenuItem.Text = "Start RPC";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // stopRPCToolStripMenuItem
            // 
            this.stopRPCToolStripMenuItem.Name = "stopRPCToolStripMenuItem";
            this.stopRPCToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.stopRPCToolStripMenuItem.Text = "Stop RPC";
            this.stopRPCToolStripMenuItem.Click += new System.EventHandler(this.stopRPCToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 464);
            this.Controls.Add(this.gunaProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaMediumCheckBox2);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaMediumCheckBox3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaMediumCheckBox1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaGoogleSwitch1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NordVPN Discord RPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaMediumCheckBox gunaMediumCheckBox1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaMediumCheckBox gunaMediumCheckBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaMediumCheckBox gunaMediumCheckBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRPCToolStripMenuItem;
    }
}

