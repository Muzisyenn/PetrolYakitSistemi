namespace pys
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCalisacagiSube = new System.Windows.Forms.TextBox();
            this.textisimsoyisim = new System.Windows.Forms.TextBox();
            this.comboBoxYapacagiis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAlacagiMaas = new System.Windows.Forms.TextBox();
            this.personelBilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pysDataSet3 = new pys.pysDataSet3();
            this.pysDataSet2 = new pys.pysDataSet2();
            this.yakitIstegiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakitIstegiTableAdapter = new pys.pysDataSet2TableAdapters.YakitIstegiTableAdapter();
            this.personelBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgileriTableAdapter = new pys.pysDataSet2TableAdapters.PersonelBilgileriTableAdapter();
            this.personelBilgileriTableAdapter1 = new pys.pysDataSet3TableAdapters.PersonelBilgileriTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısimSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calistigiSubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neIsYapiyorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgileriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(858, 316);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 38);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalışacağı Şube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yapacağı İş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "İsim Soyisim";
            // 
            // textCalisacagiSube
            // 
            this.textCalisacagiSube.Location = new System.Drawing.Point(867, 206);
            this.textCalisacagiSube.Name = "textCalisacagiSube";
            this.textCalisacagiSube.Size = new System.Drawing.Size(121, 22);
            this.textCalisacagiSube.TabIndex = 6;
            // 
            // textisimsoyisim
            // 
            this.textisimsoyisim.Location = new System.Drawing.Point(867, 92);
            this.textisimsoyisim.Name = "textisimsoyisim";
            this.textisimsoyisim.Size = new System.Drawing.Size(121, 22);
            this.textisimsoyisim.TabIndex = 7;
            // 
            // comboBoxYapacagiis
            // 
            this.comboBoxYapacagiis.FormattingEnabled = true;
            this.comboBoxYapacagiis.Items.AddRange(new object[] {
            "Yönetici",
            "Kasiyer",
            "Pompacı",
            "Temizlik İşler"});
            this.comboBoxYapacagiis.Location = new System.Drawing.Point(867, 146);
            this.comboBoxYapacagiis.Name = "comboBoxYapacagiis";
            this.comboBoxYapacagiis.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYapacagiis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alacağı Maaş";
            // 
            // textAlacagiMaas
            // 
            this.textAlacagiMaas.Location = new System.Drawing.Point(867, 257);
            this.textAlacagiMaas.Name = "textAlacagiMaas";
            this.textAlacagiMaas.Size = new System.Drawing.Size(121, 22);
            this.textAlacagiMaas.TabIndex = 10;
            // 
            // personelBilgileriBindingSource1
            // 
            this.personelBilgileriBindingSource1.DataMember = "PersonelBilgileri";
            this.personelBilgileriBindingSource1.DataSource = this.pysDataSet3;
            // 
            // pysDataSet3
            // 
            this.pysDataSet3.DataSetName = "pysDataSet3";
            this.pysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pysDataSet2
            // 
            this.pysDataSet2.DataSetName = "pysDataSet2";
            this.pysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakitIstegiBindingSource
            // 
            this.yakitIstegiBindingSource.DataMember = "YakitIstegi";
            this.yakitIstegiBindingSource.DataSource = this.pysDataSet2;
            // 
            // yakitIstegiTableAdapter
            // 
            this.yakitIstegiTableAdapter.ClearBeforeFill = true;
            // 
            // personelBilgileriBindingSource
            // 
            this.personelBilgileriBindingSource.DataMember = "PersonelBilgileri";
            this.personelBilgileriBindingSource.DataSource = this.pysDataSet2;
            // 
            // personelBilgileriTableAdapter
            // 
            this.personelBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // personelBilgileriTableAdapter1
            // 
            this.personelBilgileriTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.ısimSoyisimDataGridViewTextBoxColumn,
            this.calistigiSubeDataGridViewTextBoxColumn,
            this.neIsYapiyorDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 262);
            this.dataGridView1.TabIndex = 11;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısimSoyisimDataGridViewTextBoxColumn
            // 
            this.ısimSoyisimDataGridViewTextBoxColumn.DataPropertyName = "IsimSoyisim";
            this.ısimSoyisimDataGridViewTextBoxColumn.HeaderText = "IsimSoyisim";
            this.ısimSoyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ısimSoyisimDataGridViewTextBoxColumn.Name = "ısimSoyisimDataGridViewTextBoxColumn";
            this.ısimSoyisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // calistigiSubeDataGridViewTextBoxColumn
            // 
            this.calistigiSubeDataGridViewTextBoxColumn.DataPropertyName = "CalistigiSube";
            this.calistigiSubeDataGridViewTextBoxColumn.HeaderText = "CalistigiSube";
            this.calistigiSubeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calistigiSubeDataGridViewTextBoxColumn.Name = "calistigiSubeDataGridViewTextBoxColumn";
            this.calistigiSubeDataGridViewTextBoxColumn.Width = 125;
            // 
            // neIsYapiyorDataGridViewTextBoxColumn
            // 
            this.neIsYapiyorDataGridViewTextBoxColumn.DataPropertyName = "NeIsYapiyor";
            this.neIsYapiyorDataGridViewTextBoxColumn.HeaderText = "NeIsYapiyor";
            this.neIsYapiyorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.neIsYapiyorDataGridViewTextBoxColumn.Name = "neIsYapiyorDataGridViewTextBoxColumn";
            this.neIsYapiyorDataGridViewTextBoxColumn.Width = 125;
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "Maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "Maas";
            this.maasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textAlacagiMaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxYapacagiis);
            this.Controls.Add(this.textisimsoyisim);
            this.Controls.Add(this.textCalisacagiSube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgileriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCalisacagiSube;
        private System.Windows.Forms.TextBox textisimsoyisim;
        private System.Windows.Forms.ComboBox comboBoxYapacagiis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAlacagiMaas;
        private pysDataSet2 pysDataSet2;
        private System.Windows.Forms.BindingSource yakitIstegiBindingSource;
        private pysDataSet2TableAdapters.YakitIstegiTableAdapter yakitIstegiTableAdapter;
        private System.Windows.Forms.BindingSource personelBilgileriBindingSource;
        private pysDataSet2TableAdapters.PersonelBilgileriTableAdapter personelBilgileriTableAdapter;
        private pysDataSet3 pysDataSet3;
        private System.Windows.Forms.BindingSource personelBilgileriBindingSource1;
        private pysDataSet3TableAdapters.PersonelBilgileriTableAdapter personelBilgileriTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısimSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calistigiSubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neIsYapiyorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
    }
}