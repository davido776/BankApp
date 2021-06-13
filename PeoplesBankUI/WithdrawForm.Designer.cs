
namespace PeoplesBankUI
{
    partial class WithdrawForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudAmountToWithdraw = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProcess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToWithdraw)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(83, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount To Withdraw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(83, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Specify Account";
            // 
            // nudAmountToWithdraw
            // 
            this.nudAmountToWithdraw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudAmountToWithdraw.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAmountToWithdraw.Location = new System.Drawing.Point(427, 92);
            this.nudAmountToWithdraw.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAmountToWithdraw.Name = "nudAmountToWithdraw";
            this.nudAmountToWithdraw.Size = new System.Drawing.Size(180, 31);
            this.nudAmountToWithdraw.TabIndex = 4;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAccountType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(427, 158);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(182, 33);
            this.cmbAccountType.TabIndex = 18;
            this.cmbAccountType.Text = "specify account";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.Location = new System.Drawing.Point(342, 268);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(305, 55);
            this.btnDeposit.TabIndex = 19;
            this.btnDeposit.Text = "Withdraw";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProcess);
            this.panel1.Location = new System.Drawing.Point(427, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 45);
            this.panel1.TabIndex = 20;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblProcess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProcess.Location = new System.Drawing.Point(58, 11);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 28);
            this.lblProcess.TabIndex = 0;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.nudAmountToWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WithdrawForm";
            this.Text = "WithdrawForm";
            this.Load += new System.EventHandler(this.WithdrawForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToWithdraw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAmountToWithdraw;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProcess;
    }
}