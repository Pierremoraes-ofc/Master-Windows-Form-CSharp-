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
            label_dpi_control = new Label();
            trackBar_dpi_control = new TrackBar();
            label_border_style = new Label();
            chkBottomLeft = new CheckBox();
            chkBottomRight = new CheckBox();
            chkTopRight = new CheckBox();
            chkTopLeft = new CheckBox();
            label_border_radius = new Label();
            trackBar_border_radius = new TrackBar();
            label_system_opacity = new Label();
            label_border_size = new Label();
            trackBar_opacityForm = new TrackBar();
            trackBar_border_size = new TrackBar();
            label_percet_opacity = new Label();
            panel_Settings = new Panel();
            groupBox6 = new GroupBox();
            label_profile_setting = new Label();
            groupBox3 = new GroupBox();
            label_language = new Label();
            label_start_system = new Label();
            cmbLanguage = new ComboBox();
            checkBox_start_system = new CheckBox();
            groupBox7 = new GroupBox();
            btnOverlay = new Button();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label_config_visual = new Label();
            label_percent_border_radius = new Label();
            label_percent_border_size = new Label();
            groupBox2 = new GroupBox();
            label_color_style = new Label();
            pic_background_form = new PictureBox();
            button_border_color = new Button();
            pic_border_form = new PictureBox();
            button_background_color = new Button();
            groupBox1 = new GroupBox();
            panel_left_button = new Panel();
            groupBox4 = new GroupBox();
            panel_right_button = new Panel();
            panel_middle_button = new Panel();
            panel_Profile = new Panel();
            colorDialog1 = new ColorDialog();
            panel_x_up_button = new Panel();
            panel_x_down_button = new Panel();
            panel_mini_menu.SuspendLayout();
            panel_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_dpi_control).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_radius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_opacityForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_size).BeginInit();
            panel_Settings.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_background_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_border_form).BeginInit();
            groupBox1.SuspendLayout();
            panel_left_button.SuspendLayout();
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
            panel_mini_menu.MouseDown += panel_Settings_MouseDown;
            panel_mini_menu.MouseMove += panel_Settings_MouseMove;
            panel_mini_menu.MouseUp += panel_Settings_MouseUp;
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
            panel_Dashboard.Controls.Add(label_dpi_control);
            panel_Dashboard.Controls.Add(trackBar_dpi_control);
            panel_Dashboard.ForeColor = Color.White;
            panel_Dashboard.Location = new Point(12, 42);
            panel_Dashboard.Name = "panel_Dashboard";
            panel_Dashboard.Size = new Size(520, 394);
            panel_Dashboard.TabIndex = 1;
            panel_Dashboard.MouseDown += panel_Settings_MouseDown;
            panel_Dashboard.MouseMove += panel_Settings_MouseMove;
            panel_Dashboard.MouseUp += panel_Settings_MouseUp;
            // 
            // label_dpi_control
            // 
            label_dpi_control.AutoSize = true;
            label_dpi_control.Font = new Font("Source Code Pro", 10F);
            label_dpi_control.ForeColor = Color.White;
            label_dpi_control.Location = new Point(128, 202);
            label_dpi_control.Name = "label_dpi_control";
            label_dpi_control.Size = new Size(96, 18);
            label_dpi_control.TabIndex = 44;
            label_dpi_control.Text = "DPI Control";
            // 
            // trackBar_dpi_control
            // 
            trackBar_dpi_control.Location = new Point(122, 221);
            trackBar_dpi_control.Margin = new Padding(4);
            trackBar_dpi_control.Maximum = 30;
            trackBar_dpi_control.Minimum = 1;
            trackBar_dpi_control.Name = "trackBar_dpi_control";
            trackBar_dpi_control.Size = new Size(281, 45);
            trackBar_dpi_control.TabIndex = 32;
            trackBar_dpi_control.TickStyle = TickStyle.None;
            trackBar_dpi_control.Value = 10;
            trackBar_dpi_control.Scroll += trackBar_dpi_control_Scroll;
            // 
            // label_border_style
            // 
            label_border_style.AutoSize = true;
            label_border_style.Font = new Font("Source Code Pro", 11.25F, FontStyle.Bold);
            label_border_style.ForeColor = Color.White;
            label_border_style.Location = new Point(6, 12);
            label_border_style.Name = "label_border_style";
            label_border_style.Size = new Size(117, 19);
            label_border_style.TabIndex = 39;
            label_border_style.Text = "Border Style";
            // 
            // chkBottomLeft
            // 
            chkBottomLeft.AutoSize = true;
            chkBottomLeft.ForeColor = Color.White;
            chkBottomLeft.Location = new Point(9, 110);
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
            chkBottomRight.Location = new Point(9, 85);
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
            chkTopRight.Location = new Point(8, 60);
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
            chkTopLeft.Location = new Point(9, 35);
            chkTopLeft.Name = "chkTopLeft";
            chkTopLeft.Size = new Size(82, 19);
            chkTopLeft.TabIndex = 35;
            chkTopLeft.Text = "Top Left";
            chkTopLeft.UseVisualStyleBackColor = true;
            chkTopLeft.CheckedChanged += chkTopLeft_CheckedChanged;
            // 
            // label_border_radius
            // 
            label_border_radius.AutoSize = true;
            label_border_radius.Font = new Font("Source Code Pro", 10F);
            label_border_radius.ForeColor = Color.White;
            label_border_radius.Location = new Point(6, 125);
            label_border_radius.Name = "label_border_radius";
            label_border_radius.Size = new Size(112, 18);
            label_border_radius.TabIndex = 34;
            label_border_radius.Text = "Border radius";
            // 
            // trackBar_border_radius
            // 
            trackBar_border_radius.Location = new Point(1, 143);
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
            label_system_opacity.Location = new Point(6, 35);
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
            label_border_size.Location = new Point(6, 81);
            label_border_size.Name = "label_border_size";
            label_border_size.Size = new Size(96, 18);
            label_border_size.TabIndex = 32;
            label_border_size.Text = "Border size";
            // 
            // trackBar_opacityForm
            // 
            trackBar_opacityForm.Location = new Point(1, 54);
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
            trackBar_border_size.Location = new Point(1, 99);
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
            label_percet_opacity.Location = new Point(242, 35);
            label_percet_opacity.Name = "label_percet_opacity";
            label_percet_opacity.Size = new Size(40, 18);
            label_percet_opacity.TabIndex = 30;
            label_percet_opacity.Text = "100%";
            label_percet_opacity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel_Settings
            // 
            panel_Settings.Controls.Add(groupBox6);
            panel_Settings.Controls.Add(groupBox3);
            panel_Settings.Controls.Add(groupBox7);
            panel_Settings.Controls.Add(groupBox5);
            panel_Settings.Controls.Add(groupBox2);
            panel_Settings.Controls.Add(groupBox1);
            panel_Settings.Location = new Point(538, 42);
            panel_Settings.Name = "panel_Settings";
            panel_Settings.Size = new Size(520, 394);
            panel_Settings.TabIndex = 2;
            panel_Settings.Visible = false;
            panel_Settings.MouseDown += panel_Settings_MouseDown;
            panel_Settings.MouseMove += panel_Settings_MouseMove;
            panel_Settings.MouseUp += panel_Settings_MouseUp;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label_profile_setting);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Location = new Point(7, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(293, 91);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            // 
            // label_profile_setting
            // 
            label_profile_setting.AutoSize = true;
            label_profile_setting.Font = new Font("Source Code Pro", 11.25F, FontStyle.Bold);
            label_profile_setting.ForeColor = Color.White;
            label_profile_setting.Location = new Point(6, 12);
            label_profile_setting.Name = "label_profile_setting";
            label_profile_setting.Size = new Size(135, 19);
            label_profile_setting.TabIndex = 31;
            label_profile_setting.Text = "System opacity";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label_language);
            groupBox3.Controls.Add(label_start_system);
            groupBox3.Controls.Add(cmbLanguage);
            groupBox3.Controls.Add(checkBox_start_system);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(6, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(294, 119);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label_language
            // 
            label_language.AutoSize = true;
            label_language.Font = new Font("Source Code Pro", 10F);
            label_language.ForeColor = Color.White;
            label_language.Location = new Point(6, 64);
            label_language.Name = "label_language";
            label_language.Size = new Size(72, 18);
            label_language.TabIndex = 43;
            label_language.Text = "Language";
            // 
            // label_start_system
            // 
            label_start_system.AutoSize = true;
            label_start_system.Font = new Font("Source Code Pro", 11.25F, FontStyle.Bold);
            label_start_system.ForeColor = Color.White;
            label_start_system.Location = new Point(6, 12);
            label_start_system.Name = "label_start_system";
            label_start_system.Size = new Size(135, 19);
            label_start_system.TabIndex = 30;
            label_start_system.Text = "System opacity";
            // 
            // cmbLanguage
            // 
            cmbLanguage.BackColor = Color.FromArgb(40, 40, 40);
            cmbLanguage.FlatStyle = FlatStyle.Flat;
            cmbLanguage.ForeColor = Color.White;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(6, 85);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(197, 23);
            cmbLanguage.TabIndex = 42;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // checkBox_start_system
            // 
            checkBox_start_system.AutoSize = true;
            checkBox_start_system.Font = new Font("Source Code Pro", 10F);
            checkBox_start_system.ForeColor = Color.White;
            checkBox_start_system.Location = new Point(6, 38);
            checkBox_start_system.Name = "checkBox_start_system";
            checkBox_start_system.Size = new Size(163, 22);
            checkBox_start_system.TabIndex = 46;
            checkBox_start_system.Text = "Start with System";
            checkBox_start_system.UseVisualStyleBackColor = true;
            checkBox_start_system.CheckedChanged += checkBox_start_system_CheckedChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnOverlay);
            groupBox7.Controls.Add(label1);
            groupBox7.FlatStyle = FlatStyle.Flat;
            groupBox7.Location = new Point(306, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(200, 152);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            // 
            // btnOverlay
            // 
            btnOverlay.FlatStyle = FlatStyle.Flat;
            btnOverlay.Font = new Font("Source Code Pro", 7F);
            btnOverlay.ForeColor = Color.White;
            btnOverlay.Location = new Point(97, 123);
            btnOverlay.Name = "btnOverlay";
            btnOverlay.Size = new Size(97, 22);
            btnOverlay.TabIndex = 48;
            btnOverlay.Text = "Debug Overlay";
            btnOverlay.TextAlign = ContentAlignment.TopCenter;
            btnOverlay.UseVisualStyleBackColor = true;
            btnOverlay.Click += btnOverlay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 32;
            label1.Text = "System opacity";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label_config_visual);
            groupBox5.Controls.Add(label_percent_border_radius);
            groupBox5.Controls.Add(label_percent_border_size);
            groupBox5.Controls.Add(label_border_size);
            groupBox5.Controls.Add(label_system_opacity);
            groupBox5.Controls.Add(trackBar_border_radius);
            groupBox5.Controls.Add(trackBar_opacityForm);
            groupBox5.Controls.Add(label_border_radius);
            groupBox5.Controls.Add(trackBar_border_size);
            groupBox5.Controls.Add(label_percet_opacity);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Location = new Point(6, 202);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(294, 190);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // label_config_visual
            // 
            label_config_visual.AutoSize = true;
            label_config_visual.Font = new Font("Source Code Pro", 11.25F, FontStyle.Bold);
            label_config_visual.ForeColor = Color.White;
            label_config_visual.Location = new Point(6, 12);
            label_config_visual.Name = "label_config_visual";
            label_config_visual.Size = new Size(135, 19);
            label_config_visual.TabIndex = 30;
            label_config_visual.Text = "System opacity";
            // 
            // label_percent_border_radius
            // 
            label_percent_border_radius.AutoSize = true;
            label_percent_border_radius.Font = new Font("Source Code Pro", 10F);
            label_percent_border_radius.ForeColor = Color.White;
            label_percent_border_radius.Location = new Point(242, 125);
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
            label_percent_border_size.Location = new Point(242, 81);
            label_percent_border_size.Name = "label_percent_border_size";
            label_percent_border_size.Size = new Size(40, 18);
            label_percent_border_size.TabIndex = 49;
            label_percent_border_size.Text = "100%";
            label_percent_border_size.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_color_style);
            groupBox2.Controls.Add(pic_background_form);
            groupBox2.Controls.Add(button_border_color);
            groupBox2.Controls.Add(pic_border_form);
            groupBox2.Controls.Add(button_background_color);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(306, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label_color_style
            // 
            label_color_style.AutoSize = true;
            label_color_style.Font = new Font("Source Code Pro", 11.25F, FontStyle.Bold);
            label_color_style.ForeColor = Color.White;
            label_color_style.Location = new Point(6, 12);
            label_color_style.Name = "label_color_style";
            label_color_style.Size = new Size(135, 19);
            label_color_style.TabIndex = 30;
            label_color_style.Text = "System opacity";
            // 
            // pic_background_form
            // 
            pic_background_form.BackColor = Color.Lime;
            pic_background_form.BorderStyle = BorderStyle.FixedSingle;
            pic_background_form.Location = new Point(11, 37);
            pic_background_form.Name = "pic_background_form";
            pic_background_form.Size = new Size(30, 30);
            pic_background_form.TabIndex = 48;
            pic_background_form.TabStop = false;
            // 
            // button_border_color
            // 
            button_border_color.FlatStyle = FlatStyle.Flat;
            button_border_color.Font = new Font("Source Code Pro", 10F);
            button_border_color.ForeColor = Color.White;
            button_border_color.Location = new Point(47, 73);
            button_border_color.Name = "button_border_color";
            button_border_color.Size = new Size(144, 30);
            button_border_color.TabIndex = 44;
            button_border_color.Text = "Border Color";
            button_border_color.TextAlign = ContentAlignment.TopCenter;
            button_border_color.UseVisualStyleBackColor = true;
            button_border_color.Click += button_border_color_Click;
            // 
            // pic_border_form
            // 
            pic_border_form.BackColor = Color.Lime;
            pic_border_form.BorderStyle = BorderStyle.FixedSingle;
            pic_border_form.Location = new Point(11, 73);
            pic_border_form.Name = "pic_border_form";
            pic_border_form.Size = new Size(30, 30);
            pic_border_form.TabIndex = 45;
            pic_border_form.TabStop = false;
            // 
            // button_background_color
            // 
            button_background_color.FlatStyle = FlatStyle.Flat;
            button_background_color.Font = new Font("Source Code Pro", 10F);
            button_background_color.ForeColor = Color.White;
            button_background_color.Location = new Point(47, 37);
            button_background_color.Name = "button_background_color";
            button_background_color.Size = new Size(144, 30);
            button_background_color.TabIndex = 47;
            button_background_color.Text = "Border Color";
            button_background_color.TextAlign = ContentAlignment.TopCenter;
            button_background_color.UseVisualStyleBackColor = true;
            button_background_color.Click += button_background_color_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_border_style);
            groupBox1.Controls.Add(chkTopLeft);
            groupBox1.Controls.Add(chkTopRight);
            groupBox1.Controls.Add(chkBottomRight);
            groupBox1.Controls.Add(chkBottomLeft);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(305, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // panel_left_button
            // 
            panel_left_button.Controls.Add(groupBox4);
            panel_left_button.Location = new Point(12, 442);
            panel_left_button.Name = "panel_left_button";
            panel_left_button.Size = new Size(520, 394);
            panel_left_button.TabIndex = 3;
            panel_left_button.Visible = false;
            panel_left_button.MouseDown += panel_Settings_MouseDown;
            panel_left_button.MouseMove += panel_Settings_MouseMove;
            panel_left_button.MouseUp += panel_Settings_MouseUp;
            // 
            // groupBox4
            // 
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Location = new Point(160, 126);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 143);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // panel_right_button
            // 
            panel_right_button.Location = new Point(538, 443);
            panel_right_button.Name = "panel_right_button";
            panel_right_button.Size = new Size(520, 394);
            panel_right_button.TabIndex = 4;
            panel_right_button.Visible = false;
            panel_right_button.MouseDown += panel_Settings_MouseDown;
            panel_right_button.MouseMove += panel_Settings_MouseMove;
            panel_right_button.MouseUp += panel_Settings_MouseUp;
            // 
            // panel_middle_button
            // 
            panel_middle_button.Location = new Point(1064, 443);
            panel_middle_button.Name = "panel_middle_button";
            panel_middle_button.Size = new Size(520, 394);
            panel_middle_button.TabIndex = 6;
            panel_middle_button.Visible = false;
            panel_middle_button.MouseDown += panel_Settings_MouseDown;
            panel_middle_button.MouseMove += panel_Settings_MouseMove;
            panel_middle_button.MouseUp += panel_Settings_MouseUp;
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
            // panel_x_up_button
            // 
            panel_x_up_button.Location = new Point(12, 842);
            panel_x_up_button.Name = "panel_x_up_button";
            panel_x_up_button.Size = new Size(520, 394);
            panel_x_up_button.TabIndex = 7;
            panel_x_up_button.Visible = false;
            panel_x_up_button.MouseDown += panel_Settings_MouseDown;
            panel_x_up_button.MouseMove += panel_Settings_MouseMove;
            panel_x_up_button.MouseUp += panel_Settings_MouseUp;
            // 
            // panel_x_down_button
            // 
            panel_x_down_button.Location = new Point(538, 843);
            panel_x_down_button.Name = "panel_x_down_button";
            panel_x_down_button.Size = new Size(520, 394);
            panel_x_down_button.TabIndex = 8;
            panel_x_down_button.Visible = false;
            panel_x_down_button.MouseDown += panel_Settings_MouseDown;
            panel_x_down_button.MouseMove += panel_Settings_MouseMove;
            panel_x_down_button.MouseUp += panel_Settings_MouseUp;
            // 
            // Sistemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1640, 1061);
            Controls.Add(panel_x_down_button);
            Controls.Add(panel_x_up_button);
            Controls.Add(panel_middle_button);
            Controls.Add(panel_Profile);
            Controls.Add(panel_right_button);
            Controls.Add(panel_left_button);
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
            panel_Dashboard.ResumeLayout(false);
            panel_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_dpi_control).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_radius).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_opacityForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_border_size).EndInit();
            panel_Settings.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_background_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_border_form).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_left_button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_mini_menu;
        private Panel panel_Dashboard;
        private Panel panel_Settings;
        private Panel panel_left_button;
        private Panel panel_right_button;
        private Panel panel_middle_button;
        private Panel panel_Profile;
        private Label label_border_style;
        private CheckBox chkBottomLeft;
        private CheckBox chkBottomRight;
        private CheckBox chkTopRight;
        private CheckBox chkTopLeft;
        private Label label_border_radius;
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
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label_color_style;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Label label_start_system;
        private Label label_config_visual;
        private Label label_profile_setting;
        private GroupBox groupBox7;
        private Label label1;
        private Button btnOverlay;
        private TrackBar trackBar_dpi_control;
        private Label label_dpi_control;
        private Panel panel_x_up_button;
        private Panel panel_x_down_button;
    }
}