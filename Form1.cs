using _11_1BooksDbCRUD.Services;

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
    }
}
