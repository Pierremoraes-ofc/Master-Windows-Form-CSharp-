using System.Drawing;
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
#pragma region VARIAVEIS
        //  Controle do form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        double opacityForm;             //  controle de opacidade
        int larguraInicial;             //  controle de bordas
        int alturaInicial;              //  controle de bordas

#pragma endregion



#pragma region Config do FORM
        public MasterForm()
        {
            InitializeComponent();
        }
        private void MasterForm_Load(object sender, EventArgs e)
        {
            //  Configurações de idioma
            AppPaths.EnsureDirectories();
            LanguageManager.Load(Master.biblioteca.InputLanguage);
            ApplyLanguage();


            larguraInicial = pic_background.Width;
            alturaInicial = pic_background.Height;
            CentralizarPictureBox();
            SizeForm(Master.biblioteca.MenuSistema);
            
            //  opacidade
            this.Opacity = Master.biblioteca.MasterOpacity;
            trackBar_opacityForm.Value = (int)Math.Round(Master.biblioteca.MasterOpacity * 100);

            //  bordas

            trackBar_border_size.Value = Master.biblioteca.MasterBorderSize;
            SizeBorder(Master.biblioteca.MasterBorderSize);
        }
        private void MasterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void MasterForm_LocationChanged(object sender, EventArgs e)
        {
            foreach (var dock in _formsAbertos.Values)
            {
                SyncPos(dock.Form, dock.OffsetX, dock.OffsetY);
            }

        }
        private void MasterForm_Resize(object sender, EventArgs e)
        {
            foreach (var dock in _formsAbertos.Values)
            {
                if (dock.Form == null || dock.Form.IsDisposed)
                    continue;

                if (this.WindowState == FormWindowState.Minimized)
                    dock.Form.WindowState = FormWindowState.Minimized;
                else if (this.WindowState == FormWindowState.Normal)
                    dock.Form.WindowState = FormWindowState.Normal;
            }
        }
#pragma endregion


#pragma region FUNÇÕES
        private class DockedForm
        {
            public Form Form { get; set; }
            public int OffsetX { get; set; }
            public int OffsetY { get; set; }
        }
        private readonly Dictionary<Type, DockedForm> _formsAbertos = new();
        private T SyncForm<T>(int offsetX = 0, int offsetY = 0)
    where T : Form, new()
        {
            var tipo = typeof(T);

            if (!_formsAbertos.TryGetValue(tipo, out DockedForm dock)
                || dock.Form == null
                || dock.Form.IsDisposed)
            {
                var form = new T();

                dock = new DockedForm
                {
                    Form = form,
                    OffsetX = offsetX,
                    OffsetY = offsetY
                };

                _formsAbertos[tipo] = dock;

                form.FormClosed += (_, __) => _formsAbertos.Remove(tipo);
                form.Show(this);
            }
            else
            {
                dock.Form.Show();
                dock.Form.BringToFront();
            }

            SyncPos(dock.Form, dock.OffsetX, dock.OffsetY);
            return (T)dock.Form;
        }
        private void SyncPos(Form form, int offsetX, int offsetY)
        {
            form.Location = new Point(
                this.Left + offsetX,
                this.Top + offsetY
            );
        }
        void CentralizarPictureBox()
        {
            pic_background.Left = (this.ClientSize.Width - pic_background.Width) / 2;
            pic_background.Top = (this.ClientSize.Height - pic_background.Height) / 2;
        }
        private void RestaurarForm()
        {
            // Master
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            // Dockados
            foreach (var dock in _formsAbertos.Values)
            {
                if (dock.Form == null || dock.Form.IsDisposed)
                    continue;

                dock.Form.Show();
                dock.Form.WindowState = FormWindowState.Normal;
                dock.Form.ShowInTaskbar = false; // ← continuam dependentes do master
            }

            notifyIcon1.Visible = false;
        }
        private void OcultarParaTray()
        {
            // Oculta o master
            this.Hide();
            this.ShowInTaskbar = false;

            // Oculta todos os dockados
            foreach (var dock in _formsAbertos.Values)
            {
                if (dock.Form == null || dock.Form.IsDisposed)
                    continue;

                dock.Form.Hide();
                dock.Form.ShowInTaskbar = false;
            }

            notifyIcon1.Visible = true;
        }
        public void SizeForm(bool collapsed)
        {
            if (collapsed)
            {
                picMiniMenu.Visible = true;
                picMiniMenu.Location = new Point(434, 3);
                picMenu.Visible = false;

                this.Width = 600;

                Master.biblioteca._formMenu?.SizeMenu(true);
            }
            else
            {
                picMiniMenu.Visible = false;
                picMenu.Visible = true;

                this.Width = 800;

                Master.biblioteca._formMenu?.SizeMenu(false);
            }
        }
        private void SizeBorder(int value)
        {
            int novaLargura = larguraInicial - (value * 2); // 1px cada lado
            int novaAltura = alturaInicial - (value * 2); // 1px cima + 1px baixo

            // segurança
            if (novaLargura < 1) novaLargura = 1;
            if (novaAltura < 1) novaAltura = 1;

            pic_background.Size = new Size(novaLargura, novaAltura);

            CentralizarPictureBox(); // mantém centralizado
        }
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

        private void ApplyLanguage()
        {
            toolTip1.SetToolTip(picHide, LanguageManager.Get("rato.tooltip.picHide"));
            label_system_opacity.Text = LanguageManager.Get("rato.tooltip.label_system_opacity");
            label_border_size.Text = LanguageManager.Get("rato.tooltip.label_border_size");
        }

#pragma endregion


#pragma region Opções basica
        private void picFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void picHide_Click(object sender, EventArgs e)
        {
            this.Hide();                 // esconde o form
            this.ShowInTaskbar = false;  // remove da barra de tarefas
            OcultarParaTray();
            notifyIcon1.Visible = true;  // mostra no tray
        }
        private void picMenu_Click(object sender, EventArgs e)
        {
            SizeForm(true);
        }
        private void picMiniMenu_Click(object sender, EventArgs e)
        {
            SizeForm(false);
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurarForm();
        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
#pragma endregion


        private void button4_Click(object sender, EventArgs e)
        {
            //menu.Show();
            Master.biblioteca._formMenu = SyncForm<FormMenu>(12, 8);
            Master.biblioteca.Notification("success", "Sucesso", "Funcionou certinho!!");
            Master.biblioteca.Notification("info", "Info", "Funcionou certinho!!");
            Master.biblioteca.Notification("warning", "Alerta", "Funcionou certinho!!");
            Master.biblioteca.Notification("error", "Erro", "Funcionou certinho!!");
        }
        private void trackBar_opacityForm_Scroll(object sender, EventArgs e)
        {
            double value = trackBar_opacityForm.Value / 100.0;
            opacityForm = value;
            label2.Text = $"{trackBar_opacityForm.Value}%";
            this.Opacity = opacityForm;
        }


















        private void trackBar_border_size_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar_border_size.Value; // 1 a 5
            SizeBorder(valor);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
