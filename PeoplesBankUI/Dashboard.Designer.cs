
namespace PeoplesBankUI
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panView = new System.Windows.Forms.Panel();
            this.btnGetAccountStatement = new System.Windows.Forms.Button();
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panTransactions = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDepsosit = new System.Windows.Forms.Button();
            this.btnTransactionsMenu = new System.Windows.Forms.Button();
            this.panAccount = new System.Windows.Forms.Panel();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnAccountMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panChildForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panView.SuspendLayout();
            this.panTransactions.SuspendLayout();
            this.panAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panView);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.panTransactions);
            this.panel1.Controls.Add(this.btnTransactionsMenu);
            this.panel1.Controls.Add(this.panAccount);
            this.panel1.Controls.Add(this.btnAccountMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 751);
            this.panel1.TabIndex = 1;
            // 
            // panView
            // 
            this.panView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panView.Controls.Add(this.btnGetAccountStatement);
            this.panView.Controls.Add(this.btnGetBalance);
            this.panView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panView.Location = new System.Drawing.Point(0, 573);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(300, 171);
            this.panView.TabIndex = 6;
            // 
            // btnGetAccountStatement
            // 
            this.btnGetAccountStatement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetAccountStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAccountStatement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetAccountStatement.Location = new System.Drawing.Point(0, 59);
            this.btnGetAccountStatement.Name = "btnGetAccountStatement";
            this.btnGetAccountStatement.Size = new System.Drawing.Size(300, 62);
            this.btnGetAccountStatement.TabIndex = 5;
            this.btnGetAccountStatement.Text = "Get Account Statement";
            this.btnGetAccountStatement.UseVisualStyleBackColor = true;
            this.btnGetAccountStatement.Click += new System.EventHandler(this.btnGetAccountStatement_Click);
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetBalance.Location = new System.Drawing.Point(0, 0);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(300, 59);
            this.btnGetBalance.TabIndex = 4;
            this.btnGetBalance.Text = "Get Balance";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.Location = new System.Drawing.Point(0, 514);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(300, 59);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // panTransactions
            // 
            this.panTransactions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panTransactions.Controls.Add(this.btnTransfer);
            this.panTransactions.Controls.Add(this.btnWithdraw);
            this.panTransactions.Controls.Add(this.btnDepsosit);
            this.panTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTransactions.Location = new System.Drawing.Point(0, 328);
            this.panTransactions.Name = "panTransactions";
            this.panTransactions.Size = new System.Drawing.Size(300, 186);
            this.panTransactions.TabIndex = 4;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.Location = new System.Drawing.Point(0, 121);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(300, 56);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.Location = new System.Drawing.Point(0, 60);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(300, 61);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDepsosit
            // 
            this.btnDepsosit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepsosit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepsosit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepsosit.Location = new System.Drawing.Point(0, 0);
            this.btnDepsosit.Name = "btnDepsosit";
            this.btnDepsosit.Size = new System.Drawing.Size(300, 60);
            this.btnDepsosit.TabIndex = 3;
            this.btnDepsosit.Text = "Deposit";
            this.btnDepsosit.UseVisualStyleBackColor = true;
            this.btnDepsosit.Click += new System.EventHandler(this.btnDepsosit_Click);
            // 
            // btnTransactionsMenu
            // 
            this.btnTransactionsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsMenu.FlatAppearance.BorderSize = 0;
            this.btnTransactionsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsMenu.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTransactionsMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransactionsMenu.Location = new System.Drawing.Point(0, 271);
            this.btnTransactionsMenu.Name = "btnTransactionsMenu";
            this.btnTransactionsMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransactionsMenu.Size = new System.Drawing.Size(300, 57);
            this.btnTransactionsMenu.TabIndex = 3;
            this.btnTransactionsMenu.Text = "Transactions";
            this.btnTransactionsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionsMenu.UseVisualStyleBackColor = true;
            // 
            // panAccount
            // 
            this.panAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panAccount.Controls.Add(this.btnOpenAccount);
            this.panAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panAccount.Location = new System.Drawing.Point(0, 205);
            this.panAccount.Name = "panAccount";
            this.panAccount.Size = new System.Drawing.Size(300, 66);
            this.panAccount.TabIndex = 2;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenAccount.Location = new System.Drawing.Point(0, 0);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(300, 56);
            this.btnOpenAccount.TabIndex = 2;
            this.btnOpenAccount.Text = "OpenAccount";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // btnAccountMenu
            // 
            this.btnAccountMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountMenu.FlatAppearance.BorderSize = 0;
            this.btnAccountMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountMenu.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAccountMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccountMenu.Location = new System.Drawing.Point(0, 150);
            this.btnAccountMenu.Name = "btnAccountMenu";
            this.btnAccountMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccountMenu.Size = new System.Drawing.Size(300, 55);
            this.btnAccountMenu.TabIndex = 1;
            this.btnAccountMenu.Text = "Account";
            this.btnAccountMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountMenu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 150);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(300, 716);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 35);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(533, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bank of the people";
            this.label4.Visible = false;
            // 
            // panChildForm
            // 
            this.panChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panChildForm.Controls.Add(this.button2);
            this.panChildForm.Controls.Add(this.button1);
            this.panChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChildForm.Location = new System.Drawing.Point(300, 0);
            this.panChildForm.Name = "panChildForm";
            this.panChildForm.Size = new System.Drawing.Size(836, 716);
            this.panChildForm.TabIndex = 3;
            this.panChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panChildForm_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(658, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 751);
            this.Controls.Add(this.panChildForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panView.ResumeLayout(false);
            this.panTransactions.ResumeLayout(false);
            this.panAccount.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panView;
        private System.Windows.Forms.Button btnGetAccountStatement;
        private System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panTransactions;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDepsosit;
        private System.Windows.Forms.Button btnTransactionsMenu;
        private System.Windows.Forms.Panel panAccount;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnAccountMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panChildForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}