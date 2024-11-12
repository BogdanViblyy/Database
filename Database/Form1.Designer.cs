namespace Database
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
            this.label1 = new System.Windows.Forms.Label();
            this.nimetusTextBox = new System.Windows.Forms.TextBox();
            this.kogusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hindTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lisa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database_DataSet = new Database.Database_DataSet();
            this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodedTableAdapter = new Database.Database_DataSetTableAdapters.ToodedTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimetus";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nimetusTextBox
            // 
            this.nimetusTextBox.Location = new System.Drawing.Point(87, 38);
            this.nimetusTextBox.Name = "nimetusTextBox";
            this.nimetusTextBox.Size = new System.Drawing.Size(100, 20);
            this.nimetusTextBox.TabIndex = 1;
            // 
            // kogusTextBox
            // 
            this.kogusTextBox.Location = new System.Drawing.Point(87, 129);
            this.kogusTextBox.Name = "kogusTextBox";
            this.kogusTextBox.Size = new System.Drawing.Size(100, 20);
            this.kogusTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogus";
            // 
            // hindTextBox
            // 
            this.hindTextBox.Location = new System.Drawing.Point(87, 205);
            this.hindTextBox.Name = "hindTextBox";
            this.hindTextBox.Size = new System.Drawing.Size(100, 20);
            this.hindTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hind";
            // 
            // Lisa
            // 
            this.Lisa.Location = new System.Drawing.Point(12, 231);
            this.Lisa.Name = "Lisa";
            this.Lisa.Size = new System.Drawing.Size(175, 34);
            this.Lisa.TabIndex = 7;
            this.Lisa.Text = "Lisa";
            this.Lisa.UseVisualStyleBackColor = true;
            this.Lisa.Click += new System.EventHandler(this.Lisa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // database_DataSet
            // 
            this.database_DataSet.DataSetName = "Database_DataSet";
            this.database_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodedBindingSource
            // 
            this.toodedBindingSource.DataMember = "Tooded";
            this.toodedBindingSource.DataSource = this.database_DataSet;
            // 
            // toodedTableAdapter
            // 
            this.toodedTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimetusDataGridViewTextBoxColumn
            // 
            this.nimetusDataGridViewTextBoxColumn.DataPropertyName = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.HeaderText = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.Name = "nimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lisa);
            this.Controls.Add(this.hindTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kogusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nimetusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nimetusTextBox;
        private System.Windows.Forms.TextBox kogusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hindTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Lisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database_DataSet database_DataSet;
        private System.Windows.Forms.BindingSource toodedBindingSource;
        private Database_DataSetTableAdapters.ToodedTableAdapter toodedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
    }
}

