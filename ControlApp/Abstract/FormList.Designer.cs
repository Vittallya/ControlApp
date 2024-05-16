namespace ControlApp.Abstract
{
    //partial class FormList
    partial class FormList<TEntity>
    {

        private Button button1;
        private Panel panel1;
        private Button button2;
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
            button1 = new Button();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(177, 54);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.ContextMenuStrip = contextMenuStrip1;
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 335);
            panel1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { редактироватьToolStripMenuItem, удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(210, 24);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += OnEditClick;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(210, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += OnDeleteItemClicked;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(287, 459);
            button2.Name = "button2";
            button2.Size = new Size(177, 54);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormList
            // 
            ClientSize = new Size(762, 525);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "FormList";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}