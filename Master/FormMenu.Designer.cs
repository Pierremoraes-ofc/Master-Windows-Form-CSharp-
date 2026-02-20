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
            icon_x_down_button = new FontAwesome.Sharp.IconButton();
            icon_x_up_button = new FontAwesome.Sharp.IconButton();
            icon_middle_button = new FontAwesome.Sharp.IconButton();
            icon_right_button = new FontAwesome.Sharp.IconButton();
            icon_left_button = new FontAwesome.Sharp.IconButton();
            icon_speed_mouse = new FontAwesome.Sharp.IconButton();
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
            panelLogo.Size = new Size(234, 81);
            panelLogo.TabIndex = 0;
            panelLogo.MouseDown += panelLogo_MouseDown;
            panelLogo.MouseMove += panelLogo_MouseMove;
            panelLogo.MouseUp += panelLogo_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_menu_mouse
            // 
            panel_menu_mouse.BackColor = Color.FromArgb(50, 50, 50);
            panel_menu_mouse.Controls.Add(icon_x_down_button);
            panel_menu_mouse.Controls.Add(icon_x_up_button);
            panel_menu_mouse.Controls.Add(icon_middle_button);
            panel_menu_mouse.Controls.Add(icon_right_button);
            panel_menu_mouse.Controls.Add(icon_left_button);
            panel_menu_mouse.Controls.Add(icon_speed_mouse);
            panel_menu_mouse.Dock = DockStyle.Top;
            panel_menu_mouse.Location = new Point(0, 141);
            panel_menu_mouse.Name = "panel_menu_mouse";
            panel_menu_mouse.Size = new Size(234, 194);
            panel_menu_mouse.TabIndex = 12;
            panel_menu_mouse.Visible = false;
            // 
            // icon_x_down_button
            // 
            icon_x_down_button.Dock = DockStyle.Top;
            icon_x_down_button.FlatStyle = FlatStyle.Flat;
            icon_x_down_button.ForeColor = Color.White;
            icon_x_down_button.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            icon_x_down_button.IconColor = Color.White;
            icon_x_down_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_x_down_button.IconSize = 25;
            icon_x_down_button.ImageAlign = ContentAlignment.MiddleLeft;
            icon_x_down_button.Location = new Point(0, 150);
            icon_x_down_button.Name = "icon_x_down_button";
            icon_x_down_button.Size = new Size(234, 30);
            icon_x_down_button.TabIndex = 17;
            icon_x_down_button.Text = "iconButton1";
            icon_x_down_button.TextAlign = ContentAlignment.MiddleRight;
            icon_x_down_button.UseVisualStyleBackColor = true;
            icon_x_down_button.Visible = false;
            icon_x_down_button.Click += icon_x_down_button_Click;
            // 
            // icon_x_up_button
            // 
            icon_x_up_button.Dock = DockStyle.Top;
            icon_x_up_button.FlatStyle = FlatStyle.Flat;
            icon_x_up_button.ForeColor = Color.White;
            icon_x_up_button.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            icon_x_up_button.IconColor = Color.White;
            icon_x_up_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_x_up_button.IconSize = 25;
            icon_x_up_button.ImageAlign = ContentAlignment.MiddleLeft;
            icon_x_up_button.Location = new Point(0, 120);
            icon_x_up_button.Name = "icon_x_up_button";
            icon_x_up_button.Size = new Size(234, 30);
            icon_x_up_button.TabIndex = 16;
            icon_x_up_button.Text = "iconButton1";
            icon_x_up_button.TextAlign = ContentAlignment.MiddleRight;
            icon_x_up_button.UseVisualStyleBackColor = true;
            icon_x_up_button.Visible = false;
            icon_x_up_button.Click += icon_x_up_button_Click;
            // 
            // icon_middle_button
            // 
            icon_middle_button.Dock = DockStyle.Top;
            icon_middle_button.FlatStyle = FlatStyle.Flat;
            icon_middle_button.ForeColor = Color.White;
            icon_middle_button.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            icon_middle_button.IconColor = Color.White;
            icon_middle_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_middle_button.IconSize = 25;
            icon_middle_button.ImageAlign = ContentAlignment.MiddleLeft;
            icon_middle_button.Location = new Point(0, 90);
            icon_middle_button.Name = "icon_middle_button";
            icon_middle_button.Size = new Size(234, 30);
            icon_middle_button.TabIndex = 15;
            icon_middle_button.Text = "iconButton1";
            icon_middle_button.TextAlign = ContentAlignment.MiddleRight;
            icon_middle_button.UseVisualStyleBackColor = true;
            icon_middle_button.Visible = false;
            icon_middle_button.Click += icon_middle_button_Click;
            // 
            // icon_right_button
            // 
            icon_right_button.Dock = DockStyle.Top;
            icon_right_button.FlatStyle = FlatStyle.Flat;
            icon_right_button.ForeColor = Color.White;
            icon_right_button.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            icon_right_button.IconColor = Color.White;
            icon_right_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_right_button.IconSize = 25;
            icon_right_button.ImageAlign = ContentAlignment.MiddleLeft;
            icon_right_button.Location = new Point(0, 60);
            icon_right_button.Name = "icon_right_button";
            icon_right_button.Size = new Size(234, 30);
            icon_right_button.TabIndex = 14;
            icon_right_button.Text = "iconButton1";
            icon_right_button.TextAlign = ContentAlignment.MiddleRight;
            icon_right_button.UseVisualStyleBackColor = true;
            icon_right_button.Visible = false;
            icon_right_button.Click += icon_right_button_Click;
            // 
            // icon_left_button
            // 
            icon_left_button.Dock = DockStyle.Top;
            icon_left_button.FlatStyle = FlatStyle.Flat;
            icon_left_button.ForeColor = Color.White;
            icon_left_button.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            icon_left_button.IconColor = Color.White;
            icon_left_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_left_button.IconSize = 25;
            icon_left_button.ImageAlign = ContentAlignment.MiddleLeft;
            icon_left_button.Location = new Point(0, 30);
            icon_left_button.Name = "icon_left_button";
            icon_left_button.Size = new Size(234, 30);
            icon_left_button.TabIndex = 13;
            icon_left_button.Text = "iconButton1";
            icon_left_button.TextAlign = ContentAlignment.MiddleRight;
            icon_left_button.UseVisualStyleBackColor = true;
            icon_left_button.Visible = false;
            icon_left_button.Click += icon_left_button_Click;
            // 
            // icon_speed_mouse
            // 
            icon_speed_mouse.Dock = DockStyle.Top;
            icon_speed_mouse.FlatStyle = FlatStyle.Flat;
            icon_speed_mouse.ForeColor = Color.White;
            icon_speed_mouse.IconChar = FontAwesome.Sharp.IconChar.MousePointer;
            icon_speed_mouse.IconColor = Color.White;
            icon_speed_mouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_speed_mouse.IconSize = 25;
            icon_speed_mouse.ImageAlign = ContentAlignment.MiddleLeft;
            icon_speed_mouse.Location = new Point(0, 0);
            icon_speed_mouse.Name = "icon_speed_mouse";
            icon_speed_mouse.Size = new Size(234, 30);
            icon_speed_mouse.TabIndex = 18;
            icon_speed_mouse.Text = "iconButton1";
            icon_speed_mouse.TextAlign = ContentAlignment.MiddleRight;
            icon_speed_mouse.UseVisualStyleBackColor = true;
            icon_speed_mouse.Visible = false;
            icon_speed_mouse.Click += icon_speed_mouse_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 196);
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
            icon_mouse.Location = new Point(0, 111);
            icon_mouse.Name = "icon_mouse";
            icon_mouse.Size = new Size(234, 30);
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
            icon_home.Location = new Point(0, 81);
            icon_home.Name = "icon_home";
            icon_home.Size = new Size(234, 30);
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
            icon_profile.Location = new Point(0, 335);
            icon_profile.Name = "icon_profile";
            icon_profile.Size = new Size(234, 30);
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
            icon_setting.Location = new Point(0, 531);
            icon_setting.Name = "icon_setting";
            icon_setting.Size = new Size(234, 30);
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
            ClientSize = new Size(234, 561);
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
        private FontAwesome.Sharp.IconButton icon_middle_button;
        private FontAwesome.Sharp.IconButton icon_right_button;
        private FontAwesome.Sharp.IconButton icon_left_button;
        private FontAwesome.Sharp.IconButton icon_mouse;
        private FontAwesome.Sharp.IconButton icon_home;
        private FontAwesome.Sharp.IconButton icon_profile;
        private FontAwesome.Sharp.IconButton icon_setting;
        private FontAwesome.Sharp.IconButton icon_x_down_button;
        private FontAwesome.Sharp.IconButton icon_x_up_button;
        private FontAwesome.Sharp.IconButton icon_speed_mouse;
    }
}