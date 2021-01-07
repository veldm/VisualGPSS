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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.средстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияКодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьСхемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускСимуляцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BlockOrElementCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВетвлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FieldCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingContainer = new System.Windows.Forms.Panel();
            this.mEndLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ToolBox = new System.Windows.Forms.Panel();
            this.LabelPictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.BlockOrElementCMS.SuspendLayout();
            this.FieldCMS.SuspendLayout();
            this.DrawingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(12, 389);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(200, 369);
            this.propertyGrid.TabIndex = 1;
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
            this.файлToolStripMenuItem.DropDownClosed += new System.EventHandler(this.файлToolStripMenuItem_DropDownClosed);
            this.файлToolStripMenuItem.DropDownOpening += new System.EventHandler(this.файлToolStripMenuItem_DropDownOpening);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.открытьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.open_256_icon_icons_com_76002;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.diskette_save_saveas_1514;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.средстваToolStripMenuItem,
            this.запускСимуляцииToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(275, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // средстваToolStripMenuItem
            // 
            this.средстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияКодаToolStripMenuItem,
            this.печатьСхемыToolStripMenuItem,
            this.сохранитьКакИзображениеToolStripMenuItem});
            this.средстваToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.средстваToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.средстваToolStripMenuItem.Name = "средстваToolStripMenuItem";
            this.средстваToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.средстваToolStripMenuItem.Text = "Средства";
            this.средстваToolStripMenuItem.DropDownClosed += new System.EventHandler(this.средстваToolStripMenuItem_DropDownClosed);
            this.средстваToolStripMenuItem.DropDownOpening += new System.EventHandler(this.средстваToolStripMenuItem_DropDownOpening);
            // 
            // генерацияКодаToolStripMenuItem
            // 
            this.генерацияКодаToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.downloadoutline_110860;
            this.генерацияКодаToolStripMenuItem.Name = "генерацияКодаToolStripMenuItem";
            this.генерацияКодаToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.генерацияКодаToolStripMenuItem.Text = "Генерация кода";
            // 
            // печатьСхемыToolStripMenuItem
            // 
            this.печатьСхемыToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.Print_icon_icons_com_73705;
            this.печатьСхемыToolStripMenuItem.Name = "печатьСхемыToolStripMenuItem";
            this.печатьСхемыToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.печатьСхемыToolStripMenuItem.Text = "Печать схемы";
            // 
            // сохранитьКакИзображениеToolStripMenuItem
            // 
            this.сохранитьКакИзображениеToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources._1491253396_5document_image_82883;
            this.сохранитьКакИзображениеToolStripMenuItem.Name = "сохранитьКакИзображениеToolStripMenuItem";
            this.сохранитьКакИзображениеToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.сохранитьКакИзображениеToolStripMenuItem.Text = "Сохранить как изображение";
            this.сохранитьКакИзображениеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакИзображениеToolStripMenuItem_Click);
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
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.AutoSize = true;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.Location = new System.Drawing.Point(942, 25);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(55, 37);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "⚙";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.settingsButton_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BlockOrElementCMS
            // 
            this.BlockOrElementCMS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockOrElementCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem1,
            this.добавитьВетвлениеToolStripMenuItem});
            this.BlockOrElementCMS.Name = "BlockOrElementCMS";
            this.BlockOrElementCMS.Size = new System.Drawing.Size(230, 76);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.delete_delete_exit_1577;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Image = global::VisualGPSS.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(229, 24);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // добавитьВетвлениеToolStripMenuItem
            // 
            this.добавитьВетвлениеToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.kisspng_computer_icons_git_branching_clip_art_fork_git_5b4d48a3433994_1724267915317915232754;
            this.добавитьВетвлениеToolStripMenuItem.Name = "добавитьВетвлениеToolStripMenuItem";
            this.добавитьВетвлениеToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.добавитьВетвлениеToolStripMenuItem.Text = "Добавить ветвление";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // FieldCMS
            // 
            this.FieldCMS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FieldCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.FieldCMS.Name = "FieldCMS";
            this.FieldCMS.Size = new System.Drawing.Size(136, 28);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.элементToolStripMenuItem,
            this.блокToolStripMenuItem});
            this.создатьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.add_insert_1193;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // элементToolStripMenuItem
            // 
            this.элементToolStripMenuItem.Name = "элементToolStripMenuItem";
            this.элементToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.элементToolStripMenuItem.Text = "Элемент";
            // 
            // блокToolStripMenuItem
            // 
            this.блокToolStripMenuItem.Name = "блокToolStripMenuItem";
            this.блокToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.блокToolStripMenuItem.Text = "Блок";
            // 
            // DrawingContainer
            // 
            this.DrawingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingContainer.AutoScroll = true;
            this.DrawingContainer.Controls.Add(this.mEndLabel);
            this.DrawingContainer.Controls.Add(this.pictureBox);
            this.DrawingContainer.Location = new System.Drawing.Point(218, 76);
            this.DrawingContainer.Name = "DrawingContainer";
            this.DrawingContainer.Size = new System.Drawing.Size(810, 682);
            this.DrawingContainer.TabIndex = 9;
            // 
            // mEndLabel
            // 
            this.mEndLabel.AutoSize = true;
            this.mEndLabel.BackColor = System.Drawing.Color.Transparent;
            this.mEndLabel.Location = new System.Drawing.Point(3510, 2480);
            this.mEndLabel.Name = "mEndLabel";
            this.mEndLabel.Size = new System.Drawing.Size(0, 13);
            this.mEndLabel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(213)))), ((int)(((byte)(231)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ContextMenuStrip = this.BlockOrElementCMS;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(3510, 2480);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // ToolBox
            // 
            this.ToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ToolBox.Location = new System.Drawing.Point(12, 76);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(200, 307);
            this.ToolBox.TabIndex = 10;
            // 
            // LabelPictureBox
            // 
            this.LabelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LabelPictureBox.Image = global::VisualGPSS.Properties.Resources.VisualGPSS_Label1;
            this.LabelPictureBox.Location = new System.Drawing.Point(12, 31);
            this.LabelPictureBox.Name = "LabelPictureBox";
            this.LabelPictureBox.Size = new System.Drawing.Size(100, 29);
            this.LabelPictureBox.TabIndex = 11;
            this.LabelPictureBox.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 763);
            this.Controls.Add(this.LabelPictureBox);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.DrawingContainer);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "VisualGPSS";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.BlockOrElementCMS.ResumeLayout(false);
            this.FieldCMS.ResumeLayout(false);
            this.DrawingContainer.ResumeLayout(false);
            this.DrawingContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.Label settingsButton;
        private System.Windows.Forms.Label helpButton;
        private System.Windows.Forms.ToolStripMenuItem средстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьСхемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускСимуляцииToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip BlockOrElementCMS;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВетвлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генерацияКодаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FieldCMS;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блокToolStripMenuItem;
        private System.Windows.Forms.Panel DrawingContainer;
        private System.Windows.Forms.Panel ToolBox;
        private System.Windows.Forms.PictureBox LabelPictureBox;
        private System.Windows.Forms.Label mEndLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

