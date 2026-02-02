namespace Master
{
    partial class Toast
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
            pic_info = new PictureBox();
            label_title = new Label();
            label_description = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gradientPanel1 = new BrainerStorm.codes.GradientPanel();
            panelProgressBg = new Panel();
            panelProgressFill = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pic_info).BeginInit();
            gradientPanel1.SuspendLayout();
            panelProgressBg.SuspendLayout();
            SuspendLayout();
            // 
            // pic_info
            // 
            pic_info.BackColor = Color.Transparent;
            pic_info.Image = Properties.Resources.success;
            pic_info.Location = new Point(16, 8);
            pic_info.Name = "pic_info";
            pic_info.Size = new Size(50, 50);
            pic_info.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_info.TabIndex = 1;
            pic_info.TabStop = false;
            pic_info.Click += pic_info_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.BackColor = Color.Transparent;
            label_title.Font = new Font("Source Code Pro", 12F, FontStyle.Bold);
            label_title.ForeColor = Color.White;
            label_title.Location = new Point(72, 3);
            label_title.Name = "label_title";
            label_title.Size = new Size(59, 20);
            label_title.TabIndex = 2;
            label_title.Text = "Title";
            label_title.Click += label_title_Click;
            // 
            // label_description
            // 
            label_description.BackColor = Color.Transparent;
            label_description.ForeColor = Color.White;
            label_description.Location = new Point(72, 22);
            label_description.Name = "label_description";
            label_description.Size = new Size(224, 41);
            label_description.TabIndex = 3;
            label_description.Text = "Description text.";
            label_description.Click += label_description_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 180F;
            gradientPanel1.ColorBottom = Color.Red;
            gradientPanel1.ColorMiddle = Color.FromArgb(40, 40, 40);
            gradientPanel1.ColorTop = Color.FromArgb(40, 40, 40);
            gradientPanel1.Controls.Add(panelProgressBg);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(300, 69);
            gradientPanel1.TabIndex = 4;
            gradientPanel1.Click += gradientPanel1_Click;
            // 
            // panelProgressBg
            // 
            panelProgressBg.BackColor = Color.White;
            panelProgressBg.Controls.Add(panelProgressFill);
            panelProgressBg.Dock = DockStyle.Bottom;
            panelProgressBg.Location = new Point(0, 66);
            panelProgressBg.Name = "panelProgressBg";
            panelProgressBg.Size = new Size(300, 3);
            panelProgressBg.TabIndex = 0;
            // 
            // panelProgressFill
            // 
            panelProgressFill.BackColor = Color.Red;
            panelProgressFill.Dock = DockStyle.Left;
            panelProgressFill.Location = new Point(0, 0);
            panelProgressFill.Name = "panelProgressFill";
            panelProgressFill.Size = new Size(0, 3);
            panelProgressFill.TabIndex = 1;
            // 
            // Toast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(300, 70);
            Controls.Add(label_description);
            Controls.Add(label_title);
            Controls.Add(pic_info);
            Controls.Add(gradientPanel1);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Toast";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Form2";
            Load += Toast_Load;
            Click += Toast_Click;
            ((System.ComponentModel.ISupportInitialize)pic_info).EndInit();
            gradientPanel1.ResumeLayout(false);
            panelProgressBg.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_info;
        private Label label_title;
        private Label label_description;
        private System.Windows.Forms.Timer timer1;
        private BrainerStorm.codes.GradientPanel gradientPanel1;
        private System.Windows.Forms.Timer timer2;
        private Panel panelProgressBg;
        private Panel panelProgressFill;
    }
}