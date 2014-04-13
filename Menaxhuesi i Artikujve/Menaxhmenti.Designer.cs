namespace Menaxhuesi_i_Artikujve
{
    partial class frmMenaxhmenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenaxhmenti));
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.lblNumriSerik = new System.Windows.Forms.Label();
            this.lblLlojiArtikullit = new System.Windows.Forms.Label();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.MenuBar1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mb1Listimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mb1Ndaresi1 = new System.Windows.Forms.ToolStripSeparator();
            this.mb1Dalja = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mb1FshijFoto = new System.Windows.Forms.ToolStripMenuItem();
            this.mb1ShtoFoto = new System.Windows.Forms.ToolStripMenuItem();
            this.mb1Ndarsi = new System.Windows.Forms.ToolStripSeparator();
            this.mb1LokacioniFotos = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mb1RrethProgramit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProdhuesi = new System.Windows.Forms.Label();
            this.txtProdhuesi = new System.Windows.Forms.ComboBox();
            this.txtLlojiArtikullit = new System.Windows.Forms.ComboBox();
            this.txtNrSerik = new System.Windows.Forms.ComboBox();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.btnShto = new System.Windows.Forms.Button();
            this.btnFshij = new System.Windows.Forms.Button();
            this.btnFshijFoto = new System.Windows.Forms.Button();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.btnShtoFotografi = new System.Windows.Forms.Button();
            this.btnKerko = new System.Windows.Forms.Button();
            this.btnNdrysho = new System.Windows.Forms.Button();
            this.pctFotografia = new System.Windows.Forms.PictureBox();
            this.mbMemorizoFotografine = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdZgjedhFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblFotografija = new System.Windows.Forms.Label();
            this.MenuBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPershkrimi.Location = new System.Drawing.Point(202, 36);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(58, 13);
            this.lblPershkrimi.TabIndex = 18;
            this.lblPershkrimi.Text = "Pershkrimi:";
            // 
            // lblNumriSerik
            // 
            this.lblNumriSerik.AutoSize = true;
            this.lblNumriSerik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumriSerik.Location = new System.Drawing.Point(12, 117);
            this.lblNumriSerik.Name = "lblNumriSerik";
            this.lblNumriSerik.Size = new System.Drawing.Size(64, 13);
            this.lblNumriSerik.TabIndex = 17;
            this.lblNumriSerik.Text = "Numri Serik:";
            // 
            // lblLlojiArtikullit
            // 
            this.lblLlojiArtikullit.AutoSize = true;
            this.lblLlojiArtikullit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLlojiArtikullit.Location = new System.Drawing.Point(12, 77);
            this.lblLlojiArtikullit.Name = "lblLlojiArtikullit";
            this.lblLlojiArtikullit.Size = new System.Drawing.Size(71, 13);
            this.lblLlojiArtikullit.TabIndex = 16;
            this.lblLlojiArtikullit.Text = "Lloji i artikullit:";
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(202, 52);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPershkrimi.Size = new System.Drawing.Size(184, 137);
            this.txtPershkrimi.TabIndex = 4;
            // 
            // MenuBar1
            // 
            this.MenuBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuBar1.Location = new System.Drawing.Point(0, 0);
            this.MenuBar1.Name = "MenuBar1";
            this.MenuBar1.Size = new System.Drawing.Size(682, 24);
            this.MenuBar1.TabIndex = 21;
            this.MenuBar1.Text = "Menubar1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb1Listimi,
            this.mb1Ndaresi1,
            this.mb1Dalja});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mb1Listimi
            // 
            this.mb1Listimi.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.List_NumberedHS;
            this.mb1Listimi.Name = "mb1Listimi";
            this.mb1Listimi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mb1Listimi.Size = new System.Drawing.Size(149, 22);
            this.mb1Listimi.Text = "&Listimi";
            this.mb1Listimi.Click += new System.EventHandler(this.mb1Listimi_Click);
            // 
            // mb1Ndaresi1
            // 
            this.mb1Ndaresi1.Name = "mb1Ndaresi1";
            this.mb1Ndaresi1.Size = new System.Drawing.Size(146, 6);
            // 
            // mb1Dalja
            // 
            this.mb1Dalja.Name = "mb1Dalja";
            this.mb1Dalja.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mb1Dalja.Size = new System.Drawing.Size(149, 22);
            this.mb1Dalja.Text = "&Dalja";
            this.mb1Dalja.Click += new System.EventHandler(this.mb1Dalja_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb1FshijFoto,
            this.mb1ShtoFoto,
            this.mb1Ndarsi,
            this.mb1LokacioniFotos});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // mb1FshijFoto
            // 
            this.mb1FshijFoto.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.trash_icon;
            this.mb1FshijFoto.Name = "mb1FshijFoto";
            this.mb1FshijFoto.Size = new System.Drawing.Size(163, 22);
            this.mb1FshijFoto.Text = "Fshij Foto";
            this.mb1FshijFoto.Click += new System.EventHandler(this.btnFshijFoto_Click);
            // 
            // mb1ShtoFoto
            // 
            this.mb1ShtoFoto.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.InsertPictureHS;
            this.mb1ShtoFoto.Name = "mb1ShtoFoto";
            this.mb1ShtoFoto.Size = new System.Drawing.Size(163, 22);
            this.mb1ShtoFoto.Text = "&Shto Foto";
            this.mb1ShtoFoto.Click += new System.EventHandler(this.btnShtoFotografi_Click);
            // 
            // mb1Ndarsi
            // 
            this.mb1Ndarsi.Name = "mb1Ndarsi";
            this.mb1Ndarsi.Size = new System.Drawing.Size(160, 6);
            // 
            // mb1LokacioniFotos
            // 
            this.mb1LokacioniFotos.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.CopyHS;
            this.mb1LokacioniFotos.Name = "mb1LokacioniFotos";
            this.mb1LokacioniFotos.Size = new System.Drawing.Size(163, 22);
            this.mb1LokacioniFotos.Text = "&Lokacioni i Fotos";
            this.mb1LokacioniFotos.Click += new System.EventHandler(this.mb1LokacioniFotos_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb1RrethProgramit});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mb1RrethProgramit
            // 
            this.mb1RrethProgramit.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.Help;
            this.mb1RrethProgramit.Name = "mb1RrethProgramit";
            this.mb1RrethProgramit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mb1RrethProgramit.Size = new System.Drawing.Size(199, 22);
            this.mb1RrethProgramit.Text = "Rreth &Programit";
            this.mb1RrethProgramit.Click += new System.EventHandler(this.mb1RrethProgramit_Click);
            // 
            // lblProdhuesi
            // 
            this.lblProdhuesi.AutoSize = true;
            this.lblProdhuesi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProdhuesi.Location = new System.Drawing.Point(12, 36);
            this.lblProdhuesi.Name = "lblProdhuesi";
            this.lblProdhuesi.Size = new System.Drawing.Size(100, 13);
            this.lblProdhuesi.TabIndex = 25;
            this.lblProdhuesi.Text = "Prodhuesi i artikullit:";
            // 
            // txtProdhuesi
            // 
            this.txtProdhuesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProdhuesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtProdhuesi.BackColor = System.Drawing.SystemColors.Window;
            this.txtProdhuesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtProdhuesi.FormattingEnabled = true;
            this.txtProdhuesi.Location = new System.Drawing.Point(12, 52);
            this.txtProdhuesi.Name = "txtProdhuesi";
            this.txtProdhuesi.Size = new System.Drawing.Size(184, 21);
            this.txtProdhuesi.TabIndex = 1;
            this.txtProdhuesi.Leave += new System.EventHandler(this.txtProdhuesi_Leave);
            // 
            // txtLlojiArtikullit
            // 
            this.txtLlojiArtikullit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLlojiArtikullit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtLlojiArtikullit.BackColor = System.Drawing.SystemColors.Window;
            this.txtLlojiArtikullit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtLlojiArtikullit.FormattingEnabled = true;
            this.txtLlojiArtikullit.Location = new System.Drawing.Point(12, 93);
            this.txtLlojiArtikullit.Name = "txtLlojiArtikullit";
            this.txtLlojiArtikullit.Size = new System.Drawing.Size(184, 21);
            this.txtLlojiArtikullit.TabIndex = 2;
            this.txtLlojiArtikullit.Leave += new System.EventHandler(this.txtLlojiArtikullit_Leave);
            // 
            // txtNrSerik
            // 
            this.txtNrSerik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNrSerik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNrSerik.BackColor = System.Drawing.SystemColors.Window;
            this.txtNrSerik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtNrSerik.FormattingEnabled = true;
            this.txtNrSerik.Location = new System.Drawing.Point(12, 133);
            this.txtNrSerik.Name = "txtNrSerik";
            this.txtNrSerik.Size = new System.Drawing.Size(184, 21);
            this.txtNrSerik.TabIndex = 3;
            this.txtNrSerik.Leave += new System.EventHandler(this.txtNrSerik_Leave);
            // 
            // dgTabela
            // 
            this.dgTabela.AllowUserToAddRows = false;
            this.dgTabela.AllowUserToDeleteRows = false;
            this.dgTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgTabela.Enabled = false;
            this.dgTabela.Location = new System.Drawing.Point(0, 254);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.Size = new System.Drawing.Size(682, 288);
            this.dgTabela.TabIndex = 12;
            // 
            // btnShto
            // 
            this.btnShto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnShto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShto.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.AddTableHS;
            this.btnShto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShto.Location = new System.Drawing.Point(135, 196);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(61, 30);
            this.btnShto.TabIndex = 5;
            this.btnShto.Text = " &Shto";
            this.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnFshij
            // 
            this.btnFshij.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFshij.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFshij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFshij.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.DeleteHS;
            this.btnFshij.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFshij.Location = new System.Drawing.Point(12, 196);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(28, 30);
            this.btnFshij.TabIndex = 9;
            this.btnFshij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFshij.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshij.UseVisualStyleBackColor = true;
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // btnFshijFoto
            // 
            this.btnFshijFoto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFshijFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFshijFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFshijFoto.Image")));
            this.btnFshijFoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFshijFoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFshijFoto.Location = new System.Drawing.Point(202, 196);
            this.btnFshijFoto.Name = "btnFshijFoto";
            this.btnFshijFoto.Size = new System.Drawing.Size(83, 30);
            this.btnFshijFoto.TabIndex = 8;
            this.btnFshijFoto.Text = "Fshij Foto";
            this.btnFshijFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFshijFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshijFoto.UseVisualStyleBackColor = true;
            this.btnFshijFoto.Click += new System.EventHandler(this.btnFshijFoto_Click);
            // 
            // btnAnulo
            // 
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAnulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnulo.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.cancel_icon;
            this.btnAnulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnulo.Location = new System.Drawing.Point(12, 160);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(84, 30);
            this.btnAnulo.TabIndex = 10;
            this.btnAnulo.Text = " &Anulo";
            this.btnAnulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnulo.UseVisualStyleBackColor = true;
            this.btnAnulo.Click += new System.EventHandler(this.btnAnulo_Click);
            // 
            // btnShtoFotografi
            // 
            this.btnShtoFotografi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnShtoFotografi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShtoFotografi.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.InsertPictureHS;
            this.btnShtoFotografi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShtoFotografi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShtoFotografi.Location = new System.Drawing.Point(291, 196);
            this.btnShtoFotografi.Name = "btnShtoFotografi";
            this.btnShtoFotografi.Size = new System.Drawing.Size(95, 30);
            this.btnShtoFotografi.TabIndex = 6;
            this.btnShtoFotografi.Text = " Shto Foto";
            this.btnShtoFotografi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShtoFotografi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShtoFotografi.UseVisualStyleBackColor = true;
            this.btnShtoFotografi.Click += new System.EventHandler(this.btnShtoFotografi_Click);
            // 
            // btnKerko
            // 
            this.btnKerko.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKerko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKerko.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.FindHS;
            this.btnKerko.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKerko.Location = new System.Drawing.Point(102, 160);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(94, 30);
            this.btnKerko.TabIndex = 10;
            this.btnKerko.Text = " &Kerko";
            this.btnKerko.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // btnNdrysho
            // 
            this.btnNdrysho.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNdrysho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNdrysho.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.EditTableHS;
            this.btnNdrysho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNdrysho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNdrysho.Location = new System.Drawing.Point(46, 196);
            this.btnNdrysho.Name = "btnNdrysho";
            this.btnNdrysho.Size = new System.Drawing.Size(83, 30);
            this.btnNdrysho.TabIndex = 7;
            this.btnNdrysho.Text = " &Ndrysho";
            this.btnNdrysho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNdrysho.UseVisualStyleBackColor = true;
            this.btnNdrysho.Click += new System.EventHandler(this.btnNdrysho_Click);
            // 
            // pctFotografia
            // 
            this.pctFotografia.BackColor = System.Drawing.Color.White;
            this.pctFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotografia.ErrorImage = global::Menaxhuesi_i_Artikujve.Properties.Resources.skafoto1;
            this.pctFotografia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctFotografia.InitialImage = global::Menaxhuesi_i_Artikujve.Properties.Resources.loading;
            this.pctFotografia.Location = new System.Drawing.Point(392, 52);
            this.pctFotografia.Name = "pctFotografia";
            this.pctFotografia.Size = new System.Drawing.Size(278, 174);
            this.pctFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFotografia.TabIndex = 15;
            this.pctFotografia.TabStop = false;
            this.pctFotografia.DragDrop += new System.Windows.Forms.DragEventHandler(this.pctFotografia_DragDrop);
            this.pctFotografia.DragEnter += new System.Windows.Forms.DragEventHandler(this.pctFotografia_DragEnter);
            // 
            // mbMemorizoFotografine
            // 
            this.mbMemorizoFotografine.Image = global::Menaxhuesi_i_Artikujve.Properties.Resources.CopyHS;
            this.mbMemorizoFotografine.Name = "mbMemorizoFotografine";
            this.mbMemorizoFotografine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mbMemorizoFotografine.Size = new System.Drawing.Size(234, 22);
            this.mbMemorizoFotografine.Text = "Memorizo Fotografine";
            // 
            // ofdZgjedhFoto
            // 
            this.ofdZgjedhFoto.FileName = "ofdZgjedhFoto";
            this.ofdZgjedhFoto.Filter = "Fajlla Foto|*.jpg;*.jpeg;*.bmp;*.png;*.gif;*.tif";
            this.ofdZgjedhFoto.Title = "Zgjedh Fotografine";
            // 
            // lblFotografija
            // 
            this.lblFotografija.AutoSize = true;
            this.lblFotografija.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFotografija.Location = new System.Drawing.Point(392, 36);
            this.lblFotografija.Name = "lblFotografija";
            this.lblFotografija.Size = new System.Drawing.Size(106, 13);
            this.lblFotografija.TabIndex = 26;
            this.lblFotografija.Text = "Fotografija e artikullit:";
            // 
            // frmMenaxhmenti
            // 
            this.AcceptButton = this.btnShto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulo;
            this.ClientSize = new System.Drawing.Size(682, 542);
            this.Controls.Add(this.lblFotografija);
            this.Controls.Add(this.btnFshijFoto);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnShtoFotografi);
            this.Controls.Add(this.dgTabela);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.txtNrSerik);
            this.Controls.Add(this.txtLlojiArtikullit);
            this.Controls.Add(this.txtProdhuesi);
            this.Controls.Add(this.lblProdhuesi);
            this.Controls.Add(this.btnNdrysho);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.lblPershkrimi);
            this.Controls.Add(this.lblNumriSerik);
            this.Controls.Add(this.lblLlojiArtikullit);
            this.Controls.Add(this.pctFotografia);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.MenuBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar1;
            this.MaximizeBox = false;
            this.Name = "frmMenaxhmenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menaxhuesi i Artikujve - Menaxhmenti";
            this.Load += new System.EventHandler(this.frmMenaxhmenti_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenaxhmenti_FormClosing);
            this.MenuBar1.ResumeLayout(false);
            this.MenuBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.Label lblNumriSerik;
        private System.Windows.Forms.Label lblLlojiArtikullit;
        private System.Windows.Forms.PictureBox pctFotografia;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.MenuStrip MenuBar1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mb1Dalja;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mb1RrethProgramit;
        private System.Windows.Forms.Button btnNdrysho;
        private System.Windows.Forms.Label lblProdhuesi;
        private System.Windows.Forms.ComboBox txtProdhuesi;
        private System.Windows.Forms.ComboBox txtLlojiArtikullit;
        private System.Windows.Forms.ComboBox txtNrSerik;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mb1LokacioniFotos;
        private System.Windows.Forms.ToolStripMenuItem mbMemorizoFotografine;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.ToolStripMenuItem mb1Listimi;
        private System.Windows.Forms.Button btnShtoFotografi;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Button btnFshijFoto;
        private System.Windows.Forms.OpenFileDialog ofdZgjedhFoto;
        private System.Windows.Forms.Label lblFotografija;
        private System.Windows.Forms.ToolStripMenuItem mb1ShtoFoto;
        private System.Windows.Forms.ToolStripMenuItem mb1FshijFoto;
        private System.Windows.Forms.ToolStripSeparator mb1Ndaresi1;
        private System.Windows.Forms.ToolStripSeparator mb1Ndarsi;
    }
}