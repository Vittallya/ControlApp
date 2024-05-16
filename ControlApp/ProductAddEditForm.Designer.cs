namespace ControlApp
{
    partial class ProductAddEditForm
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
            bindingSource1 = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            textBox3 = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            textBox4 = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label5 = new Label();
            textBox5 = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label6 = new Label();
            textBox6 = new TextBox();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label7 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Core.Entities.ProductEntity);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
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
            label1.Size = new Size(111, 19);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(3, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 27);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(35, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(382, 535);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(textBox2);
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
            label2.Size = new Size(76, 19);
            label2.TabIndex = 0;
            label2.Text = "Описание";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Description", true));
            textBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(3, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 27);
            textBox2.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(textBox3);
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
            label3.Size = new Size(87, 19);
            label3.TabIndex = 0;
            label3.Text = "Стоимость";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Cost", true));
            textBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(3, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 27);
            textBox3.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(textBox4);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(3, 232);
            flowLayoutPanel5.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(369, 61);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 0;
            label4.Text = "Количество";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "Count", true, DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            textBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(3, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(351, 27);
            textBox4.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label5);
            flowLayoutPanel6.Controls.Add(textBox5);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(3, 307);
            flowLayoutPanel6.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(369, 61);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 19);
            label5.TabIndex = 0;
            label5.Text = "Производитель";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Manufacturer", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(3, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(351, 27);
            textBox5.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label6);
            flowLayoutPanel7.Controls.Add(textBox6);
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(3, 382);
            flowLayoutPanel7.Margin = new Padding(3, 7, 3, 7);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(369, 61);
            flowLayoutPanel7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 0;
            label6.Text = "Категория";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Category", true));
            textBox6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(3, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(351, 27);
            textBox6.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(label7);
            flowLayoutPanel8.Controls.Add(textBox7);
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(3, 457);
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
            label7.Size = new Size(104, 19);
            label7.TabIndex = 0;
            label7.Text = "Изображение";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "ImageName", true));
            textBox7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(3, 22);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(351, 27);
            textBox7.TabIndex = 1;
            textBox7.Text = "(нажмите)";
            textBox7.Click += textBox7_Click;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 553);
            button1.Name = "button1";
            button1.Size = new Size(351, 46);
            button1.TabIndex = 2;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductAddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 611);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProductAddEditForm";
            Text = "ProductAddEditForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private TextBox textBox3;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label4;
        private TextBox textBox4;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label5;
        private TextBox textBox5;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label6;
        private TextBox textBox6;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label7;
        private TextBox textBox7;
        private Button button1;
    }
}