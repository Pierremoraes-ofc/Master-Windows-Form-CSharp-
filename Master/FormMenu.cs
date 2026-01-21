using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Master
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            SizeMenu(Master.biblioteca.MenuSistema);
        }

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
            this.Width = collapsed ? 40 : 234;
        }

        //  Teste
        private void button4_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
        }




        private void button1_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
            showSubmenu(panel_menu_mouse);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
