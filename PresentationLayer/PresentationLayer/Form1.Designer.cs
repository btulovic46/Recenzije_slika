
namespace PresentationLayer
{
    partial class Form1
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
            this.buttonLoginGallery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegisterGallery = new System.Windows.Forms.Button();
            this.buttonRegisterReviewer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoginReviewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginGallery
            // 
            this.buttonLoginGallery.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginGallery.Location = new System.Drawing.Point(38, 92);
            this.buttonLoginGallery.Name = "buttonLoginGallery";
            this.buttonLoginGallery.Size = new System.Drawing.Size(160, 50);
            this.buttonLoginGallery.TabIndex = 0;
            this.buttonLoginGallery.Text = "Log in";
            this.buttonLoginGallery.UseVisualStyleBackColor = true;
            this.buttonLoginGallery.Click += new System.EventHandler(this.buttonLoginGallery_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Galerija";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegisterGallery
            // 
            this.buttonRegisterGallery.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterGallery.Location = new System.Drawing.Point(38, 178);
            this.buttonRegisterGallery.Name = "buttonRegisterGallery";
            this.buttonRegisterGallery.Size = new System.Drawing.Size(160, 50);
            this.buttonRegisterGallery.TabIndex = 2;
            this.buttonRegisterGallery.Text = "Register";
            this.buttonRegisterGallery.UseVisualStyleBackColor = true;
            this.buttonRegisterGallery.Click += new System.EventHandler(this.buttonRegisterGallery_Click);
            // 
            // buttonRegisterReviewer
            // 
            this.buttonRegisterReviewer.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterReviewer.Location = new System.Drawing.Point(259, 178);
            this.buttonRegisterReviewer.Name = "buttonRegisterReviewer";
            this.buttonRegisterReviewer.Size = new System.Drawing.Size(160, 50);
            this.buttonRegisterReviewer.TabIndex = 5;
            this.buttonRegisterReviewer.Text = "Register";
            this.buttonRegisterReviewer.UseVisualStyleBackColor = true;
            this.buttonRegisterReviewer.Click += new System.EventHandler(this.buttonRegisterReviewer_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kriticar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoginReviewer
            // 
            this.buttonLoginReviewer.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginReviewer.Location = new System.Drawing.Point(259, 92);
            this.buttonLoginReviewer.Name = "buttonLoginReviewer";
            this.buttonLoginReviewer.Size = new System.Drawing.Size(160, 50);
            this.buttonLoginReviewer.TabIndex = 3;
            this.buttonLoginReviewer.Text = "Log in";
            this.buttonLoginReviewer.UseVisualStyleBackColor = true;
            this.buttonLoginReviewer.Click += new System.EventHandler(this.buttonLoginReviewer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 254);
            this.Controls.Add(this.buttonRegisterReviewer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoginReviewer);
            this.Controls.Add(this.buttonRegisterGallery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoginGallery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginGallery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegisterGallery;
        private System.Windows.Forms.Button buttonRegisterReviewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoginReviewer;
    }
}

