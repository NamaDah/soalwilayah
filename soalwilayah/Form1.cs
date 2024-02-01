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
using System.Runtime.Remoting.Messaging;
//using System.Security.Cryptography.X509Certificates;

namespace soalwilayah
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=db_wilayah;Integrated Security=True;Pooling=False;");

            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=db_wilayah;Integrated Security=True;Pooling=False;");

            conn.Open();

            string username = textBox1.Text;
            string password = textBox2.Text;

            SqlCommand cmd = new SqlCommand("SELECT * FROM [tb_login] WHERE username = @username AND password = @password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("LOGIN BERHASIL");

                while (reader.Read())
                {
                    string storedRole = reader["Role"].ToString();
                    string usernames = reader["username"].ToString();
                    //string Id = reader["Id"].ToString();

                    if (storedRole == "Admin")
                    {
                        FormAdmin targetFormAdmin = new FormAdmin();
                        targetFormAdmin.Show();
                    }
                    else if (storedRole == "User")
                    {
                        string Id = reader["Id"].ToString();

                        HalamanUtama targetHalamanUtama = new HalamanUtama(usernames);
                        targetHalamanUtama.Show();
                    }
                    else
                    {
                        MessageBox.Show("ERROR, ROLE TIDAK BISA NULL.");                

                        this.Hide();
                    }

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("USERNAME ATAU PASSWORD SALAH.");
            }

            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
        }






        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister targetformRegister = new FormRegister();
            targetformRegister.Show();
            this.Hide();
        }
    }
}
