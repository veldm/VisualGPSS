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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.command_TBButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transferUncon_TBButton = new System.Windows.Forms.Button();
            this.transferPick_TBButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TransferV_TBButton = new System.Windows.Forms.Button();
            this.transferBoth_TBButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LabelPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.BlockOrElementCMS.SuspendLayout();
            this.FieldCMS.SuspendLayout();
            this.DrawingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.ToolBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.propertyGrid.ViewBackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.diskette_save_saveas_1514;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
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
            this.settingsButton.Size = new System.Drawing.Size(38, 37);
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
            this.добавитьВетвлениеToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.linegraphsymbol_120645;
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
            this.pictureBox.Size = new System.Drawing.Size(27810, 18779);
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
            this.ToolBox.AutoScroll = true;
            this.ToolBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolBox.Controls.Add(this.groupBox3);
            this.ToolBox.Controls.Add(this.groupBox2);
            this.ToolBox.Controls.Add(this.groupBox1);
            this.ToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolBox.Location = new System.Drawing.Point(12, 76);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(200, 307);
            this.ToolBox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 385);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Блоки";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::VisualGPSS.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(93, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::VisualGPSS.Properties.Resources.creation_date_sort_icon_155568;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(9, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::VisualGPSS.Properties.Resources._353443_clock_stopwatch_timer_watch_107503;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(93, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = global::VisualGPSS.Properties.Resources.Pustoy_block;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(9, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImage = global::VisualGPSS.Properties.Resources._file_upload_90117;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(9, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.BackgroundImage = global::VisualGPSS.Properties.Resources._file_download_90117;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(93, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImage = global::VisualGPSS.Properties.Resources.download_info_icon_icons1;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(9, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 2;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BackgroundImage = global::VisualGPSS.Properties.Resources.stop_upload_button_icon_icons_com_71328;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(93, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 1;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.command_TBButton);
            this.groupBox2.Location = new System.Drawing.Point(7, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Команды";
            // 
            // command_TBButton
            // 
            this.command_TBButton.BackColor = System.Drawing.Color.Transparent;
            this.command_TBButton.BackgroundImage = global::VisualGPSS.Properties.Resources.kisspng_brand_symbol_font_utilities_terminal_5ab0990dc46a48_96718621158215229578045;
            this.command_TBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.command_TBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.command_TBButton.Location = new System.Drawing.Point(10, 27);
            this.command_TBButton.Name = "command_TBButton";
            this.command_TBButton.Size = new System.Drawing.Size(70, 70);
            this.command_TBButton.TabIndex = 5;
            this.command_TBButton.UseVisualStyleBackColor = false;
            this.command_TBButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transferUncon_TBButton);
            this.groupBox1.Controls.Add(this.transferPick_TBButton);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.TransferV_TBButton);
            this.groupBox1.Controls.Add(this.transferBoth_TBButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Переходы";
            // 
            // transferUncon_TBButton
            // 
            this.transferUncon_TBButton.BackColor = System.Drawing.Color.Transparent;
            this.transferUncon_TBButton.BackgroundImage = global::VisualGPSS.Properties.Resources._5;
            this.transferUncon_TBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transferUncon_TBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferUncon_TBButton.Location = new System.Drawing.Point(10, 30);
            this.transferUncon_TBButton.Name = "transferUncon_TBButton";
            this.transferUncon_TBButton.Size = new System.Drawing.Size(70, 70);
            this.transferUncon_TBButton.TabIndex = 4;
            this.transferUncon_TBButton.UseVisualStyleBackColor = false;
            this.transferUncon_TBButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // transferPick_TBButton
            // 
            this.transferPick_TBButton.BackColor = System.Drawing.Color.Transparent;
            this.transferPick_TBButton.BackgroundImage = global::VisualGPSS.Properties.Resources._1;
            this.transferPick_TBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transferPick_TBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferPick_TBButton.Location = new System.Drawing.Point(10, 210);
            this.transferPick_TBButton.Name = "transferPick_TBButton";
            this.transferPick_TBButton.Size = new System.Drawing.Size(70, 70);
            this.transferPick_TBButton.TabIndex = 0;
            this.transferPick_TBButton.UseVisualStyleBackColor = false;
            this.transferPick_TBButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::VisualGPSS.Properties.Resources._4;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(94, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // TransferV_TBButton
            // 
            this.TransferV_TBButton.BackColor = System.Drawing.Color.Transparent;
            this.TransferV_TBButton.BackgroundImage = global::VisualGPSS.Properties.Resources._3;
            this.TransferV_TBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransferV_TBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferV_TBButton.Location = new System.Drawing.Point(10, 122);
            this.TransferV_TBButton.Name = "TransferV_TBButton";
            this.TransferV_TBButton.Size = new System.Drawing.Size(70, 70);
            this.TransferV_TBButton.TabIndex = 2;
            this.TransferV_TBButton.UseVisualStyleBackColor = false;
            this.TransferV_TBButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // transferBoth_TBButton
            // 
            this.transferBoth_TBButton.BackColor = System.Drawing.Color.Transparent;
            this.transferBoth_TBButton.BackgroundImage = global::VisualGPSS.Properties.Resources._2;
            this.transferBoth_TBButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transferBoth_TBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferBoth_TBButton.Location = new System.Drawing.Point(94, 122);
            this.transferBoth_TBButton.Name = "transferBoth_TBButton";
            this.transferBoth_TBButton.Size = new System.Drawing.Size(70, 70);
            this.transferBoth_TBButton.TabIndex = 1;
            this.transferBoth_TBButton.UseVisualStyleBackColor = false;
            this.transferBoth_TBButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All files (*.*)|*.*";
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
            this.ToolBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button transferPick_TBButton;
        private System.Windows.Forms.Button transferBoth_TBButton;
        private System.Windows.Forms.Button TransferV_TBButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button transferUncon_TBButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button command_TBButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

