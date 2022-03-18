
namespace LoginPass
{
    partial class Reg
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
            this.login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textEm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassConf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(99, 9);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(67, 13);
            this.login.TabIndex = 13;
            this.login.Text = "Regestration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(53, 100);
            this.textPass.MaxLength = 20;
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(156, 20);
            this.textPass.TabIndex = 10;
            // 
            // textEm
            // 
            this.textEm.Location = new System.Drawing.Point(53, 49);
            this.textEm.MaxLength = 20;
            this.textEm.Name = "textEm";
            this.textEm.Size = new System.Drawing.Size(156, 20);
            this.textEm.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(53, 186);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(113, 35);
            this.log.TabIndex = 7;
            this.log.Text = "Registration";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.reg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirm password";
            // 
            // textPassConf
            // 
            this.textPassConf.Location = new System.Drawing.Point(53, 147);
            this.textPassConf.MaxLength = 20;
            this.textPassConf.Name = "textPassConf";
            this.textPassConf.PasswordChar = '*';
            this.textPassConf.Size = new System.Drawing.Size(156, 20);
            this.textPassConf.TabIndex = 14;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPassConf);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textEm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.log);
            this.Name = "Reg";
            this.Text = "Reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textEm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassConf;
    }
}