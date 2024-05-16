namespace ControlApp
{
    partial class ProductDetailsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            label9 = new Label();
            ProductSource = new BindingSource(components);
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label10, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label11, 1, 2);
            tableLayoutPanel1.Controls.Add(label12, 1, 3);
            tableLayoutPanel1.Controls.Add(label13, 1, 4);
            tableLayoutPanel1.Controls.Add(label14, 1, 5);
            tableLayoutPanel1.Location = new Point(275, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(486, 383);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(3, 325);
            label10.Name = "label10";
            label10.Size = new Size(125, 22);
            label10.TabIndex = 4;
            label10.Text = "Изображение";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.DataBindings.Add(new Binding("Text", ProductSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(246, 50);
            label9.Name = "label9";
            label9.Size = new Size(136, 22);
            label9.TabIndex = 3;
            label9.Text = "Наименование";
            // 
            // ProductSource
            // 
            ProductSource.DataSource = typeof(Core.Entities.ProductEntity);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.DataBindings.Add(new Binding("Text", ProductSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(246, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 22);
            label8.TabIndex = 2;
            label8.Text = "Наименование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 22);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 125);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 1;
            label3.Text = "Стоимость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 175);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 1;
            label4.Text = "Категория";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 225);
            label5.Name = "label5";
            label5.Size = new Size(109, 22);
            label5.TabIndex = 1;
            label5.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 275);
            label6.Name = "label6";
            label6.Size = new Size(139, 22);
            label6.TabIndex = 1;
            label6.Text = "Производитель";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.DataBindings.Add(new Binding("Text", ProductSource, "ImageName", true, DataSourceUpdateMode.OnPropertyChanged));
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(246, 325);
            label7.Name = "label7";
            label7.Size = new Size(125, 22);
            label7.TabIndex = 1;
            label7.Text = "Изображение";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.DataBindings.Add(new Binding("Text", ProductSource, "Cost", true, DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(246, 125);
            label11.Name = "label11";
            label11.Size = new Size(136, 22);
            label11.TabIndex = 3;
            label11.Text = "Наименование";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.DataBindings.Add(new Binding("Text", ProductSource, "Category", true, DataSourceUpdateMode.OnPropertyChanged));
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(246, 175);
            label12.Name = "label12";
            label12.Size = new Size(136, 22);
            label12.TabIndex = 3;
            label12.Text = "Наименование";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.DataBindings.Add(new Binding("Text", ProductSource, "Count", true, DataSourceUpdateMode.OnPropertyChanged));
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(246, 225);
            label13.Name = "label13";
            label13.Size = new Size(136, 22);
            label13.TabIndex = 3;
            label13.Text = "Наименование";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.DataBindings.Add(new Binding("Text", ProductSource, "Manufacturer", true, DataSourceUpdateMode.OnPropertyChanged));
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(246, 275);
            label14.Name = "label14";
            label14.Size = new Size(136, 22);
            label14.TabIndex = 3;
            label14.Text = "Наименование";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(335, 475);
            button3.Name = "button3";
            button3.Size = new Size(198, 64);
            button3.TabIndex = 3;
            button3.Text = "Редактировать";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(563, 475);
            button1.Name = "button1";
            button1.Size = new Size(198, 64);
            button1.TabIndex = 3;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 551);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button1;
        private Label label10;
        private BindingSource ProductSource;
        private Label label7;
    }
}