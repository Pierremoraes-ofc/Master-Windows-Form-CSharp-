namespace Master
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            panelContainer = new Panel();
            label2 = new Label();
            label_system_opacity = new Label();
            trackBar_opacityForm = new TrackBar();
            panel1 = new Panel();
            picMenu = new PictureBox();
            picMiniMenu = new PictureBox();
            picHide = new PictureBox();
            picMinimizar = new PictureBox();
            picFechar = new PictureBox();
            label_border_size = new Label();
            trackBar_border_size = new TrackBar();
            pic_background1 = new PictureBox();
            pic_background = new PictureBox();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_opacityForm).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMiniMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_background1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_background).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, fecharToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 48);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Font = new Font("Source Code Pro", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecharToolStripMenuItem.ForeColor = Color.Red;
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(116, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            fecharToolStripMenuItem.Click += fecharToolStripMenuItem_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Source Code Pro", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(355, 7);
            button4.Name = "button4";
            button4.Size = new Size(20, 20);
            button4.TabIndex = 7;
            button4.Text = "+";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelContainer.BackColor = Color.FromArgb(40, 40, 40);
            panelContainer.Location = new Point(12, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(40, 430);
            panelContainer.TabIndex = 8;
            panelContainer.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(335, 207);
            label2.Name = "label2";
            label2.Size = new Size(40, 18);
            label2.TabIndex = 13;
            label2.Text = "100%";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_system_opacity
            // 
            label_system_opacity.AutoSize = true;
            label_system_opacity.Font = new Font("Source Code Pro", 10F);
            label_system_opacity.ForeColor = Color.White;
            label_system_opacity.Location = new Point(99, 208);
            label_system_opacity.Name = "label_system_opacity";
            label_system_opacity.Size = new Size(120, 18);
            label_system_opacity.TabIndex = 12;
            label_system_opacity.Text = "System opacity";
            // 
            // trackBar_opacityForm
            // 
            trackBar_opacityForm.Location = new Point(94, 232);
            trackBar_opacityForm.Margin = new Padding(4);
            trackBar_opacityForm.Maximum = 100;
            trackBar_opacityForm.Minimum = 10;
            trackBar_opacityForm.Name = "trackBar_opacityForm";
            trackBar_opacityForm.Size = new Size(281, 45);
            trackBar_opacityForm.TabIndex = 11;
            trackBar_opacityForm.TickStyle = TickStyle.None;
            trackBar_opacityForm.Value = 10;
            trackBar_opacityForm.Scroll += trackBar_opacityForm_Scroll;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(picMenu);
            panel1.Controls.Add(picMiniMenu);
            panel1.Controls.Add(picHide);
            panel1.Controls.Add(picMinimizar);
            panel1.Controls.Add(picFechar);
            panel1.Controls.Add(label_system_opacity);
            panel1.Controls.Add(label_border_size);
            panel1.Controls.Add(trackBar_opacityForm);
            panel1.Controls.Add(trackBar_border_size);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(267, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 430);
            panel1.TabIndex = 14;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // picMenu
            // 
            picMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMenu.Cursor = Cursors.Hand;
            picMenu.Image = (Image)resources.GetObject("picMenu.Image");
            picMenu.Location = new Point(434, 3);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(20, 20);
            picMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenu.TabIndex = 20;
            picMenu.TabStop = false;
            picMenu.Click += picMenu_Click;
            // 
            // picMiniMenu
            // 
            picMiniMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMiniMenu.Cursor = Cursors.Hand;
            picMiniMenu.Image = (Image)resources.GetObject("picMiniMenu.Image");
            picMiniMenu.Location = new Point(433, 3);
            picMiniMenu.Name = "picMiniMenu";
            picMiniMenu.Size = new Size(20, 20);
            picMiniMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picMiniMenu.TabIndex = 21;
            picMiniMenu.TabStop = false;
            picMiniMenu.Visible = false;
            picMiniMenu.Click += picMiniMenu_Click;
            // 
            // picHide
            // 
            picHide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHide.Cursor = Cursors.Hand;
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(456, 3);
            picHide.Name = "picHide";
            picHide.Size = new Size(20, 20);
            picHide.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide.TabIndex = 19;
            picHide.TabStop = false;
            toolTip1.SetToolTip(picHide, "Minimize to System Tray");
            picHide.Click += picHide_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinimizar.Cursor = Cursors.Hand;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(477, 3);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(20, 20);
            picMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            picMinimizar.TabIndex = 18;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picFechar
            // 
            picFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picFechar.Cursor = Cursors.Hand;
            picFechar.Image = (Image)resources.GetObject("picFechar.Image");
            picFechar.Location = new Point(498, 3);
            picFechar.Name = "picFechar";
            picFechar.Size = new Size(20, 20);
            picFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            picFechar.TabIndex = 17;
            picFechar.TabStop = false;
            picFechar.Click += picFechar_Click;
            // 
            // label_border_size
            // 
            label_border_size.AutoSize = true;
            label_border_size.Font = new Font("Source Code Pro", 10F);
            label_border_size.ForeColor = Color.White;
            label_border_size.Location = new Point(99, 261);
            label_border_size.Name = "label_border_size";
            label_border_size.Size = new Size(96, 18);
            label_border_size.TabIndex = 15;
            label_border_size.Text = "Border size";
            // 
            // trackBar_border_size
            // 
            trackBar_border_size.Location = new Point(94, 285);
            trackBar_border_size.Margin = new Padding(4);
            trackBar_border_size.Maximum = 5;
            trackBar_border_size.Minimum = 1;
            trackBar_border_size.Name = "trackBar_border_size";
            trackBar_border_size.Size = new Size(281, 45);
            trackBar_border_size.TabIndex = 14;
            trackBar_border_size.TickStyle = TickStyle.None;
            trackBar_border_size.Value = 1;
            trackBar_border_size.Scroll += trackBar_border_size_Scroll;
            // 
            // pic_background1
            // 
            pic_background1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_background1.BackColor = Color.Lime;
            pic_background1.Location = new Point(0, 0);
            pic_background1.Name = "pic_background1";
            pic_background1.Size = new Size(800, 450);
            pic_background1.TabIndex = 15;
            pic_background1.TabStop = false;
            // 
            // pic_background
            // 
            pic_background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_background.BackColor = Color.FromArgb(40, 40, 40);
            pic_background.Location = new Point(1, 1);
            pic_background.Name = "pic_background";
            pic_background.Size = new Size(798, 448);
            pic_background.TabIndex = 16;
            pic_background.TabStop = false;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelContainer);
            Controls.Add(pic_background);
            Controls.Add(pic_background1);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MasterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MasterForm_Load;
            LocationChanged += MasterForm_LocationChanged;
            MouseDown += MasterForm_MouseDown;
            Resize += MasterForm_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar_opacityForm).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMiniMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_background1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_background).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private Button button4;
        private Panel panelContainer;
        private Label label2;
        private Label label_system_opacity;
        private TrackBar trackBar_opacityForm;
        private Panel panel1;
        private Label label_border_size;
        private TrackBar trackBar_border_size;
        private PictureBox pic_background1;
        private PictureBox pic_background;
        private PictureBox picFechar;
        private PictureBox picMiniMenu;
        private PictureBox picMenu;
        private PictureBox picHide;
        private PictureBox picMinimizar;
        private ToolTip toolTip1;
    }
}
