using Master.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master
{
    public partial class Toast : Form
    {
        private Point targetLocation;
        private int animationSpeed = 20;
        int toastX, toastY;
        int toastDuration = Master.biblioteca.ToastTimer;
        int elapsedTime = 0;
        private Toast.enmAction action;
        //public ToastPosition Position { get; set; } = ToastPosition.BottomRight_Up;
        //string Position = "BottomLeft";
        public Toast()
        {
            InitializeComponent();
        }

        private void Toast_Load(object sender, EventArgs e)
        {
            label_description.Parent = gradientPanel1;
            label_description.BackColor = Color.Transparent;

            label_title.Parent = gradientPanel1;
            label_title.BackColor = Color.Transparent;

            pic_info.Parent = gradientPanel1;
            pic_info.BackColor = Color.Transparent;

            this.Opacity = Master.biblioteca.ToastOpacity;
            this.TopMost = Master.biblioteca.ToastTopMost;


        }
        public enum enmAction
        {
            wait,
            start,
            close
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 15;

                    elapsedTime += timer1.Interval;

                    float progress = (float)elapsedTime / toastDuration;
                    panelProgressFill.Width = (int)(panelProgressBg.Width * progress);

                    if (elapsedTime >= toastDuration)
                    {
                        action = enmAction.close;
                    }
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;

                    int dx = targetLocation.X - this.Left;

                    if (Math.Abs(dx) > animationSpeed)
                        this.Left += Math.Sign(dx) * animationSpeed;
                    else
                        this.Left = targetLocation.X;

                    if (this.Left == targetLocation.X && this.Opacity >= 1)
                    {
                        this.Opacity = 1;
                        action = enmAction.wait;
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    if (this.Opacity <= 0.0)
                    {
                        this.Opacity = 0.0;
                        base.Close();
                    }
                    break;
            }
        }

        private Point GetStartPosition(Point final)
        {
            var work = Screen.PrimaryScreen.WorkingArea;

            return Master.biblioteca.ToastPosition switch
            {
                "BottomRight" => new Point(work.Right, final.Y),
                "TopRight" => new Point(work.Right, final.Y),

                "BottomLeft" => new Point(-this.Width, final.Y),
                "TopLeft" => new Point(-this.Width, final.Y),

                _ => final
            };
        }

        private Point CalculateToastPosition(int index)
        {
            var work = Screen.PrimaryScreen.WorkingArea;
            int margin = 10;

            int x = 0;
            int y = 0;

            switch (Master.biblioteca.ToastPosition)
            {
                case "BottomRight":
                    x = work.Right - this.Width - margin;
                    y = work.Bottom - this.Height - (this.Height + 5) * index;
                    break;

                case "BottomLeft":
                    x = work.Left + margin;
                    y = work.Bottom - this.Height - (this.Height + 5) * index;
                    break;

                case "TopRight":
                    x = work.Right - this.Width - margin;
                    y = work.Top + (this.Height + 5) * index;
                    break;

                case "TopLeft":
                    x = work.Left + margin;
                    y = work.Top + (this.Height + 5) * index;
                    break;
            }

            return new Point(x, y);
        }
        public void Notify(string type, string title, string msg)
        {
            this.Opacity = 0;
            this.StartPosition = FormStartPosition.Manual;

            for (int i = 0; i < 20; i++)
            {
                string fname = "alert" + i;
                if (Application.OpenForms[fname] == null)
                {
                    this.Name = fname;

                    // posição FINAL (onde o toast deve parar)
                    targetLocation = CalculateToastPosition(i);

                    // posição INICIAL (fora da tela)
                    this.Location = GetStartPosition( targetLocation);

                    break;
                }
            }

            switch (type)
            {
                case "success":
                    pic_info.Image = Resources.success;
                    gradientPanel1.ColorBottom = Color.FromArgb(8, 156, 56);
                    panelProgressFill.BackColor = Color.FromArgb(8, 156, 56);
                    break;

                case "error":
                    pic_info.Image = Resources.error;
                    gradientPanel1.ColorBottom = Color.FromArgb(255, 8, 8);
                    panelProgressFill.BackColor = Color.FromArgb(255, 8, 8);
                    break;

                case "info":
                    pic_info.Image = Resources.info;
                    gradientPanel1.ColorBottom = Color.FromArgb(39, 154, 243);
                    panelProgressFill.BackColor = Color.FromArgb(39, 154, 243);
                    break;

                case "warning":
                    pic_info.Image = Resources.warning;
                    gradientPanel1.ColorBottom = Color.FromArgb(255, 195, 14);
                    panelProgressFill.BackColor = Color.FromArgb(255, 195, 14);
                    break;
            }

            // tempo do toast
            toastDuration = Master.biblioteca.ToastTimer;
            elapsedTime = 0;
            panelProgressFill.Width = 0;

            label_title.Text = title;
            label_description.Text = msg;

            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }


        private void Toast_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
        private void label_description_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
        private void label_title_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
        private void pic_info_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
        private void gradientPanel1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
    }
}
