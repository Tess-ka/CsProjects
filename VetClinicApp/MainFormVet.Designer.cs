
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
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.menuStrip1.Size = new System.Drawing.Size(1332, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(69, 29);
            this.FileMenuItem.Text = "Файл";
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(166, 34);
            this.CloseMenuItem.Text = "Выход";
            // 
            // RegistrationMenuItem
            // 
            this.RegistrationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PetSearchMenuItem,
            this.ReferenceMenuItem});
            this.RegistrationMenuItem.Name = "RegistrationMenuItem";
            this.RegistrationMenuItem.Size = new System.Drawing.Size(135, 29);
            this.RegistrationMenuItem.Text = "Регистратура";
            // 
            // PetSearchMenuItem
            // 
            this.PetSearchMenuItem.Name = "PetSearchMenuItem";
            this.PetSearchMenuItem.Size = new System.Drawing.Size(248, 34);
            this.PetSearchMenuItem.Text = "Поиск питомца";
            // 
            // ReferenceMenuItem
            // 
            this.ReferenceMenuItem.Name = "ReferenceMenuItem";
            this.ReferenceMenuItem.Size = new System.Drawing.Size(248, 34);
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
            this.DirectoryMenuItem.Size = new System.Drawing.Size(139, 29);
            this.DirectoryMenuItem.Text = "Справочники";
            // 
            // PetMenuItem
            // 
            this.PetMenuItem.Name = "PetMenuItem";
            this.PetMenuItem.Size = new System.Drawing.Size(203, 34);
            this.PetMenuItem.Text = "Питомцы";
            // 
            // OwnerMenuItem
            // 
            this.OwnerMenuItem.Name = "OwnerMenuItem";
            this.OwnerMenuItem.Size = new System.Drawing.Size(270, 34);
            this.OwnerMenuItem.Text = "Владельцы";
            this.OwnerMenuItem.Click += new System.EventHandler(this.OwnerMenuItem_Click);
            // 
            // DoctorMenuItem
            // 
            this.DoctorMenuItem.Name = "DoctorMenuItem";
            this.DoctorMenuItem.Size = new System.Drawing.Size(203, 34);
            this.DoctorMenuItem.Text = "Доктора";
            // 
            // ServicesMenuItem
            // 
            this.ServicesMenuItem.Name = "ServicesMenuItem";
            this.ServicesMenuItem.Size = new System.Drawing.Size(203, 34);
            this.ServicesMenuItem.Text = "Услуги";
            // 
            // VaccinationsMenuItem
            // 
            this.VaccinationsMenuItem.Name = "VaccinationsMenuItem";
            this.VaccinationsMenuItem.Size = new System.Drawing.Size(203, 34);
            this.VaccinationsMenuItem.Text = "Прививки";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(116, 29);
            this.SettingsMenuItem.Text = "Настройки";
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClosedWinMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(72, 29);
            this.WindowMenuItem.Text = "Окно";
            // 
            // ClosedWinMenuItem
            // 
            this.ClosedWinMenuItem.Name = "ClosedWinMenuItem";
            this.ClosedWinMenuItem.Size = new System.Drawing.Size(228, 34);
            this.ClosedWinMenuItem.Text = "Закрыть окно";
            // 
            // RefMenuItem
            // 
            this.RefMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramMenuItem});
            this.RefMenuItem.Name = "RefMenuItem";
            this.RefMenuItem.Size = new System.Drawing.Size(97, 29);
            this.RefMenuItem.Text = "Справка";
            // 
            // ProgramMenuItem
            // 
            this.ProgramMenuItem.Name = "ProgramMenuItem";
            this.ProgramMenuItem.Size = new System.Drawing.Size(227, 34);
            this.ProgramMenuItem.Text = "О программе";
            this.ProgramMenuItem.Click += new System.EventHandler(this.ProgramMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 771);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1332, 32);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 25);
            this.toolStripStatusLabel1.Text = "Ку :)";
            // 
            // MainFormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 803);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
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
    }
}

