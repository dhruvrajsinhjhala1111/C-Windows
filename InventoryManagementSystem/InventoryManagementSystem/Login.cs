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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void adminlogin_Click(object sender, EventArgs e)
        {
            string q = "select * from login where username = '" + txtunm.Text + "' and password = '" + txtpassword.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(q,con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dashboard d1 = new dashboard();
                d1.Show();
            }
            else
            {
                MessageBox.Show("Login Fail");
                txtunm.Text = "";
                txtpassword.Text = "";
            }
        }

        private void txtunm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
