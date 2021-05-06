
namespace AliasChanger
{
    partial class AliasChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AliasChanger));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeRDAliascheckBox = new System.Windows.Forms.CheckBox();
            this.RdAliasTextBox = new System.Windows.Forms.TextBox();
            this.pccAliasTextBox = new System.Windows.Forms.TextBox();
            this.clearDbCheckBox = new System.Windows.Forms.CheckBox();
            this.changeAliasBtn = new System.Windows.Forms.Button();
            this.sameRdAliasCheckBox = new System.Windows.Forms.CheckBox();
            this.RdServerAliasLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeRDAliascheckBox);
            this.groupBox1.Controls.Add(this.RdAliasTextBox);
            this.groupBox1.Controls.Add(this.pccAliasTextBox);
            this.groupBox1.Controls.Add(this.clearDbCheckBox);
            this.groupBox1.Controls.Add(this.changeAliasBtn);
            this.groupBox1.Controls.Add(this.sameRdAliasCheckBox);
            this.groupBox1.Controls.Add(this.RdServerAliasLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // changeRDAliascheckBox
            // 
            this.changeRDAliascheckBox.AutoSize = true;
            this.changeRDAliascheckBox.Location = new System.Drawing.Point(120, 23);
            this.changeRDAliascheckBox.Name = "changeRDAliascheckBox";
            this.changeRDAliascheckBox.Size = new System.Drawing.Size(105, 17);
            this.changeRDAliascheckBox.TabIndex = 8;
            this.changeRDAliascheckBox.Text = "change RD alias";
            this.changeRDAliascheckBox.UseVisualStyleBackColor = true;
            this.changeRDAliascheckBox.CheckedChanged += new System.EventHandler(this.changeRDAliascheckBox_CheckedChanged);
            // 
            // RdAliasTextBox
            // 
            this.RdAliasTextBox.Location = new System.Drawing.Point(7, 87);
            this.RdAliasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RdAliasTextBox.Name = "RdAliasTextBox";
            this.RdAliasTextBox.Size = new System.Drawing.Size(96, 20);
            this.RdAliasTextBox.TabIndex = 7;
            this.RdAliasTextBox.Visible = false;
            // 
            // pccAliasTextBox
            // 
            this.pccAliasTextBox.Location = new System.Drawing.Point(7, 41);
            this.pccAliasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pccAliasTextBox.Name = "pccAliasTextBox";
            this.pccAliasTextBox.Size = new System.Drawing.Size(96, 20);
            this.pccAliasTextBox.TabIndex = 6;
            this.pccAliasTextBox.TextChanged += new System.EventHandler(this.pccAliasTextBox_TextChanged);
            // 
            // clearDbCheckBox
            // 
            this.clearDbCheckBox.AutoSize = true;
            this.clearDbCheckBox.Location = new System.Drawing.Point(120, 90);
            this.clearDbCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.clearDbCheckBox.Name = "clearDbCheckBox";
            this.clearDbCheckBox.Size = new System.Drawing.Size(95, 17);
            this.clearDbCheckBox.TabIndex = 5;
            this.clearDbCheckBox.Text = "clear client DB";
            this.clearDbCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeAliasBtn
            // 
            this.changeAliasBtn.Enabled = false;
            this.changeAliasBtn.Location = new System.Drawing.Point(7, 120);
            this.changeAliasBtn.Margin = new System.Windows.Forms.Padding(2);
            this.changeAliasBtn.Name = "changeAliasBtn";
            this.changeAliasBtn.Size = new System.Drawing.Size(222, 28);
            this.changeAliasBtn.TabIndex = 1;
            this.changeAliasBtn.Text = "Change Alias";
            this.changeAliasBtn.UseVisualStyleBackColor = true;
            this.changeAliasBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sameRdAliasCheckBox
            // 
            this.sameRdAliasCheckBox.AutoSize = true;
            this.sameRdAliasCheckBox.Checked = true;
            this.sameRdAliasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sameRdAliasCheckBox.Enabled = false;
            this.sameRdAliasCheckBox.Location = new System.Drawing.Point(120, 56);
            this.sameRdAliasCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.sameRdAliasCheckBox.Name = "sameRdAliasCheckBox";
            this.sameRdAliasCheckBox.Size = new System.Drawing.Size(109, 17);
            this.sameRdAliasCheckBox.TabIndex = 4;
            this.sameRdAliasCheckBox.Text = "same alias for RD";
            this.sameRdAliasCheckBox.UseVisualStyleBackColor = true;
            this.sameRdAliasCheckBox.CheckedChanged += new System.EventHandler(this.sameRdAliasCheckBox_CheckedChanged);
            // 
            // RdServerAliasLbl
            // 
            this.RdServerAliasLbl.AutoSize = true;
            this.RdServerAliasLbl.Location = new System.Drawing.Point(4, 71);
            this.RdServerAliasLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RdServerAliasLbl.Name = "RdServerAliasLbl";
            this.RdServerAliasLbl.Size = new System.Drawing.Size(79, 13);
            this.RdServerAliasLbl.TabIndex = 1;
            this.RdServerAliasLbl.Text = "RD server alias";
            this.RdServerAliasLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCC server alias";
            // 
            // AliasChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 192);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AliasChanger";
            this.Text = "Alias Changer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sameRdAliasCheckBox;
        private System.Windows.Forms.Label RdServerAliasLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox clearDbCheckBox;
        private System.Windows.Forms.Button changeAliasBtn;
        private System.Windows.Forms.TextBox RdAliasTextBox;
        private System.Windows.Forms.TextBox pccAliasTextBox;
        private System.Windows.Forms.CheckBox changeRDAliascheckBox;
    }
}

