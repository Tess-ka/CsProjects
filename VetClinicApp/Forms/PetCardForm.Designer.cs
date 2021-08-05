
namespace VetClinicApp
{
    partial class PetCardForm
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
            System.Windows.Forms.Label petIdLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label speciesLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label colourLabel;
            System.Windows.Forms.Label ownerIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetCardForm));
            this.petIdTextBox = new System.Windows.Forms.TextBox();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.petIdTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            petIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            petIdLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            speciesLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            ownerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // petIdLabel
            // 
            petIdLabel.AutoSize = true;
            petIdLabel.Location = new System.Drawing.Point(256, 29);
            petIdLabel.Name = "petIdLabel";
            petIdLabel.Size = new System.Drawing.Size(21, 13);
            petIdLabel.TabIndex = 1;
            petIdLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // petIdLabel1
            // 
            petIdLabel1.AutoSize = true;
            petIdLabel1.Location = new System.Drawing.Point(95, 219);
            petIdLabel1.Name = "petIdLabel1";
            petIdLabel1.Size = new System.Drawing.Size(38, 13);
            petIdLabel1.TabIndex = 18;
            petIdLabel1.Text = "Pet Id:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(95, 245);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 20;
            nameLabel1.Text = "Name:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(95, 271);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 22;
            sexLabel.Text = "Sex:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(95, 297);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 24;
            birthdayLabel.Text = "Birthday:";
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new System.Drawing.Point(95, 323);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new System.Drawing.Size(48, 13);
            speciesLabel.TabIndex = 26;
            speciesLabel.Text = "Species:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(95, 349);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(65, 13);
            breedTypeLabel.TabIndex = 28;
            breedTypeLabel.Text = "Breed Type:";
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new System.Drawing.Point(95, 375);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(40, 13);
            colourLabel.TabIndex = 30;
            colourLabel.Text = "Colour:";
            // 
            // ownerIDLabel
            // 
            ownerIDLabel.AutoSize = true;
            ownerIDLabel.Location = new System.Drawing.Point(95, 401);
            ownerIDLabel.Name = "ownerIDLabel";
            ownerIDLabel.Size = new System.Drawing.Size(55, 13);
            ownerIDLabel.TabIndex = 32;
            ownerIDLabel.Text = "Owner ID:";
            // 
            // petIdTextBox
            // 
            this.petIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "PetId", true));
            this.petIdTextBox.Location = new System.Drawing.Point(283, 26);
            this.petIdTextBox.Name = "petIdTextBox";
            this.petIdTextBox.Size = new System.Drawing.Size(105, 20);
            this.petIdTextBox.TabIndex = 2;
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(50, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.petIdTextBox);
            this.groupBox1.Controls.Add(petIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения о питомце";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 190);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
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
            // petIdTextBox1
            // 
            this.petIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "PetId", true));
            this.petIdTextBox1.Location = new System.Drawing.Point(166, 216);
            this.petIdTextBox1.Name = "petIdTextBox1";
            this.petIdTextBox1.Size = new System.Drawing.Size(100, 20);
            this.petIdTextBox1.TabIndex = 19;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(166, 242);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 21;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(166, 268);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexTextBox.TabIndex = 23;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(166, 294);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthdayTextBox.TabIndex = 25;
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Species", true));
            this.speciesTextBox.Location = new System.Drawing.Point(166, 320);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(100, 20);
            this.speciesTextBox.TabIndex = 27;
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(166, 346);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.breedTypeTextBox.TabIndex = 29;
            // 
            // colourTextBox
            // 
            this.colourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Colour", true));
            this.colourTextBox.Location = new System.Drawing.Point(166, 372);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(100, 20);
            this.colourTextBox.TabIndex = 31;
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "OwnerID", true));
            this.ownerIDTextBox.Location = new System.Drawing.Point(166, 398);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerIDTextBox.TabIndex = 33;
            // 
            // PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(petIdLabel1);
            this.Controls.Add(this.petIdTextBox1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(speciesLabel);
            this.Controls.Add(this.speciesTextBox);
            this.Controls.Add(breedTypeLabel);
            this.Controls.Add(this.breedTypeTextBox);
            this.Controls.Add(colourLabel);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(ownerIDLabel);
            this.Controls.Add(this.ownerIDTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetCardForm";
            this.Text = "Амбулаторная карта питомца";
            this.Load += new System.EventHandler(this.PetCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox petIdTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox speciesTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.TextBox ownerIDTextBox;
    }
}