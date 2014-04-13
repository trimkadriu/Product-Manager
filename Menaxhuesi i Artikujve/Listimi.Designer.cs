namespace Menaxhuesi_i_Artikujve
{
    partial class frmListimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListimi));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbMenaxhoArtikuj = new System.Windows.Forms.ToolStripMenuItem();
            this.mbNdaresi = new System.Windows.Forms.ToolStripSeparator();
            this.mbDalja = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbKopjoFotografine = new System.Windows.Forms.ToolStripMenuItem();
            this.mbLokacioninFotografise = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbRrethProgramit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.lblLlojiArtikullit = new System.Windows.Forms.Label();
            this.lblNumriSerik = new System.Windows.Forms.Label();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.txtLlojiArtikullit = new System.Windows.Forms.ComboBox();
            this.txtNrSerik = new System.Windows.Forms.ComboBox();
            this.txtProdhuesi = new System.Windows.Forms.ComboBox();
            this.lblProdhuesi = new System.Windows.Forms.Label();
            this.btnKerko = new System.Windows.Forms.Button();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.pctFotografia = new System.Windows.Forms.PictureBox();
            this.lblFotografija = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbMenaxhoArtikuj,
            this.mbNdaresi,
            this.mbDalja});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // mbMenaxhoArtikuj
            // 
            this.mbMenaxhoArtikuj.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.OrgChartHS;
            this.mbMenaxhoArtikuj.Name = "mbMenaxhoArtikuj";
            resources.ApplyResources(this.mbMenaxhoArtikuj, "mbMenaxhoArtikuj");
            this.mbMenaxhoArtikuj.Click += new System.EventHandler(this.mbMenaxhoArtikuj_Click);
            // 
            // mbNdaresi
            // 
            this.mbNdaresi.Name = "mbNdaresi";
            resources.ApplyResources(this.mbNdaresi, "mbNdaresi");
            // 
            // mbDalja
            // 
            this.mbDalja.Name = "mbDalja";
            resources.ApplyResources(this.mbDalja, "mbDalja");
            this.mbDalja.Click += new System.EventHandler(this.mbDalja_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbKopjoFotografine,
            this.mbLokacioninFotografise});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // mbKopjoFotografine
            // 
            this.mbKopjoFotografine.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.CopyHS;
            this.mbKopjoFotografine.Name = "mbKopjoFotografine";
            resources.ApplyResources(this.mbKopjoFotografine, "mbKopjoFotografine");
            this.mbKopjoFotografine.Click += new System.EventHandler(this.mbMemorizoFotografine_Click);
            // 
            // mbLokacioninFotografise
            // 
            this.mbLokacioninFotografise.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.RenameFolderHS;
            this.mbLokacioninFotografise.Name = "mbLokacioninFotografise";
            resources.ApplyResources(this.mbLokacioninFotografise, "mbLokacioninFotografise");
            this.mbLokacioninFotografise.Click += new System.EventHandler(this.kopjoLokacioninFotografiseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbRrethProgramit});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // mbRrethProgramit
            // 
            this.mbRrethProgramit.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.Help;
            this.mbRrethProgramit.Name = "mbRrethProgramit";
            resources.ApplyResources(this.mbRrethProgramit, "mbRrethProgramit");
            this.mbRrethProgramit.Click += new System.EventHandler(this.mbRrethProgramit_Click);
            // 
            // txtPershkrimi
            // 
            resources.ApplyResources(this.txtPershkrimi, "txtPershkrimi");
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.ReadOnly = true;
            // 
            // lblLlojiArtikullit
            // 
            resources.ApplyResources(this.lblLlojiArtikullit, "lblLlojiArtikullit");
            this.lblLlojiArtikullit.Name = "lblLlojiArtikullit";
            // 
            // lblNumriSerik
            // 
            resources.ApplyResources(this.lblNumriSerik, "lblNumriSerik");
            this.lblNumriSerik.Name = "lblNumriSerik";
            // 
            // lblPershkrimi
            // 
            resources.ApplyResources(this.lblPershkrimi, "lblPershkrimi");
            this.lblPershkrimi.Name = "lblPershkrimi";
            // 
            // txtLlojiArtikullit
            // 
            this.txtLlojiArtikullit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLlojiArtikullit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.txtLlojiArtikullit, "txtLlojiArtikullit");
            this.txtLlojiArtikullit.FormattingEnabled = true;
            this.txtLlojiArtikullit.Name = "txtLlojiArtikullit";
            this.txtLlojiArtikullit.Leave += new System.EventHandler(this.txtLlojiArtikullit_Leave);
            // 
            // txtNrSerik
            // 
            this.txtNrSerik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNrSerik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.txtNrSerik, "txtNrSerik");
            this.txtNrSerik.FormattingEnabled = true;
            this.txtNrSerik.Name = "txtNrSerik";
            this.txtNrSerik.Leave += new System.EventHandler(this.txtNrSerik_Leave);
            // 
            // txtProdhuesi
            // 
            this.txtProdhuesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProdhuesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtProdhuesi.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtProdhuesi, "txtProdhuesi");
            this.txtProdhuesi.FormattingEnabled = true;
            this.txtProdhuesi.Name = "txtProdhuesi";
            this.txtProdhuesi.Leave += new System.EventHandler(this.txtProdhuesi_Leave);
            // 
            // lblProdhuesi
            // 
            resources.ApplyResources(this.lblProdhuesi, "lblProdhuesi");
            this.lblProdhuesi.Name = "lblProdhuesi";
            // 
            // btnKerko
            // 
            this.btnKerko.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnKerko, "btnKerko");
            this.btnKerko.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.FindHS;
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // btnAnulo
            // 
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnAnulo, "btnAnulo");
            this.btnAnulo.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.cancel_icon;
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            this.btnAnulo.Click += new System.EventHandler(this.btnAnulo_Click);
            // 
            // pctFotografia
            // 
            this.pctFotografia.BackColor = System.Drawing.Color.White;
            this.pctFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotografia.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctFotografia.ErrorImage = global::Menaxhuesi_i_Artikujve.Properties.Resources.skafoto;
            resources.ApplyResources(this.pctFotografia, "pctFotografia");
            this.pctFotografia.InitialImage = global::Menaxhuesi_i_Artikujve.Properties.Resources.loading;
            this.pctFotografia.Name = "pctFotografia";
            this.pctFotografia.TabStop = false;
            this.pctFotografia.DoubleClick += new System.EventHandler(this.pctFotografia_DoubleClick);
            // 
            // lblFotografija
            // 
            resources.ApplyResources(this.lblFotografija, "lblFotografija");
            this.lblFotografija.Name = "lblFotografija";
            // 
            // frmListimi
            // 
            this.AcceptButton = this.btnKerko;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulo;
            this.Controls.Add(this.lblFotografija);
            this.Controls.Add(this.txtProdhuesi);
            this.Controls.Add(this.lblProdhuesi);
            this.Controls.Add(this.txtNrSerik);
            this.Controls.Add(this.txtLlojiArtikullit);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.lblPershkrimi);
            this.Controls.Add(this.lblNumriSerik);
            this.Controls.Add(this.lblLlojiArtikullit);
            this.Controls.Add(this.pctFotografia);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "frmListimi";
            this.Load += new System.EventHandler(this.frmMenaxhuesi_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListimi_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbMenaxhoArtikuj;
        private System.Windows.Forms.ToolStripMenuItem mbDalja;
        private System.Windows.Forms.ToolStripMenuItem mbRrethProgramit;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.PictureBox pctFotografia;
        private System.Windows.Forms.Label lblLlojiArtikullit;
        private System.Windows.Forms.Label lblNumriSerik;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.ComboBox txtLlojiArtikullit;
        private System.Windows.Forms.ComboBox txtNrSerik;
        private System.Windows.Forms.ComboBox txtProdhuesi;
        private System.Windows.Forms.Label lblProdhuesi;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbKopjoFotografine;
        private System.Windows.Forms.ToolStripMenuItem mbLokacioninFotografise;
        private System.Windows.Forms.Label lblFotografija;
        private System.Windows.Forms.ToolStripSeparator mbNdaresi;
    }
}

