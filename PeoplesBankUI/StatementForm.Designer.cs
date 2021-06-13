
namespace PeoplesBankUI
{
    partial class StatementForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.lvStatement = new System.Windows.Forms.ListView();
            this.TransactionID = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.TransactionDate = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lblCurrentBalanceFigure = new System.Windows.Forms.Label();
            this.btnGetStatement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Specify Account";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAccountType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(285, 45);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(182, 33);
            this.cmbAccountType.TabIndex = 19;
            this.cmbAccountType.Text = "specify account";
            // 
            // lvStatement
            // 
            this.lvStatement.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvStatement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionID,
            this.Amount,
            this.TransactionDate,
            this.Description});
            this.lvStatement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvStatement.HideSelection = false;
            this.lvStatement.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvStatement.Location = new System.Drawing.Point(0, 257);
            this.lvStatement.Name = "lvStatement";
            this.lvStatement.Size = new System.Drawing.Size(800, 449);
            this.lvStatement.TabIndex = 20;
            this.lvStatement.UseCompatibleStateImageBehavior = false;
            this.lvStatement.View = System.Windows.Forms.View.Details;
            this.lvStatement.SelectedIndexChanged += new System.EventHandler(this.lvStatement_SelectedIndexChanged);
            // 
            // TransactionID
            // 
            this.TransactionID.Text = "TransactionID";
            this.TransactionID.Width = 200;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 200;
            // 
            // TransactionDate
            // 
            this.TransactionDate.Text = "TransactionDate";
            this.TransactionDate.Width = 200;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCurrentBalance.Location = new System.Drawing.Point(71, 133);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(243, 24);
            this.lblCurrentBalance.TabIndex = 22;
            this.lblCurrentBalance.Text = "Current Balance : ";
            // 
            // lblCurrentBalanceFigure
            // 
            this.lblCurrentBalanceFigure.AutoSize = true;
            this.lblCurrentBalanceFigure.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentBalanceFigure.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCurrentBalanceFigure.Location = new System.Drawing.Point(343, 133);
            this.lblCurrentBalanceFigure.Name = "lblCurrentBalanceFigure";
            this.lblCurrentBalanceFigure.Size = new System.Drawing.Size(0, 24);
            this.lblCurrentBalanceFigure.TabIndex = 23;
            // 
            // btnGetStatement
            // 
            this.btnGetStatement.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStatement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetStatement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetStatement.Location = new System.Drawing.Point(563, 45);
            this.btnGetStatement.Name = "btnGetStatement";
            this.btnGetStatement.Size = new System.Drawing.Size(225, 33);
            this.btnGetStatement.TabIndex = 24;
            this.btnGetStatement.Text = "Get Statement";
            this.btnGetStatement.UseVisualStyleBackColor = false;
            this.btnGetStatement.Click += new System.EventHandler(this.btnGetStatement_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(71, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Account Number : ";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAccountNumber.Location = new System.Drawing.Point(352, 179);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(0, 24);
            this.lblAccountNumber.TabIndex = 26;
            // 
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetStatement);
            this.Controls.Add(this.lblCurrentBalanceFigure);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.lvStatement);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label2);
            this.Name = "StatementForm";
            this.Load += new System.EventHandler(this.StatementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.ListView lvStatement;
        private System.Windows.Forms.ColumnHeader TransactionID;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader TransactionDate;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblCurrentBalanceFigure;
        private System.Windows.Forms.Button btnGetStatement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}