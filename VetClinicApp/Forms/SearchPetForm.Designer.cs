
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
            System.Windows.Forms.Label ownerIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPetForm));
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.petIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ownerIdTextBox = new System.Windows.Forms.TextBox();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.OwnerTableAdapter();
            this.button_cardpet_open = new System.Windows.Forms.Button();
            this.button_cardpet_open_new = new System.Windows.Forms.Button();
            this.treatmentСaseTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_search_pet = new System.Windows.Forms.Button();
            this.txtSearchPet = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_search_owner = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treatmentСaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            petIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            speciesLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            ownerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            telephoneLabel.Location = new System.Drawing.Point(6, 52);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(55, 13);
            telephoneLabel.TabIndex = 2;
            telephoneLabel.Text = "Телефон:";
            // 
            // ownerIdLabel
            // 
            ownerIdLabel.AutoSize = true;
            ownerIdLabel.Location = new System.Drawing.Point(258, 22);
            ownerIdLabel.Name = "ownerIdLabel";
            ownerIdLabel.Size = new System.Drawing.Size(21, 13);
            ownerIdLabel.TabIndex = 4;
            ownerIdLabel.Text = "ID:";
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
            this.tableAdapterManager.ImagesTableAdapter = null;
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
            this.groupBox1.Location = new System.Drawing.Point(9, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о питомце";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(ownerIdLabel);
            this.groupBox2.Controls.Add(this.ownerIdTextBox);
            this.groupBox2.Controls.Add(telephoneLabel);
            this.groupBox2.Controls.Add(this.telephoneTextBox);
            this.groupBox2.Controls.Add(lastNameLabel);
            this.groupBox2.Controls.Add(this.lastNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 85);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Владелец";
            // 
            // ownerIdTextBox
            // 
            this.ownerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "OwnerId", true));
            this.ownerIdTextBox.Location = new System.Drawing.Point(285, 19);
            this.ownerIdTextBox.Name = "ownerIdTextBox";
            this.ownerIdTextBox.Size = new System.Drawing.Size(68, 20);
            this.ownerIdTextBox.TabIndex = 5;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "Telephone", true));
            this.telephoneTextBox.Enabled = false;
            this.telephoneTextBox.Location = new System.Drawing.Point(73, 49);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(280, 20);
            this.telephoneTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "LastName", true));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(73, 19);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // button_cardpet_open
            // 
            this.button_cardpet_open.Location = new System.Drawing.Point(375, 168);
            this.button_cardpet_open.Name = "button_cardpet_open";
            this.button_cardpet_open.Size = new System.Drawing.Size(99, 37);
            this.button_cardpet_open.TabIndex = 21;
            this.button_cardpet_open.Text = "Открыть карту питомца";
            this.button_cardpet_open.UseVisualStyleBackColor = true;
            this.button_cardpet_open.Click += new System.EventHandler(this.button_cardpet_open_Click);
            // 
            // button_cardpet_open_new
            // 
            this.button_cardpet_open_new.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cardpet_open_new.Location = new System.Drawing.Point(376, 210);
            this.button_cardpet_open_new.Name = "button_cardpet_open_new";
            this.button_cardpet_open_new.Size = new System.Drawing.Size(99, 37);
            this.button_cardpet_open_new.TabIndex = 22;
            this.button_cardpet_open_new.Text = "Новый питомец";
            this.button_cardpet_open_new.UseVisualStyleBackColor = false;
            this.button_cardpet_open_new.Click += new System.EventHandler(this.button_cardpet_open_new_Click);
            // 
            // treatmentСaseTableAdapter
            // 
            this.treatmentСaseTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 61);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_search_pet);
            this.tabPage1.Controls.Add(this.txtSearchPet);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 35);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск по питомцу";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_search_pet
            // 
            this.button_search_pet.Location = new System.Drawing.Point(362, 3);
            this.button_search_pet.Name = "button_search_pet";
            this.button_search_pet.Size = new System.Drawing.Size(85, 26);
            this.button_search_pet.TabIndex = 5;
            this.button_search_pet.Text = "Найти";
            this.button_search_pet.UseVisualStyleBackColor = true;
            this.button_search_pet.Click += new System.EventHandler(this.button_search_pet_Click);
            // 
            // txtSearchPet
            // 
            this.txtSearchPet.Location = new System.Drawing.Point(39, 6);
            this.txtSearchPet.Name = "txtSearchPet";
            this.txtSearchPet.Size = new System.Drawing.Size(311, 20);
            this.txtSearchPet.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button_search_owner);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 35);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск по владельцу";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_search_owner
            // 
            this.button_search_owner.Location = new System.Drawing.Point(362, 3);
            this.button_search_owner.Name = "button_search_owner";
            this.button_search_owner.Size = new System.Drawing.Size(75, 26);
            this.button_search_owner.TabIndex = 1;
            this.button_search_owner.Text = "Найти";
            this.button_search_owner.UseVisualStyleBackColor = true;
            this.button_search_owner.Click += new System.EventHandler(this.button_search_owner_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(38, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
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
            // treatmentСaseDataGridView
            // 
            this.treatmentСaseDataGridView.AllowUserToAddRows = false;
            this.treatmentСaseDataGridView.AllowUserToDeleteRows = false;
            this.treatmentСaseDataGridView.AllowUserToResizeColumns = false;
            this.treatmentСaseDataGridView.AutoGenerateColumns = false;
            this.treatmentСaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.treatmentСaseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.treatmentСaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentСaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10});
            this.treatmentСaseDataGridView.DataSource = this.treatmentСaseBindingSource;
            this.treatmentСaseDataGridView.Location = new System.Drawing.Point(9, 275);
            this.treatmentСaseDataGridView.Name = "treatmentСaseDataGridView";
            this.treatmentСaseDataGridView.ReadOnly = true;
            this.treatmentСaseDataGridView.Size = new System.Drawing.Size(466, 174);
            this.treatmentСaseDataGridView.TabIndex = 25;
            this.treatmentСaseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.treatmentСaseDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cause";
            this.dataGridViewTextBoxColumn9.HeaderText = "Причина";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn8.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Anamnesis";
            this.dataGridViewTextBoxColumn7.HeaderText = "Анамнез";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VisualInspection";
            this.dataGridViewTextBoxColumn6.HeaderText = "Визуальный осмотр";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Conclusion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Заключение";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 37);
            this.button3.TabIndex = 26;
            this.button3.Text = "Открыть карту владельца";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(376, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 37);
            this.button4.TabIndex = 27;
            this.button4.Text = "Новый владелец";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(9, 250);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(89, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // SearchPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 484);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.treatmentСaseDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_cardpet_open_new);
            this.Controls.Add(this.button_cardpet_open);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 523);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 523);
            this.Name = "SearchPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма поиска питомца";
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private DBVetClinicaDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button button_cardpet_open;
        private System.Windows.Forms.Button button_cardpet_open_new;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource;
        private DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter treatmentСaseTableAdapter;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource1;
        private System.Windows.Forms.BindingSource treatmentСaseBindingSource2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_search_owner;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button_search_pet;
        private System.Windows.Forms.TextBox txtSearchPet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView treatmentСaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox ownerIdTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}