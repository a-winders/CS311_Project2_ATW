namespace Craps
{
    partial class frm_Main
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
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDie1.Location = new System.Drawing.Point(10, 97);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(49, 21);
            this.lblDie1.TabIndex = 0;
            this.lblDie1.Text = "Die 1:";
            this.lblDie1.Click += new System.EventHandler(this.lbl_Die1_Click);
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDie2.Location = new System.Drawing.Point(10, 130);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(49, 21);
            this.lblDie2.TabIndex = 1;
            this.lblDie2.Text = "Die 2:";
            this.lblDie2.Click += new System.EventHandler(this.lblDie2_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(12, 9);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(136, 21);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: $100.00";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBet.Location = new System.Drawing.Point(10, 45);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter your bet";
            this.txtBet.Size = new System.Drawing.Size(138, 29);
            this.txtBet.TabIndex = 3;
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(169, 23);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(86, 30);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(10, 168);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(71, 21);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "Point is:";
            this.lblPoints.Click += new System.EventHandler(this.lblPoints_Click);
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYouWin.Location = new System.Drawing.Point(188, 130);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(0, 65);
            this.lblYouWin.TabIndex = 8;
            this.lblYouWin.Click += new System.EventHandler(this.lblYouWin_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(226, 97);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(167, 65);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 350);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Name = "frm_Main";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Label lblBalance;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblPoints;
        private Label lblYouWin;
        private Label lblResult;
    } // end class
} //end namespace