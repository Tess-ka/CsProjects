
namespace VetClinicApp
{
    partial class ServiceCardForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label сategoryLabel;
            System.Windows.Forms.Label indexLabel;
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.ServiceTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbconnectionDataSet = new VetClinicApp.DbconnectionDataSet();
            this.сategoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.servicesTableAdapter = new VetClinicApp.DbconnectionDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager1 = new VetClinicApp.DbconnectionDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            сategoryLabel = new System.Windows.Forms.Label();
            indexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbconnectionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 23);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(86, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Наименование:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(6, 79);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Цена:";
            // 
            // сategoryLabel
            // 
            сategoryLabel.AutoSize = true;
            сategoryLabel.Location = new System.Drawing.Point(6, 105);
            сategoryLabel.Name = "сategoryLabel";
            сategoryLabel.Size = new System.Drawing.Size(63, 13);
            сategoryLabel.TabIndex = 8;
            сategoryLabel.Text = "Категория:";
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Location = new System.Drawing.Point(313, 105);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new System.Drawing.Size(48, 13);
            indexLabel.TabIndex = 9;
            indexLabel.Text = "Индекс:";
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.TreatmentСaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(98, 76);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(333, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(indexLabel);
            this.groupBox1.Controls.Add(this.indexTextBox);
            this.groupBox1.Controls.Add(сategoryLabel);
            this.groupBox1.Controls.Add(this.сategoryTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Услуга";
            // 
            // indexTextBox
            // 
            this.indexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Index", true));
            this.indexTextBox.Location = new System.Drawing.Point(377, 102);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(54, 20);
            this.indexTextBox.TabIndex = 10;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.dbconnectionDataSet;
            // 
            // dbconnectionDataSet
            // 
            this.dbconnectionDataSet.DataSetName = "DbconnectionDataSet";
            this.dbconnectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сategoryTextBox
            // 
            this.сategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Сategory", true));
            this.сategoryTextBox.Location = new System.Drawing.Point(98, 102);
            this.сategoryTextBox.Name = "сategoryTextBox";
            this.сategoryTextBox.Size = new System.Drawing.Size(209, 20);
            this.сategoryTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(98, 20);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(333, 50);
            this.nameTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(379, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(298, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ок";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DoctorsTableAdapter = null;
            this.tableAdapterManager1.ImagesTableAdapter = null;
            this.tableAdapterManager1.OwnersTableAdapter = null;
            this.tableAdapterManager1.PetsTableAdapter = null;
            this.tableAdapterManager1.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager1.TreatmentСaseTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = VetClinicApp.DbconnectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ServiceCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 184);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(481, 223);
            this.MinimumSize = new System.Drawing.Size(481, 223);
            this.Name = "ServiceCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма услуги";
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbconnectionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private DBVetClinicaDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.TextBox priceTextBox;
        protected internal System.Windows.Forms.TextBox nameTextBox;
        private DbconnectionDataSet dbconnectionDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private DbconnectionDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private DbconnectionDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        protected internal System.Windows.Forms.TextBox indexTextBox;
        protected internal System.Windows.Forms.TextBox сategoryTextBox;
    }
}