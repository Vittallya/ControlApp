namespace ControlApp.UserControls
{
    partial class ProductIncomeDetails
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ProductIncomeBs = new BindingSource(components);
            productsBs = new BindingSource(components);
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label7 = new Label();
            textBox7 = new TextBox();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductIncomeBs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBs).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(382, 316);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 7);
            flowLayoutPanel1.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(369, 61);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 0;
            label1.Text = "Товар";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedItem", ProductIncomeBs, "ProductEntity", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox1.DataSource = productsBs;
            comboBox1.DisplayMember = "Name";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(351, 28);
            comboBox1.TabIndex = 2;
            comboBox1.ValueMember = "Id";
            // 
            // ProductIncomeBs
            // 
            ProductIncomeBs.DataSource = typeof(Core.Entities.ProductIncomeEntity);
            // 
            // productsBs
            // 
            productsBs.DataSource = typeof(Core.Entities.ProductEntity);
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(numericUpDown1);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 82);
            flowLayoutPanel3.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(369, 61);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 0;
            label2.Text = "Количество";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", ProductIncomeBs, "Count", true, DataSourceUpdateMode.OnPropertyChanged));
            numericUpDown1.Location = new Point(3, 22);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(dateTimePicker1);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(3, 157);
            flowLayoutPanel4.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(369, 61);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 19);
            label3.TabIndex = 0;
            label3.Text = "Дата поступления";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", ProductIncomeBs, "IncomeDate", true, DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            dateTimePicker1.Location = new Point(3, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(351, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 5, 1, 0, 0, 0, 0);
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(label7);
            flowLayoutPanel8.Controls.Add(textBox7);
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(3, 232);
            flowLayoutPanel8.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(369, 61);
            flowLayoutPanel8.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 19);
            label7.TabIndex = 0;
            label7.Text = "Примечания";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", ProductIncomeBs, "Additional", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(3, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(351, 27);
            textBox7.TabIndex = 1;
            // 
            // ProductIncomeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel2);
            Name = "ProductIncomeDetails";
            Size = new Size(396, 337);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductIncomeBs).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBs).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label7;
        private TextBox textBox7;
        private BindingSource ProductIncomeBs;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private BindingSource productsBs;
    }
}
