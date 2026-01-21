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
        private Color _colorBottom = Color.FromArgb(30, 30, 30);
        private float _angle = 90f;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Cor superior do gradiente")]
        [DefaultValue(typeof(Color), "60, 60, 60")]
        public Color ColorTop
        {
            get => _colorTop;
            set
            {
                _colorTop = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Cor inferior do gradiente")]
        [DefaultValue(typeof(Color), "30, 30, 30")]
        public Color ColorBottom
        {
            get => _colorBottom;
            set
            {
                _colorBottom = value;
                Invalidate();
            }
        }

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

        public GradientPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using var brush = new LinearGradientBrush(
                ClientRectangle,
                ColorTop,
                ColorBottom,
                Angle
            );

            e.Graphics.FillRectangle(brush, ClientRectangle);
        }
    }
}
