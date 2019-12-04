using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Criptografia_Asimetrica.Functions;

namespace Criptografia_Asimetrica.Views
{
    public partial class formHome : Form
    {
        private readonly string _username;
        private bool isCrypt;

        public formHome(string username)
        {
            _username = username;
            InitializeComponent();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            radBtnCrypt.Checked = true;
            splitCont.Panel2Collapsed = true;

            toolStripStLblInfo.Text = "";
            toolStripStLblText.Text = "";
        }

        private void radBtnCrypt_CheckedChanged(object sender, EventArgs e)
        {
            isCrypt = true;
            richTxtBxSource.Text = "";
            richTxtBxCripto.Text = "";
        }

        private void radBtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            isCrypt = false;
            richTxtBxSource.Text = "";
            richTxtBxCripto.Text = "";
        }

        private void btnKeys_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                toolStripStLblText.Text = "Generando llaves!";
                toolStripStLblInfo.Text = "";
                Application.DoEvents();

                var rsa = new RSA();

                var folder = folderBrowser.SelectedPath;
                lblFolder.Text = folder;

                var fileStream = new FileStream(Path.Combine(folder, _username + "PubKey.xml"), FileMode.Create,
                    FileAccess.Write);
                var pubBytes = rsa.crearPublicKey();
                fileStream.Write(pubBytes, 0, pubBytes.Length);
                fileStream.Close();
                toolStripStLblText.Text = "Llave publica creada!";
                Application.DoEvents();

                fileStream = new FileStream(Path.Combine(folder, _username + "PrivKey.xml"), FileMode.Create,
                    FileAccess.Write);
                var privBytes = rsa.crearPrivateKey();
                fileStream.Write(privBytes, 0, privBytes.Length);
                fileStream.Close();
                toolStripStLblText.Text = "Llaves creadas";
                Application.DoEvents();

                MessageBox.Show("Llaves creadas en el folder seleccionado", "INFO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                return;
            }

            toolStripStLblText.Text = "Error al crear llaves";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (isCrypt)
            {
                toolStripStLblText.Text = "Inicio de encriptacion";
                Application.DoEvents();

                openFileDialog.Title = "Criptografia Asimetrica - Private Key";
                openFileDialog.FileName = "Private Key";
                openFileDialog.Filter = "Private Key(*.xml)|*.xml";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Stream tempStream;
                    if ((tempStream = openFileDialog.OpenFile()) != null)
                    {
                        var Key = new StreamReader(tempStream).ReadToEnd();
                        var data = RSA.encriptar(richTxtBxSource.Text, Key);
                        richTxtBxCripto.Text = Convert.ToBase64String(data);
                        toolStripStLblText.Text = richTxtBxSource.TextLength.ToString();
                        toolStripStLblInfo.Text = "caracteres encriptados";
                        splitCont.Panel2Collapsed = false;
                        return;
                    }
                }

                toolStripStLblText.Text = "Error al encriptar";
                toolStripStLblInfo.Text = "";
                Application.DoEvents();
            }
            else
            {
                toolStripStLblText.Text = "Inicio de desencriptacion";
                Application.DoEvents();

                openFileDialog.Title = "Criptografia Asimetrica - Public Key";
                openFileDialog.FileName = "Public Key";
                openFileDialog.Filter = "Public Key(*.xml)|*.xml";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Stream tempStream;
                    if ((tempStream = openFileDialog.OpenFile()) != null)
                    {
                        var Key = new StreamReader(tempStream).ReadToEnd();
                        var data = RSA.desencriptar(richTxtBxSource.Text, Key);
                        richTxtBxCripto.Text = Encoding.ASCII.GetString(data);
                        toolStripStLblText.Text = richTxtBxSource.TextLength.ToString();
                        toolStripStLblInfo.Text = "caracteres desencriptados";
                        splitCont.Panel2Collapsed = false;
                        return;
                    }
                }

                toolStripStLblText.Text = "Error al desencriptar";
                toolStripStLblInfo.Text = "";
                Application.DoEvents();
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            splitCont.Panel2Collapsed = !splitCont.Panel2Collapsed;
            btnShowHide.Text = splitCont.Panel2Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void richTxtBxSource_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTxtBxSource.Text))
            {
                btnProcess.Enabled = true;
                return;
            }

            btnProcess.Enabled = false;
        }

        private void toolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desarrollado por Óskar Calí\nDiciembre 2019", "INFO", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
    }
}