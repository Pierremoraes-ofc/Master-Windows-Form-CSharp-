using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Master.MouseSystem;

public class MouseOverlay : Form
{
    private System.Windows.Forms.Timer timer;

    private MouseDevice mouse;

    private bool left;
    private bool right;
    private bool middle;
    private bool x1;
    private bool x2;

    public MouseOverlay()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.Manual;
        this.ShowInTaskbar = false;
        this.TopMost = true;

        this.BackColor = Color.Black;
        this.ForeColor = Color.White;
        this.Opacity = 0.85;

        this.Width = 260;
        this.Height = 140;

        DetectMouse();

        timer = new System.Windows.Forms.Timer();
        timer.Interval = 16;
        timer.Tick += UpdatePosition;
        timer.Start();
    }

    private void DetectMouse()
    {
        var mice = MouseDetector.GetMice();

        if (mice.Count > 0)
        {
            mouse = mice.First();
        }
    }

    private void UpdatePosition(object sender, EventArgs e)
    {
        var pos = Cursor.Position;

        this.Location = new Point(pos.X + 20, pos.Y + 20);

        left = (Control.MouseButtons & MouseButtons.Left) != 0;
        right = (Control.MouseButtons & MouseButtons.Right) != 0;
        middle = (Control.MouseButtons & MouseButtons.Middle) != 0;
        x1 = (Control.MouseButtons & MouseButtons.XButton1) != 0;
        x2 = (Control.MouseButtons & MouseButtons.XButton2) != 0;

        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var pos = Cursor.Position;

        string name = mouse?.Name ?? "Unknown";
        string vid = mouse?.VID ?? "----";
        string pid = mouse?.PID ?? "----";

        string buttons =
            $"{(left ? "Left Buttom " : "")}" +
            $"{(right ? "Right Buttom " : "")}" +
            $"{(middle ? "Middle Buttom " : "")}" +
            $"{(x1 ? "X Button Down " : "")}" +
            $"{(x2 ? "X Button Up " : "")}";

        if (buttons == "")
            buttons = "None";

        int totalButtons =
            3 +                      // L R M
            (mouse != null ? 2 : 0); // X1 X2 estimado

        string text =
$@"Mouse Info
Name: {name}
VID: {vid}  PID: {pid}
Pos: {pos.X}, {pos.Y}
Buttons Pressed: {buttons}
Supported Buttons: {totalButtons}";

        e.Graphics.DrawString(
            text,
            this.Font,
            Brushes.White,
            10,
            10);
    }
}
/*
 

a ideia seria basicamente verificar quantos botoes tem o mouse e se tiver 2 botoes aparece no menu os botoes disponivel e entao iria ter dentro do botao Left Buttom todos esses menus:
Mouse Button = remap (teclas do mouse)
Key = muda para teclas do teclado
Key combination = sequencia de teclas teclado e mouse
edit command = copiar, colar, cortar, imprimir, etc
Media control =  play, pause, etc
Actions = minimizar, maximixar, mostrar desktop, fechar aplicaçao, etc
Mouse Pointer = nao entendi muito bem oque faz
Open = Abrir aplicativos como navegador, programas, pastas, arquivos, sites, etc
Disable = desativa o botao
Experimental = aplicaçao atual minimiza, maximiza, etc
Default = torna a funçao original


✔  DPI Control
❌ Mouse Button Remap (podemos manter para remapear tanto mudar para teclas do mouse quanto para do teclado)
❌ Key combination (sequencia de teclas teclado e mouse)
❌ Edit command (copiar, colar, cortar, imprimir, etc) e vamos colocar junto tambem (aplicaçao atual minimiza, maximiza, etc)
❌ Media control (play, pause, etc)
❌ Actions (minimizar, maximixar, mostrar desktop, fechar aplicaçao, etc)
❌ Open (Abrir aplicativos como navegador, programas, pastas, arquivos, sites, etc)
❌ Disable (desativa o botao)
❌ Default (torna a funçao original)



ta nao vamos fazer isso agora! vamos fazer a funçao Mouse Button Remap (podemos manter para remapear tanto mudar para teclas do mouse quanto para do teclado) criei o arquivo MouseButtonRemap.cs com ele criado poderemos fazer: a mudança dos botoes remapear uma tecla do mouse para outra do mouse ou até do teclado e vamos deixar ele para que possamos ate fazer fazer funções de key combination que seria combinação de teclas por exemplo ao clicar com botao direito do mouse executar ctrl+alt+dell!
 */