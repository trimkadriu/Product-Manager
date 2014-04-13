using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Menaxhuesi_i_Artikujve
{
    public partial class frmListimi : Form
    {
        lidhjadb objlidhjadb = new lidhjadb();

        public frmListimi()
        {
            InitializeComponent();
        }

        private void mbRrethProgramit_Click(object sender, EventArgs e)
        {
            frmRrethProgramit rrethprogramit = new frmRrethProgramit();
            rrethprogramit.Show();
        }

        private void mbDalja_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mbMenaxhoArtikuj_Click(object sender, EventArgs e)
        {
            frmMenaxhmenti menaxhmenti = new frmMenaxhmenti();
            menaxhmenti.Show();
            this.Hide();
        }

        private void frmMenaxhuesi_Load(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(Application.StartupPath + "\\artikujt.accdb") == false)
            {
                MessageBox.Show(this, "Databaza nuk egziston! Ju lutem sigurohuni qe te keni fajllin e databazes\nLokacioni: " + Application.StartupPath + "\\artikujt.accdb\n\nProgrami duhet te mbyllet.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            objlidhjadb.komando("SELECT DISTINCT Prodhuesi FROM artikujt");
            txtProdhuesi.DataSource = objlidhjadb.ktheTabela();
            txtProdhuesi.ValueMember = "Prodhuesi";
            txtProdhuesi.Text = "";
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            if (txtNrSerik.Text == string.Empty)
            {
                if (txtLlojiArtikullit.Text == string.Empty)
                {
                    if (txtProdhuesi.Text == string.Empty)
                    {
                        MessageBox.Show(this, "Gabim! Ju lutem plotesoni ndonjeren fushe ne forme.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtProdhuesi_Leave(null, null);
                    }
                }
                else
                {
                    txtLlojiArtikullit_Leave(null, null);
                }
            }
            else
            {
                txtNrSerik_Leave(null, null);
            }
        }

        private void txtProdhuesi_Leave(object sender, EventArgs e)
        {
            if (txtProdhuesi.Text != string.Empty)
            {
                objlidhjadb.komando("SELECT DISTINCT Lloji FROM artikujt WHERE Prodhuesi = '" + txtProdhuesi.Text + "'");
                txtLlojiArtikullit.DataSource = objlidhjadb.ktheTabela();
                txtLlojiArtikullit.ValueMember = "Lloji";
                txtLlojiArtikullit.Text = "";
            }
            else
            {
                txtLlojiArtikullit.Text = string.Empty;
                txtNrSerik.Text = string.Empty;
                txtPershkrimi.Text = string.Empty;
                pctFotografia.Image = null;
            }
        }

        private void txtLlojiArtikullit_Leave(object sender, EventArgs e)
        {
            if (txtLlojiArtikullit.Text != string.Empty)
            {
                objlidhjadb.komando("SELECT NrSerik FROM artikujt WHERE Lloji = '" + txtLlojiArtikullit.Text + "'");
                txtNrSerik.DataSource = objlidhjadb.ktheTabela();
                txtNrSerik.ValueMember = "NrSerik";
                txtNrSerik.Text = "";
            }
            else
            {
                txtNrSerik.Text = string.Empty;
                txtPershkrimi.Text = string.Empty;
                pctFotografia.Image = null;
            }
        }

        private void txtNrSerik_Leave(object sender, EventArgs e)
        {
            if (txtNrSerik.Text != string.Empty)
            {
                objlidhjadb.komando("SELECT Pershkrimi FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
                try
                {
                    txtPershkrimi.Text = objlidhjadb.ktheTabela().Rows[0]["Pershkrimi"].ToString();
                    pctFotografia.ImageLocation = Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Gabim!\nErrori: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtPershkrimi.Text = string.Empty;
                pctFotografia.Image = null;
                Clipboard.Clear();
            }
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            if (txtNrSerik.Text == string.Empty)
            {
                if (txtLlojiArtikullit.Text == string.Empty)
                {
                    if (txtProdhuesi.Text == string.Empty)
                    {
                        txtProdhuesi.Focus();
                        System.Media.SystemSounds.Beep.Play();
                    }
                    else
                    {
                        txtProdhuesi.Text = string.Empty;
                        txtProdhuesi.Focus();
                    }
                }
                else
                {
                    txtLlojiArtikullit.Text = string.Empty;
                    txtProdhuesi.Focus();
                }
            }
            else
            {
                txtNrSerik.Text = string.Empty;
                txtPershkrimi.Text = string.Empty;
                pctFotografia.Image = null;
                Clipboard.Clear();
                txtLlojiArtikullit.Focus();
            }
        }

        private void mbMemorizoFotografine_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetImage(Image.FromFile(pctFotografia.ImageLocation));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Gabim!\nErrori: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kopjoLokacioninFotografiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(pctFotografia.ImageLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Gabim!\nErrori: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pctFotografia_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(pctFotografia.ImageLocation);
                MessageBox.Show(this, "Lokacioni i fotografice eshte kopjuar", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Gabim!\nErrori: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
