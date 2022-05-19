namespace StanleySaveEditor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.jsonTree = new System.Windows.Forms.TreeView();
            this.propsView = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelsMacGameInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsGaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Parallels_PopUp = new System.Windows.Forms.Panel();
            this.Confirm = new System.Windows.Forms.Button();
            this.confirm_richtextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Parallels_PopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.jsonTree);
            this.splitContainer1.Panel1MinSize = 256;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propsView);
            this.splitContainer1.Size = new System.Drawing.Size(1380, 764);
            this.splitContainer1.SplitterDistance = 593;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.splitContainer1_KeyDown);
            // 
            // jsonTree
            // 
            this.jsonTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jsonTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonTree.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonTree.Location = new System.Drawing.Point(0, 0);
            this.jsonTree.Margin = new System.Windows.Forms.Padding(6);
            this.jsonTree.Name = "jsonTree";
            this.jsonTree.Size = new System.Drawing.Size(593, 764);
            this.jsonTree.TabIndex = 0;
            this.jsonTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.jsonTree_AfterSelect);
            this.jsonTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jsonTree_KeyDown);
            // 
            // propsView
            // 
            this.propsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propsView.Location = new System.Drawing.Point(0, 0);
            this.propsView.Margin = new System.Windows.Forms.Padding(6);
            this.propsView.Name = "propsView";
            this.propsView.Size = new System.Drawing.Size(779, 764);
            this.propsView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1380, 40);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parallelsMacGameInstallToolStripMenuItem,
            this.windowsGaToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // parallelsMacGameInstallToolStripMenuItem
            // 
            this.parallelsMacGameInstallToolStripMenuItem.Name = "parallelsMacGameInstallToolStripMenuItem";
            this.parallelsMacGameInstallToolStripMenuItem.Size = new System.Drawing.Size(517, 44);
            this.parallelsMacGameInstallToolStripMenuItem.Text = "MacOS Install (Read from Parallels)";
            this.parallelsMacGameInstallToolStripMenuItem.Click += new System.EventHandler(this.parallelsMacGameInstallToolStripMenuItem_Click);
            // 
            // windowsGaToolStripMenuItem
            // 
            this.windowsGaToolStripMenuItem.Name = "windowsGaToolStripMenuItem";
            this.windowsGaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.windowsGaToolStripMenuItem.Size = new System.Drawing.Size(517, 44);
            this.windowsGaToolStripMenuItem.Text = "Windows Install";
            this.windowsGaToolStripMenuItem.Click += new System.EventHandler(this.windowsGaToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(277, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Parallels_PopUp
            // 
            this.Parallels_PopUp.BackColor = System.Drawing.SystemColors.Window;
            this.Parallels_PopUp.Controls.Add(this.Confirm);
            this.Parallels_PopUp.Controls.Add(this.confirm_richtextbox);
            this.Parallels_PopUp.Location = new System.Drawing.Point(0, 43);
            this.Parallels_PopUp.Name = "Parallels_PopUp";
            this.Parallels_PopUp.Size = new System.Drawing.Size(1380, 761);
            this.Parallels_PopUp.TabIndex = 1;
            this.Parallels_PopUp.Visible = false;
            // 
            // Confirm
            // 
            this.Confirm.ForeColor = System.Drawing.Color.Black;
            this.Confirm.Location = new System.Drawing.Point(432, 643);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(501, 73);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // confirm_richtextbox
            // 
            this.confirm_richtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_richtextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.confirm_richtextbox.Font = new System.Drawing.Font("Segoe UI", 7.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_richtextbox.ForeColor = System.Drawing.Color.Black;
            this.confirm_richtextbox.Location = new System.Drawing.Point(333, 204);
            this.confirm_richtextbox.Name = "confirm_richtextbox";
            this.confirm_richtextbox.Size = new System.Drawing.Size(679, 227);
            this.confirm_richtextbox.TabIndex = 1;
            this.confirm_richtextbox.Text = resources.GetString("confirm_richtextbox.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1380, 804);
            this.Controls.Add(this.Parallels_PopUp);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanley Parable Ultra Deluxe Save File Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Parallels_PopUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView jsonTree;
        private System.Windows.Forms.PropertyGrid propsView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parallelsMacGameInstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsGaToolStripMenuItem;
        private System.Windows.Forms.Panel Parallels_PopUp;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.RichTextBox confirm_richtextbox;
    }
}

