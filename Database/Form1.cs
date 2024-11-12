using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        SqlConnection conn= new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }
        public void NaitaAndmed()
        {
            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT* FROM Tooded");
            adapter =new SqlDataAdapter(cmd.ToString(), conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }
        private void lisaButton_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_DataSet.Tooded' table. You can move, or remove it, as needed.
            this.toodedTableAdapter.Fill(this.database_DataSet.Tooded);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Lisa_Click(object sender, EventArgs e)
        {
            if (nimetusTextBox.Text.Trim() != string.Empty && kogusTextBox.Text.Trim() != string.Empty && hindTextBox.Text.Trim() != string.Empty)
            {
                    conn.Open();
                    cmd = new SqlCommand("Insert into Tooded(Nimetus, Kogus, Hind) Values (@toode,@kogus,@hind)", conn);
                    cmd.Parameters.AddWithValue("@toode", nimetusTextBox.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogusTextBox.Text);
                    cmd.Parameters.AddWithValue("@hind", hindTextBox.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                
            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }
        }
    }
}
