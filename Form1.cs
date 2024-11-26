using _11_1BooksDbCRUD.Models;
using _11_1BooksDbCRUD.Services;
using System.Xml.Linq;

namespace _11_1BooksDbCRUD
{
    public partial class Form1 : Form
    {
        CRUD crud;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            bookGrid.DataSource = crud.GetAllRecords();
            bookGrid.Columns[6].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            foreach (var c in crud.GetAllCategories())
            {
                comboCategory.Items.Add(c.Name);
            }
        }

        private void Clear()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                tb.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIsbn.Text))
            {
                if (comboCategory.SelectedIndex != -1)
                {
                    var newbook = new Book();
                    newbook.ISBNid = txtIsbn.Text;
                    newbook.Title = txtTitle.Text;
                    newbook.Author = txtAuthor.Text;
                    newbook.Description = txtDescription.Text;
                    newbook.Stock = int.Parse(txtStock.Text);
                    newbook.CategoryId = comboCategory.SelectedIndex + 1;
                    crud.AddRecord(newbook);
                    MessageBox.Show("Record Added!");
                }

            }
            btnSubmit.Enabled = false;
            bookGrid.DataSource = crud.GetAllRecords();
            Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = bookGrid.CurrentRow.Cells[0].Value;
            var bookToUpdate = crud.FindBook((string)id);
            txtIsbn.Text = bookToUpdate.ISBNid;
            txtAuthor.Text = bookToUpdate.Author;
            txtTitle.Text = bookToUpdate.Title;
            txtDescription.Text = bookToUpdate.Description;
            txtStock.Text = bookToUpdate.Stock.ToString();
            comboCategory.SelectedIndex = bookToUpdate.CategoryId - 1;
            btnUpdate.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var id = txtIsbn.Text;
            //if (string.IsNullOrEmpty(id))
            //{
            //    MessageBox.Show("ISBN cannot be null!");
            //    return;
            //}       

            var bookToUpdate = crud.FindBook(id);
            bookToUpdate.ISBNid = txtIsbn.Text;
            bookToUpdate.Title = txtTitle.Text;
            bookToUpdate.Author = txtAuthor.Text;
            bookToUpdate.Description = txtDescription.Text;
            bookToUpdate.Stock = int.Parse(txtStock.Text);
            bookToUpdate.CategoryId = comboCategory.SelectedIndex + 1;
            crud.UpdateRecord(id, bookToUpdate);
            MessageBox.Show("Record Updated");
            bookGrid.DataSource = crud.GetAllRecords();
            btnUpdate.Enabled = false;
            Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                var id = bookGrid.CurrentRow.Cells[0].Value;
            crud.DeleteRecord((string)id);
            MessageBox.Show("Record Deleted!");
            bookGrid.DataSource = crud.GetAllRecords();
        }
    }
}
