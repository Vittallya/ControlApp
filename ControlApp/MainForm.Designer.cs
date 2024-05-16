namespace ControlApp
{
    partial class MainForm
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button5 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button2 = new Button();
            button7 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button4 = new Button();
            button8 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            button3 = new Button();
            button9 = new Button();
            menuStrip1 = new MenuStrip();
            профильToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Margin = new Padding(3, 3, 3, 30);
            button1.Name = "button1";
            button1.Size = new Size(267, 55);
            button1.TabIndex = 1;
            button1.Text = "Товары";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(30, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(403, 318);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(377, 62);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.reportImg;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(276, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 55);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Controls.Add(button7);
            flowLayoutPanel3.Location = new Point(3, 71);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(377, 62);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Margin = new Padding(3, 3, 3, 30);
            button2.Name = "button2";
            button2.Size = new Size(267, 55);
            button2.TabIndex = 2;
            button2.Text = "Поступления товаров";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.reportImg;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(276, 3);
            button7.Name = "button7";
            button7.Size = new Size(94, 55);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button4);
            flowLayoutPanel4.Controls.Add(button8);
            flowLayoutPanel4.Location = new Point(3, 139);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(377, 62);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 3);
            button4.Margin = new Padding(3, 3, 3, 30);
            button4.Name = "button4";
            button4.Size = new Size(267, 55);
            button4.TabIndex = 4;
            button4.Text = "Продажи";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.reportImg;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(276, 3);
            button8.Name = "button8";
            button8.Size = new Size(94, 55);
            button8.TabIndex = 2;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(button3);
            flowLayoutPanel5.Controls.Add(button9);
            flowLayoutPanel5.Location = new Point(3, 207);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(377, 62);
            flowLayoutPanel5.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Margin = new Padding(3, 3, 3, 30);
            button3.Name = "button3";
            button3.Size = new Size(267, 55);
            button3.TabIndex = 3;
            button3.Text = "Возвраты товаров";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button9
            // 
            button9.BackgroundImage = Properties.Resources.reportImg;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(276, 3);
            button9.Name = "button9";
            button9.Size = new Size(94, 55);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { профильToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // профильToolStripMenuItem
            // 
            профильToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выйтиToolStripMenuItem });
            профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            профильToolStripMenuItem.Size = new Size(87, 24);
            профильToolStripMenuItem.Text = "Профиль";
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(136, 26);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 371);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem профильToolStripMenuItem;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button8;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button button9;
    }
}