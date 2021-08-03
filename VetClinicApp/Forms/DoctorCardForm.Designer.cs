
namespace VetClinicApp
{
    partial class DoctorCardForm
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
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label fathernameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label qualificationLabel;
            System.Windows.Forms.Label doctorIdLabel;
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.fathernameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qualificationTextBox = new System.Windows.Forms.TextBox();
            this.DoctorPhoto = new System.Windows.Forms.PictureBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CanButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.doctorTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            lastnameLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            fathernameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            qualificationLabel = new System.Windows.Forms.Label();
            doctorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(9, 46);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(59, 13);
            lastnameLabel.TabIndex = 3;
            lastnameLabel.Text = "Фамилия:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(9, 72);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(32, 13);
            firstnameLabel.TabIndex = 5;
            firstnameLabel.Text = "Имя:";
            // 
            // fathernameLabel
            // 
            fathernameLabel.AutoSize = true;
            fathernameLabel.Location = new System.Drawing.Point(9, 98);
            fathernameLabel.Name = "fathernameLabel";
            fathernameLabel.Size = new System.Drawing.Size(57, 13);
            fathernameLabel.TabIndex = 7;
            fathernameLabel.Text = "Отчество:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(9, 130);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(90, 13);
            birthdayLabel.TabIndex = 9;
            birthdayLabel.Text = "День рождения:";
            // 
            // qualificationLabel
            // 
            qualificationLabel.AutoSize = true;
            qualificationLabel.Location = new System.Drawing.Point(9, 156);
            qualificationLabel.Name = "qualificationLabel";
            qualificationLabel.Size = new System.Drawing.Size(85, 13);
            qualificationLabel.TabIndex = 11;
            qualificationLabel.Text = "Квалификация:";
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Location = new System.Drawing.Point(143, 18);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new System.Drawing.Size(21, 13);
            doctorIdLabel.TabIndex = 8;
            doctorIdLabel.Text = "ID:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(74, 43);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(177, 20);
            this.lastnameTextBox.TabIndex = 4;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(74, 71);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(177, 20);
            this.firstnameTextBox.TabIndex = 6;
            // 
            // fathernameTextBox
            // 
            this.fathernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Fathername", true));
            this.fathernameTextBox.Location = new System.Drawing.Point(74, 99);
            this.fathernameTextBox.Name = "fathernameTextBox";
            this.fathernameTextBox.Size = new System.Drawing.Size(177, 20);
            this.fathernameTextBox.TabIndex = 8;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doctorBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(105, 127);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.birthdayDateTimePicker.TabIndex = 10;
            // 
            // qualificationTextBox
            // 
            this.qualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Qualification", true));
            this.qualificationTextBox.Location = new System.Drawing.Point(12, 176);
            this.qualificationTextBox.Multiline = true;
            this.qualificationTextBox.Name = "qualificationTextBox";
            this.qualificationTextBox.Size = new System.Drawing.Size(239, 81);
            this.qualificationTextBox.TabIndex = 12;
            // 
            // DoctorPhoto
            // 
            this.DoctorPhoto.Location = new System.Drawing.Point(6, 14);
            this.DoctorPhoto.Name = "DoctorPhoto";
            this.DoctorPhoto.Size = new System.Drawing.Size(206, 188);
            this.DoctorPhoto.TabIndex = 13;
            this.DoctorPhoto.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(326, 283);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 14;
            this.OKButton.Text = "Ок";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CanButton
            // 
            this.CanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanButton.Location = new System.Drawing.Point(407, 283);
            this.CanButton.Name = "CanButton";
            this.CanButton.Size = new System.Drawing.Size(75, 23);
            this.CanButton.TabIndex = 15;
            this.CanButton.Text = "Отмена";
            this.CanButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(doctorIdLabel);
            this.groupBox1.Controls.Add(this.doctorId);
            this.groupBox1.Controls.Add(this.lastnameTextBox);
            this.groupBox1.Controls.Add(lastnameLabel);
            this.groupBox1.Controls.Add(this.qualificationTextBox);
            this.groupBox1.Controls.Add(qualificationLabel);
            this.groupBox1.Controls.Add(this.birthdayDateTimePicker);
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Controls.Add(this.firstnameTextBox);
            this.groupBox1.Controls.Add(firstnameLabel);
            this.groupBox1.Controls.Add(fathernameLabel);
            this.groupBox1.Controls.Add(this.fathernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 264);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные ветеринара";
            // 
            // doctorId
            // 
            this.doctorId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "DoctorId", true));
            this.doctorId.Enabled = false;
            this.doctorId.Location = new System.Drawing.Point(170, 15);
            this.doctorId.Name = "doctorId";
            this.doctorId.Size = new System.Drawing.Size(81, 20);
            this.doctorId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "File path:";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.ForeColor = System.Drawing.Color.Red;
            this.FileName.Location = new System.Drawing.Point(55, 210);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(80, 13);
            this.FileName.TabIndex = 18;
            this.FileName.Text = "directory path...";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(155, 205);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(57, 23);
            this.BrowseButton.TabIndex = 19;
            this.BrowseButton.Text = "Обзор";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(56, 233);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 20;
            this.UploadButton.Text = "Загрузить";
            this.UploadButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DoctorPhoto);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.UploadButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BrowseButton);
            this.groupBox2.Controls.Add(this.FileName);
            this.groupBox2.Location = new System.Drawing.Point(270, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 263);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фото";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TreatmentСaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DoctorCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CanButton);
            this.Controls.Add(this.OKButton);
            this.Name = "DoctorCardForm";
            this.Text = "Форма ветеринара";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DBVetClinicaDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox DoctorPhoto;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CanButton;
        protected internal System.Windows.Forms.TextBox lastnameTextBox;
        protected internal System.Windows.Forms.TextBox firstnameTextBox;
        protected internal System.Windows.Forms.TextBox fathernameTextBox;
        protected internal System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        protected internal System.Windows.Forms.TextBox qualificationTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.TextBox doctorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}