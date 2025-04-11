namespace WindowsFormsApp4
{
    partial class FormPageHum
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.labelHome = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnPinnedMovies = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.Judol = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnOpenFiles = new Guna.UI2.WinForms.Guna2Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHome.Location = new System.Drawing.Point(266, 22);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(68, 28);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Home";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IndicateFocus = true;
            this.btnHome.Location = new System.Drawing.Point(12, 96);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(199, 32);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnPinned_Click);
            // 
            // btnPinnedMovies
            // 
            this.btnPinnedMovies.Animated = true;
            this.btnPinnedMovies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPinnedMovies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPinnedMovies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPinnedMovies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPinnedMovies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPinnedMovies.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinnedMovies.ForeColor = System.Drawing.Color.White;
            this.btnPinnedMovies.IndicateFocus = true;
            this.btnPinnedMovies.Location = new System.Drawing.Point(12, 145);
            this.btnPinnedMovies.Name = "btnPinnedMovies";
            this.btnPinnedMovies.Size = new System.Drawing.Size(199, 32);
            this.btnPinnedMovies.TabIndex = 3;
            this.btnPinnedMovies.Text = "Now Playing";
            this.btnPinnedMovies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPinnedMovies.Click += new System.EventHandler(this.btnPlayQueue_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(12, 326);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(199, 32);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 198);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(199, 32);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Playlists";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSidebar.Controls.Add(this.Judol);
            this.panelSidebar.Controls.Add(this.guna2Button1);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnPinnedMovies);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(224, 449);
            this.panelSidebar.TabIndex = 0;
            // 
            // Judol
            // 
            this.Judol.AutoSize = true;
            this.Judol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Judol.Location = new System.Drawing.Point(12, 12);
            this.Judol.Name = "Judol";
            this.Judol.Size = new System.Drawing.Size(43, 18);
            this.Judol.TabIndex = 2;
            this.Judol.Text = "Judul";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Animated = true;
            this.btnOpenFiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFiles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpenFiles.ForeColor = System.Drawing.Color.White;
            this.btnOpenFiles.IndicateFocus = true;
            this.btnOpenFiles.Location = new System.Drawing.Point(356, 326);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Size = new System.Drawing.Size(155, 32);
            this.btnOpenFiles.TabIndex = 6;
            this.btnOpenFiles.Text = "Open File(s)";
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(315, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(281, 176);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(338, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(338, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormPageHum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOpenFiles);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPageHum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPageHum";
            this.Load += new System.EventHandler(this.FormPageHum_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label labelHome;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnPinnedMovies;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label Judol;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnOpenFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

