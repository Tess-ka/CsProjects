
namespace VetClinicApp
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.ownerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ownerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ownerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchOwnerToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchOwnerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ownerTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.OwnerTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingNavigator)).BeginInit();
            this.ownerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataGridView)).BeginInit();
            this.searchOwnerToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownerBindingNavigator
            // 
            this.ownerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ownerBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerBindingNavigator.BindingSource = this.ownerBindingSource;
            this.ownerBindingNavigator.CountItem = null;
            this.ownerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ownerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.ownerBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ownerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ownerBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.ownerBindingNavigator.Location = new System.Drawing.Point(1044, 0);
            this.ownerBindingNavigator.MoveFirstItem = null;
            this.ownerBindingNavigator.MoveLastItem = null;
            this.ownerBindingNavigator.MoveNextItem = null;
            this.ownerBindingNavigator.MovePreviousItem = null;
            this.ownerBindingNavigator.Name = "ownerBindingNavigator";
            this.ownerBindingNavigator.PositionItem = null;
            this.ownerBindingNavigator.Size = new System.Drawing.Size(108, 31);
            this.ownerBindingNavigator.TabIndex = 0;
            this.ownerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.dBVetClinicaDataSet;
            // 
            // dBVetClinicaDataSet
            // 
            this.dBVetClinicaDataSet.DataSetName = "DBVetClinicaDataSet";
            this.dBVetClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // ownerBindingNavigatorSaveItem
            // 
            this.ownerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ownerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ownerBindingNavigatorSaveItem.Image")));
            this.ownerBindingNavigatorSaveItem.Name = "ownerBindingNavigatorSaveItem";
            this.ownerBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.ownerBindingNavigatorSaveItem.Text = "Save Data";
            this.ownerBindingNavigatorSaveItem.Click += new System.EventHandler(this.ownerBindingNavigatorSaveItem_Click);
            // 
            // ownerDataGridView
            // 
            this.ownerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerDataGridView.AutoGenerateColumns = false;
            this.ownerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ownerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ownerDataGridView.DataSource = this.ownerBindingSource;
            this.ownerDataGridView.Location = new System.Drawing.Point(0, 28);
            this.ownerDataGridView.Name = "ownerDataGridView";
            this.ownerDataGridView.RowHeadersWidth = 62;
            this.ownerDataGridView.Size = new System.Drawing.Size(1152, 727);
            this.ownerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OwnerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FatherName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn5.HeaderText = "День рождения";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "E-mail";
            this.dataGridViewTextBoxColumn7.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // searchOwnerToolStrip
            // 
            this.searchOwnerToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchOwnerToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchOwnerToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.searchOwnerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameToolStripLabel,
            this.lastNameToolStripTextBox,
            this.searchOwnerToolStripButton});
            this.searchOwnerToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchOwnerToolStrip.Name = "searchOwnerToolStrip";
            this.searchOwnerToolStrip.Size = new System.Drawing.Size(273, 25);
            this.searchOwnerToolStrip.TabIndex = 2;
            this.searchOwnerToolStrip.Text = "searchOwnerToolStrip";
            // 
            // lastNameToolStripLabel
            // 
            this.lastNameToolStripLabel.Name = "lastNameToolStripLabel";
            this.lastNameToolStripLabel.Size = new System.Drawing.Size(114, 22);
            this.lastNameToolStripLabel.Text = "Поиск по фамилии";
            // 
            // lastNameToolStripTextBox
            // 
            this.lastNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameToolStripTextBox.Name = "lastNameToolStripTextBox";
            this.lastNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchOwnerToolStripButton
            // 
            this.searchOwnerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchOwnerToolStripButton.Name = "searchOwnerToolStripButton";
            this.searchOwnerToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.searchOwnerToolStripButton.Text = "Найти";
            this.searchOwnerToolStripButton.Click += new System.EventHandler(this.searchOwnerToolStripButton_Click);
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = this.ownerTableAdapter;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TreatmentСaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 749);
            this.Controls.Add(this.searchOwnerToolStrip);
            this.Controls.Add(this.ownerDataGridView);
            this.Controls.Add(this.ownerBindingNavigator);
            this.Name = "OwnerForm";
            this.Text = "OwnerForm";
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingNavigator)).EndInit();
            this.ownerBindingNavigator.ResumeLayout(false);
            this.ownerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataGridView)).EndInit();
            this.searchOwnerToolStrip.ResumeLayout(false);
            this.searchOwnerToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private DBVetClinicaDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ownerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton ownerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ownerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStrip searchOwnerToolStrip;
        private System.Windows.Forms.ToolStripLabel lastNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lastNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchOwnerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}