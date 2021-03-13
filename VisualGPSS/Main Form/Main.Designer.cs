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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.upScaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleCB = new System.Windows.Forms.ToolStripComboBox();
            this.downScaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolBox = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.terminateButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.uncertainButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.multiChannelDeviceButton = new System.Windows.Forms.Button();
            this.singleChannelDeviceButton = new System.Windows.Forms.Button();
            this.imageSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.schemaSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LabelPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.BlockOrElementCMS.SuspendLayout();
            this.FieldCMS.SuspendLayout();
            this.ToolBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(12, 389);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(200, 317);
            this.propertyGrid.TabIndex = 1;
            this.propertyGrid.ViewBackColor = System.Drawing.SystemColors.ButtonFace;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.graphicsRefresh);
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
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.diskette_save_saveas_1514;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.средстваToolStripMenuItem,
            this.запускСимуляцииToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(393, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // средстваToolStripMenuItem
            // 
            this.средстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияКодаToolStripMenuItem,
            this.печатьСхемыToolStripMenuItem,
            this.сохранитьКакИзображениеToolStripMenuItem,
            this.toolStripSeparator1,
            this.upScaleMenuItem,
            this.scaleCB,
            this.downScaleMenuItem});
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
            this.генерацияКодаToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.генерацияКодаToolStripMenuItem.Text = "Генерация кода";
            this.генерацияКодаToolStripMenuItem.Click += new System.EventHandler(this.генерацияКодаToolStripMenuItem_Click);
            // 
            // печатьСхемыToolStripMenuItem
            // 
            this.печатьСхемыToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.Print_icon_icons_com_73705;
            this.печатьСхемыToolStripMenuItem.Name = "печатьСхемыToolStripMenuItem";
            this.печатьСхемыToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.печатьСхемыToolStripMenuItem.Text = "Печать схемы";
            // 
            // сохранитьКакИзображениеToolStripMenuItem
            // 
            this.сохранитьКакИзображениеToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources._1491253396_5document_image_82883;
            this.сохранитьКакИзображениеToolStripMenuItem.Name = "сохранитьКакИзображениеToolStripMenuItem";
            this.сохранитьКакИзображениеToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.сохранитьКакИзображениеToolStripMenuItem.Text = "Сохранить как изображение";
            this.сохранитьКакИзображениеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакИзображениеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // upScaleMenuItem
            // 
            this.upScaleMenuItem.Image = global::VisualGPSS.Properties.Resources.zoomin_zoom_search_find_1530;
            this.upScaleMenuItem.Name = "upScaleMenuItem";
            this.upScaleMenuItem.Size = new System.Drawing.Size(262, 26);
            this.upScaleMenuItem.Text = "Увеличить масштаб";
            this.upScaleMenuItem.Click += new System.EventHandler(this.UpScale);
            // 
            // scaleCB
            // 
            this.scaleCB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scaleCB.Name = "scaleCB";
            this.scaleCB.Size = new System.Drawing.Size(100, 25);
            this.scaleCB.Text = "100%";
            this.scaleCB.TextChanged += new System.EventHandler(this.ScaleChanged);
            // 
            // downScaleMenuItem
            // 
            this.downScaleMenuItem.Image = global::VisualGPSS.Properties.Resources.zoomout_zoom_search_find_1530;
            this.downScaleMenuItem.Name = "downScaleMenuItem";
            this.downScaleMenuItem.Size = new System.Drawing.Size(262, 26);
            this.downScaleMenuItem.Text = "Уменьшить масштаб";
            this.downScaleMenuItem.Click += new System.EventHandler(this.DownScale);
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
            this.settingsButton.Location = new System.Drawing.Point(885, 23);
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
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.Location = new System.Drawing.Point(929, 26);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 31);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "?";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.MouseEnter += new System.EventHandler(this.helpButton_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.graphicsRefresh);
            // 
            // BlockOrElementCMS
            // 
            this.BlockOrElementCMS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockOrElementCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BlockOrElementCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem1,
            this.добавитьВетвлениеToolStripMenuItem});
            this.BlockOrElementCMS.Name = "BlockOrElementCMS";
            this.BlockOrElementCMS.Size = new System.Drawing.Size(234, 82);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.delete_delete_exit_1577;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Image = global::VisualGPSS.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.EditElement);
            // 
            // добавитьВетвлениеToolStripMenuItem
            // 
            this.добавитьВетвлениеToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.linegraphsymbol_120645;
            this.добавитьВетвлениеToolStripMenuItem.Name = "добавитьВетвлениеToolStripMenuItem";
            this.добавитьВетвлениеToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.добавитьВетвлениеToolStripMenuItem.Text = "Добавить ветвление";
            this.добавитьВетвлениеToolStripMenuItem.Click += new System.EventHandler(this.AddTransfer);
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
            this.FieldCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FieldCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.FieldCMS.Name = "FieldCMS";
            this.FieldCMS.Size = new System.Drawing.Size(140, 30);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.элементToolStripMenuItem,
            this.блокToolStripMenuItem});
            this.создатьToolStripMenuItem.Image = global::VisualGPSS.Properties.Resources.add_insert_1193;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
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
            // ToolBox
            // 
            this.ToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ToolBox.AutoScroll = true;
            this.ToolBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolBox.Controls.Add(this.groupBox3);
            this.ToolBox.Controls.Add(this.groupBox2);
            this.ToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolBox.Location = new System.Drawing.Point(12, 76);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(200, 307);
            this.ToolBox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.terminateButton);
            this.groupBox3.Controls.Add(this.generateButton);
            this.groupBox3.Controls.Add(this.uncertainButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 205);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Блоки";
            // 
            // terminateButton
            // 
            this.terminateButton.BackColor = System.Drawing.Color.White;
            this.terminateButton.BackgroundImage = global::VisualGPSS.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.terminateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.terminateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminateButton.Location = new System.Drawing.Point(93, 28);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(70, 70);
            this.terminateButton.TabIndex = 7;
            this.terminateButton.UseVisualStyleBackColor = false;
            this.terminateButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.White;
            this.generateButton.BackgroundImage = global::VisualGPSS.Properties.Resources.creation_date_sort_icon_155568;
            this.generateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Location = new System.Drawing.Point(9, 28);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(70, 70);
            this.generateButton.TabIndex = 6;
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // uncertainButton
            // 
            this.uncertainButton.BackColor = System.Drawing.Color.White;
            this.uncertainButton.BackgroundImage = global::VisualGPSS.Properties.Resources.Pustoy_block;
            this.uncertainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uncertainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uncertainButton.Location = new System.Drawing.Point(9, 123);
            this.uncertainButton.Name = "uncertainButton";
            this.uncertainButton.Size = new System.Drawing.Size(70, 70);
            this.uncertainButton.TabIndex = 4;
            this.uncertainButton.UseVisualStyleBackColor = false;
            this.uncertainButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.multiChannelDeviceButton);
            this.groupBox2.Controls.Add(this.singleChannelDeviceButton);
            this.groupBox2.Location = new System.Drawing.Point(7, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Устройства";
            // 
            // multiChannelDeviceButton
            // 
            this.multiChannelDeviceButton.BackColor = System.Drawing.Color.Transparent;
            this.multiChannelDeviceButton.BackgroundImage = global::VisualGPSS.Properties.Resources.устройствоN;
            this.multiChannelDeviceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiChannelDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiChannelDeviceButton.Location = new System.Drawing.Point(93, 27);
            this.multiChannelDeviceButton.Name = "multiChannelDeviceButton";
            this.multiChannelDeviceButton.Size = new System.Drawing.Size(70, 70);
            this.multiChannelDeviceButton.TabIndex = 6;
            this.multiChannelDeviceButton.UseVisualStyleBackColor = false;
            // 
            // singleChannelDeviceButton
            // 
            this.singleChannelDeviceButton.BackColor = System.Drawing.Color.Transparent;
            this.singleChannelDeviceButton.BackgroundImage = global::VisualGPSS.Properties.Resources.устройство1;
            this.singleChannelDeviceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.singleChannelDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleChannelDeviceButton.Location = new System.Drawing.Point(10, 27);
            this.singleChannelDeviceButton.Name = "singleChannelDeviceButton";
            this.singleChannelDeviceButton.Size = new System.Drawing.Size(70, 70);
            this.singleChannelDeviceButton.TabIndex = 5;
            this.singleChannelDeviceButton.UseVisualStyleBackColor = false;
            this.singleChannelDeviceButton.Click += new System.EventHandler(this.ToolBoxItemClicked);
            // 
            // imageSaveFileDialog
            // 
            this.imageSaveFileDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            // 
            // schemaSaveFileDialog
            // 
            this.schemaSaveFileDialog.Filter = "Все файлы|*.*|Файлы VisualGPSS схем|*.vgsch";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(218, 681);
            this.hScrollBar1.Maximum = 50000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(718, 25);
            this.hScrollBar1.SmallChange = 10;
            this.hScrollBar1.TabIndex = 13;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.graphicsRefresh);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(936, 76);
            this.vScrollBar1.Maximum = 30000;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 605);
            this.vScrollBar1.TabIndex = 14;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.graphicsRefresh);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(936, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "   ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(213)))), ((int)(((byte)(231)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ContextMenuStrip = this.BlockOrElementCMS;
            this.pictureBox.Location = new System.Drawing.Point(218, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(718, 600);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
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
            this.ClientSize = new System.Drawing.Size(969, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.LabelPictureBox);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "VisualGPSS";
            this.SizeChanged += new System.EventHandler(this.graphicsRefresh);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.BlockOrElementCMS.ResumeLayout(false);
            this.FieldCMS.ResumeLayout(false);
            this.ToolBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel ToolBox;
        private System.Windows.Forms.PictureBox LabelPictureBox;
        private System.Windows.Forms.SaveFileDialog imageSaveFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uncertainButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button singleChannelDeviceButton;
        private System.Windows.Forms.Button terminateButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.SaveFileDialog schemaSaveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button multiChannelDeviceButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripComboBox scaleCB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem upScaleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downScaleMenuItem;
    }
}

