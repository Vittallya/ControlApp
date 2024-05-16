namespace ControlApp.UserControls
{
    partial class SalesList
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductEntity = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TotalSum = new DataGridViewTextBoxColumn();
            SaleDate = new DataGridViewTextBoxColumn();
            additionalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productSaleEntityBindingSource = new BindingSource(components);
            productReturnEntityBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productSaleEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productReturnEntityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ProductEntity, countDataGridViewTextBoxColumn, TotalSum, SaleDate, additionalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productSaleEntityBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(717, 289);
            dataGridView1.TabIndex = 0;
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
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Количество";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TotalSum
            // 
            TotalSum.DataPropertyName = "TotalSum";
            TotalSum.HeaderText = "Общая сумма";
            TotalSum.MinimumWidth = 6;
            TotalSum.Name = "TotalSum";
            TotalSum.ReadOnly = true;
            // 
            // SaleDate
            // 
            SaleDate.DataPropertyName = "SaleDate";
            SaleDate.HeaderText = "Дата продажи";
            SaleDate.MinimumWidth = 6;
            SaleDate.Name = "SaleDate";
            SaleDate.ReadOnly = true;
            // 
            // additionalDataGridViewTextBoxColumn
            // 
            additionalDataGridViewTextBoxColumn.DataPropertyName = "Additional";
            additionalDataGridViewTextBoxColumn.HeaderText = "Примечания";
            additionalDataGridViewTextBoxColumn.MinimumWidth = 6;
            additionalDataGridViewTextBoxColumn.Name = "additionalDataGridViewTextBoxColumn";
            additionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSaleEntityBindingSource
            // 
            productSaleEntityBindingSource.DataSource = typeof(Core.Entities.ProductSaleEntity);
            // 
            // productReturnEntityBindingSource
            // 
            productReturnEntityBindingSource.DataSource = typeof(Core.Entities.ProductReturnEntity);
            // 
            // SalesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "SalesList";
            Size = new Size(717, 289);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productSaleEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productReturnEntityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productEntityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private BindingSource productReturnEntityBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductEntity;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TotalSum;
        private DataGridViewTextBoxColumn SaleDate;
        private DataGridViewTextBoxColumn additionalDataGridViewTextBoxColumn;
        private BindingSource productSaleEntityBindingSource;
    }
}
