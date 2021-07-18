
namespace VetClinicApp
{
    partial class MainFormVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormVet));
            this.MainFormPicture = new System.Windows.Forms.PictureBox();
            this.OpenCase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormPicture
            // 
            this.MainFormPicture.Image = ((System.Drawing.Image)(resources.GetObject("MainFormPicture.Image")));
            this.MainFormPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("MainFormPicture.InitialImage")));
            this.MainFormPicture.Location = new System.Drawing.Point(482, 12);
            this.MainFormPicture.Name = "MainFormPicture";
            this.MainFormPicture.Size = new System.Drawing.Size(455, 605);
            this.MainFormPicture.TabIndex = 1;
            this.MainFormPicture.TabStop = false;
            this.MainFormPicture.WaitOnLoad = true;
            // 
            // OpenCase
            // 
            this.OpenCase.Location = new System.Drawing.Point(150, 108);
            this.OpenCase.Name = "OpenCase";
            this.OpenCase.Size = new System.Drawing.Size(203, 55);
            this.OpenCase.TabIndex = 2;
            this.OpenCase.Text = "Новый случай лечения";
            this.OpenCase.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Питомцы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenCase);
            this.Controls.Add(this.MainFormPicture);
            this.Name = "MainFormVet";
            this.Text = "Ветеринарная клиника";
            this.Load += new System.EventHandler(this.MainFormVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainFormPicture;
        private System.Windows.Forms.Button OpenCase;
        private System.Windows.Forms.Button button1;
    }
}

