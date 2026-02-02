using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BrainerStorm.codes
{
    [DesignerCategory("Code")]
    public class GradientPanel : Panel
    {
        private Color _colorTop = Color.FromArgb(60, 60, 60);
        private Color _colorMiddle = Color.FromArgb(45, 45, 45);
        private Color _colorBottom = Color.FromArgb(30, 30, 30);
        private float _angle = 90f;

        public GradientPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        // 🔹 COR INICIAL
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Cor inicial do gradiente")]
        public Color ColorTop
        {
            get => _colorTop;
            set
            {
                _colorTop = value;
                Invalidate();
            }
        }

        // 🔹 COR DO MEIO
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Cor do meio do gradiente")]
        public Color ColorMiddle
        {
            get => _colorMiddle;
            set
            {
                _colorMiddle = value;
                Invalidate();
            }
        }

        // 🔹 COR FINAL
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Cor final do gradiente")]
        public Color ColorBottom
        {
            get => _colorBottom;
            set
            {
                _colorBottom = value;
                Invalidate();
            }
        }

        // 🔹 ÂNGULO
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Ângulo do gradiente")]
        [DefaultValue(90f)]
        public float Angle
        {
            get => _angle;
            set
            {
                _angle = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using var brush = new LinearGradientBrush(
                ClientRectangle,
                ColorTop,
                ColorBottom,
                Angle
            );

            // 🎨 GRADIENTE COM 3 CORES
            brush.InterpolationColors = new ColorBlend
            {
                Colors = new[]
                {
                    ColorTop,
                    ColorMiddle,
                    ColorBottom
                },
                Positions = new[]
                {
                    0f,    // início
                    0.5f,  // meio
                    1f     // fim
                }
            };

            e.Graphics.FillRectangle(brush, ClientRectangle);
        }
    }
}
