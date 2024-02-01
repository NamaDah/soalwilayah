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

namespace soalwilayah
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }


        private void FormRegister_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=db_wilayah;Integrated Security=True;Pooling=False;");

            conn.Open();
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=db_wilayah;Integrated Security=True;Pooling=False;");

            conn.Open();

            string username = textBoxU.Text;
            string password = textBoxP.Text;
            
            radioButtonAdmin.Tag = "Admin";
            radioButtonUser.Tag = "User";

            string selectedRole = GetSelectedRole();

            SqlCommand cmd = new SqlCommand("INSERT INTO [tb_login] (username, password, Role) VALUES (@username, @password, @Role)", conn);

            cmd.Parameters.AddWithValue("@username", textBoxU.Text);
            cmd.Parameters.AddWithValue("@password", textBoxP.Text);
            cmd.Parameters.AddWithValue("@Role", selectedRole);

            cmd.ExecuteNonQuery();

            conn.Close();   

            textBoxU.Text = "";
            textBoxP.Text = "";

            MessageBox.Show("REGISTER BERHASIL");

            FormLogin targetFormLogin = new FormLogin();
            targetFormLogin.Show();

            this.Hide();    

        }

        private string GetSelectedRole()
        {
            if (radioButtonAdmin.Checked)
                return radioButtonAdmin.Tag.ToString();
            else if (radioButtonUser.Checked)
                return radioButtonUser.Tag.ToString();
            else
                return String.Empty;
        }


    }
}
