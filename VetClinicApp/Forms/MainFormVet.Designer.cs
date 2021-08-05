
namespace VetClinicApp
{
    partial class MainFormVet
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Питомцы");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Владельцы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ветеринары");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Услуги");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Прививки");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Справочники    ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Все случаи");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Посещения    ", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormVet));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PetSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OwnerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VaccinationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosedWinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.RegistrationMenuItem,
            this.DirectoryMenuItem,
            this.SettingsMenuItem,
            this.WindowMenuItem,
            this.RefMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(109, 22);
            this.CloseMenuItem.Text = "Выход";
            // 
            // RegistrationMenuItem
            // 
            this.RegistrationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PetSearchMenuItem,
            this.ReferenceMenuItem});
            this.RegistrationMenuItem.Name = "RegistrationMenuItem";
            this.RegistrationMenuItem.Size = new System.Drawing.Size(92, 20);
            this.RegistrationMenuItem.Text = "Регистратура";
            // 
            // PetSearchMenuItem
            // 
            this.PetSearchMenuItem.Name = "PetSearchMenuItem";
            this.PetSearchMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PetSearchMenuItem.Text = "Поиск питомца";
            this.PetSearchMenuItem.Click += new System.EventHandler(this.PetSearchMenuItem_Click);
            // 
            // ReferenceMenuItem
            // 
            this.ReferenceMenuItem.Name = "ReferenceMenuItem";
            this.ReferenceMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ReferenceMenuItem.Text = "Выдача справок";
            // 
            // DirectoryMenuItem
            // 
            this.DirectoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PetMenuItem,
            this.OwnerMenuItem,
            this.DoctorMenuItem,
            this.ServicesMenuItem,
            this.VaccinationsMenuItem});
            this.DirectoryMenuItem.Name = "DirectoryMenuItem";
            this.DirectoryMenuItem.Size = new System.Drawing.Size(94, 20);
            this.DirectoryMenuItem.Text = "Справочники";
            // 
            // PetMenuItem
            // 
            this.PetMenuItem.Name = "PetMenuItem";
            this.PetMenuItem.Size = new System.Drawing.Size(141, 22);
            this.PetMenuItem.Text = "Питомцы";
            // 
            // OwnerMenuItem
            // 
            this.OwnerMenuItem.Name = "OwnerMenuItem";
            this.OwnerMenuItem.Size = new System.Drawing.Size(141, 22);
            this.OwnerMenuItem.Text = "Владельцы";
            this.OwnerMenuItem.Click += new System.EventHandler(this.OwnerMenuItem_Click);
            // 
            // DoctorMenuItem
            // 
            this.DoctorMenuItem.Name = "DoctorMenuItem";
            this.DoctorMenuItem.Size = new System.Drawing.Size(141, 22);
            this.DoctorMenuItem.Text = "Ветеринары";
            this.DoctorMenuItem.Click += new System.EventHandler(this.DoctorMenuItem_Click);
            // 
            // ServicesMenuItem
            // 
            this.ServicesMenuItem.Name = "ServicesMenuItem";
            this.ServicesMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ServicesMenuItem.Text = "Услуги";
            // 
            // VaccinationsMenuItem
            // 
            this.VaccinationsMenuItem.Name = "VaccinationsMenuItem";
            this.VaccinationsMenuItem.Size = new System.Drawing.Size(141, 22);
            this.VaccinationsMenuItem.Text = "Прививки";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsMenuItem.Text = "Настройки";
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClosedWinMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(48, 20);
            this.WindowMenuItem.Text = "Окно";
            // 
            // ClosedWinMenuItem
            // 
            this.ClosedWinMenuItem.Name = "ClosedWinMenuItem";
            this.ClosedWinMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ClosedWinMenuItem.Text = "Закрыть окно";
            // 
            // RefMenuItem
            // 
            this.RefMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramMenuItem});
            this.RefMenuItem.Name = "RefMenuItem";
            this.RefMenuItem.Size = new System.Drawing.Size(65, 20);
            this.RefMenuItem.Text = "Справка";
            // 
            // ProgramMenuItem
            // 
            this.ProgramMenuItem.Name = "ProgramMenuItem";
            this.ProgramMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ProgramMenuItem.Text = "О программе";
            this.ProgramMenuItem.Click += new System.EventHandler(this.ProgramMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1332, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel1.Text = "Ку :)";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 24;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageKey = "documenthorizontal.ico";
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageKey = "document (1).ico";
            treeNode1.Text = "Питомцы";
            treeNode2.ImageKey = "documenthorizontal.ico";
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageKey = "document (1).ico";
            treeNode2.Text = "Владельцы";
            treeNode3.ImageKey = "documenthorizontal.ico";
            treeNode3.Name = "Node3";
            treeNode3.SelectedImageKey = "document (1).ico";
            treeNode3.Text = "Ветеринары";
            treeNode4.ImageKey = "documenthorizontal.ico";
            treeNode4.Name = "Node4";
            treeNode4.SelectedImageKey = "document (1).ico";
            treeNode4.Text = "Услуги";
            treeNode5.ImageKey = "documenthorizontal.ico";
            treeNode5.Name = "Node7";
            treeNode5.SelectedImageKey = "document (1).ico";
            treeNode5.Text = "Прививки";
            treeNode6.ImageKey = "foldersmiley.ico";
            treeNode6.Name = "Node0";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode6.SelectedImageKey = "folderhorizontalopen.ico";
            treeNode6.Text = "Справочники    ";
            treeNode7.Name = "Node6";
            treeNode7.SelectedImageKey = "document (1).ico";
            treeNode7.Text = "Все случаи";
            treeNode8.ImageKey = "foldersmiley.ico";
            treeNode8.Name = "Node5";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode8.SelectedImageKey = "folderhorizontalopen.ico";
            treeNode8.Text = "Посещения    ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(244, 703);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "documenthorizontal.ico");
            this.imageList1.Images.SetKeyName(1, "foldersmiley.ico");
            this.imageList1.Images.SetKeyName(2, "folderhorizontalopen.ico");
            this.imageList1.Images.SetKeyName(3, "document (1).ico");
            // 
            // MainFormVet
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 749);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormVet";
            this.Text = "Ветеринарная клиника";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistrationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PetSearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DirectoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OwnerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoctorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServicesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VaccinationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClosedWinMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

