namespace _11_1BooksDbCRUD
{
    partial class Form1
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
            bookGrid = new DataGridView();
            lblIsbn = new Label();
            btnAdd = new Button();
            btnSubmit = new Button();
            btnSelect = new Button();
            btnUpdate = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblDescription = new Label();
            lblStock = new Label();
            txtIsbn = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            txtStock = new TextBox();
            btnDelete = new Button();
            lblCategory = new Label();
            comboCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bookGrid).BeginInit();
            SuspendLayout();
            // 
            // bookGrid
            // 
            bookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGrid.Location = new Point(47, 33);
            bookGrid.Name = "bookGrid";
            bookGrid.Size = new Size(712, 196);
            bookGrid.TabIndex = 0;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(47, 259);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(32, 15);
            lblIsbn.TabIndex = 1;
            lblIsbn.Text = "ISBN";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(308, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(308, 311);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(408, 282);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(408, 311);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(47, 299);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(47, 339);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(47, 380);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(47, 413);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(120, 256);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(100, 23);
            txtIsbn.TabIndex = 11;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 299);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 12;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(120, 336);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 377);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 14;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(120, 413);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(519, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(308, 396);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 17;
            lblCategory.Text = "Category";
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(398, 394);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(121, 23);
            comboCategory.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboCategory);
            Controls.Add(lblCategory);
            Controls.Add(btnDelete);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtIsbn);
            Controls.Add(lblStock);
            Controls.Add(lblDescription);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelect);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(lblIsbn);
            Controls.Add(bookGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bookGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookGrid;
        private Label lblIsbn;
        private Button btnAdd;
        private Button btnSubmit;
        private Button btnSelect;
        private Button btnUpdate;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblDescription;
        private Label lblStock;
        private TextBox txtIsbn;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private TextBox txtStock;
        private Button btnDelete;
        private Label lblCategory;
        private ComboBox comboCategory;
    }
}
