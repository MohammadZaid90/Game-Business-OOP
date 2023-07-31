
namespace GUI_BMS_Project.Forms
{
    partial class ClientChangePassForm
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
            this.textoldPassword = new System.Windows.Forms.TextBox();
            this.OldP = new System.Windows.Forms.Label();
            this.textoldName = new System.Windows.Forms.TextBox();
            this.oldUN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.NewUN = new System.Windows.Forms.Label();
            this.NewP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.OldR = new System.Windows.Forms.Label();
            this.textoldRole = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoldPassword
            // 
            this.textoldPassword.Location = new System.Drawing.Point(305, 225);
            this.textoldPassword.Multiline = true;
            this.textoldPassword.Name = "textoldPassword";
            this.textoldPassword.Size = new System.Drawing.Size(208, 34);
            this.textoldPassword.TabIndex = 48;
            // 
            // OldP
            // 
            this.OldP.AutoSize = true;
            this.OldP.BackColor = System.Drawing.Color.Transparent;
            this.OldP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OldP.Location = new System.Drawing.Point(33, 225);
            this.OldP.Name = "OldP";
            this.OldP.Size = new System.Drawing.Size(177, 29);
            this.OldP.TabIndex = 47;
            this.OldP.Text = "Old Password";
            // 
            // textoldName
            // 
            this.textoldName.Location = new System.Drawing.Point(305, 153);
            this.textoldName.Multiline = true;
            this.textoldName.Name = "textoldName";
            this.textoldName.Size = new System.Drawing.Size(208, 37);
            this.textoldName.TabIndex = 46;
            // 
            // oldUN
            // 
            this.oldUN.AutoSize = true;
            this.oldUN.BackColor = System.Drawing.Color.Transparent;
            this.oldUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldUN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oldUN.Location = new System.Drawing.Point(33, 153);
            this.oldUN.Name = "oldUN";
            this.oldUN.Size = new System.Drawing.Size(193, 29);
            this.oldUN.TabIndex = 43;
            this.oldUN.Text = "Old User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(312, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 113;
            this.label1.Text = "Change Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(688, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 45);
            this.button1.TabIndex = 114;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(296, 412);
            this.txtNewName.Multiline = true;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(208, 37);
            this.txtNewName.TabIndex = 118;
            this.txtNewName.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(296, 484);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(208, 34);
            this.txtNewPassword.TabIndex = 117;
            this.txtNewPassword.Visible = false;
            // 
            // NewUN
            // 
            this.NewUN.AutoSize = true;
            this.NewUN.BackColor = System.Drawing.Color.Transparent;
            this.NewUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewUN.Location = new System.Drawing.Point(62, 420);
            this.NewUN.Name = "NewUN";
            this.NewUN.Size = new System.Drawing.Size(204, 29);
            this.NewUN.TabIndex = 115;
            this.NewUN.Text = "New User Name";
            this.NewUN.Visible = false;
            // 
            // NewP
            // 
            this.NewP.AutoSize = true;
            this.NewP.BackColor = System.Drawing.Color.Transparent;
            this.NewP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewP.Location = new System.Drawing.Point(62, 489);
            this.NewP.Name = "NewP";
            this.NewP.Size = new System.Drawing.Size(195, 29);
            this.NewP.TabIndex = 116;
            this.NewP.Text = "New Password:";
            this.NewP.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 121;
            this.label2.Text = "Old UserName was:";
            this.label2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 122;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(526, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 23);
            this.label10.TabIndex = 123;
            this.label10.Text = "Old Password was:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(748, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 124;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(748, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 125;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(526, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 23);
            this.label13.TabIndex = 126;
            this.label13.Text = "New UserName is:";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(526, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 23);
            this.label14.TabIndex = 127;
            this.label14.Text = "New Password is:";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(748, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 23);
            this.label15.TabIndex = 128;
            this.label15.Text = "label15";
            this.label15.Visible = false;
            // 
            // OldR
            // 
            this.OldR.AutoSize = true;
            this.OldR.BackColor = System.Drawing.Color.Transparent;
            this.OldR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OldR.Location = new System.Drawing.Point(36, 294);
            this.OldR.Name = "OldR";
            this.OldR.Size = new System.Drawing.Size(263, 29);
            this.OldR.TabIndex = 50;
            this.OldR.Text = "Old Role(Only Client)";
            // 
            // textoldRole
            // 
            this.textoldRole.Location = new System.Drawing.Point(305, 294);
            this.textoldRole.Multiline = true;
            this.textoldRole.Name = "textoldRole";
            this.textoldRole.Size = new System.Drawing.Size(208, 34);
            this.textoldRole.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 31);
            this.label9.TabIndex = 129;
            this.label9.Text = "🏠";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.Red;
            this.lblclose.Location = new System.Drawing.Point(853, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(46, 31);
            this.lblclose.TabIndex = 130;
            this.lblclose.Text = "❌";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(69, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 45);
            this.button2.TabIndex = 131;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(911, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.NewUN);
            this.Controls.Add(this.NewP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldR);
            this.Controls.Add(this.textoldRole);
            this.Controls.Add(this.textoldPassword);
            this.Controls.Add(this.OldP);
            this.Controls.Add(this.textoldName);
            this.Controls.Add(this.oldUN);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientChangePassForm";
            this.Text = "ClientChangePassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textoldPassword;
        private System.Windows.Forms.Label OldP;
        private System.Windows.Forms.TextBox textoldName;
        private System.Windows.Forms.Label oldUN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label NewUN;
        private System.Windows.Forms.Label NewP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label OldR;
        private System.Windows.Forms.TextBox textoldRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Button button2;
    }
}