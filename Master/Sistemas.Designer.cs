namespace Master
{
    partial class Sistemas
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
            panel_mini_menu = new Panel();
            icon_night = new FontAwesome.Sharp.IconButton();
            icon_menu_v = new FontAwesome.Sharp.IconButton();
            icon_day = new FontAwesome.Sharp.IconButton();
            icon_minimize = new FontAwesome.Sharp.IconButton();
            icon_menu_h = new FontAwesome.Sharp.IconButton();
            icon_eye_hide = new FontAwesome.Sharp.IconButton();
            icon_exit = new FontAwesome.Sharp.IconButton();
            label_Title = new Label();
            panel_Dashboard = new Panel();
            label_border_style = new Label();
            chkBottomLeft = new CheckBox();
            chkBottomRight = new CheckBox();
            chkTopRight = new CheckBox();
            chkTopLeft = new CheckBox();
            label1 = new Label();
            trackBar_border_radius = new TrackBar();
            label_system_opacity = new Label();
            label_border_size = new Label();
            trackBar_opacityForm = new TrackBar();
            trackBar_border_size = new TrackBar();
            label_percet_opacity = new Label();
            panel_Settings = new Panel();
            label_percent_border_radius = new Label();
            label_percent_border_size = new Label();
            pic_background_form = new PictureBox();
            button_background_color = new Button();
            checkBox_start_system = new CheckBox();
            pic_border_form = new PictureBox();
            button_border_color = new Button();
            label_language = new Label();
            cmbLanguage = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            panel_Dpi = new Panel();
            panel_Macro = new Panel();
            panel_Remap = new Panel();
            panel_Profile = new Panel();
            colorDialog1 = new ColorDialog();
            panel_mini_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_radius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_opacityForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_size).BeginInit();
            panel_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_background_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_border_form).BeginInit();
            SuspendLayout();
            // 
            // panel_mini_menu
            // 
            panel_mini_menu.Controls.Add(icon_night);
            panel_mini_menu.Controls.Add(icon_menu_v);
            panel_mini_menu.Controls.Add(icon_day);
            panel_mini_menu.Controls.Add(icon_minimize);
            panel_mini_menu.Controls.Add(icon_menu_h);
            panel_mini_menu.Controls.Add(icon_eye_hide);
            panel_mini_menu.Controls.Add(icon_exit);
            panel_mini_menu.Controls.Add(label_Title);
            panel_mini_menu.Dock = DockStyle.Top;
            panel_mini_menu.Location = new Point(0, 0);
            panel_mini_menu.Name = "panel_mini_menu";
            panel_mini_menu.Size = new Size(1640, 36);
            panel_mini_menu.TabIndex = 0;
            // 
            // icon_night
            // 
            icon_night.FlatStyle = FlatStyle.Flat;
            icon_night.ForeColor = Color.FromArgb(40, 40, 40);
            icon_night.IconChar = FontAwesome.Sharp.IconChar.Moon;
            icon_night.IconColor = Color.White;
            icon_night.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_night.IconSize = 20;
            icon_night.Location = new Point(395, 7);
            icon_night.Name = "icon_night";
            icon_night.Size = new Size(20, 20);
            icon_night.TabIndex = 6;
            icon_night.UseVisualStyleBackColor = true;
            icon_night.Visible = false;
            icon_night.Click += icon_night_Click;
            // 
            // icon_menu_v
            // 
            icon_menu_v.FlatStyle = FlatStyle.Flat;
            icon_menu_v.ForeColor = Color.FromArgb(40, 40, 40);
            icon_menu_v.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            icon_menu_v.IconColor = Color.White;
            icon_menu_v.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_menu_v.IconSize = 15;
            icon_menu_v.Location = new Point(343, 7);
            icon_menu_v.Name = "icon_menu_v";
            icon_menu_v.Size = new Size(20, 20);
            icon_menu_v.TabIndex = 4;
            icon_menu_v.UseVisualStyleBackColor = true;
            icon_menu_v.Visible = false;
            icon_menu_v.Click += icon_menu_v_Click;
            // 
            // icon_day
            // 
            icon_day.FlatStyle = FlatStyle.Flat;
            icon_day.ForeColor = Color.FromArgb(40, 40, 40);
            icon_day.IconChar = FontAwesome.Sharp.IconChar.Sun;
            icon_day.IconColor = Color.White;
            icon_day.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_day.IconSize = 20;
            icon_day.Location = new Point(421, 7);
            icon_day.Name = "icon_day";
            icon_day.Size = new Size(20, 20);
            icon_day.TabIndex = 5;
            icon_day.UseVisualStyleBackColor = true;
            icon_day.Visible = false;
            icon_day.Click += icon_day_Click;
            // 
            // icon_minimize
            // 
            icon_minimize.FlatStyle = FlatStyle.Flat;
            icon_minimize.ForeColor = Color.FromArgb(40, 40, 40);
            icon_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            icon_minimize.IconColor = Color.White;
            icon_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_minimize.IconSize = 15;
            icon_minimize.Location = new Point(470, 7);
            icon_minimize.Name = "icon_minimize";
            icon_minimize.Size = new Size(20, 20);
            icon_minimize.TabIndex = 1;
            icon_minimize.UseVisualStyleBackColor = true;
            icon_minimize.Click += icon_minimize_Click;
            // 
            // icon_menu_h
            // 
            icon_menu_h.FlatStyle = FlatStyle.Flat;
            icon_menu_h.ForeColor = Color.FromArgb(40, 40, 40);
            icon_menu_h.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            icon_menu_h.IconColor = Color.White;
            icon_menu_h.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_menu_h.IconSize = 15;
            icon_menu_h.Location = new Point(369, 7);
            icon_menu_h.Name = "icon_menu_h";
            icon_menu_h.Size = new Size(20, 20);
            icon_menu_h.TabIndex = 3;
            icon_menu_h.UseVisualStyleBackColor = true;
            icon_menu_h.Click += icon_menu_h_Click;
            // 
            // icon_eye_hide
            // 
            icon_eye_hide.FlatStyle = FlatStyle.Flat;
            icon_eye_hide.ForeColor = Color.FromArgb(40, 40, 40);
            icon_eye_hide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            icon_eye_hide.IconColor = Color.White;
            icon_eye_hide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_eye_hide.IconSize = 15;
            icon_eye_hide.Location = new Point(445, 7);
            icon_eye_hide.Name = "icon_eye_hide";
            icon_eye_hide.Size = new Size(20, 20);
            icon_eye_hide.TabIndex = 0;
            icon_eye_hide.UseVisualStyleBackColor = true;
            icon_eye_hide.Click += icon_eye_hide_Click;
            // 
            // icon_exit
            // 
            icon_exit.FlatStyle = FlatStyle.Flat;
            icon_exit.ForeColor = Color.FromArgb(40, 40, 40);
            icon_exit.IconChar = FontAwesome.Sharp.IconChar.X;
            icon_exit.IconColor = Color.White;
            icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_exit.IconSize = 15;
            icon_exit.Location = new Point(495, 7);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(20, 20);
            icon_exit.TabIndex = 2;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Source Code Pro", 16F);
            label_Title.ForeColor = Color.White;
            label_Title.Location = new Point(16, 4);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(0, 28);
            label_Title.TabIndex = 40;
            // 
            // panel_Dashboard
            // 
            panel_Dashboard.BackColor = Color.FromArgb(40, 40, 40);
            panel_Dashboard.ForeColor = Color.White;
            panel_Dashboard.Location = new Point(12, 42);
            panel_Dashboard.Name = "panel_Dashboard";
            panel_Dashboard.Size = new Size(520, 394);
            panel_Dashboard.TabIndex = 1;
            panel_Dashboard.MouseDown += panel_Settings_MouseDown;
            panel_Dashboard.MouseMove += panel_Settings_MouseMove;
            panel_Dashboard.MouseUp += panel_Settings_MouseUp;
            // 
            // label_border_style
            // 
            label_border_style.AutoSize = true;
            label_border_style.Font = new Font("Source Code Pro", 10F);
            label_border_style.ForeColor = Color.White;
            label_border_style.Location = new Point(308, 208);
            label_border_style.Name = "label_border_style";
            label_border_style.Size = new Size(104, 18);
            label_border_style.TabIndex = 39;
            label_border_style.Text = "Border Style";
            // 
            // chkBottomLeft
            // 
            chkBottomLeft.AutoSize = true;
            chkBottomLeft.ForeColor = Color.White;
            chkBottomLeft.Location = new Point(311, 305);
            chkBottomLeft.Name = "chkBottomLeft";
            chkBottomLeft.Size = new Size(103, 19);
            chkBottomLeft.TabIndex = 38;
            chkBottomLeft.Text = "Botton Left";
            chkBottomLeft.UseVisualStyleBackColor = true;
            chkBottomLeft.CheckedChanged += chkBottomLeft_CheckedChanged;
            // 
            // chkBottomRight
            // 
            chkBottomRight.AutoSize = true;
            chkBottomRight.ForeColor = Color.White;
            chkBottomRight.Location = new Point(311, 280);
            chkBottomRight.Name = "chkBottomRight";
            chkBottomRight.Size = new Size(110, 19);
            chkBottomRight.TabIndex = 37;
            chkBottomRight.Text = "Botton Right";
            chkBottomRight.UseVisualStyleBackColor = true;
            chkBottomRight.CheckedChanged += chkBottomRight_CheckedChanged;
            // 
            // chkTopRight
            // 
            chkTopRight.AutoSize = true;
            chkTopRight.ForeColor = Color.White;
            chkTopRight.Location = new Point(310, 255);
            chkTopRight.Name = "chkTopRight";
            chkTopRight.Size = new Size(89, 19);
            chkTopRight.TabIndex = 36;
            chkTopRight.Text = "Top Right";
            chkTopRight.UseVisualStyleBackColor = true;
            chkTopRight.CheckedChanged += chkTopRight_CheckedChanged;
            // 
            // chkTopLeft
            // 
            chkTopLeft.AutoSize = true;
            chkTopLeft.ForeColor = Color.White;
            chkTopLeft.Location = new Point(311, 230);
            chkTopLeft.Name = "chkTopLeft";
            chkTopLeft.Size = new Size(82, 19);
            chkTopLeft.TabIndex = 35;
            chkTopLeft.Text = "Top Left";
            chkTopLeft.UseVisualStyleBackColor = true;
            chkTopLeft.CheckedChanged += chkTopLeft_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 313);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 34;
            label1.Text = "Border radius";
            // 
            // trackBar_border_radius
            // 
            trackBar_border_radius.Location = new Point(1, 336);
            trackBar_border_radius.Margin = new Padding(4);
            trackBar_border_radius.Maximum = 20;
            trackBar_border_radius.Minimum = 1;
            trackBar_border_radius.Name = "trackBar_border_radius";
            trackBar_border_radius.Size = new Size(281, 45);
            trackBar_border_radius.TabIndex = 33;
            trackBar_border_radius.TickStyle = TickStyle.None;
            trackBar_border_radius.Value = 1;
            trackBar_border_radius.Scroll += trackBar_border_radius_Scroll;
            // 
            // label_system_opacity
            // 
            label_system_opacity.AutoSize = true;
            label_system_opacity.Font = new Font("Source Code Pro", 10F);
            label_system_opacity.ForeColor = Color.White;
            label_system_opacity.Location = new Point(6, 209);
            label_system_opacity.Name = "label_system_opacity";
            label_system_opacity.Size = new Size(120, 18);
            label_system_opacity.TabIndex = 29;
            label_system_opacity.Text = "System opacity";
            // 
            // label_border_size
            // 
            label_border_size.AutoSize = true;
            label_border_size.Font = new Font("Source Code Pro", 10F);
            label_border_size.ForeColor = Color.White;
            label_border_size.Location = new Point(6, 262);
            label_border_size.Name = "label_border_size";
            label_border_size.Size = new Size(96, 18);
            label_border_size.TabIndex = 32;
            label_border_size.Text = "Border size";
            // 
            // trackBar_opacityForm
            // 
            trackBar_opacityForm.Location = new Point(1, 233);
            trackBar_opacityForm.Margin = new Padding(4);
            trackBar_opacityForm.Maximum = 100;
            trackBar_opacityForm.Minimum = 10;
            trackBar_opacityForm.Name = "trackBar_opacityForm";
            trackBar_opacityForm.Size = new Size(281, 45);
            trackBar_opacityForm.TabIndex = 28;
            trackBar_opacityForm.TickStyle = TickStyle.None;
            trackBar_opacityForm.Value = 10;
            trackBar_opacityForm.Scroll += trackBar_opacityForm_Scroll;
            // 
            // trackBar_border_size
            // 
            trackBar_border_size.Location = new Point(1, 286);
            trackBar_border_size.Margin = new Padding(4);
            trackBar_border_size.Maximum = 5;
            trackBar_border_size.Minimum = 1;
            trackBar_border_size.Name = "trackBar_border_size";
            trackBar_border_size.Size = new Size(281, 45);
            trackBar_border_size.TabIndex = 31;
            trackBar_border_size.TickStyle = TickStyle.None;
            trackBar_border_size.Value = 1;
            trackBar_border_size.Scroll += trackBar_border_size_Scroll;
            // 
            // label_percet_opacity
            // 
            label_percet_opacity.AutoSize = true;
            label_percet_opacity.Font = new Font("Source Code Pro", 10F);
            label_percet_opacity.ForeColor = Color.White;
            label_percet_opacity.Location = new Point(242, 209);
            label_percet_opacity.Name = "label_percet_opacity";
            label_percet_opacity.Size = new Size(40, 18);
            label_percet_opacity.TabIndex = 30;
            label_percet_opacity.Text = "100%";
            label_percet_opacity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel_Settings
            // 
            panel_Settings.Controls.Add(label_percent_border_radius);
            panel_Settings.Controls.Add(label_percent_border_size);
            panel_Settings.Controls.Add(pic_background_form);
            panel_Settings.Controls.Add(button_background_color);
            panel_Settings.Controls.Add(checkBox_start_system);
            panel_Settings.Controls.Add(pic_border_form);
            panel_Settings.Controls.Add(button_border_color);
            panel_Settings.Controls.Add(label_language);
            panel_Settings.Controls.Add(cmbLanguage);
            panel_Settings.Controls.Add(label3);
            panel_Settings.Controls.Add(label4);
            panel_Settings.Controls.Add(label_border_style);
            panel_Settings.Controls.Add(chkBottomLeft);
            panel_Settings.Controls.Add(label_percet_opacity);
            panel_Settings.Controls.Add(chkBottomRight);
            panel_Settings.Controls.Add(trackBar_border_size);
            panel_Settings.Controls.Add(chkTopRight);
            panel_Settings.Controls.Add(trackBar_opacityForm);
            panel_Settings.Controls.Add(chkTopLeft);
            panel_Settings.Controls.Add(label_border_size);
            panel_Settings.Controls.Add(label1);
            panel_Settings.Controls.Add(label_system_opacity);
            panel_Settings.Controls.Add(trackBar_border_radius);
            panel_Settings.Location = new Point(538, 42);
            panel_Settings.Name = "panel_Settings";
            panel_Settings.Size = new Size(520, 394);
            panel_Settings.TabIndex = 2;
            panel_Settings.Visible = false;
            panel_Settings.MouseDown += panel_Settings_MouseDown;
            panel_Settings.MouseMove += panel_Settings_MouseMove;
            panel_Settings.MouseUp += panel_Settings_MouseUp;
            // 
            // label_percent_border_radius
            // 
            label_percent_border_radius.AutoSize = true;
            label_percent_border_radius.Font = new Font("Source Code Pro", 10F);
            label_percent_border_radius.ForeColor = Color.White;
            label_percent_border_radius.Location = new Point(242, 315);
            label_percent_border_radius.Name = "label_percent_border_radius";
            label_percent_border_radius.Size = new Size(40, 18);
            label_percent_border_radius.TabIndex = 50;
            label_percent_border_radius.Text = "100%";
            label_percent_border_radius.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_percent_border_size
            // 
            label_percent_border_size.AutoSize = true;
            label_percent_border_size.Font = new Font("Source Code Pro", 10F);
            label_percent_border_size.ForeColor = Color.White;
            label_percent_border_size.Location = new Point(242, 264);
            label_percent_border_size.Name = "label_percent_border_size";
            label_percent_border_size.Size = new Size(40, 18);
            label_percent_border_size.TabIndex = 49;
            label_percent_border_size.Text = "100%";
            label_percent_border_size.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pic_background_form
            // 
            pic_background_form.BackColor = Color.Lime;
            pic_background_form.Location = new Point(6, 129);
            pic_background_form.Name = "pic_background_form";
            pic_background_form.Size = new Size(30, 30);
            pic_background_form.TabIndex = 48;
            pic_background_form.TabStop = false;
            // 
            // button_background_color
            // 
            button_background_color.FlatStyle = FlatStyle.Flat;
            button_background_color.Font = new Font("Source Code Pro", 10F);
            button_background_color.ForeColor = Color.White;
            button_background_color.Location = new Point(42, 129);
            button_background_color.Name = "button_background_color";
            button_background_color.Size = new Size(144, 30);
            button_background_color.TabIndex = 47;
            button_background_color.Text = "Border Color";
            button_background_color.TextAlign = ContentAlignment.TopCenter;
            button_background_color.UseVisualStyleBackColor = true;
            button_background_color.Click += button_background_color_Click;
            // 
            // checkBox_start_system
            // 
            checkBox_start_system.AutoSize = true;
            checkBox_start_system.Font = new Font("Source Code Pro", 10F);
            checkBox_start_system.ForeColor = Color.White;
            checkBox_start_system.Location = new Point(311, 40);
            checkBox_start_system.Name = "checkBox_start_system";
            checkBox_start_system.Size = new Size(163, 22);
            checkBox_start_system.TabIndex = 46;
            checkBox_start_system.Text = "Start with System";
            checkBox_start_system.UseVisualStyleBackColor = true;
            checkBox_start_system.CheckedChanged += checkBox_start_system_CheckedChanged;
            // 
            // pic_border_form
            // 
            pic_border_form.BackColor = Color.Lime;
            pic_border_form.Location = new Point(6, 165);
            pic_border_form.Name = "pic_border_form";
            pic_border_form.Size = new Size(30, 30);
            pic_border_form.TabIndex = 45;
            pic_border_form.TabStop = false;
            // 
            // button_border_color
            // 
            button_border_color.FlatStyle = FlatStyle.Flat;
            button_border_color.Font = new Font("Source Code Pro", 10F);
            button_border_color.ForeColor = Color.White;
            button_border_color.Location = new Point(42, 165);
            button_border_color.Name = "button_border_color";
            button_border_color.Size = new Size(144, 30);
            button_border_color.TabIndex = 44;
            button_border_color.Text = "Border Color";
            button_border_color.TextAlign = ContentAlignment.TopCenter;
            button_border_color.UseVisualStyleBackColor = true;
            button_border_color.Click += button_border_color_Click;
            // 
            // label_language
            // 
            label_language.AutoSize = true;
            label_language.Font = new Font("Source Code Pro", 10F);
            label_language.ForeColor = Color.White;
            label_language.Location = new Point(6, 13);
            label_language.Name = "label_language";
            label_language.Size = new Size(72, 18);
            label_language.TabIndex = 43;
            label_language.Text = "Language";
            // 
            // cmbLanguage
            // 
            cmbLanguage.BackColor = Color.FromArgb(40, 40, 40);
            cmbLanguage.FlatStyle = FlatStyle.Flat;
            cmbLanguage.ForeColor = Color.White;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(6, 39);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(197, 23);
            cmbLanguage.TabIndex = 42;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Code Pro", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 315);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 41;
            label3.Text = "Border radius";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Code Pro", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 264);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 40;
            label4.Text = "Border size";
            // 
            // panel_Dpi
            // 
            panel_Dpi.Location = new Point(12, 442);
            panel_Dpi.Name = "panel_Dpi";
            panel_Dpi.Size = new Size(520, 394);
            panel_Dpi.TabIndex = 3;
            panel_Dpi.Visible = false;
            panel_Dpi.MouseDown += panel_Settings_MouseDown;
            panel_Dpi.MouseMove += panel_Settings_MouseMove;
            panel_Dpi.MouseUp += panel_Settings_MouseUp;
            // 
            // panel_Macro
            // 
            panel_Macro.Location = new Point(538, 443);
            panel_Macro.Name = "panel_Macro";
            panel_Macro.Size = new Size(520, 394);
            panel_Macro.TabIndex = 4;
            panel_Macro.Visible = false;
            panel_Macro.MouseDown += panel_Settings_MouseDown;
            panel_Macro.MouseMove += panel_Settings_MouseMove;
            panel_Macro.MouseUp += panel_Settings_MouseUp;
            // 
            // panel_Remap
            // 
            panel_Remap.Location = new Point(1064, 443);
            panel_Remap.Name = "panel_Remap";
            panel_Remap.Size = new Size(520, 394);
            panel_Remap.TabIndex = 6;
            panel_Remap.Visible = false;
            panel_Remap.MouseDown += panel_Settings_MouseDown;
            panel_Remap.MouseMove += panel_Settings_MouseMove;
            panel_Remap.MouseUp += panel_Settings_MouseUp;
            // 
            // panel_Profile
            // 
            panel_Profile.Location = new Point(1064, 42);
            panel_Profile.Name = "panel_Profile";
            panel_Profile.Size = new Size(520, 394);
            panel_Profile.TabIndex = 5;
            panel_Profile.Visible = false;
            panel_Profile.MouseDown += panel_Settings_MouseDown;
            panel_Profile.MouseMove += panel_Settings_MouseMove;
            panel_Profile.MouseUp += panel_Settings_MouseUp;
            // 
            // Sistemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1640, 849);
            Controls.Add(panel_Remap);
            Controls.Add(panel_Profile);
            Controls.Add(panel_Macro);
            Controls.Add(panel_Dpi);
            Controls.Add(panel_Settings);
            Controls.Add(panel_Dashboard);
            Controls.Add(panel_mini_menu);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sistemas";
            Text = "Sistemas";
            Load += Sistemas_Load;
            Paint += Sistemas_Paint;
            panel_mini_menu.ResumeLayout(false);
            panel_mini_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_radius).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_opacityForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_size).EndInit();
            panel_Settings.ResumeLayout(false);
            panel_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_background_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_border_form).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_mini_menu;
        private Panel panel_Dashboard;
        private Panel panel_Settings;
        private Panel panel_Dpi;
        private Panel panel_Macro;
        private Panel panel_Remap;
        private Panel panel_Profile;
        private Label label_border_style;
        private CheckBox chkBottomLeft;
        private CheckBox chkBottomRight;
        private CheckBox chkTopRight;
        private CheckBox chkTopLeft;
        private Label label1;
        private TrackBar trackBar_border_radius;
        private Label label_system_opacity;
        private Label label_border_size;
        private TrackBar trackBar_opacityForm;
        private TrackBar trackBar_border_size;
        private Label label_percet_opacity;
        private Label label_Title;
        private FontAwesome.Sharp.IconButton icon_eye_hide;
        private FontAwesome.Sharp.IconButton icon_minimize;
        private FontAwesome.Sharp.IconButton icon_menu_h;
        private FontAwesome.Sharp.IconButton icon_exit;
        private FontAwesome.Sharp.IconButton icon_menu_v;
        private FontAwesome.Sharp.IconButton icon_night;
        private FontAwesome.Sharp.IconButton icon_day;
        private Label label3;
        private Label label4;
        private CheckBox checkBox_start_system;
        private PictureBox pic_border_form;
        private Button button_border_color;
        private Label label_language;
        private ComboBox cmbLanguage;
        private ColorDialog colorDialog1;
        private PictureBox pic_background_form;
        private Button button_background_color;
        private Label label_percent_border_size;
        private Label label_percent_border_radius;
    }
}