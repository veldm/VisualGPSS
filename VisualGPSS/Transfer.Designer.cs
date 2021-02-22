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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Следующий блок (default)"});
            this.comboBox1.Location = new System.Drawing.Point(124, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Depth = 0;
            this.Label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(15, 184);
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
            this.Label2.Location = new System.Drawing.Point(15, 237);
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
            this.Label3.Location = new System.Drawing.Point(15, 291);
            this.Label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(92, 19);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "ДИАПАЗОН";
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Location = new System.Drawing.Point(246, 334);
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
            this.Cancelbutton.Location = new System.Drawing.Point(124, 334);
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
            this.DeleteButton.Location = new System.Drawing.Point(15, 334);
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
            this.TypeCB.Location = new System.Drawing.Point(18, 127);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(321, 28);
            this.TypeCB.TabIndex = 14;
            this.TypeCB.Text = "TRANSFER";
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.LineColor = System.Drawing.SystemColors.Desktop;
            this.propertyGrid.Location = new System.Drawing.Point(355, 82);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(182, 288);
            this.propertyGrid.TabIndex = 15;
            // 
            // TextBox
            // 
            this.TextBox.Depth = 0;
            this.TextBox.Hint = "";
            this.TextBox.Location = new System.Drawing.Point(124, 289);
            this.TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.SelectedText = "";
            this.TextBox.SelectionLength = 0;
            this.TextBox.SelectionStart = 0;
            this.TextBox.Size = new System.Drawing.Size(215, 23);
            this.TextBox.TabIndex = 16;
            this.TextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 84);
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
            this.LabelTextBox.Location = new System.Drawing.Point(81, 82);
            this.LabelTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.PasswordChar = '\0';
            this.LabelTextBox.SelectedText = "";
            this.LabelTextBox.SelectionLength = 0;
            this.LabelTextBox.SelectionStart = 0;
            this.LabelTextBox.Size = new System.Drawing.Size(258, 23);
            this.LabelTextBox.TabIndex = 16;
            this.LabelTextBox.UseSystemPasswordChar = false;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(549, 387);
            this.Controls.Add(this.LabelTextBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transfer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Редактор перенаправлений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel Label1;
        private MaterialSkin.Controls.MaterialLabel Label2;
        private MaterialSkin.Controls.MaterialLabel Label3;
        private MaterialSkin.Controls.MaterialFlatButton SaveButton;
        private MaterialSkin.Controls.MaterialFlatButton Cancelbutton;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButton;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField LabelTextBox;
    }
}