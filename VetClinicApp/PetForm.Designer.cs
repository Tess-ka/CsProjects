
namespace VetClinicApp
{
    partial class PetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetForm));
            this.petBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVetClinicaDataSet = new VetClinicApp.DBVetClinicaDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.petBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.petDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petIdSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.petIdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.petIdToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.petIdSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.petTableAdapter = new VetClinicApp.DBVetClinicaDataSetTableAdapters.PetTableAdapter();
            this.tableAdapterManager = new VetClinicApp.DBVetClinicaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingNavigator)).BeginInit();
            this.petBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDataGridView)).BeginInit();
            this.petIdSearchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // petBindingNavigator
            // 
            this.petBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.petBindingNavigator.BindingSource = this.petBindingSource;
            this.petBindingNavigator.CountItem = null;
            this.petBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.petBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.petBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.petBindingNavigatorSaveItem});
            this.petBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.petBindingNavigator.MoveFirstItem = null;
            this.petBindingNavigator.MoveLastItem = null;
            this.petBindingNavigator.MoveNextItem = null;
            this.petBindingNavigator.MovePreviousItem = null;
            this.petBindingNavigator.Name = "petBindingNavigator";
            this.petBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.petBindingNavigator.PositionItem = null;
            this.petBindingNavigator.Size = new System.Drawing.Size(964, 33);
            this.petBindingNavigator.TabIndex = 0;
            this.petBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // petBindingNavigatorSaveItem
            // 
            this.petBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.petBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("petBindingNavigatorSaveItem.Image")));
            this.petBindingNavigatorSaveItem.Name = "petBindingNavigatorSaveItem";
            this.petBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.petBindingNavigatorSaveItem.Text = "Save Data";
            this.petBindingNavigatorSaveItem.Click += new System.EventHandler(this.petBindingNavigatorSaveItem_Click);
            // 
            // petDataGridView
            // 
            this.petDataGridView.AutoGenerateColumns = false;
            this.petDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.petDataGridView.Location = new System.Drawing.Point(0, 78);
            this.petDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.petDataGridView.Name = "petDataGridView";
            this.petDataGridView.RowHeadersWidth = 62;
            this.petDataGridView.RowTemplate.Height = 28;
            this.petDataGridView.Size = new System.Drawing.Size(964, 571);
            this.petDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PetId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PetId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Species";
            this.dataGridViewTextBoxColumn5.HeaderText = "Species";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BreedType";
            this.dataGridViewTextBoxColumn6.HeaderText = "BreedType";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn7.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OwnerID";
            this.dataGridViewTextBoxColumn8.HeaderText = "OwnerID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // petIdSearchToolStrip
            // 
            this.petIdSearchToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.petIdSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.petIdToolStripLabel,
            this.petIdToolStripTextBox,
            this.petIdSearchToolStripButton});
            this.petIdSearchToolStrip.Location = new System.Drawing.Point(0, 33);
            this.petIdSearchToolStrip.Name = "petIdSearchToolStrip";
            this.petIdSearchToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.petIdSearchToolStrip.Size = new System.Drawing.Size(964, 34);
            this.petIdSearchToolStrip.TabIndex = 2;
            this.petIdSearchToolStrip.Text = "petIdSearchToolStrip";
            // 
            // petIdToolStripLabel
            // 
            this.petIdToolStripLabel.Name = "petIdToolStripLabel";
            this.petIdToolStripLabel.Size = new System.Drawing.Size(56, 29);
            this.petIdToolStripLabel.Text = "PetId:";
            // 
            // petIdToolStripTextBox
            // 
            this.petIdToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.petIdToolStripTextBox.Name = "petIdToolStripTextBox";
            this.petIdToolStripTextBox.Size = new System.Drawing.Size(68, 34);
            // 
            // petIdSearchToolStripButton
            // 
            this.petIdSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.petIdSearchToolStripButton.Name = "petIdSearchToolStripButton";
            this.petIdSearchToolStripButton.Size = new System.Drawing.Size(108, 29);
            this.petIdSearchToolStripButton.Text = "PetIdSearch";
            this.petIdSearchToolStripButton.Click += new System.EventHandler(this.petIdSearchToolStripButton_Click);
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
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 648);
            this.Controls.Add(this.petIdSearchToolStrip);
            this.Controls.Add(this.petDataGridView);
            this.Controls.Add(this.petBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PetForm";
            this.Text = "PetForm";
            this.Load += new System.EventHandler(this.PetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petBindingNavigator)).EndInit();
            this.petBindingNavigator.ResumeLayout(false);
            this.petBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVetClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petDataGridView)).EndInit();
            this.petIdSearchToolStrip.ResumeLayout(false);
            this.petIdSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBVetClinicaDataSet dBVetClinicaDataSet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private DBVetClinicaDataSetTableAdapters.PetTableAdapter petTableAdapter;
        private DBVetClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator petBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton petBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView petDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStrip petIdSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel petIdToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox petIdToolStripTextBox;
        private System.Windows.Forms.ToolStripButton petIdSearchToolStripButton;
    }
}