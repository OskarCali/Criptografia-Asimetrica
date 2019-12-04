using System;
using System.Windows.Forms;
using Criptografia_Asimetrica.Views;

namespace Criptografia_Asimetrica
{
    public partial class formLogIn : Form
    {
        public formLogIn()
        {
            InitializeComponent();
        }

        private void txtBxName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBxName.Text))
            {
                btnEnter.Enabled = true;
                return;
            }

            btnEnter.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var home = new formHome(txtBxName.Text);

            Hide();
            home.ShowDialog(this);
            Show();
        }
    }
}