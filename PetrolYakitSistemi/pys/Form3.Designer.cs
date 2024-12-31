namespace pys
{
    partial class Form3
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
            this.btnYakitIste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSubeAdi = new System.Windows.Forms.TextBox();
            this.textIstenilenYakit = new System.Windows.Forms.TextBox();
            this.textDepodakiYakit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstenenYakitMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevcutDepoMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitIstegiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pysDataSet1 = new pys.pysDataSet1();
            this.yakitIstegiTableAdapter = new pys.pysDataSet1TableAdapters.YakitIstegiTableAdapter();
            this.pysDataSet3 = new pys.pysDataSet3();
            this.yakitIstegiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yakitIstegiTableAdapter1 = new pys.pysDataSet3TableAdapters.YakitIstegiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYakitIste
            // 
            this.btnYakitIste.Location = new System.Drawing.Point(321, 340);
            this.btnYakitIste.Name = "btnYakitIste";
            this.btnYakitIste.Size = new System.Drawing.Size(75, 23);
            this.btnYakitIste.TabIndex = 0;
            this.btnYakitIste.Text = "Yakıt İste";
            this.btnYakitIste.UseVisualStyleBackColor = true;
            this.btnYakitIste.Click += new System.EventHandler(this.btnYakitIste_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yakıt İsteyen Şube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İstenile Yakıt Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depoda Kalan Yakıt Miktarı";
            // 
            // textSubeAdi
            // 
            this.textSubeAdi.Location = new System.Drawing.Point(330, 211);
            this.textSubeAdi.Name = "textSubeAdi";
            this.textSubeAdi.Size = new System.Drawing.Size(100, 22);
            this.textSubeAdi.TabIndex = 4;
            // 
            // textIstenilenYakit
            // 
            this.textIstenilenYakit.Location = new System.Drawing.Point(330, 270);
            this.textIstenilenYakit.Name = "textIstenilenYakit";
            this.textIstenilenYakit.Size = new System.Drawing.Size(100, 22);
            this.textIstenilenYakit.TabIndex = 5;
            // 
            // textDepodakiYakit
            // 
            this.textDepodakiYakit.Location = new System.Drawing.Point(675, 76);
            this.textDepodakiYakit.Name = "textDepodakiYakit";
            this.textDepodakiYakit.Size = new System.Drawing.Size(100, 22);
            this.textDepodakiYakit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yakıt İsteme Sistemi";
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
            this.dataGridView1.DataSource = this.yakitIstegiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(448, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 150);
            this.dataGridView1.TabIndex = 8;
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
            // yakitIstegiBindingSource
            // 
            this.yakitIstegiBindingSource.DataMember = "YakitIstegi";
            this.yakitIstegiBindingSource.DataSource = this.pysDataSet1;
            // 
            // pysDataSet1
            // 
            this.pysDataSet1.DataSetName = "pysDataSet1";
            this.pysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakitIstegiTableAdapter
            // 
            this.yakitIstegiTableAdapter.ClearBeforeFill = true;
            // 
            // pysDataSet3
            // 
            this.pysDataSet3.DataSetName = "pysDataSet3";
            this.pysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakitIstegiBindingSource1
            // 
            this.yakitIstegiBindingSource1.DataMember = "YakitIstegi";
            this.yakitIstegiBindingSource1.DataSource = this.pysDataSet3;
            // 
            // yakitIstegiTableAdapter1
            // 
            this.yakitIstegiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDepodakiYakit);
            this.Controls.Add(this.textIstenilenYakit);
            this.Controls.Add(this.textSubeAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYakitIste);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitIstegiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYakitIste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSubeAdi;
        private System.Windows.Forms.TextBox textIstenilenYakit;
        private System.Windows.Forms.TextBox textDepodakiYakit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pysDataSet1 pysDataSet1;
        private System.Windows.Forms.BindingSource yakitIstegiBindingSource;
        private pysDataSet1TableAdapters.YakitIstegiTableAdapter yakitIstegiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstenenYakitMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevcutDepoMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private pysDataSet3 pysDataSet3;
        private System.Windows.Forms.BindingSource yakitIstegiBindingSource1;
        private pysDataSet3TableAdapters.YakitIstegiTableAdapter yakitIstegiTableAdapter1;
    }
}