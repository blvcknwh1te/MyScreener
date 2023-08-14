namespace MyScreener
{
    partial class MainForm
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.addCriteriaGroupBox = new System.Windows.Forms.GroupBox();
            this.editCriteriaGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.addCriteria2ComboBox = new System.Windows.Forms.GroupBox();
            this.editCriteriaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(1010, 410);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(162, 40);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // addCriteriaGroupBox
            // 
            this.addCriteriaGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCriteriaGroupBox.Location = new System.Drawing.Point(10, 10);
            this.addCriteriaGroupBox.Name = "addCriteriaGroupBox";
            this.addCriteriaGroupBox.Size = new System.Drawing.Size(140, 300);
            this.addCriteriaGroupBox.TabIndex = 1;
            this.addCriteriaGroupBox.TabStop = false;
            this.addCriteriaGroupBox.Text = "Add Criteria";
            // 
            // editCriteriaGroupBox
            // 
            this.editCriteriaGroupBox.Controls.Add(this.radioButton1);
            this.editCriteriaGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editCriteriaGroupBox.Location = new System.Drawing.Point(556, 10);
            this.editCriteriaGroupBox.Name = "editCriteriaGroupBox";
            this.editCriteriaGroupBox.Size = new System.Drawing.Size(400, 300);
            this.editCriteriaGroupBox.TabIndex = 3;
            this.editCriteriaGroupBox.TabStop = false;
            this.editCriteriaGroupBox.Text = "Edit Criteria";
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ratio (Test)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // addCriteria2ComboBox
            // 
            this.addCriteria2ComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCriteria2ComboBox.Location = new System.Drawing.Point(160, 10);
            this.addCriteria2ComboBox.Name = "addCriteria2ComboBox";
            this.addCriteria2ComboBox.Size = new System.Drawing.Size(230, 300);
            this.addCriteria2ComboBox.TabIndex = 2;
            this.addCriteria2ComboBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.addCriteria2ComboBox);
            this.Controls.Add(this.editCriteriaGroupBox);
            this.Controls.Add(this.addCriteriaGroupBox);
            this.Controls.Add(this.buttonApply);
            this.Name = "MainForm";
            this.Text = "Screener";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.editCriteriaGroupBox.ResumeLayout(false);
            this.editCriteriaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonApply;
        private GroupBox addCriteriaGroupBox;
        private GroupBox editCriteriaGroupBox;
        private RadioButton radioButton1;
        private GroupBox addCriteria2ComboBox;
    }
}