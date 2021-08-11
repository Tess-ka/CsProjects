
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
            System.Windows.Forms.Label petIdLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label speciesLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label colourLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetCardForm));
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.petIdTextBox1 = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            petIdLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            speciesLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // petIdLabel1
            // 
            petIdLabel1.AutoSize = true;
            petIdLabel1.Location = new System.Drawing.Point(142, 22);
            petIdLabel1.Name = "petIdLabel1";
            petIdLabel1.Size = new System.Drawing.Size(38, 13);
            petIdLabel1.TabIndex = 18;
            petIdLabel1.Text = "Pet Id:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(9, 51);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(32, 13);
            nameLabel1.TabIndex = 20;
            nameLabel1.Text = "Имя:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(11, 107);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(30, 13);
            sexLabel.TabIndex = 22;
            sexLabel.Text = "Пол:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(9, 136);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(52, 13);
            birthdayLabel.TabIndex = 24;
            birthdayLabel.Text = "Возраст:";
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new System.Drawing.Point(9, 79);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new System.Drawing.Size(29, 13);
            speciesLabel.TabIndex = 26;
            speciesLabel.Text = "Вид:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(9, 164);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(48, 13);
            breedTypeLabel.TabIndex = 28;
            breedTypeLabel.Text = "Порода:";
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new System.Drawing.Point(9, 192);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(42, 13);
            colourLabel.TabIndex = 30;
            colourLabel.Text = "Окрас:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexComboBox);
            this.groupBox1.Controls.Add(petIdLabel1);
            this.groupBox1.Controls.Add(nameLabel1);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Controls.Add(this.petIdTextBox1);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.colourTextBox);
            this.groupBox1.Controls.Add(colourLabel);
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Controls.Add(this.breedTypeTextBox);
            this.groupBox1.Controls.Add(this.birthdayTextBox);
            this.groupBox1.Controls.Add(breedTypeLabel);
            this.groupBox1.Controls.Add(speciesLabel);
            this.groupBox1.Controls.Add(this.speciesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 217);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения о питомце";
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Sex", true));
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.petBindingSource, "Sex", true));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sexComboBox.Location = new System.Drawing.Point(80, 104);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(200, 21);
            this.sexComboBox.TabIndex = 32;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(80, 48);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox1.TabIndex = 21;
            // 
            // petIdTextBox1
            // 
            this.petIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "PetId", true));
            this.petIdTextBox1.Location = new System.Drawing.Point(190, 19);
            this.petIdTextBox1.Name = "petIdTextBox1";
            this.petIdTextBox1.ReadOnly = true;
            this.petIdTextBox1.Size = new System.Drawing.Size(90, 20);
            this.petIdTextBox1.TabIndex = 19;
            // 
            // colourTextBox
            // 
            this.colourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Colour", true));
            this.colourTextBox.Location = new System.Drawing.Point(80, 189);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(200, 20);
            this.colourTextBox.TabIndex = 31;
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(80, 161);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.breedTypeTextBox.TabIndex = 29;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(80, 133);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(200, 20);
            this.birthdayTextBox.TabIndex = 25;
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "Species", true));
            this.speciesTextBox.Location = new System.Drawing.Point(80, 76);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(200, 20);
            this.speciesTextBox.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 190);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 217);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фото";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(338, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(419, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PetCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Амбулаторная карта питомца";
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private DBVetClinicaDataSetTableAdapters.PetTableAdapter petTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.TextBox petIdTextBox1;
        protected internal System.Windows.Forms.TextBox nameTextBox1;
        protected internal System.Windows.Forms.TextBox birthdayTextBox;
        protected internal System.Windows.Forms.TextBox speciesTextBox;
        protected internal System.Windows.Forms.TextBox breedTypeTextBox;
        protected internal System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.ComboBox sexComboBox;
    }
}