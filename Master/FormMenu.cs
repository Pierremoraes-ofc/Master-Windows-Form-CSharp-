using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Master.biblioteca;
using static Master.Sistemas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master
{
    public partial class FormMenu : Form
    {
        private bool _dragging = false;
        private Point _dragCursor;
        private Point _dragForm;

        #region CONFIGURAÇÕES DO FORM MENU

        public FormMenu()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            Language();                                         //  Aplica o Idioma
            SizeMenu(Master.biblioteca.MenuSistema);
            this.ShowInTaskbar = false;

            Cfg_Style();                                        //  Atualiza paramatros de configuraçao
        }
        private void FormMenu_Paint(object sender, PaintEventArgs e)
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

        #endregion


        #region FUNÇÕES ESSENCIAIS

        public void hideSubmenu()
        {
            panel_menu_mouse.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        public void SizeMenu(bool collapsed)
        {
            this.Width = collapsed ? 35 : 234;
        }

        #endregion

        #region     IDIOMA

        public void Language()
        {
            icon_home.Text = "     " + LanguageManager.Get("rato.menu.home");
            icon_mouse.Text = "     " + LanguageManager.Get("rato.menu.mouse");
            icon_remap.Text = "     " + LanguageManager.Get("rato.menu.remap");
            icon_macro.Text = "     " + LanguageManager.Get("rato.menu.macro");
            icon_dpi.Text = "     " + LanguageManager.Get("rato.menu.dpi");
            icon_profile.Text = "     " + LanguageManager.Get("rato.menu.profile");
            icon_setting.Text = "     " + LanguageManager.Get("rato.menu.setting");
        }
        public void Cfg_Style()
        {
            if (Master.biblioteca.DayNight == 0)
            {
                //  Tema Claro/Day

                icon_home.IconColor = Color.Black;
                icon_home.ForeColor = Color.Black;
                icon_home.BackColor = Color.FromArgb(224, 224, 224);

                icon_mouse.IconColor = Color.Black;
                icon_mouse.ForeColor = Color.Black;
                icon_mouse.BackColor = Color.FromArgb(224, 224, 224);

                icon_profile.IconColor = Color.Black;
                icon_profile.ForeColor = Color.Black;
                icon_profile.BackColor = Color.FromArgb(224, 224, 224);

                icon_setting.IconColor = Color.Black;
                icon_setting.ForeColor = Color.Black;
                icon_setting.BackColor = Color.FromArgb(224, 224, 224);

                panel_menu_mouse.BackColor = Color.Silver;

                icon_macro.IconColor = Color.Black;
                icon_macro.ForeColor = Color.Black;
                icon_macro.BackColor = Color.Silver;

                icon_remap.IconColor = Color.Black;
                icon_remap.ForeColor = Color.Black;
                icon_remap.BackColor = Color.Silver;

                icon_dpi.IconColor = Color.Black;
                icon_dpi.ForeColor = Color.Black;
                icon_dpi.BackColor = Color.Silver;

                panel1.BackColor = Color.FromArgb(224, 224, 224);
                panelLogo.BackColor = Color.FromArgb(224, 224, 224);
            }
            if (Master.biblioteca.DayNight == 1)
            {
                //  Tema Escuro/Night

                icon_home.IconColor = Color.White;
                icon_home.ForeColor = Color.White;
                icon_home.BackColor = Color.FromArgb(40, 40, 40);

                icon_mouse.IconColor = Color.White;
                icon_mouse.ForeColor = Color.White;
                icon_mouse.BackColor = Color.FromArgb(40, 40, 40);

                icon_profile.IconColor = Color.White;
                icon_profile.ForeColor = Color.White;
                icon_profile.BackColor = Color.FromArgb(40, 40, 40);

                icon_setting.IconColor = Color.White;
                icon_setting.ForeColor = Color.White;
                icon_setting.BackColor = Color.FromArgb(40, 40, 40);

                panel_menu_mouse.BackColor = Color.FromArgb(50, 50, 50);

                icon_macro.IconColor = Color.White;
                icon_macro.ForeColor = Color.White;
                icon_macro.BackColor = Color.FromArgb(50, 50, 50);

                icon_remap.IconColor = Color.White;
                icon_remap.ForeColor = Color.White;
                icon_remap.BackColor = Color.FromArgb(50, 50, 50);

                icon_dpi.IconColor = Color.White;
                icon_dpi.ForeColor = Color.White;
                icon_dpi.BackColor = Color.FromArgb(50, 50, 50);

                panel1.BackColor = Color.FromArgb(40, 40, 40);
                panelLogo.BackColor = Color.FromArgb(40, 40, 40);

            }


        }

        #endregion

        #region BOTOES DE MENU
        private void icon_home_Click(object sender, EventArgs e)
        {
            Master.biblioteca._formSystem?.MenuSelect(SistemaMenu.Dashboard, icon_home.Text);
        }
        private void icon_home_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void icon_mouse_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
            showSubmenu(panel_menu_mouse);
        }
        private void icon_macro_Click(object sender, EventArgs e)
        {
            Master.biblioteca._formSystem?.MenuSelect(SistemaMenu.Macro, icon_macro.Text);
        }
        private void icon_dpi_Click(object sender, EventArgs e)
        {
            Master.biblioteca._formSystem?.MenuSelect(SistemaMenu.Dpi, icon_dpi.Text);
        }
        private void icon_remap_Click(object sender, EventArgs e)
        {
            Master.biblioteca._formSystem?.MenuSelect(SistemaMenu.Remap, icon_remap.Text);
        }

        private void icon_profile_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void icon_profile_Click(object sender, EventArgs e)
        {
            Master.biblioteca._formSystem?.MenuSelect(SistemaMenu.Profile, icon_profile.Text);
        }
        private void icon_setting_Click(object sender, EventArgs e)
        {
            Master.biblioteca._formSystem?.MenuSelect(SistemaMenu.Settings, icon_setting.Text);
        }
        private void icon_setting_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        #endregion

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _dragging = true;
            _dragCursor = Cursor.Position;
            _dragForm = DockManager.Master.Location;
        }

        private void panelLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging)
                return;

            Point diff = Point.Subtract(Cursor.Position, new Size(_dragCursor));
            DockManager.Master.Location = Point.Add(_dragForm, new Size(diff));
        }

        private void panelLogo_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
