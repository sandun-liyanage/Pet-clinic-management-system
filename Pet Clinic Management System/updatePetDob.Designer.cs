﻿
namespace Pet_Clinic_Management_System
{
    partial class updatePetDob
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.petID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(28, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 47);
            this.button2.TabIndex = 52;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(486, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 51;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dob.Location = new System.Drawing.Point(621, 304);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(284, 34);
            this.dob.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(456, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 49;
            this.label2.Text = "New DOB";
            // 
            // petID
            // 
            this.petID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.petID.Location = new System.Drawing.Point(621, 228);
            this.petID.Name = "petID";
            this.petID.Size = new System.Drawing.Size(284, 34);
            this.petID.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(456, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 31);
            this.label6.TabIndex = 47;
            this.label6.Text = "Enter pet ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 72);
            this.label1.TabIndex = 46;
            this.label1.Text = "Update pet\'s date of birth";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(740, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 47);
            this.button3.TabIndex = 53;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updatePetDob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pet_Clinic_Management_System.Properties.Resources._115488;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 718);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "updatePetDob";
            this.Text = "updatePetDob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox petID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}