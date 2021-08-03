
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
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.OwnerTableAdapter();
            this.button_cardpet_open = new System.Windows.Forms.Button();
            this.button_cardpet_open_new = new System.Windows.Forms.Button();
            this.treatmentСaseTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TreatmentСaseTableAdapter();
            this.treatmentСaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentСaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_search_owner = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.petDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchPet = new System.Windows.Forms.TextBox();
            this.button_search_pet = new System.Windows.Forms.Button();
            petIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            speciesLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 75);
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
            this.groupBox2.Location = new System.Drawing.Point(9, 151);
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
            // button_cardpet_open
            // 
            this.button_cardpet_open.Location = new System.Drawing.Point(375, 80);
            this.button_cardpet_open.Name = "button_cardpet_open";
            this.button_cardpet_open.Size = new System.Drawing.Size(85, 71);
            this.button_cardpet_open.TabIndex = 21;
            this.button_cardpet_open.Text = "Открыть карту питомца";
            this.button_cardpet_open.UseVisualStyleBackColor = true;
            this.button_cardpet_open.Click += new System.EventHandler(this.button_cardpet_open_Click);
            // 
            // button_cardpet_open_new
            // 
            this.button_cardpet_open_new.Location = new System.Drawing.Point(375, 156);
            this.button_cardpet_open_new.Name = "button_cardpet_open_new";
            this.button_cardpet_open_new.Size = new System.Drawing.Size(85, 73);
            this.button_cardpet_open_new.TabIndex = 22;
            this.button_cardpet_open_new.Text = "Новый питомец";
            this.button_cardpet_open_new.UseVisualStyleBackColor = true;
            this.button_cardpet_open_new.Click += new System.EventHandler(this.button_cardpet_open_new_Click);
            // 
            // treatmentСaseTableAdapter
            // 
            this.treatmentСaseTableAdapter.ClearBeforeFill = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 61);
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
            this.tabPage1.Size = new System.Drawing.Size(443, 35);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск по питомцу";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button_search_owner);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 35);
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
            // petDataGridView
            // 
            this.petDataGridView.AutoGenerateColumns = false;
            this.petDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.petDataGridView.DataSource = this.petBindingSource;
            this.petDataGridView.Location = new System.Drawing.Point(9, 235);
            this.petDataGridView.Name = "petDataGridView";
            this.petDataGridView.Size = new System.Drawing.Size(451, 121);
            this.petDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PetId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PetId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Species";
            this.dataGridViewTextBoxColumn5.HeaderText = "Species";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BreedType";
            this.dataGridViewTextBoxColumn6.HeaderText = "BreedType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn7.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OwnerID";
            this.dataGridViewTextBoxColumn8.HeaderText = "OwnerID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // txtSearchPet
            // 
            this.txtSearchPet.Location = new System.Drawing.Point(39, 6);
            this.txtSearchPet.Name = "txtSearchPet";
            this.txtSearchPet.Size = new System.Drawing.Size(311, 20);
            this.txtSearchPet.TabIndex = 4;
            // 
            // button_search_pet
            // 
            this.button_search_pet.Location = new System.Drawing.Point(362, 3);
            this.button_search_pet.Name = "button_search_pet";
            this.button_search_pet.Size = new System.Drawing.Size(75, 26);
            this.button_search_pet.TabIndex = 5;
            this.button_search_pet.Text = "Найти";
            this.button_search_pet.UseVisualStyleBackColor = true;
            this.button_search_pet.Click += new System.EventHandler(this.button_search_pet_Click);
            // 
            // SearchPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(468, 429);
            this.Controls.Add(this.petDataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_cardpet_open_new);
            this.Controls.Add(this.button_cardpet_open);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 468);
            this.Name = "SearchPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма поиска питомца";
 //           this.Load += new System.EventHandler(this.SearchPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentСaseBindingSource2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView petDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button_search_pet;
        private System.Windows.Forms.TextBox txtSearchPet;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}