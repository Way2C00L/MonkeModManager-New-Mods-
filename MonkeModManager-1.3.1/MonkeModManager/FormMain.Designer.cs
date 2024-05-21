﻿namespace MonkeModManager
{
    partial class FormMainBG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainBG));
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonModInfo = new System.Windows.Forms.Button();
            this.buttonToggleMods = new System.Windows.Forms.Button();
            this.Utilities = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUninstallAll = new System.Windows.Forms.Button();
            this.buttonBackupMods = new System.Windows.Forms.Button();
            this.buttonBackupCosmetics = new System.Windows.Forms.Button();
            this.buttonRestoreCosmetics = new System.Windows.Forms.Button();
            this.buttonRestoreMods = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.custom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dark = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.buttonDiscordLink = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBepInEx = new System.Windows.Forms.Button();
            this.buttonOpenConfig = new System.Windows.Forms.Button();
            this.buttonOpenGameFolder = new System.Windows.Forms.Button();
            this.labelOpen = new System.Windows.Forms.Label();
            this.Plugins = new System.Windows.Forms.TabPage();
            this.listViewMods = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.contextMenuStripMain.SuspendLayout();
            this.Utilities.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Plugins.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Location = new System.Drawing.Point(10, 25);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(508, 22);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolderBrowser.Location = new System.Drawing.Point(524, 25);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(26, 23);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "..";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gorilla Tag Folder Path:";
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.Enabled = false;
            this.buttonInstall.Location = new System.Drawing.Point(440, 341);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(112, 23);
            this.buttonInstall.TabIndex = 4;
            this.buttonInstall.Text = "Install / Update";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 346);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: Null";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(124, 26);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            this.viewInfoToolStripMenuItem.Click += new System.EventHandler(this.viewInfoToolStripMenuItem_Click);
            // 
            // buttonModInfo
            // 
            this.buttonModInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModInfo.Enabled = false;
            this.buttonModInfo.Location = new System.Drawing.Point(322, 341);
            this.buttonModInfo.Name = "buttonModInfo";
            this.buttonModInfo.Size = new System.Drawing.Size(112, 23);
            this.buttonModInfo.TabIndex = 9;
            this.buttonModInfo.Text = "View Mod Info";
            this.buttonModInfo.UseVisualStyleBackColor = true;
            this.buttonModInfo.Click += new System.EventHandler(this.buttonModInfo_Click);
            // 
            // buttonToggleMods
            // 
            this.buttonToggleMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToggleMods.Enabled = false;
            this.buttonToggleMods.Location = new System.Drawing.Point(204, 341);
            this.buttonToggleMods.Name = "buttonToggleMods";
            this.buttonToggleMods.Size = new System.Drawing.Size(112, 23);
            this.buttonToggleMods.TabIndex = 10;
            this.buttonToggleMods.Text = "Disable Mods";
            this.buttonToggleMods.UseVisualStyleBackColor = true;
            this.buttonToggleMods.Click += new System.EventHandler(this.buttonToggleMods_Click);
            // 
            // Utilities
            // 
            this.Utilities.Controls.Add(this.groupBox3);
            this.Utilities.Controls.Add(this.groupBox2);
            this.Utilities.Controls.Add(this.buttonDiscordLink);
            this.Utilities.Controls.Add(this.groupBox1);
            this.Utilities.Location = new System.Drawing.Point(4, 22);
            this.Utilities.Name = "Utilities";
            this.Utilities.Size = new System.Drawing.Size(536, 256);
            this.Utilities.TabIndex = 1;
            this.Utilities.Text = "Utilities";
            this.Utilities.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonUninstallAll);
            this.groupBox3.Controls.Add(this.buttonBackupMods);
            this.groupBox3.Controls.Add(this.buttonBackupCosmetics);
            this.groupBox3.Controls.Add(this.buttonRestoreCosmetics);
            this.groupBox3.Controls.Add(this.buttonRestoreMods);
            this.groupBox3.Location = new System.Drawing.Point(12, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 210);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Managing Mods";
            // 
            // buttonUninstallAll
            // 
            this.buttonUninstallAll.Location = new System.Drawing.Point(6, 35);
            this.buttonUninstallAll.Name = "buttonUninstallAll";
            this.buttonUninstallAll.Size = new System.Drawing.Size(132, 23);
            this.buttonUninstallAll.TabIndex = 0;
            this.buttonUninstallAll.Text = "Uninstall All Mods";
            this.buttonUninstallAll.UseVisualStyleBackColor = true;
            this.buttonUninstallAll.Click += new System.EventHandler(this.buttonUninstallAll_Click);
            // 
            // buttonBackupMods
            // 
            this.buttonBackupMods.Location = new System.Drawing.Point(6, 64);
            this.buttonBackupMods.Name = "buttonBackupMods";
            this.buttonBackupMods.Size = new System.Drawing.Size(132, 23);
            this.buttonBackupMods.TabIndex = 1;
            this.buttonBackupMods.Text = "Backup Mods Folder";
            this.buttonBackupMods.UseVisualStyleBackColor = true;
            this.buttonBackupMods.Click += new System.EventHandler(this.buttonBackupMods_Click);
            // 
            // buttonBackupCosmetics
            // 
            this.buttonBackupCosmetics.Location = new System.Drawing.Point(6, 93);
            this.buttonBackupCosmetics.Name = "buttonBackupCosmetics";
            this.buttonBackupCosmetics.Size = new System.Drawing.Size(132, 23);
            this.buttonBackupCosmetics.TabIndex = 2;
            this.buttonBackupCosmetics.Text = "Backup Cosmetics";
            this.buttonBackupCosmetics.UseVisualStyleBackColor = true;
            this.buttonBackupCosmetics.Click += new System.EventHandler(this.buttonBackupCosmetics_Click);
            // 
            // buttonRestoreCosmetics
            // 
            this.buttonRestoreCosmetics.Location = new System.Drawing.Point(6, 165);
            this.buttonRestoreCosmetics.Name = "buttonRestoreCosmetics";
            this.buttonRestoreCosmetics.Size = new System.Drawing.Size(132, 37);
            this.buttonRestoreCosmetics.TabIndex = 4;
            this.buttonRestoreCosmetics.Text = "Restore Cosmetics from Backup";
            this.buttonRestoreCosmetics.UseVisualStyleBackColor = true;
            this.buttonRestoreCosmetics.Click += new System.EventHandler(this.buttonRestoreCosmetics_Click);
            // 
            // buttonRestoreMods
            // 
            this.buttonRestoreMods.Location = new System.Drawing.Point(6, 122);
            this.buttonRestoreMods.Name = "buttonRestoreMods";
            this.buttonRestoreMods.Size = new System.Drawing.Size(132, 37);
            this.buttonRestoreMods.TabIndex = 3;
            this.buttonRestoreMods.Text = "Restore Mods from Backup";
            this.buttonRestoreMods.UseVisualStyleBackColor = true;
            this.buttonRestoreMods.Click += new System.EventHandler(this.buttonRestoreMods_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.custom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dark);
            this.groupBox2.Controls.Add(this.white);
            this.groupBox2.Location = new System.Drawing.Point(190, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 130);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // custom
            // 
            this.custom.BackColor = System.Drawing.SystemColors.Menu;
            this.custom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.custom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom.ForeColor = System.Drawing.SystemColors.InfoText;
            this.custom.Location = new System.Drawing.Point(6, 101);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(134, 23);
            this.custom.TabIndex = 12;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = false;
            this.custom.Click += new System.EventHandler(this.custom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "App Theme";
            // 
            // dark
            // 
            this.dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.dark.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dark.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dark.ForeColor = System.Drawing.Color.White;
            this.dark.Location = new System.Drawing.Point(6, 40);
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(134, 28);
            this.dark.TabIndex = 11;
            this.dark.Text = "Dark";
            this.dark.UseVisualStyleBackColor = false;
            this.dark.Click += new System.EventHandler(this.dark_Click);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.SystemColors.Menu;
            this.white.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.white.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.white.ForeColor = System.Drawing.SystemColors.InfoText;
            this.white.Location = new System.Drawing.Point(6, 72);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(134, 23);
            this.white.TabIndex = 10;
            this.white.Text = "White";
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // buttonDiscordLink
            // 
            this.buttonDiscordLink.Location = new System.Drawing.Point(379, 153);
            this.buttonDiscordLink.Name = "buttonDiscordLink";
            this.buttonDiscordLink.Size = new System.Drawing.Size(134, 23);
            this.buttonDiscordLink.TabIndex = 8;
            this.buttonDiscordLink.Text = "Join the Discord!";
            this.buttonDiscordLink.UseVisualStyleBackColor = true;
            this.buttonDiscordLink.Click += new System.EventHandler(this.buttonDiscordLink_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBepInEx);
            this.groupBox1.Controls.Add(this.buttonOpenConfig);
            this.groupBox1.Controls.Add(this.buttonOpenGameFolder);
            this.groupBox1.Controls.Add(this.labelOpen);
            this.groupBox1.Location = new System.Drawing.Point(373, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonBepInEx
            // 
            this.buttonBepInEx.Location = new System.Drawing.Point(6, 96);
            this.buttonBepInEx.Name = "buttonBepInEx";
            this.buttonBepInEx.Size = new System.Drawing.Size(134, 23);
            this.buttonBepInEx.TabIndex = 5;
            this.buttonBepInEx.Text = "BepInEx Folder";
            this.buttonBepInEx.UseVisualStyleBackColor = true;
            this.buttonBepInEx.Click += new System.EventHandler(this.buttonOpenBepInExFolder_Click);
            // 
            // buttonOpenConfig
            // 
            this.buttonOpenConfig.Location = new System.Drawing.Point(6, 67);
            this.buttonOpenConfig.Name = "buttonOpenConfig";
            this.buttonOpenConfig.Size = new System.Drawing.Size(134, 23);
            this.buttonOpenConfig.TabIndex = 5;
            this.buttonOpenConfig.Text = "Config Folder";
            this.buttonOpenConfig.UseVisualStyleBackColor = true;
            this.buttonOpenConfig.Click += new System.EventHandler(this.buttonOpenConfigFolder_Click);
            // 
            // buttonOpenGameFolder
            // 
            this.buttonOpenGameFolder.Location = new System.Drawing.Point(6, 38);
            this.buttonOpenGameFolder.Name = "buttonOpenGameFolder";
            this.buttonOpenGameFolder.Size = new System.Drawing.Size(134, 23);
            this.buttonOpenGameFolder.TabIndex = 5;
            this.buttonOpenGameFolder.Text = "Game Folder";
            this.buttonOpenGameFolder.UseVisualStyleBackColor = true;
            this.buttonOpenGameFolder.Click += new System.EventHandler(this.buttonOpenGameFolder_Click);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Location = new System.Drawing.Point(23, 15);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(99, 13);
            this.labelOpen.TabIndex = 6;
            this.labelOpen.Text = "Important Folders";
            // 
            // Plugins
            // 
            this.Plugins.Controls.Add(this.listViewMods);
            this.Plugins.Location = new System.Drawing.Point(4, 22);
            this.Plugins.Name = "Plugins";
            this.Plugins.Padding = new System.Windows.Forms.Padding(3);
            this.Plugins.Size = new System.Drawing.Size(536, 256);
            this.Plugins.TabIndex = 0;
            this.Plugins.Text = "Plugins";
            this.Plugins.UseVisualStyleBackColor = true;
            // 
            // listViewMods
            // 
            this.listViewMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMods.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAuthor});
            this.listViewMods.ContextMenuStrip = this.contextMenuStripMain;
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.HideSelection = false;
            this.listViewMods.Location = new System.Drawing.Point(6, 6);
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(524, 244);
            this.listViewMods.TabIndex = 0;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            this.listViewMods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMods_ItemChecked);
            this.listViewMods.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMods_ItemSelectionChanged);
            this.listViewMods.DoubleClick += new System.EventHandler(this.listViewMods_DoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 321;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 162;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.Plugins);
            this.tabControlMain.Controls.Add(this.Utilities);
            this.tabControlMain.Enabled = false;
            this.tabControlMain.Location = new System.Drawing.Point(10, 53);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(544, 282);
            this.tabControlMain.TabIndex = 8;
            // 
            // FormMainBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(566, 376);
            this.Controls.Add(this.buttonToggleMods);
            this.Controls.Add(this.buttonModInfo);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.textBoxDirectory);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainBG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monke Mod Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.Utilities.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Plugins.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonModInfo;
        private System.Windows.Forms.Button buttonToggleMods;
        private System.Windows.Forms.TabPage Utilities;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button custom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dark;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.Button buttonDiscordLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBepInEx;
        private System.Windows.Forms.Button buttonOpenConfig;
        private System.Windows.Forms.Button buttonOpenGameFolder;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Button buttonRestoreCosmetics;
        private System.Windows.Forms.Button buttonRestoreMods;
        private System.Windows.Forms.Button buttonBackupCosmetics;
        private System.Windows.Forms.Button buttonBackupMods;
        private System.Windows.Forms.Button buttonUninstallAll;
        private System.Windows.Forms.TabPage Plugins;
        private System.Windows.Forms.ListView listViewMods;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
    }
}

