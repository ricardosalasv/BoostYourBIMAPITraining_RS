
namespace BoostYourBIMAPITraining
{
    partial class myNewForm
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
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.groupBoxDirection = new System.Windows.Forms.GroupBox();
            this.radioBtnVertical = new System.Windows.Forms.RadioButton();
            this.radioBtnHorizontal = new System.Windows.Forms.RadioButton();
            this.groupBoxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(329, 334);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 0;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(248, 334);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(96, 32);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(172, 23);
            this.textBoxDistance.TabIndex = 2;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDistance.Location = new System.Drawing.Point(13, 32);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(69, 21);
            this.labelDistance.TabIndex = 3;
            this.labelDistance.Text = "Distance";
            this.labelDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Controls.Add(this.radioBtnHorizontal);
            this.groupBoxDirection.Controls.Add(this.radioBtnVertical);
            this.groupBoxDirection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDirection.Location = new System.Drawing.Point(13, 71);
            this.groupBoxDirection.Name = "groupBoxDirection";
            this.groupBoxDirection.Size = new System.Drawing.Size(255, 106);
            this.groupBoxDirection.TabIndex = 4;
            this.groupBoxDirection.TabStop = false;
            this.groupBoxDirection.Text = "Direction";
            // 
            // radioBtnVertical
            // 
            this.radioBtnVertical.AutoSize = true;
            this.radioBtnVertical.Location = new System.Drawing.Point(7, 29);
            this.radioBtnVertical.Name = "radioBtnVertical";
            this.radioBtnVertical.Size = new System.Drawing.Size(79, 25);
            this.radioBtnVertical.TabIndex = 0;
            this.radioBtnVertical.TabStop = true;
            this.radioBtnVertical.Text = "Vertical";
            this.radioBtnVertical.UseVisualStyleBackColor = true;
            // 
            // radioBtnHorizontal
            // 
            this.radioBtnHorizontal.AutoSize = true;
            this.radioBtnHorizontal.Location = new System.Drawing.Point(7, 60);
            this.radioBtnHorizontal.Name = "radioBtnHorizontal";
            this.radioBtnHorizontal.Size = new System.Drawing.Size(100, 25);
            this.radioBtnHorizontal.TabIndex = 0;
            this.radioBtnHorizontal.TabStop = true;
            this.radioBtnHorizontal.Text = "Horizontal";
            this.radioBtnHorizontal.UseVisualStyleBackColor = true;
            // 
            // myNewForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCANCEL;
            this.ClientSize = new System.Drawing.Size(416, 369);
            this.Controls.Add(this.groupBoxDirection);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCANCEL);
            this.Name = "myNewForm";
            this.Text = "myNewForm";
            this.groupBoxDirection.ResumeLayout(false);
            this.groupBoxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.GroupBox groupBoxDirection;
        private System.Windows.Forms.RadioButton radioBtnHorizontal;
        private System.Windows.Forms.RadioButton radioBtnVertical;
    }
}