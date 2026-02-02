namespace Master
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel_menu_mouse = new Panel();
            icon_dpi = new FontAwesome.Sharp.IconButton();
            icon_remap = new FontAwesome.Sharp.IconButton();
            icon_macro = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            icon_mouse = new FontAwesome.Sharp.IconButton();
            icon_home = new FontAwesome.Sharp.IconButton();
            icon_profile = new FontAwesome.Sharp.IconButton();
            icon_setting = new FontAwesome.Sharp.IconButton();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_menu_mouse.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(234, 114);
            panelLogo.TabIndex = 0;
            panelLogo.MouseDown += panelLogo_MouseDown;
            panelLogo.MouseMove += panelLogo_MouseMove;
            panelLogo.MouseUp += panelLogo_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_menu_mouse
            // 
            panel_menu_mouse.BackColor = Color.FromArgb(50, 50, 50);
            panel_menu_mouse.Controls.Add(icon_dpi);
            panel_menu_mouse.Controls.Add(icon_remap);
            panel_menu_mouse.Controls.Add(icon_macro);
            panel_menu_mouse.Dock = DockStyle.Top;
            panel_menu_mouse.Location = new Point(0, 194);
            panel_menu_mouse.Name = "panel_menu_mouse";
            panel_menu_mouse.Size = new Size(234, 130);
            panel_menu_mouse.TabIndex = 12;
            panel_menu_mouse.Visible = false;
            // 
            // icon_dpi
            // 
            icon_dpi.Dock = DockStyle.Top;
            icon_dpi.FlatStyle = FlatStyle.Flat;
            icon_dpi.ForeColor = Color.White;
            icon_dpi.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            icon_dpi.IconColor = Color.White;
            icon_dpi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_dpi.IconSize = 25;
            icon_dpi.ImageAlign = ContentAlignment.MiddleLeft;
            icon_dpi.Location = new Point(0, 80);
            icon_dpi.Name = "icon_dpi";
            icon_dpi.Size = new Size(234, 40);
            icon_dpi.TabIndex = 15;
            icon_dpi.Text = "iconButton1";
            icon_dpi.TextAlign = ContentAlignment.MiddleRight;
            icon_dpi.UseVisualStyleBackColor = true;
            icon_dpi.Click += icon_dpi_Click;
            // 
            // icon_remap
            // 
            icon_remap.Dock = DockStyle.Top;
            icon_remap.FlatStyle = FlatStyle.Flat;
            icon_remap.ForeColor = Color.White;
            icon_remap.IconChar = FontAwesome.Sharp.IconChar.Map;
            icon_remap.IconColor = Color.White;
            icon_remap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_remap.IconSize = 25;
            icon_remap.ImageAlign = ContentAlignment.MiddleLeft;
            icon_remap.Location = new Point(0, 40);
            icon_remap.Name = "icon_remap";
            icon_remap.Size = new Size(234, 40);
            icon_remap.TabIndex = 14;
            icon_remap.Text = "iconButton1";
            icon_remap.TextAlign = ContentAlignment.MiddleRight;
            icon_remap.UseVisualStyleBackColor = true;
            icon_remap.Click += icon_remap_Click;
            // 
            // icon_macro
            // 
            icon_macro.Dock = DockStyle.Top;
            icon_macro.FlatStyle = FlatStyle.Flat;
            icon_macro.ForeColor = Color.White;
            icon_macro.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            icon_macro.IconColor = Color.White;
            icon_macro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_macro.IconSize = 25;
            icon_macro.ImageAlign = ContentAlignment.MiddleLeft;
            icon_macro.Location = new Point(0, 0);
            icon_macro.Name = "icon_macro";
            icon_macro.Size = new Size(234, 40);
            icon_macro.TabIndex = 13;
            icon_macro.Text = "iconButton1";
            icon_macro.TextAlign = ContentAlignment.MiddleRight;
            icon_macro.UseVisualStyleBackColor = true;
            icon_macro.Click += icon_macro_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 66);
            panel1.TabIndex = 13;
            panel1.MouseDown += panelLogo_MouseDown;
            panel1.MouseMove += panelLogo_MouseMove;
            panel1.MouseUp += panelLogo_MouseUp;
            // 
            // icon_mouse
            // 
            icon_mouse.Dock = DockStyle.Top;
            icon_mouse.FlatStyle = FlatStyle.Flat;
            icon_mouse.ForeColor = Color.White;
            icon_mouse.IconChar = FontAwesome.Sharp.IconChar.GaugeSimpleMed;
            icon_mouse.IconColor = Color.White;
            icon_mouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_mouse.IconSize = 25;
            icon_mouse.ImageAlign = ContentAlignment.MiddleLeft;
            icon_mouse.Location = new Point(0, 154);
            icon_mouse.Name = "icon_mouse";
            icon_mouse.Size = new Size(234, 40);
            icon_mouse.TabIndex = 16;
            icon_mouse.Text = "icon_mouse";
            icon_mouse.TextAlign = ContentAlignment.MiddleRight;
            icon_mouse.UseVisualStyleBackColor = true;
            icon_mouse.MouseHover += icon_mouse_MouseHover;
            // 
            // icon_home
            // 
            icon_home.Dock = DockStyle.Top;
            icon_home.FlatStyle = FlatStyle.Flat;
            icon_home.ForeColor = Color.White;
            icon_home.IconChar = FontAwesome.Sharp.IconChar.House;
            icon_home.IconColor = Color.White;
            icon_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_home.IconSize = 25;
            icon_home.ImageAlign = ContentAlignment.MiddleLeft;
            icon_home.Location = new Point(0, 114);
            icon_home.Name = "icon_home";
            icon_home.Size = new Size(234, 40);
            icon_home.TabIndex = 17;
            icon_home.Text = "icon_home";
            icon_home.TextAlign = ContentAlignment.MiddleRight;
            icon_home.UseVisualStyleBackColor = true;
            icon_home.Click += icon_home_Click;
            icon_home.MouseHover += icon_home_MouseHover;
            // 
            // icon_profile
            // 
            icon_profile.Dock = DockStyle.Top;
            icon_profile.FlatStyle = FlatStyle.Flat;
            icon_profile.ForeColor = Color.White;
            icon_profile.IconChar = FontAwesome.Sharp.IconChar.User;
            icon_profile.IconColor = Color.White;
            icon_profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_profile.IconSize = 25;
            icon_profile.ImageAlign = ContentAlignment.MiddleLeft;
            icon_profile.Location = new Point(0, 324);
            icon_profile.Name = "icon_profile";
            icon_profile.Size = new Size(234, 40);
            icon_profile.TabIndex = 18;
            icon_profile.Text = "icon_profile";
            icon_profile.TextAlign = ContentAlignment.MiddleRight;
            icon_profile.UseVisualStyleBackColor = true;
            icon_profile.Click += icon_profile_Click;
            icon_profile.MouseHover += icon_profile_MouseHover;
            // 
            // icon_setting
            // 
            icon_setting.Dock = DockStyle.Bottom;
            icon_setting.FlatStyle = FlatStyle.Flat;
            icon_setting.ForeColor = Color.White;
            icon_setting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            icon_setting.IconColor = Color.White;
            icon_setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_setting.IconSize = 25;
            icon_setting.ImageAlign = ContentAlignment.MiddleLeft;
            icon_setting.Location = new Point(0, 390);
            icon_setting.Name = "icon_setting";
            icon_setting.Size = new Size(234, 40);
            icon_setting.TabIndex = 19;
            icon_setting.Text = "icon_setting";
            icon_setting.TextAlign = ContentAlignment.MiddleRight;
            icon_setting.UseVisualStyleBackColor = true;
            icon_setting.Click += icon_setting_Click;
            icon_setting.MouseHover += icon_setting_MouseHover;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(234, 430);
            Controls.Add(icon_setting);
            Controls.Add(panel1);
            Controls.Add(icon_profile);
            Controls.Add(panel_menu_mouse);
            Controls.Add(icon_mouse);
            Controls.Add(icon_home);
            Controls.Add(panelLogo);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            ShowInTaskbar = false;
            Text = "FormMenu";
            Load += FormMenu_Load;
            Paint += FormMenu_Paint;
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_menu_mouse.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panel_menu_mouse;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton icon_dpi;
        private FontAwesome.Sharp.IconButton icon_remap;
        private FontAwesome.Sharp.IconButton icon_macro;
        private FontAwesome.Sharp.IconButton icon_mouse;
        private FontAwesome.Sharp.IconButton icon_home;
        private FontAwesome.Sharp.IconButton icon_profile;
        private FontAwesome.Sharp.IconButton icon_setting;
    }
}