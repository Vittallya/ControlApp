namespace ControlApp
{
    partial class ProductsForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 433);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(293, 537);
            button3.Name = "button3";
            button3.Size = new Size(198, 64);
            button3.TabIndex = 4;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 6;
            label1.Text = "Поиск:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(611, 24);
            button1.Name = "button1";
            button1.Size = new Size(177, 47);
            button1.TabIndex = 7;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 624);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}