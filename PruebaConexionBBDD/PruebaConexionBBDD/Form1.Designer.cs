
namespace PruebaConexionBBDD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new PruebaConexionBBDD.DataSet1();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new PruebaConexionBBDD.DataSet1TableAdapters.EMPLOYEESTableAdapter();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hIREDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMISSIONPCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANAGERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.hIREDATEDataGridViewTextBoxColumn,
            this.jOBIDDataGridViewTextBoxColumn,
            this.sALARYDataGridViewTextBoxColumn,
            this.cOMMISSIONPCTDataGridViewTextBoxColumn,
            this.mANAGERIDDataGridViewTextBoxColumn,
            this.dEPARTMENTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.dataSet1;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            this.fIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lASTNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.pHONENUMBERDataGridViewTextBoxColumn.Width = 150;
            // 
            // hIREDATEDataGridViewTextBoxColumn
            // 
            this.hIREDATEDataGridViewTextBoxColumn.DataPropertyName = "HIRE_DATE";
            this.hIREDATEDataGridViewTextBoxColumn.HeaderText = "HIRE_DATE";
            this.hIREDATEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hIREDATEDataGridViewTextBoxColumn.Name = "hIREDATEDataGridViewTextBoxColumn";
            this.hIREDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.hIREDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // jOBIDDataGridViewTextBoxColumn
            // 
            this.jOBIDDataGridViewTextBoxColumn.DataPropertyName = "JOB_ID";
            this.jOBIDDataGridViewTextBoxColumn.HeaderText = "JOB_ID";
            this.jOBIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jOBIDDataGridViewTextBoxColumn.Name = "jOBIDDataGridViewTextBoxColumn";
            this.jOBIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jOBIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sALARYDataGridViewTextBoxColumn
            // 
            this.sALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sALARYDataGridViewTextBoxColumn.Name = "sALARYDataGridViewTextBoxColumn";
            this.sALARYDataGridViewTextBoxColumn.ReadOnly = true;
            this.sALARYDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOMMISSIONPCTDataGridViewTextBoxColumn
            // 
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.DataPropertyName = "COMMISSION_PCT";
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.HeaderText = "COMMISSION_PCT";
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.Name = "cOMMISSIONPCTDataGridViewTextBoxColumn";
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMMISSIONPCTDataGridViewTextBoxColumn.Width = 150;
            // 
            // mANAGERIDDataGridViewTextBoxColumn
            // 
            this.mANAGERIDDataGridViewTextBoxColumn.DataPropertyName = "MANAGER_ID";
            this.mANAGERIDDataGridViewTextBoxColumn.HeaderText = "MANAGER_ID";
            this.mANAGERIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mANAGERIDDataGridViewTextBoxColumn.Name = "mANAGERIDDataGridViewTextBoxColumn";
            this.mANAGERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mANAGERIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dEPARTMENTIDDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTIDDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT_ID";
            this.dEPARTMENTIDDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT_ID";
            this.dEPARTMENTIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dEPARTMENTIDDataGridViewTextBoxColumn.Name = "dEPARTMENTIDDataGridViewTextBoxColumn";
            this.dEPARTMENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPARTMENTIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 727);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private DataSet1TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hIREDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMISSIONPCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANAGERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTIDDataGridViewTextBoxColumn;
    }
}

