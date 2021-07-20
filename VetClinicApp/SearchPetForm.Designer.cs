
namespace VetClinicApp
{
    partial class SearchPetForm
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
            System.Windows.Forms.Label petIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label speciesLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.petIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.petIdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.petIdToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.OwnerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treatmentСaseTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter();
            this.treatmentСaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentСaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            petIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            speciesLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // petIdLabel
            // 
            petIdLabel.AutoSize = true;
            petIdLabel.Location = new System.Drawing.Point(6, 25);
            petIdLabel.Name = "petIdLabel";
            petIdLabel.Size = new System.Drawing.Size(21, 13);
            petIdLabel.TabIndex = 1;
            petIdLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(134, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new System.Drawing.Point(7, 51);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new System.Drawing.Size(29, 13);
            speciesLabel.TabIndex = 9;
            speciesLabel.Text = "Вид:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(134, 51);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(48, 13);
            breedTypeLabel.TabIndex = 11;
            breedTypeLabel.Text = "Порода:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(6, 22);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(37, 13);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "ФИО:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(6, 48);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(55, 13);
            telephoneLabel.TabIndex = 2;
            telephoneLabel.Text = "Телефон:";
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.PetTableAdapter = this.petTableAdapter;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TreatmentСaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // petIdTextBox
            // 
            this.petIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "PetId", true));
            this.petIdTextBox.Enabled = false;
            this.petIdTextBox.Location = new System.Drawing.Point(42, 22);
            this.petIdTextBox.Name = "petIdTextBox";
            this.petIdTextBox.Size = new System.Drawing.Size(75, 20);
            this.petIdTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(188, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(166, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Species", true));
            this.speciesTextBox.Enabled = false;
            this.speciesTextBox.Location = new System.Drawing.Point(42, 48);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(75, 20);
            this.speciesTextBox.TabIndex = 10;
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "BreedType", true));
            this.breedTypeTextBox.Enabled = false;
            this.breedTypeTextBox.Location = new System.Drawing.Point(188, 48);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(166, 20);
            this.breedTypeTextBox.TabIndex = 12;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petIdToolStripLabel,
            this.petIdToolStripTextBox,
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(461, 25);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // petIdToolStripLabel
            // 
            this.petIdToolStripLabel.Name = "petIdToolStripLabel";
            this.petIdToolStripLabel.Size = new System.Drawing.Size(69, 22);
            this.petIdToolStripLabel.Text = "ID питомца";
            // 
            // petIdToolStripTextBox
            // 
            this.petIdToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.petIdToolStripTextBox.Name = "petIdToolStripTextBox";
            this.petIdToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.nameToolStripLabel.Text = "Имя";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillByToolStripButton.Text = "Найти";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(petIdLabel);
            this.groupBox1.Controls.Add(this.petIdTextBox);
            this.groupBox1.Controls.Add(this.breedTypeTextBox);
            this.groupBox1.Controls.Add(breedTypeLabel);
            this.groupBox1.Controls.Add(this.speciesTextBox);
            this.groupBox1.Controls.Add(speciesLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о питомце";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(telephoneLabel);
            this.groupBox2.Controls.Add(this.telephoneTextBox);
            this.groupBox2.Controls.Add(lastNameLabel);
            this.groupBox2.Controls.Add(this.lastNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(4, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 78);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Владелец";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "Telephone", true));
            this.telephoneTextBox.Enabled = false;
            this.telephoneTextBox.Location = new System.Drawing.Point(73, 45);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(280, 20);
            this.telephoneTextBox.TabIndex = 3;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "LastName", true));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(73, 19);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(280, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 71);
            this.button1.TabIndex = 21;
            this.button1.Text = "Открыть карту питомца";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 73);
            this.button2.TabIndex = 22;
            this.button2.Text = "Новый питомец";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // treatmentСaseTableAdapter
            // 
            this.treatmentСaseTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentСaseDataGridView
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.treatmentСaseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.treatmentСaseDataGridView.AutoGenerateColumns = false;
            this.treatmentСaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentСaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.treatmentСaseDataGridView.DataSource = this.treatmentСaseBindingSource;
            this.treatmentСaseDataGridView.Location = new System.Drawing.Point(5, 187);
            this.treatmentСaseDataGridView.Name = "treatmentСaseDataGridView";
            this.treatmentСaseDataGridView.Size = new System.Drawing.Size(450, 167);
            this.treatmentСaseDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TreatmentСaseId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TreatmentСaseId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoctorID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PetID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PetID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VisualInspection";
            this.dataGridViewTextBoxColumn6.HeaderText = "VisualInspection";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Anamnesis";
            this.dataGridViewTextBoxColumn7.HeaderText = "Anamnesis";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn8.HeaderText = "Diagnosis";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cause";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cause";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Conclusion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Conclusion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // treatmentСaseBindingSource
            // 
            this.treatmentСaseBindingSource.DataMember = "FK_TreatmentСase_PetId";
            this.treatmentСaseBindingSource.DataSource = this.petBindingSource;
            // 
            // treatmentСaseBindingSource1
            // 
            this.treatmentСaseBindingSource1.DataMember = "FK_TreatmentСase_PetId";
            this.treatmentСaseBindingSource1.DataSource = this.petBindingSource;
            // 
            // treatmentСaseBindingSource2
            // 
            this.treatmentСaseBindingSource2.DataMember = "FK_TreatmentСase_PetId";
            this.treatmentСaseBindingSource2.DataSource = this.petBindingSource;
            // 
            // SearchPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 359);
            this.Controls.Add(this.treatmentСaseDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма поиска питомца";
            this.Load += new System.EventHandler(this.SearchPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private DBVetClinicaDataSetTableAdapters.PetTableAdapter petTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox petIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox speciesTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel petIdToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox petIdToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private DBVetClinicaDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource;
        private DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter treatmentСaseTableAdapter;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource1;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource2;
        private System.Windows.Forms.DataGridView treatmentСaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}