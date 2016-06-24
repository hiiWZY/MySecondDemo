namespace MySqlExample3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indepYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lifeExpectancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNPOldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.governmentFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headOfStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldDataSet = new MySqlExample3.worldDataSet();
            this.countryTableAdapter = new MySqlExample3.worldDataSetTableAdapters.countryTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.continentDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.surfaceAreaDataGridViewTextBoxColumn,
            this.indepYearDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.lifeExpectancyDataGridViewTextBoxColumn,
            this.gNPDataGridViewTextBoxColumn,
            this.gNPOldDataGridViewTextBoxColumn,
            this.localNameDataGridViewTextBoxColumn,
            this.governmentFormDataGridViewTextBoxColumn,
            this.headOfStateDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.code2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(731, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // continentDataGridViewTextBoxColumn
            // 
            this.continentDataGridViewTextBoxColumn.DataPropertyName = "Continent";
            this.continentDataGridViewTextBoxColumn.HeaderText = "Continent";
            this.continentDataGridViewTextBoxColumn.Name = "continentDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // surfaceAreaDataGridViewTextBoxColumn
            // 
            this.surfaceAreaDataGridViewTextBoxColumn.DataPropertyName = "SurfaceArea";
            this.surfaceAreaDataGridViewTextBoxColumn.HeaderText = "SurfaceArea";
            this.surfaceAreaDataGridViewTextBoxColumn.Name = "surfaceAreaDataGridViewTextBoxColumn";
            // 
            // indepYearDataGridViewTextBoxColumn
            // 
            this.indepYearDataGridViewTextBoxColumn.DataPropertyName = "IndepYear";
            this.indepYearDataGridViewTextBoxColumn.HeaderText = "IndepYear";
            this.indepYearDataGridViewTextBoxColumn.Name = "indepYearDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // lifeExpectancyDataGridViewTextBoxColumn
            // 
            this.lifeExpectancyDataGridViewTextBoxColumn.DataPropertyName = "LifeExpectancy";
            this.lifeExpectancyDataGridViewTextBoxColumn.HeaderText = "LifeExpectancy";
            this.lifeExpectancyDataGridViewTextBoxColumn.Name = "lifeExpectancyDataGridViewTextBoxColumn";
            // 
            // gNPDataGridViewTextBoxColumn
            // 
            this.gNPDataGridViewTextBoxColumn.DataPropertyName = "GNP";
            this.gNPDataGridViewTextBoxColumn.HeaderText = "GNP";
            this.gNPDataGridViewTextBoxColumn.Name = "gNPDataGridViewTextBoxColumn";
            // 
            // gNPOldDataGridViewTextBoxColumn
            // 
            this.gNPOldDataGridViewTextBoxColumn.DataPropertyName = "GNPOld";
            this.gNPOldDataGridViewTextBoxColumn.HeaderText = "GNPOld";
            this.gNPOldDataGridViewTextBoxColumn.Name = "gNPOldDataGridViewTextBoxColumn";
            // 
            // localNameDataGridViewTextBoxColumn
            // 
            this.localNameDataGridViewTextBoxColumn.DataPropertyName = "LocalName";
            this.localNameDataGridViewTextBoxColumn.HeaderText = "LocalName";
            this.localNameDataGridViewTextBoxColumn.Name = "localNameDataGridViewTextBoxColumn";
            // 
            // governmentFormDataGridViewTextBoxColumn
            // 
            this.governmentFormDataGridViewTextBoxColumn.DataPropertyName = "GovernmentForm";
            this.governmentFormDataGridViewTextBoxColumn.HeaderText = "GovernmentForm";
            this.governmentFormDataGridViewTextBoxColumn.Name = "governmentFormDataGridViewTextBoxColumn";
            // 
            // headOfStateDataGridViewTextBoxColumn
            // 
            this.headOfStateDataGridViewTextBoxColumn.DataPropertyName = "HeadOfState";
            this.headOfStateDataGridViewTextBoxColumn.HeaderText = "HeadOfState";
            this.headOfStateDataGridViewTextBoxColumn.Name = "headOfStateDataGridViewTextBoxColumn";
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            // 
            // code2DataGridViewTextBoxColumn
            // 
            this.code2DataGridViewTextBoxColumn.DataPropertyName = "Code2";
            this.code2DataGridViewTextBoxColumn.HeaderText = "Code2";
            this.code2DataGridViewTextBoxColumn.Name = "code2DataGridViewTextBoxColumn";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.worldDataSet;
            // 
            // worldDataSet
            // 
            this.worldDataSet.DataSetName = "worldDataSet";
            this.worldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 21);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 468);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private worldDataSet worldDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private worldDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn continentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indepYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifeExpectancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNPOldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn governmentFormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headOfStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn code2DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

