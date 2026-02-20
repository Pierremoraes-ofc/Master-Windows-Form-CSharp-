using Master.Actions;
using Master.MouseSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static Master.Actions.Ax;
using static Master.biblioteca;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master
{
    public partial class Sistemas : Form
    {
        #region VARIAVEIS

        //  Controle do form
        private bool _dragging = false;
        private Point _dragCursor;
        private Point _dragForm;

        Color BorderColor;
        Color BackgroundColor;

        //  Debug do mouse
        private MouseOverlay overlay;


        private KeyCombinationNew currentCombination = new();
        private bool capturing = false;


        #endregion



        #region CONFIG DO FORM

        public Sistemas()
        {
            InitializeComponent();
        }
        private void Sistemas_Paint(object sender, PaintEventArgs e)
        {
            var corners = Master.biblioteca.GetSelectedCorners(Master.biblioteca.MasterTopLeft, Master.biblioteca.MasterTopRight, Master.biblioteca.MasterBottomRight, Master.biblioteca.MasterBottomLeft);

            Master.biblioteca.FormRegionAndBorder(
                this,
                Master.biblioteca.MasterBorderRadius,
                e.Graphics,
                Master.biblioteca.borderColor,
                Master.biblioteca.MasterBorderSize,
                corners
            );
        }
        private void Sistemas_Load(object sender, EventArgs e)
        {
            LoadStyle();                                        //  Visual e Configurações do Form
            Language();                                         //  Aplica o Idioma
            LoadLanguages();

            AppPaths.EnsureDirectories();
            cmbLanguage.BeginUpdate();
            cmbLanguage.Items.Clear();

            foreach (var lang in _languages)
                cmbLanguage.Items.Add(lang);

            cmbLanguage.EndUpdate();

            if (cmbLanguage.Items.Count > 0)
                cmbLanguage.SelectedIndex = 0;


            Cfg_Style();                                        //  Carrega todo visual e configuraçao do sistema


            DetectMice();                                       //  Carrega Dados do mouse

            //  INICIA O DPI SCALER
            MouseDpiScaler.Start(trackBar_dpi_control.Value / 10f);




            combobox_right_button_master.Items.Clear();

            foreach (KeyN key in Enum.GetValues(typeof(KeyN)))
            {
                combobox_right_button_master.Items.Add(key);
            }

            combobox_right_button_master.SelectedItem = KeyN.NONE;

        }

        #endregion


        #region MOVIMENTO DOS FORMS

        private void panel_Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging)
                return;

            Point diff = Point.Subtract(Cursor.Position, new Size(_dragCursor));
            DockManager.Master.Location = Point.Add(_dragForm, new Size(diff));
        }
        private void panel_Settings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _dragging = true;
            _dragCursor = Cursor.Position;
            _dragForm = DockManager.Master.Location;
        }
        private void panel_Settings_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        #endregion


        #region MECANICA DO FORM

        public void Cfg_Style()
        {
            if (Master.biblioteca.DayNight == 0)
            {
                //  Tema Claro/Day
                label_Title.ForeColor = Color.Black;

                icon_exit.IconColor = Color.Black;
                icon_exit.BackColor = Color.FromArgb(224, 224, 224);

                icon_eye_hide.IconColor = Color.Black;
                icon_eye_hide.BackColor = Color.FromArgb(224, 224, 224);

                icon_menu_h.IconColor = Color.Black;
                icon_menu_h.BackColor = Color.FromArgb(224, 224, 224);

                icon_menu_v.IconColor = Color.Black;
                icon_menu_v.BackColor = Color.FromArgb(224, 224, 224);

                icon_minimize.IconColor = Color.Black;
                icon_minimize.BackColor = Color.FromArgb(224, 224, 224);

                icon_night.IconColor = Color.Black;
                icon_night.BackColor = Color.FromArgb(224, 224, 224);

                icon_day.IconColor = Color.Black;
                icon_day.BackColor = Color.FromArgb(224, 224, 224);

                panel_mini_menu.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Dashboard
                panel_Dashboard.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Setting
                panel_Settings.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Profile
                panel_Profile.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Botao Esquerdo
                panel_left_button.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Botao Direito
                panel_right_button.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Botao Middle
                panel_middle_button.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Botao Lateral Superior
                panel_x_up_button.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu Botao Lateral Inferior
                panel_x_down_button.BackColor = Color.FromArgb(224, 224, 224);

                //  Menu de Velocidade do Ponteiro
                panel_speed_mouse.BackColor = Color.FromArgb(224, 224, 224);
            }
            if (Master.biblioteca.DayNight == 1)
            {
                //  Tema Escuro/Night

                //  MiniMenu
                label_Title.ForeColor = Color.White;

                icon_exit.IconColor = Color.White;
                icon_exit.BackColor = Color.FromArgb(40, 40, 40);

                icon_eye_hide.IconColor = Color.White;
                icon_eye_hide.BackColor = Color.FromArgb(40, 40, 40);

                icon_menu_h.IconColor = Color.White;
                icon_menu_h.BackColor = Color.FromArgb(40, 40, 40);

                icon_menu_v.IconColor = Color.White;
                icon_menu_v.BackColor = Color.FromArgb(40, 40, 40);

                icon_minimize.IconColor = Color.White;
                icon_minimize.BackColor = Color.FromArgb(40, 40, 40);

                icon_night.IconColor = Color.White;
                icon_night.BackColor = Color.FromArgb(40, 40, 40);

                icon_day.IconColor = Color.White;
                icon_day.BackColor = Color.FromArgb(40, 40, 40);

                panel_mini_menu.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Dashboard
                panel_Dashboard.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Setting
                panel_Settings.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Profile
                panel_Profile.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu DPI
                panel_left_button.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Macro
                panel_right_button.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Remap
                panel_middle_button.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Botao Lateral Superior
                panel_x_up_button.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu Botao Lateral Inferior
                panel_x_down_button.BackColor = Color.FromArgb(40, 40, 40);

                //  Menu de Velocidade do Ponteiro
                panel_speed_mouse.BackColor = Color.FromArgb(40, 40, 40);
            }
        }
        public void LoadStyle()
        {
            //  Form
            this.Size = new Size(520, 430);
            this.ShowInTaskbar = false;

            //  Mini Menu
            icon_menu_v.Visible = true;
            icon_menu_v.Location = new Point(421, 7);
            icon_menu_h.Visible = false;
            icon_menu_h.Location = new Point(421, 7);
            icon_day.Visible = true;
            icon_day.Location = new Point(395, 7);
            icon_night.Visible = false;
            icon_night.Location = new Point(395, 7);

            //  Panels Menus
            panel_Dashboard.Dock = DockStyle.Fill;
            panel_Settings.Dock = DockStyle.Fill;
            panel_Profile.Dock = DockStyle.Fill;
            panel_left_button.Dock = DockStyle.Fill;
            panel_right_button.Dock = DockStyle.Fill;
            panel_middle_button.Dock = DockStyle.Fill;
            panel_x_up_button.Dock = DockStyle.Fill;
            panel_x_down_button.Dock = DockStyle.Fill;
            panel_speed_mouse.Dock = DockStyle.Fill;

            panel_Dashboard.Visible = true;
            panel_Settings.Visible = false;
            panel_Profile.Visible = false;
            panel_left_button.Visible = false;
            panel_right_button.Visible = false;
            panel_middle_button.Visible = false;
            panel_x_up_button.Visible = false;
            panel_x_down_button.Visible = false;
            panel_speed_mouse.Visible = false;

            //  Setting 
            //Pictures do Border e Background color
            pic_border_form.BackColor = Master.biblioteca.borderColor;
            pic_background_form.BackColor = Master.biblioteca.BackgroundColor;
            //  border size
            trackBar_border_size.Value = Master.biblioteca.MasterBorderSize;
            label_percent_border_size.Text = $"{trackBar_border_size.Value}%";
            //  opacidade
            trackBar_opacityForm.Value = (int)Math.Round(Master.biblioteca.MasterOpacity * 100);
            label_percet_opacity.Text = $"{trackBar_opacityForm.Value}%";
            //  Arredondamento das bordas
            trackBar_border_radius.Value = Master.biblioteca.MasterBorderRadius;
            label_percent_border_radius.Text = $"{trackBar_border_radius.Value}%";
            //  Checks das bordas
            chkTopLeft.Checked = Master.biblioteca.MasterTopLeft;
            chkTopRight.Checked = Master.biblioteca.MasterTopRight;
            chkBottomLeft.Checked = Master.biblioteca.MasterBottomLeft;
            chkBottomRight.Checked = Master.biblioteca.MasterBottomRight;

            //  Configurações do mouse
            trackBar_dpi_control.Value = (int)Math.Round(Master.biblioteca.MasterDPI * 100);
            label_dpi_control_percent.Text = $"{(int)Math.Round(Master.biblioteca.MasterDPI * 20)}%";

            if (Master.biblioteca.DayNight == 0)
            {
                //  dia/claro
                Master.biblioteca.DayNight = 0;
                MasterForm.FormMaster?.SyncDesin();
                icon_day.Visible = false;
                icon_night.Visible = true;
            }
            if (Master.biblioteca.DayNight == 1)
            {
                //  noite/escuro
                Master.biblioteca.DayNight = 1;
                MasterForm.FormMaster?.SyncDesin();
                icon_day.Visible = true;
                icon_night.Visible = false;
            }

        }
        private void ColapsMenu(bool collapsed)
        {
            if (collapsed)
            {
                icon_menu_h.Visible = true;
                icon_menu_v.Visible = false;
            }
            else
            {
                icon_menu_h.Visible = false;
                icon_menu_v.Visible = true;
            }
        }
        private void hideSubmenu()
        {
            panel_Dashboard.Visible = false;
            panel_Settings.Visible = false;
            panel_Profile.Visible = false;
            panel_left_button.Visible = false;
            panel_right_button.Visible = false;
            panel_middle_button.Visible = false;
            panel_x_up_button.Visible = false;
            panel_x_down_button.Visible = false;
            panel_speed_mouse.Visible = false;
        }
        public void MenuSelect(SistemaMenu menu, string title)
        {
            hideSubmenu();

            switch (menu)
            {
                case SistemaMenu.Dashboard:
                    panel_Dashboard.Visible = true;
                    break;

                case SistemaMenu.Settings:
                    panel_Settings.Visible = true;
                    break;

                case SistemaMenu.Profile:
                    panel_Profile.Visible = true;
                    break;

                case SistemaMenu.left_button:
                    panel_left_button.Visible = true;
                    break;

                case SistemaMenu.right_button:
                    panel_right_button.Visible = true;
                    break;

                case SistemaMenu.middle_button:
                    panel_middle_button.Visible = true;
                    break;

                case SistemaMenu.x_up_button:
                    panel_x_up_button.Visible = true;
                    break;

                case SistemaMenu.x_down_button:
                    panel_x_down_button.Visible = true;
                    break;

                case SistemaMenu.speed_mouse:
                    panel_speed_mouse.Visible = true;
                    break;
            }

            label_Title.Text = title;
        }

        #endregion


        #region SISTEMA DE IDIOMA

        private List<string> _languages = new();
        private void LoadLanguages()
        {
            _languages.Clear();

            AppPaths.EnsureDirectories();

            if (!Directory.Exists(AppPaths.Language))
                return;

            var files = Directory.GetFiles(
                AppPaths.Language, "*.json");

            foreach (var file in files)
            {
                string name =
                    Path.GetFileNameWithoutExtension(file);

                _languages.Add(name);
            }
        }
        public void Language()
        {
            //  BARRA DE MENU
            label_Title.Text = "     " + LanguageManager.Get("rato.menu.home");

            //  MENU SETTING
            label_language.Text = LanguageManager.Get("rato.setting.label_language");
            checkBox_start_system.Text = LanguageManager.Get("rato.setting.checkBox_start_system");
            button_background_color.Text = LanguageManager.Get("rato.setting.button_background_color");
            button_border_color.Text = LanguageManager.Get("rato.setting.button_border_color");
            label_system_opacity.Text = LanguageManager.Get("rato.setting.label_system_opacity");
            label_border_size.Text = LanguageManager.Get("rato.setting.label_border_size");
            label_border_radius.Text = LanguageManager.Get("rato.setting.label_border_radius");
            label_border_style.Text = LanguageManager.Get("rato.setting.label_border_style");
            chkTopLeft.Text = LanguageManager.Get("rato.setting.chkTopLeft");
            chkTopRight.Text = LanguageManager.Get("rato.setting.chkTopRight");
            chkBottomRight.Text = LanguageManager.Get("rato.setting.chkBottomRight");
            chkBottomLeft.Text = LanguageManager.Get("rato.setting.chkBottomLeft");
            label_color_style.Text = LanguageManager.Get("rato.setting.label_color_style");
            label_start_system.Text = LanguageManager.Get("rato.setting.label_start_system");
            label_config_visual.Text = LanguageManager.Get("rato.setting.label_config_visual");
            label_profile_setting.Text = LanguageManager.Get("rato.setting.label_profile_setting");


            combobox_right_button_configuration.Items.Clear();
            combobox_right_button_configuration.Items.Add(LanguageManager.Get("rato.mouseconfig.none"));
            combobox_right_button_configuration.Items.Add(LanguageManager.Get("rato.mouseconfig.configbutton.key"));
            combobox_right_button_configuration.Items.Add(LanguageManager.Get("rato.mouseconfig.configbutton.keycombination"));
            combobox_right_button_configuration.Items.Add(LanguageManager.Get("rato.mouseconfig.configbutton.command"));
            combobox_right_button_configuration.SelectedIndex = 0;
        }

        #endregion


        #region MENU

        private void icon_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MasterForm"].WindowState = FormWindowState.Minimized;
        }
        private void icon_eye_hide_Click(object sender, EventArgs e)
        {
            MasterForm.FormMaster?.OcultarParaTray();
        }
        private void icon_menu_h_Click(object sender, EventArgs e)
        {
            MasterForm.FormMaster?.SizeForm(false);
            ColapsMenu(false);
        }
        private void icon_menu_v_Click(object sender, EventArgs e)
        {
            MasterForm.FormMaster?.SizeForm(true);
            ColapsMenu(true);
        }
        private void icon_night_Click(object sender, EventArgs e)
        {
            Master.biblioteca.DayNight = 1;
            MasterForm.FormMaster?.SyncDesin();
            icon_day.Visible = true;
            icon_night.Visible = false;
        }
        private void icon_day_Click(object sender, EventArgs e)
        {
            Master.biblioteca.DayNight = 0;
            MasterForm.FormMaster?.SyncDesin();
            icon_day.Visible = false;
            icon_night.Visible = true;
        }

        #endregion


        #region BOTOES DO PAINEL SETTINGS

        private void checkBox_start_system_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_start_system.Checked)
                StartupManager.Enable();
            else
                StartupManager.Disable();
        }
        private void button_border_color_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            colorDialog1.AnyColor = true;

            // cor inicial = cor atual do form
            colorDialog1.Color = BorderColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BorderColor = colorDialog1.Color;
                pic_border_form.BackColor = BorderColor;
                Master.biblioteca.borderColor = BorderColor;
                MasterForm.FormMaster?.SyncDesin();
            }
        }
        private void button_background_color_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            colorDialog1.AnyColor = true;

            // cor inicial = cor atual do form
            colorDialog1.Color = BackgroundColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = colorDialog1.Color;
                pic_background_form.BackColor = BackgroundColor;
                Master.biblioteca.BackgroundColor = BackgroundColor;
                MasterForm.FormMaster?.SyncDesin();
            }
        }

        private void chkTopLeft_CheckedChanged(object sender, EventArgs e)
        {
            Master.biblioteca.MasterTopLeft = chkTopLeft.Checked;
            MasterForm.FormMaster?.SyncDesin();
        }
        private void chkTopRight_CheckedChanged(object sender, EventArgs e)
        {
            Master.biblioteca.MasterTopRight = chkTopRight.Checked;
            MasterForm.FormMaster?.SyncDesin();
        }
        private void chkBottomRight_CheckedChanged(object sender, EventArgs e)
        {
            Master.biblioteca.MasterBottomRight = chkBottomRight.Checked;
            MasterForm.FormMaster?.SyncDesin();
        }
        private void chkBottomLeft_CheckedChanged(object sender, EventArgs e)
        {
            Master.biblioteca.MasterBottomLeft = chkBottomLeft.Checked;
            MasterForm.FormMaster?.SyncDesin();
        }

        private void trackBar_opacityForm_Scroll(object sender, EventArgs e)
        {
            Master.biblioteca.MasterOpacity = (float)(trackBar_opacityForm.Value / 100.0);
            label_percet_opacity.Text = $"{trackBar_opacityForm.Value}%";
            MasterForm.FormMaster?.SyncDesin();
        }
        private void trackBar_border_size_Scroll(object sender, EventArgs e)
        {
            Master.biblioteca.MasterBorderSize = trackBar_border_size.Value;
            label_percent_border_size.Text = $"{trackBar_border_size.Value}%";
            MasterForm.FormMaster?.SyncDesin();
        }
        private void trackBar_border_radius_Scroll(object sender, EventArgs e)
        {
            Master.biblioteca.MasterBorderRadius = trackBar_border_radius.Value;
            label_percent_border_radius.Text = $"{trackBar_border_radius.Value}%";
            MasterForm.FormMaster?.SyncDesin();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedItem == null)
                return;

            Master.biblioteca.InputLanguage = cmbLanguage.SelectedItem.ToString();
            LanguageManager.Load(Master.biblioteca.InputLanguage);

            MasterForm.FormMaster?.ApplyLanguageAll();
        }

        #endregion

        #region DEBUGGER

        private void DetectMice()
        {
            var mice = MouseDetector.GetMice();

            foreach (var mouse in mice)
            {
                Console.WriteLine("Nome: " + mouse.Name);
                Console.WriteLine("VID: " + mouse.VID);
                Console.WriteLine("PID: " + mouse.PID);
                Console.WriteLine("Handle: " + mouse.Handle);
                Console.WriteLine("--------------------");
            }
        }
        private void btnOverlay_Click(object sender, EventArgs e)
        {
            if (overlay == null || overlay.IsDisposed)
            {
                overlay = new MouseOverlay();
                overlay.Show();
            }
            else
            {
                overlay.Close();
                overlay = null;
            }
        }

        #endregion

        #region MOUSE SETTING

        private void trackBar_dpi_control_Scroll(object sender, EventArgs e)
        {
            Master.biblioteca.MasterDPI = trackBar_dpi_control.Value / 10f;
            label_dpi_control_percent.Text = $"{(int)Math.Round(Master.biblioteca.MasterDPI * 20)}%";
            MouseDpiScaler.SetMultiplier(Master.biblioteca.MasterDPI);
        }

        #endregion

        #region FUNÇÕES IMPORTANTES

        private void IniciarCaptura()
        {
            capturing = true;

            // limpa combinação anterior
            currentCombination = new KeyCombinationNew();

            // limpa texto
            textbox_right_button_action_combination.Clear();

            textbox_right_button_action_combination.Text = "Pressione as teclas...";

            textbox_right_button_action_combination.SelectionStart = textbox_right_button_action_combination.Text.Length;
        }

        #endregion

        public class ButtonRemapConfig
        {
            public KeyN MasterKey;

            public ActionType ActionType;

            public KeyN Key;

            public KeyN[] Combination;

            public EdicionOpciones? Command;

            public bool BlockOriginal;
        }

        public ButtonRemapConfig GetRightButtonConfig()
        {
            var config = new ButtonRemapConfig();

            // MASTER KEY
            config.MasterKey =
                (KeyN)combobox_right_button_master.SelectedItem;

            // TYPE
            config.ActionType =
                (ActionType)combobox_right_button_configuration.SelectedIndex;

            config.BlockOriginal =
                checkbox_right_button.Checked;

            switch (config.ActionType)
            {
                case ActionType.Key:

                    config.Key =
                        (KeyN)combobox_right_button_action.SelectedItem;

                    break;


                case ActionType.KeyCombination:

                    config.Combination =
                        ParseCombination(
                            textbox_right_button_action_combination.Text);

                    break;


                case ActionType.Command:

                    var cmd =
                        GetCommand(
                            combobox_right_button_action.SelectedIndex);

                    if (cmd.HasValue)
                        config.Command = cmd.Value;

                    break;
            }

            return config;
        }
        public static KeyN[] ParseCombination(string text)
        {
            string[] parts = text.Split('+');

            List<KeyN> keys = new List<KeyN>();

            foreach (string part in parts)
            {
                string key = part.Trim().ToUpper();

                if (Enum.TryParse<KeyN>(key, out var result))
                    keys.Add(result);
            }

            return keys.ToArray();
        }

        public static EdicionOpciones? GetCommand(int index)
        {
            if (index <= 0) return null;

            return (EdicionOpciones)(index - 1);
        }
        private void combobox_right_button_configuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionType type = (ActionType)combobox_right_button_configuration.SelectedIndex;

            combobox_right_button_action.Items.Clear();

            switch (type)
            {
                case ActionType.None:

                    combobox_right_button_action.Enabled = false;
                    textbox_right_button_action_combination.Enabled = false;

                    break;


                case ActionType.Key:

                    combobox_right_button_action.Enabled = true;
                    textbox_right_button_action_combination.Enabled = false;

                    foreach (KeyN key in Enum.GetValues(typeof(KeyN)))
                        combobox_right_button_action.Items.Add(key);

                    break;


                case ActionType.Command:

                    combobox_right_button_action.Enabled = true;
                    textbox_right_button_action_combination.Enabled = false;

                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.none"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.copy"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.paste"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.cut"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.undo"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.remake"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.new"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.save"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.openfile"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.selectall"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.search"));
                    combobox_right_button_action.Items.Add(LanguageManager.Get("rato.mouseconfig.actionbutton.print"));

                    combobox_right_button_action.SelectedIndex = 0;

                    break;


                case ActionType.KeyCombination:

                    combobox_right_button_action.Enabled = false;
                    textbox_right_button_action_combination.Enabled = true;

                    break;
            }
        }

        private void combobox_right_button_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ActionType)combobox_right_button_configuration.SelectedIndex == ActionType.Key)
            {
                KeyN key = (KeyN)combobox_right_button_action.SelectedItem;


            }
        }

        private void checkbox_right_button_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_start_system.Checked)
                Master.biblioteca.MasterWinAction = true;
            else
                Master.biblioteca.MasterWinAction = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ax.Executar(currentCombination);
        }
        private void textbox_right_button_action_combination_Enter(object sender, EventArgs e)
        {
            IniciarCaptura();
        }
        private void textbox_right_button_action_combination_KeyDown(object sender, KeyEventArgs e)
        {
            if (!capturing) return;

            e.SuppressKeyPress = true;
            e.Handled = true;

            KeyN key = (KeyN)e.KeyCode;

            if (!currentCombination.Keys.Contains(key))
                currentCombination.Keys.Add(key);

            textbox_right_button_action_combination.Text = currentCombination.ToString();
        }
        private void textbox_right_button_action_combination_KeyUp(object sender, KeyEventArgs e)
        {
            capturing = false;
        }
        private void textbox_right_button_action_combination_Leave(object sender, EventArgs e)
        {
            capturing = false;
        }
        private void textbox_right_button_action_combination_MouseDown(object sender, MouseEventArgs e)
        {
            IniciarCaptura();
        }

    }
}
