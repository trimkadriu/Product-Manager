using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Menaxhuesi_i_Artikujve
{
    public partial class frmMenaxhmenti : Form
    {
        lidhjadb objlidhjadb = new lidhjadb();

        public frmMenaxhmenti()
        {
            InitializeComponent();
            pctFotografia.AllowDrop = true;
        }

        private void mb1Dalja_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mb1RrethProgramit_Click(object sender, EventArgs e)
        {
            frmRrethProgramit rrethprogramit = new frmRrethProgramit();
            rrethprogramit.Show();
        }

        private void mb1Listimi_Click(object sender, EventArgs e)
        {
            frmListimi listimi = new frmListimi();
            listimi.Show();
            this.Hide();
        }

        private void frmMenaxhmenti_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\artikujt.accdb") == false)
            {
                MessageBox.Show(this, "Databaza nuk egziston! Ju lutem sigurohuni qe te keni fajllin e databazes\nLokacioni: " + Application.StartupPath + "\\artikujt.accdb\n\nProgrami duhet te mbyllet.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            objlidhjadb.komando("SELECT DISTINCT Prodhuesi FROM artikujt");
            txtProdhuesi.DataSource = objlidhjadb.ktheTabela();
            txtProdhuesi.ValueMember = "Prodhuesi";
            txtProdhuesi.Text = "";
            objlidhjadb.komando("SELECT * FROM artikujt");
            dgTabela.DataSource = objlidhjadb.ktheTabela();
        }

        private void txtProdhuesi_Leave(object sender, EventArgs e)
        {
            if (txtProdhuesi.Text != string.Empty)
            {
                objlidhjadb.komando("SELECT DISTINCT ID, Prodhuesi, Lloji FROM artikujt WHERE Prodhuesi = '" + txtProdhuesi.Text + "'");
                txtLlojiArtikullit.DataSource = objlidhjadb.ktheTabela();
                txtLlojiArtikullit.ValueMember = "Lloji";
                txtLlojiArtikullit.Text = "";
                dgTabela.DataSource = objlidhjadb.ktheTabela();
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
                objlidhjadb.komando("SELECT ID, Prodhuesi, Lloji, NrSerik FROM artikujt WHERE Lloji = '" + txtLlojiArtikullit.Text + "'");
                txtNrSerik.DataSource = objlidhjadb.ktheTabela();
                txtNrSerik.ValueMember = "NrSerik";
                txtNrSerik.Text = "";
                dgTabela.DataSource = objlidhjadb.ktheTabela();
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
                try
                {
                    objlidhjadb.komando("SELECT ID, Prodhuesi, Lloji, NrSerik, Pershkrimi FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
                    txtPershkrimi.Text = objlidhjadb.ktheTabela().Rows[0]["Pershkrimi"].ToString();
                    pctFotografia.ImageLocation = Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png";
                    txtProdhuesi.DataSource = objlidhjadb.ktheTabela();
                    txtProdhuesi.ValueMember = "Prodhuesi";
                    txtLlojiArtikullit.DataSource = objlidhjadb.ktheTabela();
                    txtLlojiArtikullit.ValueMember = "Lloji";
                    dgTabela.DataSource = objlidhjadb.ktheTabela();
                }
                catch (Exception) { }
            }
            else
            {
                txtPershkrimi.Text = string.Empty;
                pctFotografia.ImageLocation = null;
                Clipboard.Clear();
            }
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

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            txtPershkrimi.Text = string.Empty;
            if (txtNrSerik.Text == string.Empty)
            {
                if (txtLlojiArtikullit.Text == string.Empty)
                {
                    if (txtProdhuesi.Text == string.Empty)
                    {
                        txtProdhuesi.Focus();
                        System.Media.SystemSounds.Beep.Play();
                        frmMenaxhmenti_Load(null, null);
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
                pctFotografia.Image = null;
                txtLlojiArtikullit.Focus();
            }
        }

        private void frmMenaxhmenti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mb1LokacioniFotos_Click(object sender, EventArgs e)
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

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (txtProdhuesi.Text == string.Empty || txtLlojiArtikullit.Text == string.Empty || txtNrSerik.Text == string.Empty || txtPershkrimi.Text == string.Empty)
            {
                MessageBox.Show(this, "Gabim! Ju lutem plotesoni fushat e duhura ne forme.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                objlidhjadb.komando("INSERT INTO artikujt (Prodhuesi, Lloji, NrSerik, Pershkrimi) VALUES" +
                    "('" + txtProdhuesi.Text + "', '" + txtLlojiArtikullit.Text + "', '" + txtNrSerik.Text + "', '" + txtPershkrimi.Text + "')");
                if (pctFotografia.ImageLocation != null)
                {
                    try
                    {
                        System.IO.File.Copy(pctFotografia.ImageLocation, Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png", true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Gabimi: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtProdhuesi.Text = string.Empty;
                txtLlojiArtikullit.Text = string.Empty;
                txtNrSerik.Text = string.Empty;
                txtPershkrimi.Text = string.Empty;
                pctFotografia.ImageLocation = null;
                frmMenaxhmenti_Load(null, null);
                txtProdhuesi.Focus();
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            if (txtNrSerik.Text == string.Empty)
            {
                MessageBox.Show(this, "Ju lutem zgjedhni artikullin qe deshironi te fshini.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtNrSerik_Leave(null, null);
                if (txtProdhuesi.Text != string.Empty && txtLlojiArtikullit.Text != string.Empty && txtPershkrimi.Text != string.Empty)
                {
                    DialogResult dr = MessageBox.Show(this, "A jeni i sigurte qe deshironi te fshini artikullin:\n\n" + txtProdhuesi.Text + " " + txtLlojiArtikullit.Text + "\n" + txtNrSerik.Text, "Pyetje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            if (System.IO.File.Exists(Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png"))
                            {
                                System.IO.File.Delete(Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png");
                            }
                            objlidhjadb.komando("DELETE FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
                            txtProdhuesi.Text = string.Empty;
                            txtLlojiArtikullit.Text = string.Empty;
                            txtNrSerik.Text = string.Empty;
                            txtPershkrimi.Text = string.Empty;
                            pctFotografia.ImageLocation = null;
                            frmMenaxhmenti_Load(null, null);
                            txtProdhuesi.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Gabimi: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Ky artikull nuk egziston", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFshijFoto_Click(object sender, EventArgs e)
        {
            if (pctFotografia.ImageLocation != null)
            {
                if (pctFotografia.ImageLocation != string.Empty && pctFotografia.ImageLocation.Contains(Application.StartupPath) == true)
                {
                    try
                    {
                        System.IO.File.Delete(pctFotografia.ImageLocation);
                        pctFotografia.ImageLocation = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Gabimi: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pctFotografia_DragDrop(object sender, DragEventArgs e)
        {
            string str;
            string[] picstr = (string[])e.Data.GetData(DataFormats.FileDrop);
            str = picstr[0];
            objlidhjadb.komando("SELECT NrSerik FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
            if (objlidhjadb.ktheTabela().Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Artikulli egziston ne databaze!\n\nA deshironi qe artikullit egzistues (" + txtNrSerik.Text + ") ti ndryshoni fotografine?", "Pyetje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    {
                        try
                        {
                            System.IO.File.Delete(Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png");
                            System.IO.File.Copy(str, Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png");
                            pctFotografia.ImageLocation = Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Gabimi: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                pctFotografia.ImageLocation = str;
            }
        }

        private void pctFotografia_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnShtoFotografi_Click(object sender, EventArgs e)
        {
            if (ofdZgjedhFoto.ShowDialog() == DialogResult.OK)
            {
                objlidhjadb.komando("SELECT NrSerik FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
                if (objlidhjadb.ktheTabela().Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show(this, "Artikulli egziston ne databaze!\n\nA deshironi qe artikullit egzistues (" + txtNrSerik.Text + ") ti ndryshoni fotografine?", "Pyetje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            System.IO.File.Delete(Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png");
                            System.IO.File.Copy(ofdZgjedhFoto.FileName, Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png");
                            pctFotografia.ImageLocation = Application.StartupPath + "\\foto\\" + txtNrSerik.Text + ".png";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Gabimi: " + ex.Message, "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    pctFotografia.ImageLocation = ofdZgjedhFoto.FileName;
                }
            }
            
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            objlidhjadb.komando("SELECT NrSerik FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
            if (objlidhjadb.ktheTabela().Rows.Count > 0 && txtPershkrimi.Text != string.Empty)
            {
                DialogResult dr = MessageBox.Show(this, "A jeni i sigurt qe deshironi te ndryshoni artikullin " + txtNrSerik.Text + " ?", "Pyetje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    objlidhjadb.komando("UPDATE artikujt SET Pershkrimi = '" + txtPershkrimi.Text + "' WHERE NrSerik = '" + txtNrSerik.Text + "'");
                    objlidhjadb.komando("SELECT * FROM artikujt WHERE NrSerik = '" + txtNrSerik.Text + "'");
                    dgTabela.DataSource = objlidhjadb.ktheTabela();
                }
            }
            else
            {
                MessageBox.Show(this, "Artikulli nuk egziston. Ju lutem zgjedhni artikullin qe deshironi ta ndryshoni.", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
