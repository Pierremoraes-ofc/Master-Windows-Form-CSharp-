using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BrainerStorm.codes
{
    [DesignerCategory("Code")]
    public class AnimatedGradientPanel : Panel
    {
        private System.Windows.Forms.Timer animationTimer;
        private float offset = 0f;
        private float speed = 0.005f;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorTop { get; set; } = Color.FromArgb(80, 80, 80);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorMiddle { get; set; } = Color.FromArgb(50, 50, 50);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorBottom { get; set; } = Color.FromArgb(30, 30, 30);

        [Category("Appearance")]
        [Description("Velocidade da animação do gradiente")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float AnimationSpeed
        {
            get => speed;
            set => speed = Math.Max(0.001f, value);
        }

        public AnimatedGradientPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            animationTimer = new System.Windows.Forms.Timer
            {
                Interval = 16 // ~60 FPS
            };

            animationTimer.Tick += (s, e) =>
            {
                offset += speed;

                if (offset >= 1f)
                {
                    offset = 0f;

                    // 🔁 ROTACIONA AS CORES
                    RotateColors();
                }

                Invalidate();
            };


            if (!DesignMode)
                animationTimer.Start();
        }
        private void RotateColors()
        {
            Color temp = ColorBottom;
            ColorBottom = ColorMiddle;
            ColorMiddle = ColorTop;
            ColorTop = temp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 🔒 PROTEÇÕES CRÍTICAS
            if (DesignMode)
                return;

            if (Width <= 1 || Height <= 1)
                return;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (var brush = new LinearGradientBrush(rect, ColorTop, ColorBottom, 90f))
            {
                var blend = new ColorBlend
                {
                    Colors = new[] { ColorTop, ColorMiddle, ColorBottom },
                    Positions = new[] { 0f, offset, 1f }
                };

                brush.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                animationTimer?.Stop();
                animationTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
