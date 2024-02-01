using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soalwilayah
{
    public partial class HalamanUtama : Form
    {

        private string loggedInUsername;

        public HalamanUtama(string username)
        {
            InitializeComponent();
            loggedInUsername = username;

            // Set UI elements here, if needed
            labelUsername.Text = "Welcome, " + loggedInUsername;
            //AdjustLabelUsernameAlignment();
            AdjustLabelUsernameAlignment();



        }

        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void buttonLaporkan_Click(object sender, EventArgs e)
        {
            Laporkan formLaporan = new Laporkan();
            formLaporan.ShowDialog();

            this.Hide();

        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            CekLaporan targetCekLaporan = new CekLaporan();
            targetCekLaporan.Show();

            this.Hide();
            AdjustLabelUsernameAlignment();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin targetLoginForm = new FormLogin();
            targetLoginForm.Show();
            this.Hide();
            AdjustLabelUsernameAlignment();
        }
    }
}
