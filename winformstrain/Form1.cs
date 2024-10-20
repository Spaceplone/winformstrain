using System.ComponentModel;
using Domain.Model;

namespace winformstrain
{
    public partial class Form1 : Form
    {
        private BindingList<User>   _users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false; // do this first so the DGV never tries to autogenerate columns
                                                      // even if we bind the datasource before we  configure the columns

            dataGridView1.DataSource = _users;

            _users = new BindingList<User>
            {
                new() { Name= "Martin", Gender= Gender.MALE, DateOfBirth= DateOnly.Parse("14.11.1989") },
                new() { Name = "Connie", Gender = Gender.NONBINARY, DateOfBirth= DateOnly.Parse("14.11.1989")}
            };

            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Full Name",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gender",
                HeaderText = "Gender",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateOfBirth",
                HeaderText = "Date of Birth"
            });


            dataGridView1.ReadOnly = true;

            //todo: find a more elegant way to configure the columns
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
