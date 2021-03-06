﻿namespace MusicRandomizer
{
    partial class RegionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpRegions = new System.Windows.Forms.GroupBox();
            this.radJapan = new System.Windows.Forms.RadioButton();
            this.radEurope = new System.Windows.Forms.RadioButton();
            this.radNorthAmerica = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpRegions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What region is your Splatoon copy in?";
            // 
            // grpRegions
            // 
            this.grpRegions.Controls.Add(this.radJapan);
            this.grpRegions.Controls.Add(this.radEurope);
            this.grpRegions.Controls.Add(this.radNorthAmerica);
            this.grpRegions.Location = new System.Drawing.Point(15, 25);
            this.grpRegions.Name = "grpRegions";
            this.grpRegions.Size = new System.Drawing.Size(190, 100);
            this.grpRegions.TabIndex = 1;
            this.grpRegions.TabStop = false;
            this.grpRegions.Text = "Regions";
            // 
            // radJapan
            // 
            this.radJapan.AutoSize = true;
            this.radJapan.Location = new System.Drawing.Point(7, 66);
            this.radJapan.Name = "radJapan";
            this.radJapan.Size = new System.Drawing.Size(54, 17);
            this.radJapan.TabIndex = 2;
            this.radJapan.TabStop = true;
            this.radJapan.Text = "Japan";
            this.radJapan.UseVisualStyleBackColor = true;
            // 
            // radEurope
            // 
            this.radEurope.AutoSize = true;
            this.radEurope.Location = new System.Drawing.Point(7, 43);
            this.radEurope.Name = "radEurope";
            this.radEurope.Size = new System.Drawing.Size(59, 17);
            this.radEurope.TabIndex = 1;
            this.radEurope.TabStop = true;
            this.radEurope.Text = "Europe";
            this.radEurope.UseVisualStyleBackColor = true;
            // 
            // radNorthAmerica
            // 
            this.radNorthAmerica.AutoSize = true;
            this.radNorthAmerica.Location = new System.Drawing.Point(7, 20);
            this.radNorthAmerica.Name = "radNorthAmerica";
            this.radNorthAmerica.Size = new System.Drawing.Size(92, 17);
            this.radNorthAmerica.TabIndex = 0;
            this.radNorthAmerica.TabStop = true;
            this.radNorthAmerica.Text = "North America";
            this.radNorthAmerica.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 162);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpRegions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegionForm";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.VersionRequestForm_Load);
            this.grpRegions.ResumeLayout(false);
            this.grpRegions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRegions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radJapan;
        private System.Windows.Forms.RadioButton radEurope;
        private System.Windows.Forms.RadioButton radNorthAmerica;
    }
}