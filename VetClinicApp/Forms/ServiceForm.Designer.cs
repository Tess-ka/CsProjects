
namespace VetClinicApp
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.InsertButton2 = new System.Windows.Forms.ToolStripButton();
            this.UpdateButton2 = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton3 = new System.Windows.Forms.ToolStripButton();
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.serviceTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.ServiceTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertButton2,
            this.UpdateButton2,
            this.DeleteButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // InsertButton2
            // 
            this.InsertButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertButton2.Image = ((System.Drawing.Image)(resources.GetObject("InsertButton2.Image")));
            this.InsertButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertButton2.Name = "InsertButton2";
            this.InsertButton2.Size = new System.Drawing.Size(23, 22);
            this.InsertButton2.Text = "InsertStripButton2";
            this.InsertButton2.Click += new System.EventHandler(this.InsertButton2_Click);
            // 
            // UpdateButton2
            // 
            this.UpdateButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateButton2.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton2.Image")));
            this.UpdateButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateButton2.Name = "UpdateButton2";
            this.UpdateButton2.Size = new System.Drawing.Size(23, 22);
            this.UpdateButton2.Text = "UpdateStripButton2";
            this.UpdateButton2.Click += new System.EventHandler(this.UpdateButton2_Click);
            // 
            // DeleteButton3
            // 
            this.DeleteButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton3.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton3.Image")));
            this.DeleteButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton3.Name = "DeleteButton3";
            this.DeleteButton3.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton3.Text = "DeleteStripButton3";
            this.DeleteButton3.Click += new System.EventHandler(this.DeleteButton3_Click);
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.AllowUserToResizeColumns = false;
            this.serviceDataGridView.AutoGenerateColumns = false;
            this.serviceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.serviceDataGridView.DataSource = this.serviceBindingSource;
            this.serviceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceDataGridView.Location = new System.Drawing.Point(0, 25);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            this.serviceDataGridView.Size = new System.Drawing.Size(800, 425);
            this.serviceDataGridView.TabIndex = 2;
            this.serviceDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDataGridView_CellDoubleClick);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ServiceId";
            this.dataGridViewTextBoxColumn1.FillWeight = 66.23791F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 188.0768F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.FillWeight = 45.68528F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ServiceForm";
            this.Text = "Услуги";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton InsertButton2;
        private System.Windows.Forms.ToolStripButton UpdateButton2;
        private System.Windows.Forms.ToolStripButton DeleteButton3;
        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private DBVetClinicaDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        protected internal System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}