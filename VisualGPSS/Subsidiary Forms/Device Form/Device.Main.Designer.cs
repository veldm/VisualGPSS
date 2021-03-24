namespace VisualGPSS
{
    partial class Device
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
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.DeleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.Cancelbutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScatterTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.DelayTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.QueueTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.NameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.multiChanellCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.ChanellCountCB = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChanellCountCB)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(526, 72);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(223, 486);
            this.propertyGrid.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteButton.Location = new System.Drawing.Point(12, 515);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = false;
            this.DeleteButton.Size = new System.Drawing.Size(76, 36);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.AutoSize = true;
            this.Cancelbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancelbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelbutton.Depth = 0;
            this.Cancelbutton.Location = new System.Drawing.Point(199, 515);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancelbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Primary = false;
            this.Cancelbutton.Size = new System.Drawing.Size(86, 36);
            this.Cancelbutton.TabIndex = 18;
            this.Cancelbutton.Text = "Отменить";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Depth = 0;
            this.SaveButton.Location = new System.Drawing.Point(411, 515);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.Size = new System.Drawing.Size(93, 36);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 434);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Свойства";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Блоки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.ScatterTextBox);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.DelayTextBox);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.QueueTextBox);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.NameTextBox);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Location = new System.Drawing.Point(6, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 218);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // ScatterTextBox
            // 
            this.ScatterTextBox.Depth = 0;
            this.ScatterTextBox.Hint = "";
            this.ScatterTextBox.Location = new System.Drawing.Point(146, 178);
            this.ScatterTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScatterTextBox.Name = "ScatterTextBox";
            this.ScatterTextBox.PasswordChar = '\0';
            this.ScatterTextBox.SelectedText = "";
            this.ScatterTextBox.SelectionLength = 0;
            this.ScatterTextBox.SelectionStart = 0;
            this.ScatterTextBox.Size = new System.Drawing.Size(324, 23);
            this.ScatterTextBox.TabIndex = 7;
            this.ScatterTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "РАЗБРОС";
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Depth = 0;
            this.DelayTextBox.Hint = "";
            this.DelayTextBox.Location = new System.Drawing.Point(146, 122);
            this.DelayTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.PasswordChar = '\0';
            this.DelayTextBox.SelectedText = "";
            this.DelayTextBox.SelectionLength = 0;
            this.DelayTextBox.SelectionStart = 0;
            this.DelayTextBox.Size = new System.Drawing.Size(324, 23);
            this.DelayTextBox.TabIndex = 5;
            this.DelayTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 122);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "ЗАДЕРЖКА";
            // 
            // QueueTextBox
            // 
            this.QueueTextBox.Depth = 0;
            this.QueueTextBox.Hint = "";
            this.QueueTextBox.Location = new System.Drawing.Point(146, 68);
            this.QueueTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.QueueTextBox.Name = "QueueTextBox";
            this.QueueTextBox.PasswordChar = '\0';
            this.QueueTextBox.SelectedText = "";
            this.QueueTextBox.SelectionLength = 0;
            this.QueueTextBox.SelectionStart = 0;
            this.QueueTextBox.Size = new System.Drawing.Size(324, 23);
            this.QueueTextBox.TabIndex = 3;
            this.QueueTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 68);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "ОЧЕРЕДЬ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Depth = 0;
            this.NameTextBox.Hint = "";
            this.NameTextBox.Location = new System.Drawing.Point(146, 22);
            this.NameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.Size = new System.Drawing.Size(324, 23);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ИМЯ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.multiChanellCB);
            this.groupBox1.Controls.Add(this.numberComboBox);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.LabelTextBox);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.ChanellCountCB);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 149);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(109, 65);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(183, 19);
            this.materialLabel7.TabIndex = 33;
            this.materialLabel7.Text = "КОЛИЧЕСТВО КАНАЛОВ";
            // 
            // multiChanellCB
            // 
            this.multiChanellCB.AutoSize = true;
            this.multiChanellCB.Depth = 0;
            this.multiChanellCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.multiChanellCB.Location = new System.Drawing.Point(10, 20);
            this.multiChanellCB.Margin = new System.Windows.Forms.Padding(0);
            this.multiChanellCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.multiChanellCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiChanellCB.Name = "multiChanellCB";
            this.multiChanellCB.Ripple = true;
            this.multiChanellCB.Size = new System.Drawing.Size(253, 30);
            this.multiChanellCB.TabIndex = 32;
            this.multiChanellCB.Text = "МНОГОКАНАЛЬНОЕ УСТРОЙСТВО";
            this.multiChanellCB.UseVisualStyleBackColor = true;
            // 
            // numberComboBox
            // 
            this.numberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(420, 106);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(51, 28);
            this.numberComboBox.TabIndex = 30;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(381, 110);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(24, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "№";
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Depth = 0;
            this.LabelTextBox.Hint = "";
            this.LabelTextBox.Location = new System.Drawing.Point(80, 106);
            this.LabelTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.PasswordChar = '\0';
            this.LabelTextBox.SelectedText = "";
            this.LabelTextBox.SelectionLength = 0;
            this.LabelTextBox.SelectionStart = 0;
            this.LabelTextBox.Size = new System.Drawing.Size(283, 23);
            this.LabelTextBox.TabIndex = 29;
            this.LabelTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(11, 110);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(60, 19);
            this.materialLabel6.TabIndex = 28;
            this.materialLabel6.Text = "МЕТКА";
            // 
            // ChanellCountCB
            // 
            this.ChanellCountCB.Enabled = false;
            this.ChanellCountCB.Location = new System.Drawing.Point(36, 62);
            this.ChanellCountCB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChanellCountCB.Name = "ChanellCountCB";
            this.ChanellCountCB.Size = new System.Drawing.Size(54, 26);
            this.ChanellCountCB.TabIndex = 1;
            this.ChanellCountCB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 384);
            this.listBox1.TabIndex = 0;
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 570);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Cancelbutton);
            this.Name = "Device";
            this.Tag = "";
            this.Text = "Редактор устройств";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChanellCountCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGrid;
        public MaterialSkin.Controls.MaterialFlatButton SaveButton;
        private MaterialSkin.Controls.MaterialFlatButton Cancelbutton;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ScatterTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField DelayTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField QueueTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCheckBox multiChanellCB;
        private System.Windows.Forms.ComboBox numberComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField LabelTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.NumericUpDown ChanellCountCB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
    }
}