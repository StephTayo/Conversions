
namespace Conversions
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtCentimeters = new System.Windows.Forms.TextBox();
            this.btnToMetric = new System.Windows.Forms.Button();
            this.btnToImperial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Centimeters";
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(104, 42);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(100, 29);
            this.txtFeet.TabIndex = 3;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(104, 116);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(100, 29);
            this.txtInches.TabIndex = 4;
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(506, 92);
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(100, 29);
            this.txtCentimeters.TabIndex = 5;
            // 
            // btnToMetric
            // 
            this.btnToMetric.Location = new System.Drawing.Point(283, 35);
            this.btnToMetric.Name = "btnToMetric";
            this.btnToMetric.Size = new System.Drawing.Size(57, 41);
            this.btnToMetric.TabIndex = 6;
            this.btnToMetric.Text = ">>";
            this.btnToMetric.UseVisualStyleBackColor = true;
            this.btnToMetric.Click += new System.EventHandler(this.btnToMetric_Click);
            // 
            // btnToImperial
            // 
            this.btnToImperial.Location = new System.Drawing.Point(283, 116);
            this.btnToImperial.Name = "btnToImperial";
            this.btnToImperial.Size = new System.Drawing.Size(57, 41);
            this.btnToImperial.TabIndex = 7;
            this.btnToImperial.Text = "<<";
            this.btnToImperial.UseVisualStyleBackColor = true;
            this.btnToImperial.Click += new System.EventHandler(this.btnToImperial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 205);
            this.Controls.Add(this.btnToImperial);
            this.Controls.Add(this.btnToMetric);
            this.Controls.Add(this.txtCentimeters);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtCentimeters;
        private System.Windows.Forms.Button btnToMetric;
        private System.Windows.Forms.Button btnToImperial;
    }
}

