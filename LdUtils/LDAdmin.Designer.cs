namespace LdUtils
{
    partial class LDAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFlagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDev = new System.Windows.Forms.CheckBox();
            this.chkStaging = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(410, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check LD Flags";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(135, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "301877682124626847";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(31, 146);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(525, 177);
            this.txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "key/user_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flag";
            // 
            // txtFlagName
            // 
            this.txtFlagName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlagName.Location = new System.Drawing.Point(135, 73);
            this.txtFlagName.Name = "txtFlagName";
            this.txtFlagName.Size = new System.Drawing.Size(421, 27);
            this.txtFlagName.TabIndex = 5;
            this.txtFlagName.Text = "can_switch_stp2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Environments";
            // 
            // chkDev
            // 
            this.chkDev.AutoSize = true;
            this.chkDev.Checked = true;
            this.chkDev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDev.Location = new System.Drawing.Point(135, 111);
            this.chkDev.Name = "chkDev";
            this.chkDev.Size = new System.Drawing.Size(57, 24);
            this.chkDev.TabIndex = 8;
            this.chkDev.Text = "Dev";
            this.chkDev.UseVisualStyleBackColor = true;
            // 
            // chkStaging
            // 
            this.chkStaging.AutoSize = true;
            this.chkStaging.Location = new System.Drawing.Point(198, 111);
            this.chkStaging.Name = "chkStaging";
            this.chkStaging.Size = new System.Drawing.Size(82, 24);
            this.chkStaging.TabIndex = 9;
            this.chkStaging.Text = "Staging";
            this.chkStaging.UseVisualStyleBackColor = true;
            // 
            // LDAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 394);
            this.Controls.Add(this.chkStaging);
            this.Controls.Add(this.chkDev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFlagName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "LDAdmin";
            this.Text = "LDAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox txtOutput;
        private Label label1;
        private Label label2;
        private TextBox txtFlagName;
        private Label label3;
        private CheckBox chkDev;
        private CheckBox chkStaging;
    }
}