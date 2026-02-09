using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Master
{
    public static class biblioteca
    {
        public static string    ProjectName = "";                                   //  Nome do meu projeto centralizado!
        public static FormMenu _formMenu;                                           //  usado para salvar as instâncias!
        public static Sistemas _formSystem;                                         //  usado para salvar as instâncias!

        //  Configuração das Notificações:
        public static bool      ToastTopMost = true;                                //  Sobreposição
        public static float     ToastOpacity = 1.0f;                                //  Opacidade
        public static string    ToastPosition = "BottomLeft";                       //  Posição         BottomRight = canto inferior DIREITO / BottomLeft = canto inferior ESQUERDO / TopRight = canto superior direito / TopLeft = canto superior ESQUERDO
        public static int       ToastTimer = 60000;                                 //  Tempo mostrando

        //  Configuração de Idioma
        public static string    InputLanguage = "Portugues-BR";

        //  Configuração do Menu
        public static bool      MenuSistema = false;                                //  false = grande / true = compacto

        //  Configuração do Projeto
        public static float     MasterOpacity = 0.5f;                               //  Opacidade do fundo do Projeto
        public static int       MasterBorderSize = 1;                               //  Largura da borda
        public static Color     borderColor = Color.FromArgb(0, 255, 0);            //  Cor da borda do Form
        public static Color     BackgroundColor = Color.FromArgb(40, 40, 40);       //  Cor da borda do Form
        public static int       MasterBorderRadius = 1;                             //  Curvatura da borda do form
        public static bool      MasterTopLeft = false;                              //  Topo da borda Esquerda curva
        public static bool      MasterTopRight = false;                             //  Topo da borda direita curva
        public static bool      MasterBottomLeft = false;                           //  Base Esquerda curva
        public static bool      MasterBottomRight = false;                          //  Base Direita curva
        public static int       DayNight = 1;                                       //  Tema do Sistema 0 = Claro/Day 1 = Escuro/Night




        // valor padrão
        public static int botoesMouse = 2;

        // constante do Windows
        private const int SM_CMOUSEBUTTONS = 43;

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);

        public static void DetectordeBotoes()
        {
            botoesMouse = GetSystemMetrics(SM_CMOUSEBUTTONS);

            // segurança caso retorne valor inválido
            if (botoesMouse < 1)
                botoesMouse = 2;
        }

        //  Pop-up de Notificações
        public static void Notification(string type, string title, string msg)
        {
            Toast ntfy = new Toast();
            ntfy.Notify(type, title, msg);
        }
        
        //  Controle de Bordas!
        public static RoundedCorners GetSelectedCorners(bool topLeft, bool topRight, bool bottomRight, bool bottomLeft)
        {
            RoundedCorners corners = RoundedCorners.None;

            if (topLeft)
                corners |= RoundedCorners.TopLeft;

            if (topRight)
                corners |= RoundedCorners.TopRight;

            if (bottomRight)
                corners |= RoundedCorners.BottomRight;

            if (bottomLeft)
                corners |= RoundedCorners.BottomLeft;

            return corners;
        }
        public enum RoundedCorners
        {
            None = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomRight = 4,
            BottomLeft = 8,

            All = TopLeft | TopRight | BottomRight | BottomLeft
        }
        public static GraphicsPath GetRoundedPath(Rectangle rect, float radius, RoundedCorners corners)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2;

            // 🔹 Top Left
            if (corners.HasFlag(RoundedCorners.TopLeft))
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            // 🔹 Top
            path.AddLine(
                rect.X + (corners.HasFlag(RoundedCorners.TopLeft) ? radius : 0),
                rect.Y,
                rect.Right - (corners.HasFlag(RoundedCorners.TopRight) ? radius : 0),
                rect.Y);

            // 🔹 Top Right
            if (corners.HasFlag(RoundedCorners.TopRight))
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            else
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);

            // 🔹 Right
            path.AddLine(
                rect.Right,
                rect.Y + (corners.HasFlag(RoundedCorners.TopRight) ? radius : 0),
                rect.Right,
                rect.Bottom - (corners.HasFlag(RoundedCorners.BottomRight) ? radius : 0));

            // 🔹 Bottom Right
            if (corners.HasFlag(RoundedCorners.BottomRight))
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

            // 🔹 Bottom
            path.AddLine(
                rect.Right - (corners.HasFlag(RoundedCorners.BottomRight) ? radius : 0),
                rect.Bottom,
                rect.X + (corners.HasFlag(RoundedCorners.BottomLeft) ? radius : 0),
                rect.Bottom);

            // 🔹 Bottom Left
            if (corners.HasFlag(RoundedCorners.BottomLeft))
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            else
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

            // 🔹 Left
            path.AddLine(
                rect.X,
                rect.Bottom - (corners.HasFlag(RoundedCorners.BottomLeft) ? radius : 0),
                rect.X,
                rect.Y + (corners.HasFlag(RoundedCorners.TopLeft) ? radius : 0));

            path.CloseFigure();
            return path;
        }
        public static void FormRegionAndBorder(Form form, float radius, Graphics g, Color borderColor, float borderSize, RoundedCorners corners)
        {
            if (form.WindowState == FormWindowState.Minimized)
                return;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectRegion = new Rectangle(0, 0, form.Width, form.Height);

            using (GraphicsPath regionPath =
                GetRoundedPath(rectRegion, radius, corners))
            {
                form.Region = new Region(regionPath);
            }

            if (borderSize <= 0)
                return;

            Rectangle rectBorder = new Rectangle(1, 1, form.Width - 2, form.Height - 2);
            float radiusBorder = Math.Max(1, radius - 1);

            using (GraphicsPath borderPath =
                GetRoundedPath(rectBorder, radiusBorder, corners))
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                pen.Alignment = PenAlignment.Inset;
                g.DrawPath(pen, borderPath);
            }
        }

        //  Controle de movimento
        public class DockedForm
        {
            public Form Form { get; set; }
            public int OffsetX { get; set; }
            public int OffsetY { get; set; }
        }
        public static class DockManager
        {
            private static readonly Dictionary<Type, DockedForm> _forms = new();
            public static Form Master { get; private set; }

            public static void SetMaster(Form master)
            {
                Master = master;
            }
            public static void SyncWindowState(FormWindowState state)
            {
                foreach (var dock in _forms.Values)
                {
                    if (dock.Form == null || dock.Form.IsDisposed)
                        continue;

                    dock.Form.WindowState = state;
                }
            }
            public static void ShowAll()
            {
                foreach (var dock in _forms.Values)
                {
                    if (dock.Form == null || dock.Form.IsDisposed)
                        continue;

                    dock.Form.Show();
                    dock.Form.WindowState = FormWindowState.Normal;
                    dock.Form.ShowInTaskbar = false;
                }

                SyncAll();
            }
            public static void HideAll()
            {
                foreach (var dock in _forms.Values)
                {
                    if (dock.Form == null || dock.Form.IsDisposed)
                        continue;

                    dock.Form.Hide();
                    dock.Form.ShowInTaskbar = false;
                }
            }
            public static T Show<T>(int offsetX = 0, int offsetY = 0)
                where T : Form, new()
            {
                if (Master == null)
                    throw new InvalidOperationException("MasterForm não definido.");

                var type = typeof(T);

                if (!_forms.TryGetValue(type, out var dock)
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

                    _forms[type] = dock;

                    form.FormClosed += (_, __) => _forms.Remove(type);
                    form.Show(Master);
                }
                else
                {
                    dock.Form.Show();
                    dock.Form.BringToFront();
                }

                SyncPos(dock);
                return (T)dock.Form;
            }
            public static void UpdateOffset<T>(int offsetX, int offsetY)
                where T : Form
            {
                if (_forms.TryGetValue(typeof(T), out var dock))
                {
                    dock.OffsetX = offsetX;
                    dock.OffsetY = offsetY;
                    SyncPos(dock);
                }
            }
            public static void SyncAll()
            {
                foreach (var dock in _forms.Values)
                    SyncPos(dock);
            }
            private static void SyncPos(DockedForm dock)
            {
                if (dock.Form == null || dock.Form.IsDisposed)
                    return;

                dock.Form.Location = new Point(
                    Master.Left + dock.OffsetX,
                    Master.Top + dock.OffsetY
                );
            }
        }
    }
}
