namespace pys
{
    partial class Form6
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textIstenenYakitMiktari = new System.Windows.Forms.TextBox();
            this.textMevcutDepoMiktari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pysDataSet3 = new pys.pysDataSet3();
            this.yakitIstegiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakitIstegiTableAdapter = new pys.pysDataSet3TableAdapters.YakitIstegiTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevcutDepoMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(259, 337);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(82, 31);
            this.btnOnayla.TabIndex = 0;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(384, 337);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(82, 31);
            this.btnReddet.TabIndex = 1;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(330, 223);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 2;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textIstenenYakitMiktari
            // 
            this.textIstenenYakitMiktari.Location = new System.Drawing.Point(330, 279);
            this.textIstenenYakitMiktari.Name = "textIstenenYakitMiktari";
            this.textIstenenYakitMiktari.Size = new System.Drawing.Size(100, 22);
            this.textIstenenYakitMiktari.TabIndex = 3;
            // 
            // textMevcutDepoMiktari
            // 
            this.textMevcutDepoMiktari.Location = new System.Drawing.Point(621, 223);
            this.textMevcutDepoMiktari.Name = "textMevcutDepoMiktari";
            this.textMevcutDepoMiktari.Size = new System.Drawing.Size(100, 22);
            this.textMevcutDepoMiktari.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.subeAdiDataGridViewTextBoxColumn,
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn,
            this.mevcutDepoMiktariDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yakitIstegiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // pysDataSet3
            // 
            this.pysDataSet3.DataSetName = "pysDataSet3";
            this.pysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakitIstegiBindingSource
            // 
            this.yakitIstegiBindingSource.DataMember = "YakitIstegi";
            this.yakitIstegiBindingSource.DataSource = this.pysDataSet3;
            // 
            // yakitIstegiTableAdapter
            // 
            this.yakitIstegiTableAdapter.ClearBeforeFill = true;
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
            // subeAdiDataGridViewTextBoxColumn
            // 
            this.subeAdiDataGridViewTextBoxColumn.DataPropertyName = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.HeaderText = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeAdiDataGridViewTextBoxColumn.Name = "subeAdiDataGridViewTextBoxColumn";
            this.subeAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıstenenYakitMiktariDataGridViewTextBoxColumn
            // 
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn.DataPropertyName = "IstenenYakitMiktari";
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn.HeaderText = "IstenenYakitMiktari";
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn.Name = "ıstenenYakitMiktariDataGridViewTextBoxColumn";
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // mevcutDepoMiktariDataGridViewTextBoxColumn
            // 
            this.mevcutDepoMiktariDataGridViewTextBoxColumn.DataPropertyName = "MevcutDepoMiktari";
            this.mevcutDepoMiktariDataGridViewTextBoxColumn.HeaderText = "MevcutDepoMiktari";
            this.mevcutDepoMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mevcutDepoMiktariDataGridViewTextBoxColumn.Name = "mevcutDepoMiktariDataGridViewTextBoxColumn";
            this.mevcutDepoMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Depodaki Mevcut Yakıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "İstenen Yakıt Mktarı";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textMevcutDepoMiktari);
            this.Controls.Add(this.textIstenenYakitMiktari);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textIstenenYakitMiktari;
        private System.Windows.Forms.TextBox textMevcutDepoMiktari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pysDataSet3 pysDataSet3;
        private System.Windows.Forms.BindingSource yakitIstegiBindingSource;
        private pysDataSet3TableAdapters.YakitIstegiTableAdapter yakitIstegiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstenenYakitMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevcutDepoMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}