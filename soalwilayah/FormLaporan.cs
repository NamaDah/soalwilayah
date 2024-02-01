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
    public partial class FormLaporan : Form
    {
        private void FormLaporan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=db_wilayah;Integrated Security=True;Pooling=False;");

            conn.Open();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=msi;Initial Catalog=db_wilayah;Integrated Security=True;Pooling=False;");

            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [tb_laporan] (jbully, keterangan, Id) VALUES (@jbully, @keterangan, @Id)", conn);

            cmd.Parameters.AddWithValue("@jbully", textBox1.Text);
            cmd.Parameters.AddWithValue("@keterangan", richTextBox1.Text);

            cmd.ExecuteNonQuery();

            conn.Close();



            textBox1.Text = "";
            richTextBox1.Text = "";

            MessageBox.Show("LAPORAN TERKIRIM, ADMIN AKAN MENINJAUNYA.");

            this.Hide();
        }
    }
}
