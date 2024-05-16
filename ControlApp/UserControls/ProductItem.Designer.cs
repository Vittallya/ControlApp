namespace ControlApp
{
    partial class ProductItem
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
            label1 = new Label();
            productBS = new BindingSource(components);
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)productBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.DataBindings.Add(new Binding("Text", productBS, "Name", true));
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(44, 66);
            label1.Name = "label1";
            label1.Size = new Size(444, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += ProductItem_Click;
            // 
            // productBS
            // 
            productBS.DataSource = typeof(Core.Entities.ProductEntity);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(506, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ProductItem_Click;
            // 
            // label2
            // 
            label2.DataBindings.Add(new Binding("Text", productBS, "Description", true));
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(44, 112);
            label2.Name = "label2";
            label2.Size = new Size(444, 62);
            label2.TabIndex = 0;
            label2.Text = "label1";
            label2.Click += ProductItem_Click;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ActiveCaption;
            Name = "ProductItem";
            Size = new Size(691, 198);
            ((System.ComponentModel.ISupportInitialize)productBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private BindingSource productBS;
    }
}
