
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
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label speciesLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label colourLabel;
            System.Windows.Forms.Label ownerIDLabel;
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.petIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            petIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            speciesLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            ownerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // petIdLabel
            // 
            petIdLabel.AutoSize = true;
            petIdLabel.Location = new System.Drawing.Point(256, 29);
            petIdLabel.Name = "petIdLabel";
            petIdLabel.Size = new System.Drawing.Size(21, 13);
            petIdLabel.TabIndex = 1;
            petIdLabel.Text = "ID:";
            // 
            // petIdTextBox
            // 
            this.petIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "PetId", true));
            this.petIdTextBox.Location = new System.Drawing.Point(283, 26);
            this.petIdTextBox.Name = "petIdTextBox";
            this.petIdTextBox.Size = new System.Drawing.Size(105, 20);
            this.petIdTextBox.TabIndex = 2;
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
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(50, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(13, 191);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 5;
            sexLabel.Text = "Sex:";
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(84, 188);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexTextBox.TabIndex = 6;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(13, 218);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.petBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(84, 214);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 8;
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new System.Drawing.Point(13, 243);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new System.Drawing.Size(48, 13);
            speciesLabel.TabIndex = 9;
            speciesLabel.Text = "Species:";
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Species", true));
            this.speciesTextBox.Location = new System.Drawing.Point(84, 240);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(200, 20);
            this.speciesTextBox.TabIndex = 10;
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(13, 269);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(65, 13);
            breedTypeLabel.TabIndex = 11;
            breedTypeLabel.Text = "Breed Type:";
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(84, 266);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.breedTypeTextBox.TabIndex = 12;
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new System.Drawing.Point(13, 295);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(40, 13);
            colourLabel.TabIndex = 13;
            colourLabel.Text = "Colour:";
            // 
            // colourTextBox
            // 
            this.colourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Colour", true));
            this.colourTextBox.Location = new System.Drawing.Point(84, 292);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(200, 20);
            this.colourTextBox.TabIndex = 14;
            // 
            // ownerIDLabel
            // 
            ownerIDLabel.AutoSize = true;
            ownerIDLabel.Location = new System.Drawing.Point(13, 321);
            ownerIDLabel.Name = "ownerIDLabel";
            ownerIDLabel.Size = new System.Drawing.Size(55, 13);
            ownerIDLabel.TabIndex = 15;
            ownerIDLabel.Text = "Owner ID:";
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "OwnerID", true));
            this.ownerIDTextBox.Location = new System.Drawing.Point(84, 318);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.ownerIDTextBox.TabIndex = 16;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(speciesLabel);
            this.Controls.Add(this.speciesTextBox);
            this.Controls.Add(breedTypeLabel);
            this.Controls.Add(this.breedTypeTextBox);
            this.Controls.Add(colourLabel);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(ownerIDLabel);
            this.Controls.Add(this.ownerIDTextBox);
            this.Name = "PetCardForm";
            this.Text = "Амбулаторная карта питомца";
            this.Load += new System.EventHandler(this.PetCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox speciesTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}