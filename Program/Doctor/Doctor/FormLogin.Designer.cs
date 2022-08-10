namespace Doctor
{
    partial class FormLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.loginID = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginEnter = new System.Windows.Forms.Button();
            this.loginContinue = new System.Windows.Forms.Button();
            this.loginMessege = new System.Windows.Forms.Label();
            this.loginMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "כניסה למערכת";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(336, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "תעודת זהות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(336, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "סיסמה";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loginID
            // 
            this.loginID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginID.Location = new System.Drawing.Point(200, 209);
            this.loginID.Margin = new System.Windows.Forms.Padding(2);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(100, 20);
            this.loginID.TabIndex = 2;
            // 
            // loginPassword
            // 
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassword.Location = new System.Drawing.Point(200, 252);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(100, 20);
            this.loginPassword.TabIndex = 3;
            // 
            // loginEnter
            // 
            this.loginEnter.Location = new System.Drawing.Point(59, 318);
            this.loginEnter.Name = "loginEnter";
            this.loginEnter.Size = new System.Drawing.Size(75, 23);
            this.loginEnter.TabIndex = 4;
            this.loginEnter.Text = "כניסה";
            this.loginEnter.UseVisualStyleBackColor = true;
            this.loginEnter.Click += new System.EventHandler(this.loginEnter_Click);
            // 
            // loginContinue
            // 
            this.loginContinue.Location = new System.Drawing.Point(59, 359);
            this.loginContinue.Name = "loginContinue";
            this.loginContinue.Size = new System.Drawing.Size(75, 23);
            this.loginContinue.TabIndex = 6;
            this.loginContinue.Text = "המשך";
            this.loginContinue.UseVisualStyleBackColor = true;
            this.loginContinue.Visible = false;
            this.loginContinue.Click += new System.EventHandler(this.loginContinue_Click);
            // 
            // loginMessege
            // 
            this.loginMessege.AutoSize = true;
            this.loginMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginMessege.Location = new System.Drawing.Point(209, 144);
            this.loginMessege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginMessege.Name = "loginMessege";
            this.loginMessege.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginMessege.Size = new System.Drawing.Size(0, 20);
            this.loginMessege.TabIndex = 8;
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginMessage.Location = new System.Drawing.Point(377, 368);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginMessage.Size = new System.Drawing.Size(13, 20);
            this.loginMessage.TabIndex = 9;
            this.loginMessage.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(457, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginMessage);
            this.Controls.Add(this.loginMessege);
            this.Controls.Add(this.loginContinue);
            this.Controls.Add(this.loginEnter);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginID;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button loginEnter;
        private System.Windows.Forms.Button loginContinue;
        private System.Windows.Forms.Label loginMessege;
        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

