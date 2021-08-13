
namespace VetClinicApp
{
    partial class TreatmentCaseForm
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label doctorIDLabel;
            System.Windows.Forms.Label petIDLabel;
            System.Windows.Forms.Label visualInspectionLabel;
            System.Windows.Forms.Label anamnesisLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label causeLabel;
            System.Windows.Forms.Label conclusionLabel;
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.treatmentСaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.doctorIDTextBox = new System.Windows.Forms.TextBox();
            this.visualInspectionTextBox = new System.Windows.Forms.TextBox();
            this.anamnesisTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.causeTextBox = new System.Windows.Forms.TextBox();
            this.conclusionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petIDLabel2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NamePet = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.ServiceTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            dataLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            doctorIDLabel = new System.Windows.Forms.Label();
            petIDLabel = new System.Windows.Forms.Label();
            visualInspectionLabel = new System.Windows.Forms.Label();
            anamnesisLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            causeLabel = new System.Windows.Forms.Label();
            conclusionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(10, 25);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(36, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Дата:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(291, 25);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(47, 13);
            numberLabel.TabIndex = 5;
            numberLabel.Text = "Number:";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Location = new System.Drawing.Point(22, 490);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new System.Drawing.Size(48, 13);
            doctorIDLabel.TabIndex = 7;
            doctorIDLabel.Text = "Доктор:";
            // 
            // petIDLabel
            // 
            petIDLabel.AutoSize = true;
            petIDLabel.Location = new System.Drawing.Point(291, 21);
            petIDLabel.Name = "petIDLabel";
            petIDLabel.Size = new System.Drawing.Size(40, 13);
            petIDLabel.TabIndex = 9;
            petIDLabel.Text = "Pet ID:";
            // 
            // visualInspectionLabel
            // 
            visualInspectionLabel.AutoSize = true;
            visualInspectionLabel.Location = new System.Drawing.Point(10, 77);
            visualInspectionLabel.Name = "visualInspectionLabel";
            visualInspectionLabel.Size = new System.Drawing.Size(112, 13);
            visualInspectionLabel.TabIndex = 11;
            visualInspectionLabel.Text = "Визуальный осмотр:";
            // 
            // anamnesisLabel
            // 
            anamnesisLabel.AutoSize = true;
            anamnesisLabel.Location = new System.Drawing.Point(10, 129);
            anamnesisLabel.Name = "anamnesisLabel";
            anamnesisLabel.Size = new System.Drawing.Size(55, 13);
            anamnesisLabel.TabIndex = 13;
            anamnesisLabel.Text = "Анамнез:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(10, 103);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(54, 13);
            diagnosisLabel.TabIndex = 15;
            diagnosisLabel.Text = "Диагноз:";
            // 
            // causeLabel
            // 
            causeLabel.AutoSize = true;
            causeLabel.Location = new System.Drawing.Point(10, 51);
            causeLabel.Name = "causeLabel";
            causeLabel.Size = new System.Drawing.Size(113, 13);
            causeLabel.TabIndex = 17;
            causeLabel.Text = "Причина посещения:";
            // 
            // conclusionLabel
            // 
            conclusionLabel.AutoSize = true;
            conclusionLabel.Location = new System.Drawing.Point(10, 155);
            conclusionLabel.Name = "conclusionLabel";
            conclusionLabel.Size = new System.Drawing.Size(72, 13);
            conclusionLabel.TabIndex = 19;
            conclusionLabel.Text = "Заключение:";
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatmentСaseBindingSource
            // 
            this.treatmentСaseBindingSource.DataMember = "TreatmentСase";
            this.treatmentСaseBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // treatmentСaseTableAdapter
            // 
            this.treatmentСaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TreatmentСaseTableAdapter = this.treatmentСaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.treatmentСaseBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(129, 22);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(344, 22);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(168, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // doctorIDTextBox
            // 
            this.doctorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "DoctorID", true));
            this.doctorIDTextBox.Location = new System.Drawing.Point(84, 487);
            this.doctorIDTextBox.Name = "doctorIDTextBox";
            this.doctorIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.doctorIDTextBox.TabIndex = 8;
            // 
            // visualInspectionTextBox
            // 
            this.visualInspectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "VisualInspection", true));
            this.visualInspectionTextBox.Location = new System.Drawing.Point(129, 74);
            this.visualInspectionTextBox.Name = "visualInspectionTextBox";
            this.visualInspectionTextBox.Size = new System.Drawing.Size(383, 20);
            this.visualInspectionTextBox.TabIndex = 12;
            // 
            // anamnesisTextBox
            // 
            this.anamnesisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "Anamnesis", true));
            this.anamnesisTextBox.Location = new System.Drawing.Point(129, 126);
            this.anamnesisTextBox.Name = "anamnesisTextBox";
            this.anamnesisTextBox.Size = new System.Drawing.Size(383, 20);
            this.anamnesisTextBox.TabIndex = 14;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(129, 100);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(383, 20);
            this.diagnosisTextBox.TabIndex = 16;
            // 
            // causeTextBox
            // 
            this.causeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "Cause", true));
            this.causeTextBox.Location = new System.Drawing.Point(129, 48);
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.Size = new System.Drawing.Size(383, 20);
            this.causeTextBox.TabIndex = 18;
            // 
            // conclusionTextBox
            // 
            this.conclusionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "Conclusion", true));
            this.conclusionTextBox.Location = new System.Drawing.Point(129, 152);
            this.conclusionTextBox.Name = "conclusionTextBox";
            this.conclusionTextBox.Size = new System.Drawing.Size(383, 20);
            this.conclusionTextBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.petIDLabel2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NamePet);
            this.groupBox1.Controls.Add(petIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 76);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Питомец";
            // 
            // petIDLabel2
            // 
            this.petIDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treatmentСaseBindingSource, "PetID", true));
            this.petIDLabel2.Location = new System.Drawing.Point(337, 21);
            this.petIDLabel2.Name = "petIDLabel2";
            this.petIDLabel2.Size = new System.Drawing.Size(71, 23);
            this.petIDLabel2.TabIndex = 15;
            this.petIDLabel2.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Карта питомца";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вид, порода:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // NamePet
            // 
            this.NamePet.AutoSize = true;
            this.NamePet.Location = new System.Drawing.Point(6, 21);
            this.NamePet.Name = "NamePet";
            this.NamePet.Size = new System.Drawing.Size(32, 13);
            this.NamePet.TabIndex = 11;
            this.NamePet.Text = "Имя:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(numberLabel);
            this.groupBox2.Controls.Add(this.dataDateTimePicker);
            this.groupBox2.Controls.Add(this.numberTextBox);
            this.groupBox2.Controls.Add(dataLabel);
            this.groupBox2.Controls.Add(conclusionLabel);
            this.groupBox2.Controls.Add(this.anamnesisTextBox);
            this.groupBox2.Controls.Add(this.conclusionTextBox);
            this.groupBox2.Controls.Add(anamnesisLabel);
            this.groupBox2.Controls.Add(visualInspectionLabel);
            this.groupBox2.Controls.Add(this.visualInspectionTextBox);
            this.groupBox2.Controls.Add(diagnosisLabel);
            this.groupBox2.Controls.Add(this.diagnosisTextBox);
            this.groupBox2.Controls.Add(causeLabel);
            this.groupBox2.Controls.Add(this.causeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 184);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные об осмотре";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 191);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Предоставлены услуги:";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TreatmentCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(doctorIDLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.doctorIDTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "TreatmentCaseForm";
            this.Text = "Форма осмотра (случая лечения)";
            this.Load += new System.EventHandler(this.TreatmentCaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource;
        private DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter treatmentСaseTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        protected internal System.Windows.Forms.DateTimePicker dataDateTimePicker;
        protected internal System.Windows.Forms.TextBox numberTextBox;
        protected internal System.Windows.Forms.TextBox doctorIDTextBox;
        protected internal System.Windows.Forms.TextBox visualInspectionTextBox;
        protected internal System.Windows.Forms.TextBox anamnesisTextBox;
        protected internal System.Windows.Forms.TextBox diagnosisTextBox;
        protected internal System.Windows.Forms.TextBox causeTextBox;
        protected internal System.Windows.Forms.TextBox conclusionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label petIDLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NamePet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private DBVetClinicaDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}