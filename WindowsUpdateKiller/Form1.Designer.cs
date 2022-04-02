namespace WindowsUpdateKiller
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notfication = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.developByLoveMohammadDadashRostamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameMohammadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapurtcomputer30gmailcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notfication
            // 
            this.notfication.ContextMenuStrip = this.menu;
            this.notfication.Icon = ((System.Drawing.Icon)(resources.GetObject("notfication.Icon")));
            this.notfication.Visible = true;
            // 
            // menu
            // 
            this.menu.AllowDrop = true;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeItem,
            this.deactiveItem,
            this.toolStripSeparator1,
            this.developByLoveMohammadDadashRostamiToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(164, 98);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // activeItem
            // 
            this.activeItem.DoubleClickEnabled = true;
            this.activeItem.Name = "activeItem";
            this.activeItem.Size = new System.Drawing.Size(163, 22);
            this.activeItem.Text = "Active Service";
            this.activeItem.Click += new System.EventHandler(this.activeItem_Click);
            // 
            // deactiveItem
            // 
            this.deactiveItem.Name = "deactiveItem";
            this.deactiveItem.Size = new System.Drawing.Size(163, 22);
            this.deactiveItem.Text = "Deactive Service";
            this.deactiveItem.Click += new System.EventHandler(this.deactiveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // developByLoveMohammadDadashRostamiToolStripMenuItem
            // 
            this.developByLoveMohammadDadashRostamiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameMohammadToolStripMenuItem,
            this.sapurtcomputer30gmailcomToolStripMenuItem});
            this.developByLoveMohammadDadashRostamiToolStripMenuItem.Name = "developByLoveMohammadDadashRostamiToolStripMenuItem";
            this.developByLoveMohammadDadashRostamiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.developByLoveMohammadDadashRostamiToolStripMenuItem.Text = "About Developer";
            // 
            // nameMohammadToolStripMenuItem
            // 
            this.nameMohammadToolStripMenuItem.Enabled = false;
            this.nameMohammadToolStripMenuItem.Name = "nameMohammadToolStripMenuItem";
            this.nameMohammadToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.nameMohammadToolStripMenuItem.Text = "Mohammad Dadash Rostami";
            // 
            // sapurtcomputer30gmailcomToolStripMenuItem
            // 
            this.sapurtcomputer30gmailcomToolStripMenuItem.Enabled = false;
            this.sapurtcomputer30gmailcomToolStripMenuItem.Name = "sapurtcomputer30gmailcomToolStripMenuItem";
            this.sapurtcomputer30gmailcomToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.sapurtcomputer30gmailcomToolStripMenuItem.Text = "sapurtcomputer30@gmail.com";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // appTimer
            // 
            this.appTimer.Interval = 500;
            this.appTimer.Tick += new System.EventHandler(this.appTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 68);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notfication;
        private System.Windows.Forms.Timer appTimer;
        private ContextMenuStrip menu;
        private ToolStripMenuItem activeItem;
        private ToolStripMenuItem deactiveItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem developByLoveMohammadDadashRostamiToolStripMenuItem;
        private ToolStripMenuItem nameMohammadToolStripMenuItem;
        private ToolStripMenuItem sapurtcomputer30gmailcomToolStripMenuItem;
    }
}