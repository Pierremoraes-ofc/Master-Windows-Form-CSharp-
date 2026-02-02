using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Master.biblioteca;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master
{
    public partial class MasterForm : Form
    {
        #region VARIAVEIS

        public static MasterForm FormMaster { get; private set; }

        //  Controle do form
        private bool _dragging = false;
        private Point _dragCursor;
        private Point _dragForm;

        #endregion


        #region Config do FORM

        private void MasterForm_Paint(object sender, PaintEventArgs e)
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

            //Master.biblioteca.FormRegionAndBorder(this, Master.biblioteca.MasterBorderRadius, e.Graphics, borderColor, Master.biblioteca.MasterBorderSize, RoundedCorners.TopRight | RoundedCorners.BottomLeft);
        }
        public MasterForm()
        {
            InitializeComponent();
            FormMaster = this;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(Master.biblioteca.MasterBorderSize);

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private void MasterForm_Load(object sender, EventArgs e)
        {
            //  Configurações de idioma
            AppPaths.EnsureDirectories();
            LanguageManager.Load(Master.biblioteca.InputLanguage);
            Language();


            SizeForm(Master.biblioteca.MenuSistema);


            DockManager.SetMaster(this);

        }

        //  Movimentação do Form
        private void MasterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _dragging = true;
            _dragCursor = Cursor.Position;
            _dragForm = DockManager.Master.Location;
        }
        private void MasterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging)
                return;

            Point diff = Point.Subtract(Cursor.Position, new Size(_dragCursor));
            DockManager.Master.Location = Point.Add(_dragForm, new Size(diff));
        }
        private void MasterForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void MasterForm_LocationChanged(object sender, EventArgs e)
        {
            DockManager.SyncAll();
        }
        private void MasterForm_Resize(object sender, EventArgs e)
        {
            DockManager.SyncWindowState(this.WindowState);
        }
        #endregion


        #region FUNÇÕES

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            DockManager.SyncAll();
        }
        public void RestaurarForm()
        {
            // Master
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            DockManager.ShowAll();

            notifyIcon1.Visible = false;
        }
        public void OcultarParaTray()
        {
            // Oculta o master
            this.Hide();
            this.ShowInTaskbar = false;

            DockManager.HideAll();

            notifyIcon1.Visible = true;
        }
        public void SizeForm(bool collapsed)
        {
            this.Width = collapsed ? 600 : 800;

            Master.biblioteca._formMenu?.SizeMenu(collapsed);

            DockManager.UpdateOffset<Sistemas>(
                collapsed ? 70 : 270,
                8
            );

            SyncDesin();
            this.Invalidate();
        }
        public void SyncDesin()
        {
            Language();
            this.Opacity = Master.biblioteca.MasterOpacity;
            this.BackColor = Master.biblioteca.BackgroundColor;
            this.Padding = new Padding(Master.biblioteca.MasterBorderSize); // importante!
            this.Invalidate();                      // 🔁 redesenha


            //  parametros de Menu
            if (Master.biblioteca._formMenu != null && !Master.biblioteca._formMenu.IsDisposed)
            {
                Master.biblioteca._formMenu?.Cfg_Style();
                Master.biblioteca._formMenu.Invalidate();
            }
            //  parametros de Sistemas
            if (Master.biblioteca._formSystem != null && !Master.biblioteca._formSystem.IsDisposed)
            {
                Master.biblioteca._formSystem?.Cfg_Style();
                Master.biblioteca._formSystem.Invalidate();
            }
        }

        #endregion


        #region SISTEMA DE IDIOMA

        public void ApplyLanguageAll()
        {
            Language();

            Master.biblioteca._formMenu?.Language();
            Master.biblioteca._formSystem?.Language();
        }
        private void Language()
        {
        }

        #endregion


        #region OPÇOES DO MENU STRIP 
        //  MenuStrip Menu simples que fica quando o Form fica oculto no Tray!

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurarForm();
        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        //  Botao para teste!
        private void button4_Click(object sender, EventArgs e)
        {
            //  Teste dos Forms!
            Master.biblioteca._formMenu = DockManager.Show<FormMenu>(12, 8);
            Master.biblioteca._formSystem = DockManager.Show<Sistemas>(270, 8);

            //  Teste Dos Notfys!
            Master.biblioteca.Notification("success", "Sucesso", "Funcionou certinho!!");
            Master.biblioteca.Notification("info", "Info", "Funcionou certinho!!");
            Master.biblioteca.Notification("warning", "Alerta", "Funcionou certinho!!");
            Master.biblioteca.Notification("error", "Erro", "Funcionou certinho!!");
        }

    }
}
