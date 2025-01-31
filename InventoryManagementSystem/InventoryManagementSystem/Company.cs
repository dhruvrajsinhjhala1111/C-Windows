using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class Company : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            string query = "Select * from company";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into company (companyname,Description) values ('" + txtcompanyname.Text + "','" + txtdescription.Text + "')";

            SqlCommand cmd = new SqlCommand(q,con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Inserted");
            display();
            con.Close();
        }
    }
}
