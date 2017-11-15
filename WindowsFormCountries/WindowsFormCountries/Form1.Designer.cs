namespace WindowsFormCountries
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.lblSortiranje = new System.Windows.Forms.Label();
            this.lblKontinent = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.textBoxPovrsina = new System.Windows.Forms.TextBox();
            this.textBoxBrojStan = new System.Windows.Forms.TextBox();
            this.textBoxGlavniGrad = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.lblKontinet = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.lblBrSt = new System.Windows.Forms.Label();
            this.lblGlGr = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewCountries.Location = new System.Drawing.Point(306, 33);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(663, 324);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sCode";
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sName";
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sCapital";
            this.Column3.HeaderText = "Glavni grad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nPopulation";
            this.Column4.HeaderText = "Broj stanovnika";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fArea";
            this.Column5.HeaderText = "Površina";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sRegion";
            this.Column6.HeaderText = "Kontinent";
            this.Column6.Name = "Column6";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(23, 33);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(193, 21);
            this.comboBoxRegion.TabIndex = 1;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(23, 93);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(193, 21);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 437);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Controls.Add(this.lblPretrazi);
            this.tabPage1.Controls.Add(this.lblSortiranje);
            this.tabPage1.Controls.Add(this.lblKontinent);
            this.tabPage1.Controls.Add(this.comboBoxSort);
            this.tabPage1.Controls.Add(this.dataGridViewCountries);
            this.tabPage1.Controls.Add(this.comboBoxRegion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1025, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pregled";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(23, 177);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(193, 39);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Pretraži";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 150);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(193, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(23, 134);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(42, 13);
            this.lblPretrazi.TabIndex = 5;
            this.lblPretrazi.Text = "Pretraži";
            // 
            // lblSortiranje
            // 
            this.lblSortiranje.AutoSize = true;
            this.lblSortiranje.Location = new System.Drawing.Point(23, 77);
            this.lblSortiranje.Name = "lblSortiranje";
            this.lblSortiranje.Size = new System.Drawing.Size(66, 13);
            this.lblSortiranje.TabIndex = 4;
            this.lblSortiranje.Text = "Sortiranje po";
            // 
            // lblKontinent
            // 
            this.lblKontinent.AutoSize = true;
            this.lblKontinent.Location = new System.Drawing.Point(23, 17);
            this.lblKontinent.Name = "lblKontinent";
            this.lblKontinent.Size = new System.Drawing.Size(52, 13);
            this.lblKontinent.TabIndex = 3;
            this.lblKontinent.Text = "Kontinent";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.buttonSpremi);
            this.tabPage2.Controls.Add(this.comboBoxAdd);
            this.tabPage2.Controls.Add(this.textBoxPovrsina);
            this.tabPage2.Controls.Add(this.textBoxBrojStan);
            this.tabPage2.Controls.Add(this.textBoxGlavniGrad);
            this.tabPage2.Controls.Add(this.textBoxNaziv);
            this.tabPage2.Controls.Add(this.textBoxKod);
            this.tabPage2.Controls.Add(this.lblKontinet);
            this.tabPage2.Controls.Add(this.lblPovrsina);
            this.tabPage2.Controls.Add(this.lblBrSt);
            this.tabPage2.Controls.Add(this.lblGlGr);
            this.tabPage2.Controls.Add(this.lblNaziv);
            this.tabPage2.Controls.Add(this.lblKod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1025, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(25, 323);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(211, 69);
            this.buttonSpremi.TabIndex = 12;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.FormattingEnabled = true;
            this.comboBoxAdd.Location = new System.Drawing.Point(115, 280);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdd.TabIndex = 11;
            // 
            // textBoxPovrsina
            // 
            this.textBoxPovrsina.Location = new System.Drawing.Point(115, 229);
            this.textBoxPovrsina.Name = "textBoxPovrsina";
            this.textBoxPovrsina.Size = new System.Drawing.Size(121, 20);
            this.textBoxPovrsina.TabIndex = 10;
            // 
            // textBoxBrojStan
            // 
            this.textBoxBrojStan.Location = new System.Drawing.Point(115, 175);
            this.textBoxBrojStan.Name = "textBoxBrojStan";
            this.textBoxBrojStan.Size = new System.Drawing.Size(121, 20);
            this.textBoxBrojStan.TabIndex = 9;
            // 
            // textBoxGlavniGrad
            // 
            this.textBoxGlavniGrad.Location = new System.Drawing.Point(115, 116);
            this.textBoxGlavniGrad.Name = "textBoxGlavniGrad";
            this.textBoxGlavniGrad.Size = new System.Drawing.Size(121, 20);
            this.textBoxGlavniGrad.TabIndex = 8;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(115, 75);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(121, 20);
            this.textBoxNaziv.TabIndex = 7;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(115, 36);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(121, 20);
            this.textBoxKod.TabIndex = 6;
            // 
            // lblKontinet
            // 
            this.lblKontinet.AutoSize = true;
            this.lblKontinet.Location = new System.Drawing.Point(22, 280);
            this.lblKontinet.Name = "lblKontinet";
            this.lblKontinet.Size = new System.Drawing.Size(55, 13);
            this.lblKontinet.TabIndex = 5;
            this.lblKontinet.Text = "Kontinent:";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(22, 229);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(48, 13);
            this.lblPovrsina.TabIndex = 4;
            this.lblPovrsina.Text = "Povrsina";
            // 
            // lblBrSt
            // 
            this.lblBrSt.AutoSize = true;
            this.lblBrSt.Location = new System.Drawing.Point(22, 175);
            this.lblBrSt.Name = "lblBrSt";
            this.lblBrSt.Size = new System.Drawing.Size(83, 13);
            this.lblBrSt.TabIndex = 3;
            this.lblBrSt.Text = "Broj stanovnika:";
            // 
            // lblGlGr
            // 
            this.lblGlGr.AutoSize = true;
            this.lblGlGr.Location = new System.Drawing.Point(22, 124);
            this.lblGlGr.Name = "lblGlGr";
            this.lblGlGr.Size = new System.Drawing.Size(64, 13);
            this.lblGlGr.TabIndex = 2;
            this.lblGlGr.Text = "Glavni grad:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(22, 75);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(22, 36);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(29, 13);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "Kod:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1025, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Karta svijeta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1025, 411);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri(" https://www.openstreetmap.org", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "REST Countries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.Label lblSortiranje;
        private System.Windows.Forms.Label lblKontinent;
        private System.Windows.Forms.TextBox textBoxPovrsina;
        private System.Windows.Forms.TextBox textBoxBrojStan;
        private System.Windows.Forms.TextBox textBoxGlavniGrad;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.Label lblKontinet;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.Label lblBrSt;
        private System.Windows.Forms.Label lblGlGr;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.ComboBox comboBoxAdd;
        private System.Windows.Forms.Button buttonSpremi;
    }
}

