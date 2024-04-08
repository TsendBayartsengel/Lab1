namespace rab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИЛЬТРЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яРКОСТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бИНАРИЗАЦИЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТТЕНКИСЕРОГОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.фИЛЬТРЫToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // фИЛЬТРЫToolStripMenuItem
            // 
            this.фИЛЬТРЫToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.яРКОСТЬToolStripMenuItem,
            this.бИНАРИЗАЦИЯToolStripMenuItem,
            this.оТТЕНКИСЕРОГОToolStripMenuItem});
            this.фИЛЬТРЫToolStripMenuItem.Name = "фИЛЬТРЫToolStripMenuItem";
            this.фИЛЬТРЫToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.фИЛЬТРЫToolStripMenuItem.Text = "ФИЛЬТРЫ";
            // 
            // яРКОСТЬToolStripMenuItem
            // 
            this.яРКОСТЬToolStripMenuItem.Name = "яРКОСТЬToolStripMenuItem";
            this.яРКОСТЬToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.яРКОСТЬToolStripMenuItem.Text = "ЯРКОСТЬ";
            this.яРКОСТЬToolStripMenuItem.Click += new System.EventHandler(this.яРКОСТЬToolStripMenuItem_Click);
            // 
            // бИНАРИЗАЦИЯToolStripMenuItem
            // 
            this.бИНАРИЗАЦИЯToolStripMenuItem.Name = "бИНАРИЗАЦИЯToolStripMenuItem";
            this.бИНАРИЗАЦИЯToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.бИНАРИЗАЦИЯToolStripMenuItem.Text = "БИНАРИЗАЦИЯ";
            this.бИНАРИЗАЦИЯToolStripMenuItem.Click += new System.EventHandler(this.бИНАРИЗАЦИЯToolStripMenuItem_Click);
            // 
            // оТТЕНКИСЕРОГОToolStripMenuItem
            // 
            this.оТТЕНКИСЕРОГОToolStripMenuItem.Name = "оТТЕНКИСЕРОГОToolStripMenuItem";
            this.оТТЕНКИСЕРОГОToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.оТТЕНКИСЕРОГОToolStripMenuItem.Text = "ОТТЕНКИ СЕРОГО";
            this.оТТЕНКИСЕРОГОToolStripMenuItem.Click += new System.EventHandler(this.оТТЕНКИСЕРОГОToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 507);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(893, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 530);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИЛЬТРЫToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem яРКОСТЬToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бИНАРИЗАЦИЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТТЕНКИСЕРОГОToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

