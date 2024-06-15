namespace InventoryManager
{
    partial class InventoryManagerStudio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            priceTextBox = new TextBox();
            inventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            skuTextBox = new TextBox();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            quantityTextBox = new TextBox();
            categoryBox = new ComboBox();
            skuLabel = new Label();
            nameLabel = new Label();
            categoryLabel = new Label();
            priceLabel = new Label();
            descriptionLabel = new Label();
            quantityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label1
            // 
            label1.Font = new Font("Meiryo UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(956, 39);
            label1.TabIndex = 0;
            label1.Text = "Inventory Manager Studio XL Supreme";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 145);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(315, 23);
            priceTextBox.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            inventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGridView.BackgroundColor = Color.White;
            inventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGridView.Location = new Point(12, 222);
            inventoryGridView.Name = "inventoryGridView";
            inventoryGridView.RowTemplate.Height = 25;
            inventoryGridView.Size = new Size(956, 422);
            inventoryGridView.TabIndex = 2;
            inventoryGridView.CellDoubleClick += inventoryGridView_CellDoubleClick;
            // 
            // newButton
            // 
            newButton.BackColor = Color.White;
            newButton.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(12, 184);
            newButton.Name = "newButton";
            newButton.Size = new Size(315, 32);
            newButton.TabIndex = 3;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(333, 184);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(315, 32);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(654, 184);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(315, 32);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // skuTextBox
            // 
            skuTextBox.Location = new Point(12, 98);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(315, 23);
            skuTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(333, 98);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(315, 23);
            nameTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(333, 145);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(315, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(654, 145);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(315, 23);
            quantityTextBox.TabIndex = 9;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Automotive", "Hardware", "Grocery", "Pharmacy" });
            categoryBox.Location = new Point(654, 98);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(316, 23);
            categoryBox.TabIndex = 10;
            // 
            // skuLabel
            // 
            skuLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            skuLabel.Location = new Point(12, 80);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new Size(315, 15);
            skuLabel.TabIndex = 11;
            skuLabel.Text = "SKU:";
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(333, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(315, 15);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLabel.Location = new Point(655, 80);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(315, 15);
            categoryLabel.TabIndex = 13;
            categoryLabel.Text = "Category:";
            // 
            // priceLabel
            // 
            priceLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            priceLabel.Location = new Point(12, 124);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(315, 15);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Price:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(333, 124);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(315, 15);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // quantityLabel
            // 
            quantityLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.Location = new Point(655, 124);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(315, 15);
            quantityLabel.TabIndex = 16;
            quantityLabel.Text = "Quantity:";
            // 
            // InventoryManagerStudio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(978, 656);
            Controls.Add(quantityLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(priceLabel);
            Controls.Add(categoryLabel);
            Controls.Add(nameLabel);
            Controls.Add(skuLabel);
            Controls.Add(categoryBox);
            Controls.Add(quantityTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(inventoryGridView);
            Controls.Add(priceTextBox);
            Controls.Add(label1);
            Name = "InventoryManagerStudio";
            Text = "Inventory Manager Studio";
            Load += InventoryManagerStudio_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label1;
        private TextBox priceTextBox;
        private DataGridView inventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private TextBox skuTextBox;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private TextBox quantityTextBox;
        private ComboBox categoryBox;
        private Label skuLabel;
        private Label nameLabel;
        private Label categoryLabel;
        private Label priceLabel;
        private Label descriptionLabel;
        private Label quantityLabel;
    }
}