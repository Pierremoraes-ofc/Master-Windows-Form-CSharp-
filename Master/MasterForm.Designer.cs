namespace Master
{
    partial class MasterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            panelContainer = new Panel();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, fecharToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 48);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Font = new Font("Source Code Pro", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecharToolStripMenuItem.ForeColor = Color.Red;
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(116, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            fecharToolStripMenuItem.Click += fecharToolStripMenuItem_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Source Code Pro", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(518, 206);
            button4.Name = "button4";
            button4.Size = new Size(20, 20);
            button4.TabIndex = 7;
            button4.Text = "+";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelContainer.BackColor = Color.FromArgb(40, 40, 40);
            panelContainer.Location = new Point(12, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(35, 430);
            panelContainer.TabIndex = 8;
            panelContainer.Visible = false;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(panelContainer);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MasterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MasterForm_Load;
            LocationChanged += MasterForm_LocationChanged;
            Paint += MasterForm_Paint;
            MouseDown += MasterForm_MouseDown;
            MouseMove += MasterForm_MouseMove;
            MouseUp += MasterForm_MouseUp;
            Resize += MasterForm_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private Button button4;
        private Panel panelContainer;
        private ToolTip toolTip1;
    }
}
