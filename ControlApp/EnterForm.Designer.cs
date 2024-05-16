namespace ControlApp
{
    partial class EnterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            loginViewModel = new BindingSource(components);
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)loginViewModel).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(167, 257);
            button1.Name = "button1";
            button1.Size = new Size(234, 70);
            button1.TabIndex = 3;
            button1.TabStop = false;
            button1.Text = "ВОЙТИ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(124, 56);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.DataBindings.Add(new Binding("Text", loginViewModel, "Login", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(111, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 30);
            textBox1.TabIndex = 0;
            // 
            // loginViewModel
            // 
            loginViewModel.DataSource = typeof(ViewModels.LoginViewModel);
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.DataBindings.Add(new Binding("Text", loginViewModel, "Password", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(111, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 30);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(124, 137);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 1;
            label2.Text = "Пароль:";
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 339);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "EnterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            KeyDown += EnterForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)loginViewModel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private BindingSource loginViewModel;
    }
}
