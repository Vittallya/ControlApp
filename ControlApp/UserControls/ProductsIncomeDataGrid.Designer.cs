namespace ControlApp.UserControls
{
    partial class ProductsIncomeDataGrid
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            productIncomeEntityBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductEntity = new DataGridViewTextBoxColumn();
            incomeDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalSumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            additionalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productIncomeEntityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Core.Entities.ProductIncomeEntity);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ProductEntity, incomeDateDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, totalSumDataGridViewTextBoxColumn, additionalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productIncomeEntityBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 330);
            dataGridView1.TabIndex = 0;
            // 
            // productIncomeEntityBindingSource
            // 
            productIncomeEntityBindingSource.DataSource = typeof(Core.Entities.ProductIncomeEntity);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductEntity
            // 
            ProductEntity.DataPropertyName = "ProductName";
            ProductEntity.HeaderText = "Товар";
            ProductEntity.MinimumWidth = 6;
            ProductEntity.Name = "ProductEntity";
            ProductEntity.ReadOnly = true;
            // 
            // incomeDateDataGridViewTextBoxColumn
            // 
            incomeDateDataGridViewTextBoxColumn.DataPropertyName = "IncomeDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            incomeDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
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
            totalSumDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            totalSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionalDataGridViewTextBoxColumn
            // 
            additionalDataGridViewTextBoxColumn.DataPropertyName = "Additional";
            additionalDataGridViewTextBoxColumn.HeaderText = "Примечания";
            additionalDataGridViewTextBoxColumn.MinimumWidth = 6;
            additionalDataGridViewTextBoxColumn.Name = "additionalDataGridViewTextBoxColumn";
            additionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductsIncomeDataGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "ProductsIncomeDataGrid";
            Size = new Size(735, 336);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productIncomeEntityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productEntityDataGridViewTextBoxColumn;
        private BindingSource productIncomeEntityBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductEntity;
        private DataGridViewTextBoxColumn incomeDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additionalDataGridViewTextBoxColumn;
    }
}
