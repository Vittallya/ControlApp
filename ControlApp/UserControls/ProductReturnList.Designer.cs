namespace ControlApp.UserControls
{
    partial class ProductReturnList
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
            productReturnEntityBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductEntity = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            additionalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productReturnEntityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ProductEntity, countDataGridViewTextBoxColumn, ReturnDate, Reason, additionalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productReturnEntityBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 330);
            dataGridView1.TabIndex = 0;
            // 
            // productReturnEntityBindingSource
            // 
            productReturnEntityBindingSource.DataSource = typeof(Core.Entities.ProductReturnEntity);
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
            // ReturnDate
            // 
            ReturnDate.DataPropertyName = "ReturnDate";
            ReturnDate.HeaderText = "Дата возврата";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            // 
            // Reason
            // 
            Reason.DataPropertyName = "Reason";
            Reason.HeaderText = "Причина возврата";
            Reason.MinimumWidth = 6;
            Reason.Name = "Reason";
            Reason.ReadOnly = true;
            // 
            // additionalDataGridViewTextBoxColumn
            // 
            additionalDataGridViewTextBoxColumn.DataPropertyName = "Additional";
            additionalDataGridViewTextBoxColumn.HeaderText = "Примечания";
            additionalDataGridViewTextBoxColumn.MinimumWidth = 6;
            additionalDataGridViewTextBoxColumn.Name = "additionalDataGridViewTextBoxColumn";
            additionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductReturnList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "ProductReturnList";
            Size = new Size(735, 336);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productReturnEntityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productEntityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductEntity;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ReturnDate;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn additionalDataGridViewTextBoxColumn;
        private BindingSource productReturnEntityBindingSource;
    }
}
