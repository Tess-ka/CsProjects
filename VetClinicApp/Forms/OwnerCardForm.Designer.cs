
namespace VetClinicApp
{
    partial class OwnerCardForm
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
            System.Windows.Forms.Label ownerIdLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label fatherNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerCardForm));
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.OwnerTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.ownerIdTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.OkButton1 = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.petDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ownerIdLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            fatherNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownerIdLabel
            // 
            ownerIdLabel.AutoSize = true;
            ownerIdLabel.Location = new System.Drawing.Point(184, 16);
            ownerIdLabel.Name = "ownerIdLabel";
            ownerIdLabel.Size = new System.Drawing.Size(21, 13);
            ownerIdLabel.TabIndex = 1;
            ownerIdLabel.Text = "ID:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(13, 39);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(59, 13);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Фамилия:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(13, 68);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(32, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "Имя:";
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Location = new System.Drawing.Point(13, 94);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new System.Drawing.Size(57, 13);
            fatherNameLabel.TabIndex = 7;
            fatherNameLabel.Text = "Отчество:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(13, 121);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(90, 13);
            birthdayLabel.TabIndex = 9;
            birthdayLabel.Text = "День рождения:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(13, 146);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(55, 13);
            telephoneLabel.TabIndex = 11;
            telephoneLabel.Text = "Телефон:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(13, 172);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(38, 13);
            e_mailLabel.TabIndex = 13;
            e_mailLabel.Text = "E-mail:";
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = this.ownerTableAdapter;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TreatmentСaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ownerIdTextBox
            // 
            this.ownerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "OwnerId", true));
            this.ownerIdTextBox.Enabled = false;
            this.ownerIdTextBox.Location = new System.Drawing.Point(211, 13);
            this.ownerIdTextBox.Name = "ownerIdTextBox";
            this.ownerIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.ownerIdTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(109, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "FatherName", true));
            this.fatherNameTextBox.Location = new System.Drawing.Point(109, 91);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.fatherNameTextBox.TabIndex = 8;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ownerBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(109, 117);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.birthdayDateTimePicker.TabIndex = 10;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(109, 143);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(223, 20);
            this.telephoneTextBox.TabIndex = 12;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ownerBindingSource, "E-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(109, 169);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(223, 20);
            this.e_mailTextBox.TabIndex = 14;
            // 
            // OkButton1
            // 
            this.OkButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton1.Location = new System.Drawing.Point(411, 465);
            this.OkButton1.Name = "OkButton1";
            this.OkButton1.Size = new System.Drawing.Size(75, 23);
            this.OkButton1.TabIndex = 15;
            this.OkButton1.Text = "Ok";
            this.OkButton1.UseVisualStyleBackColor = true;
            // 
            // CancelButton1
            // 
            this.CancelButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton1.Location = new System.Drawing.Point(492, 465);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 16;
            this.CancelButton1.Text = "Отмена";
            this.CancelButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ownerIdTextBox);
            this.groupBox1.Controls.Add(ownerIdLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.e_mailTextBox);
            this.groupBox1.Controls.Add(e_mailLabel);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.telephoneTextBox);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(telephoneLabel);
            this.groupBox1.Controls.Add(fatherNameLabel);
            this.groupBox1.Controls.Add(this.birthdayDateTimePicker);
            this.groupBox1.Controls.Add(this.fatherNameTextBox);
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 202);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные врача";
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "FK_Pet_Owner";
            this.petBindingSource.DataSource = this.ownerBindingSource;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(8, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 222);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Питомцы";
            // 
            // petDataGridView
            // 
            this.petDataGridView.AllowUserToAddRows = false;
            this.petDataGridView.AllowUserToDeleteRows = false;
            this.petDataGridView.AutoGenerateColumns = false;
            this.petDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.petDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.petDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.petDataGridView.DataSource = this.petBindingSource;
            this.petDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.petDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.petDataGridView.Location = new System.Drawing.Point(3, 16);
            this.petDataGridView.Name = "petDataGridView";
            this.petDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.petDataGridView.Size = new System.Drawing.Size(555, 203);
            this.petDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PetId";
            this.dataGridViewTextBoxColumn1.FillWeight = 177.665F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn3.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn4.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Species";
            this.dataGridViewTextBoxColumn5.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BreedType";
            this.dataGridViewTextBoxColumn6.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Порода";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn7.FillWeight = 87.05584F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Окрас";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(352, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 202);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(8, 209);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 20;
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
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // OwnerCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.OkButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OwnerCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карта владельца";
            this.Load += new System.EventHandler(this.OwnerCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private DBVetClinicaDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button OkButton1;
        private System.Windows.Forms.Button CancelButton1;
        protected internal System.Windows.Forms.TextBox ownerIdTextBox;
        protected internal System.Windows.Forms.TextBox lastNameTextBox;
        protected internal System.Windows.Forms.TextBox firstNameTextBox;
        protected internal System.Windows.Forms.TextBox fatherNameTextBox;
        protected internal System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        protected internal System.Windows.Forms.TextBox telephoneTextBox;
        protected internal System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource petBindingSource;
        private DBVetClinicaDataSetTableAdapters.PetTableAdapter petTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView petDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}