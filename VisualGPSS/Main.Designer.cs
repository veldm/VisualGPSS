namespace VisualGPSS
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.средстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предпросмотрКодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьСхемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускСимуляцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(12, 389);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(200, 362);
            this.propertyGrid.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(213)))), ((int)(((byte)(231)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(226, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(796, 675);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // toolBox
            // 
            this.toolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolBox.Location = new System.Drawing.Point(12, 76);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(200, 307);
            this.toolBox.TabIndex = 3;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Панель элементов";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.средстваToolStripMenuItem,
            this.запускСимуляцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // средстваToolStripMenuItem
            // 
            this.средстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предпросмотрКодаToolStripMenuItem,
            this.печатьСхемыToolStripMenuItem,
            this.сохранитьКакИзображениеToolStripMenuItem});
            this.средстваToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.средстваToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.средстваToolStripMenuItem.Name = "средстваToolStripMenuItem";
            this.средстваToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.средстваToolStripMenuItem.Text = "Средства";
            // 
            // предпросмотрКодаToolStripMenuItem
            // 
            this.предпросмотрКодаToolStripMenuItem.Name = "предпросмотрКодаToolStripMenuItem";
            this.предпросмотрКодаToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.предпросмотрКодаToolStripMenuItem.Text = "Предпросмотр кода";
            // 
            // печатьСхемыToolStripMenuItem
            // 
            this.печатьСхемыToolStripMenuItem.Name = "печатьСхемыToolStripMenuItem";
            this.печатьСхемыToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.печатьСхемыToolStripMenuItem.Text = "Печать схемы";
            // 
            // сохранитьКакИзображениеToolStripMenuItem
            // 
            this.сохранитьКакИзображениеToolStripMenuItem.Name = "сохранитьКакИзображениеToolStripMenuItem";
            this.сохранитьКакИзображениеToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.сохранитьКакИзображениеToolStripMenuItem.Text = "Сохранить как изображение";
            // 
            // запускСимуляцииToolStripMenuItem
            // 
            this.запускСимуляцииToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.запускСимуляцииToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.запускСимуляцииToolStripMenuItem.Name = "запускСимуляцииToolStripMenuItem";
            this.запускСимуляцииToolStripMenuItem.Size = new System.Drawing.Size(135, 21);
            this.запускСимуляцииToolStripMenuItem.Text = "Запуск симуляции";
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.Location = new System.Drawing.Point(955, 19);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(43, 42);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "⚙";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.Location = new System.Drawing.Point(993, 25);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(35, 37);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "?";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.MouseEnter += new System.EventHandler(this.helpButton_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 763);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "VisualGPSS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox toolBox;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.Label settingsButton;
        private System.Windows.Forms.Label helpButton;
        private System.Windows.Forms.ToolStripMenuItem средстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предпросмотрКодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьСхемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускСимуляцииToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Timer timer1;
    }
}

