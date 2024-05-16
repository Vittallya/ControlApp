namespace ControlApp
{
    partial class ProductsIncomeForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            productIncomeViewModelBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            incomeDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            additionalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productIncomeViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, incomeDateDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, totalSumDataGridViewTextBoxColumn, additionalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productIncomeViewModelBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1067, 302);
            dataGridView1.TabIndex = 0;
            // 
            // productIncomeViewModelBindingSource
            // 
            productIncomeViewModelBindingSource.DataSource = typeof(ViewModels.ProductIncomeViewModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ID товара";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDateDataGridViewTextBoxColumn
            // 
            incomeDateDataGridViewTextBoxColumn.DataPropertyName = "IncomeDate";
            incomeDateDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            incomeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            incomeDateDataGridViewTextBoxColumn.Name = "incomeDateDataGridViewTextBoxColumn";
            incomeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Количество";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            totalSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            totalSumDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            totalSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionalDataGridViewTextBoxColumn
            // 
            additionalDataGridViewTextBoxColumn.DataPropertyName = "Additional";
            additionalDataGridViewTextBoxColumn.HeaderText = "Дополнения";
            additionalDataGridViewTextBoxColumn.MinimumWidth = 6;
            additionalDataGridViewTextBoxColumn.Name = "additionalDataGridViewTextBoxColumn";
            additionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductsIncomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 450);
            Controls.Add(dataGridView1);
            Name = "ProductsIncomeForm";
            Text = "ProductsIncomeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productIncomeViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productIncomeViewModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn incomeDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionalDataGridViewTextBoxColumn;
    }
}