using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace BrainerStorm.codes
{
    [DesignerCategory("Code")]
    public class SwirlGradientPanel : Panel
    {
        private Timer timer;
        private float angle = 0f;
        private float speed = 0.8f;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CenterColor { get; set; } = Color.FromArgb(80, 120, 255);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color MiddleColor { get; set; } = Color.FromArgb(80, 255, 180);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color EdgeColor { get; set; } = Color.FromArgb(255, 200, 80);

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float RotationSpeed
        {
            get => speed;
            set => speed = Math.Max(0.1f, value);
        }

        public SwirlGradientPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            timer = new Timer();
            timer.Interval = 16; // ~60 FPS
            timer.Tick += (s, e) =>
            {
                angle += speed;
                if (angle >= 360f) angle = 0f;
                Invalidate();
            };

            if (!DesignMode)
                timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);

                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterPoint = new PointF(rect.Width / 2f, rect.Height / 2f);
                    brush.CenterColor = CenterColor;
                    brush.SurroundColors = new[] { EdgeColor };

                    // 🔁 mistura intermediária
                    brush.InterpolationColors = new ColorBlend
                    {
                        Colors = new[]
                        {
                            CenterColor,
                            MiddleColor,
                            EdgeColor
                        },
                        Positions = new[] { 0f, 0.5f, 1f }
                    };

                    // 🌪️ transformação de rotação (efeito furacão)
                    Matrix m = new Matrix();
                    m.RotateAt(angle, brush.CenterPoint);
                    brush.Transform = m;

                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }
    }
}
