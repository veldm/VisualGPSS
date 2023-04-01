namespace VisualGPSS
{
    partial class Transfer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Label1 = new MaterialSkin.Controls.MaterialLabel();
            this.Label2 = new MaterialSkin.Controls.MaterialLabel();
            this.Label3 = new MaterialSkin.Controls.MaterialLabel();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.Cancelbutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.TextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.CommentTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FuncComboBox = new System.Windows.Forms.ComboBox();
            this.label2AddButton = new System.Windows.Forms.Button();
            this.label1AddButton = new System.Windows.Forms.Button();
            this.addNewElement_CMS = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.добавитьБлокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУстройствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВетвлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.addNewElement_CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Следующий блок (default)"});
            this.comboBox1.Location = new System.Drawing.Point(131, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Depth = 0;
            this.Label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(11, 21);
            this.Label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 19);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "МЕТКА №1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Depth = 0;
            this.Label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(11, 74);
            this.Label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 19);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "МЕТКА №2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Depth = 0;
            this.Label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.Location = new System.Drawing.Point(11, 128);
            this.Label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 19);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "ВЕРОЯТНОСТЬ";
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Location = new System.Drawing.Point(333, 412);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.Size = new System.Drawing.Size(93, 36);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.AutoSize = true;
            this.Cancelbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancelbutton.Depth = 0;
            this.Cancelbutton.Location = new System.Drawing.Point(164, 412);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancelbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Primary = false;
            this.Cancelbutton.Size = new System.Drawing.Size(86, 36);
            this.Cancelbutton.TabIndex = 12;
            this.Cancelbutton.Text = "Отменить";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteButton.Location = new System.Drawing.Point(13, 412);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = false;
            this.DeleteButton.Size = new System.Drawing.Size(76, 36);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // TypeCB
            // 
            this.TypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "TRANSFER",
            "TRANSFER BOTH",
            "TRANSFER VAR",
            "TRANSFER ALL",
            "TRANSFER PICK"});
            this.TypeCB.Location = new System.Drawing.Point(80, 19);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(325, 28);
            this.TypeCB.TabIndex = 14;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.LineColor = System.Drawing.SystemColors.Desktop;
            this.propertyGrid.Location = new System.Drawing.Point(443, 75);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(182, 373);
            this.propertyGrid.TabIndex = 15;
            // 
            // TextBox
            // 
            this.TextBox.Depth = 0;
            this.TextBox.Hint = "";
            this.TextBox.Location = new System.Drawing.Point(132, 127);
            this.TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.SelectedText = "";
            this.TextBox.SelectionLength = 0;
            this.TextBox.SelectionStart = 0;
            this.TextBox.Size = new System.Drawing.Size(250, 23);
            this.TextBox.TabIndex = 16;
            this.TextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 69);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "МЕТКА";
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Depth = 0;
            this.LabelTextBox.Hint = "";
            this.LabelTextBox.Location = new System.Drawing.Point(77, 65);
            this.LabelTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.PasswordChar = '\0';
            this.LabelTextBox.SelectedText = "";
            this.LabelTextBox.SelectionLength = 0;
            this.LabelTextBox.SelectionStart = 0;
            this.LabelTextBox.Size = new System.Drawing.Size(325, 23);
            this.LabelTextBox.TabIndex = 16;
            this.LabelTextBox.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.CommentTextbox);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.LabelTextBox);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.TypeCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 23);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "ТИП";
            // 
            // CommentTextbox
            // 
            this.CommentTextbox.Depth = 0;
            this.CommentTextbox.Hint = "";
            this.CommentTextbox.Location = new System.Drawing.Point(142, 105);
            this.CommentTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CommentTextbox.Name = "CommentTextbox";
            this.CommentTextbox.PasswordChar = '\0';
            this.CommentTextbox.SelectedText = "";
            this.CommentTextbox.SelectionLength = 0;
            this.CommentTextbox.SelectionStart = 0;
            this.CommentTextbox.Size = new System.Drawing.Size(260, 23);
            this.CommentTextbox.TabIndex = 18;
            this.CommentTextbox.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(125, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "КОММЕНТАРИЙ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox);
            this.groupBox2.Controls.Add(this.FuncComboBox);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2AddButton);
            this.groupBox2.Controls.Add(this.label1AddButton);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 170);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // FuncComboBox
            // 
            this.FuncComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuncComboBox.FormattingEnabled = true;
            this.FuncComboBox.Location = new System.Drawing.Point(131, 124);
            this.FuncComboBox.Name = "FuncComboBox";
            this.FuncComboBox.Size = new System.Drawing.Size(273, 28);
            this.FuncComboBox.TabIndex = 19;
            this.FuncComboBox.SelectedIndexChanged += new System.EventHandler(this.FuncComboBox_SelectedIndexChanged);
            // 
            // label2AddButton
            // 
            this.label2AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.label2AddButton.BackgroundImage = global::VisualGPSS.Properties.Resources.add_insert_1193;
            this.label2AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.label2AddButton.Location = new System.Drawing.Point(378, 70);
            this.label2AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.label2AddButton.Name = "label2AddButton";
            this.label2AddButton.Size = new System.Drawing.Size(26, 27);
            this.label2AddButton.TabIndex = 18;
            this.label2AddButton.UseVisualStyleBackColor = false;
            this.label2AddButton.Click += new System.EventHandler(this.labelAddButton_Click);
            // 
            // label1AddButton
            // 
            this.label1AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.label1AddButton.BackgroundImage = global::VisualGPSS.Properties.Resources.add_insert_1193;
            this.label1AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.label1AddButton.Location = new System.Drawing.Point(378, 17);
            this.label1AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.label1AddButton.Name = "label1AddButton";
            this.label1AddButton.Size = new System.Drawing.Size(26, 27);
            this.label1AddButton.TabIndex = 17;
            this.label1AddButton.UseVisualStyleBackColor = false;
            this.label1AddButton.Click += new System.EventHandler(this.labelAddButton_Click);
            // 
            // addNewElement_CMS
            // 
            this.addNewElement_CMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addNewElement_CMS.Depth = 0;
            this.addNewElement_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБлокToolStripMenuItem,
            this.добавитьУстройствоToolStripMenuItem,
            this.добавитьВетвлениеToolStripMenuItem});
            this.addNewElement_CMS.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNewElement_CMS.Name = "materialContextMenuStrip1";
            this.addNewElement_CMS.Size = new System.Drawing.Size(192, 70);
            // 
            // добавитьБлокToolStripMenuItem
            // 
            this.добавитьБлокToolStripMenuItem.Name = "добавитьБлокToolStripMenuItem";
            this.добавитьБлокToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьБлокToolStripMenuItem.Text = "Добавить блок";
            this.добавитьБлокToolStripMenuItem.Click += new System.EventHandler(this.добавитьБлокToolStripMenuItem_Click);
            // 
            // добавитьУстройствоToolStripMenuItem
            // 
            this.добавитьУстройствоToolStripMenuItem.Name = "добавитьУстройствоToolStripMenuItem";
            this.добавитьУстройствоToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьУстройствоToolStripMenuItem.Text = "Добавить устройство";
            this.добавитьУстройствоToolStripMenuItem.Click += new System.EventHandler(this.добавитьУстройствоToolStripMenuItem_Click);
            // 
            // добавитьВетвлениеToolStripMenuItem
            // 
            this.добавитьВетвлениеToolStripMenuItem.Name = "добавитьВетвлениеToolStripMenuItem";
            this.добавитьВетвлениеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьВетвлениеToolStripMenuItem.Text = "Добавить ветвление";
            this.добавитьВетвлениеToolStripMenuItem.Click += new System.EventHandler(this.добавитьВетвлениеToolStripMenuItem_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.SaveButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transfer";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Редактор перенаправлений";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.addNewElement_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel Label1;
        private MaterialSkin.Controls.MaterialLabel Label2;
        private MaterialSkin.Controls.MaterialLabel Label3;
        public MaterialSkin.Controls.MaterialFlatButton SaveButton;
        private MaterialSkin.Controls.MaterialFlatButton Cancelbutton;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButton;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField LabelTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField CommentTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button label2AddButton;
        private System.Windows.Forms.Button label1AddButton;
        private MaterialSkin.Controls.MaterialContextMenuStrip addNewElement_CMS;
        private System.Windows.Forms.ToolStripMenuItem добавитьБлокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУстройствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВетвлениеToolStripMenuItem;
        private System.Windows.Forms.ComboBox FuncComboBox;
    }
}