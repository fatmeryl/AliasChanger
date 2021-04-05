
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
            this.clearDbCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sameRdAliasCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBoxRdAlias = new System.Windows.Forms.ComboBox();
            this.comboBoxPccAlias = new System.Windows.Forms.ComboBox();
            this.RdServerAliasLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearDbCheckBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sameRdAliasCheckBox);
            this.groupBox1.Controls.Add(this.comboBoxRdAlias);
            this.groupBox1.Controls.Add(this.comboBoxPccAlias);
            this.groupBox1.Controls.Add(this.RdServerAliasLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // clearDbCheckBox
            // 
            this.clearDbCheckBox.AutoSize = true;
            this.clearDbCheckBox.Location = new System.Drawing.Point(163, 86);
            this.clearDbCheckBox.Name = "clearDbCheckBox";
            this.clearDbCheckBox.Size = new System.Drawing.Size(121, 21);
            this.clearDbCheckBox.TabIndex = 5;
            this.clearDbCheckBox.Text = "clear client DB";
            this.clearDbCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Alias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sameRdAliasCheckBox
            // 
            this.sameRdAliasCheckBox.AutoSize = true;
            this.sameRdAliasCheckBox.Checked = true;
            this.sameRdAliasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sameRdAliasCheckBox.Location = new System.Drawing.Point(163, 51);
            this.sameRdAliasCheckBox.Name = "sameRdAliasCheckBox";
            this.sameRdAliasCheckBox.Size = new System.Drawing.Size(142, 21);
            this.sameRdAliasCheckBox.TabIndex = 4;
            this.sameRdAliasCheckBox.Text = "same alias for RD";
            this.sameRdAliasCheckBox.UseVisualStyleBackColor = true;
            this.sameRdAliasCheckBox.CheckedChanged += new System.EventHandler(this.sameRdAliasCheckBox_CheckedChanged);
            // 
            // comboBoxRdAlias
            // 
            this.comboBoxRdAlias.FormattingEnabled = true;
            this.comboBoxRdAlias.Location = new System.Drawing.Point(9, 107);
            this.comboBoxRdAlias.Name = "comboBoxRdAlias";
            this.comboBoxRdAlias.Size = new System.Drawing.Size(122, 24);
            this.comboBoxRdAlias.TabIndex = 3;
            this.comboBoxRdAlias.Visible = false;
            // 
            // comboBoxPccAlias
            // 
            this.comboBoxPccAlias.FormattingEnabled = true;
            this.comboBoxPccAlias.Location = new System.Drawing.Point(9, 48);
            this.comboBoxPccAlias.Name = "comboBoxPccAlias";
            this.comboBoxPccAlias.Size = new System.Drawing.Size(122, 24);
            this.comboBoxPccAlias.TabIndex = 2;
            // 
            // RdServerAliasLbl
            // 
            this.RdServerAliasLbl.AutoSize = true;
            this.RdServerAliasLbl.Location = new System.Drawing.Point(6, 87);
            this.RdServerAliasLbl.Name = "RdServerAliasLbl";
            this.RdServerAliasLbl.Size = new System.Drawing.Size(105, 17);
            this.RdServerAliasLbl.TabIndex = 1;
            this.RdServerAliasLbl.Text = "RD server alias";
            this.RdServerAliasLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PCC server alias";
            // 
            // AliasChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(338, 236);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AliasChanger";
            this.Text = "Alias Changer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sameRdAliasCheckBox;
        private System.Windows.Forms.ComboBox comboBoxRdAlias;
        private System.Windows.Forms.ComboBox comboBoxPccAlias;
        private System.Windows.Forms.Label RdServerAliasLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox clearDbCheckBox;
        private System.Windows.Forms.Button button1;
    }
}

