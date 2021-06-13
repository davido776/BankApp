
namespace PeoplesBankUI
{
    partial class TransferForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecipientAccountNumber = new System.Windows.Forms.TextBox();
            this.nudAmountToTransfer = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipient Account Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount To Transfer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Specify Account : ";
            // 
            // txtRecipientAccountNumber
            // 
            this.txtRecipientAccountNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRecipientAccountNumber.Location = new System.Drawing.Point(390, 61);
            this.txtRecipientAccountNumber.Name = "txtRecipientAccountNumber";
            this.txtRecipientAccountNumber.Size = new System.Drawing.Size(360, 31);
            this.txtRecipientAccountNumber.TabIndex = 7;
            // 
            // nudAmountToTransfer
            // 
            this.nudAmountToTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudAmountToTransfer.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAmountToTransfer.Location = new System.Drawing.Point(390, 117);
            this.nudAmountToTransfer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAmountToTransfer.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAmountToTransfer.Name = "nudAmountToTransfer";
            this.nudAmountToTransfer.Size = new System.Drawing.Size(180, 31);
            this.nudAmountToTransfer.TabIndex = 8;
            this.nudAmountToTransfer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(390, 174);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(182, 33);
            this.cmbAccountType.TabIndex = 18;
            this.cmbAccountType.SelectedIndexChanged += new System.EventHandler(this.cmbAccountType_SelectedIndexChanged);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransfer.Location = new System.Drawing.Point(390, 295);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(305, 55);
            this.btnTransfer.TabIndex = 19;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.nudAmountToTransfer);
            this.Controls.Add(this.txtRecipientAccountNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecipientAccountNumber;
        private System.Windows.Forms.NumericUpDown nudAmountToTransfer;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Button btnTransfer;
    }
}