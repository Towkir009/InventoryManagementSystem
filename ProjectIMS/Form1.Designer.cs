namespace ProjectIMS
{
    partial class InventoryManagementSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-125, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1776, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(617, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(334, 41);
            this.nameTextBox.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryGridView.Location = new System.Drawing.Point(1, 289);
            this.inventoryGridView.Name = "inventoryGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.Size = new System.Drawing.Size(1856, 433);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.White;
            this.newButton.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(627, 222);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(104, 49);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(737, 222);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 49);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(845, 220);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 52);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(617, 152);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(334, 41);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuTextBox.Location = new System.Drawing.Point(195, 80);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(334, 41);
            this.skuTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(195, 152);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(334, 41);
            this.priceTextBox.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(1052, 152);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(334, 41);
            this.quantityTextBox.TabIndex = 1;
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Smartphone",
            "Laptop",
            "Watch",
            "Pharmacy",
            "Grocery"});
            this.categoryBox.Location = new System.Drawing.Point(1052, 81);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(334, 40);
            this.categoryBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SKU";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1048, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1048, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Category";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Gray;
            this.printButton.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(1307, 236);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(79, 36);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // InventoryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 71F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.Name = "InventoryManagementSystem";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagementSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button printButton;
    }
}

