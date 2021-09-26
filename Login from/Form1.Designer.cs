
namespace Login_from
{
    partial class FrmLogin
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
            this.User = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Remembertick = new System.Windows.Forms.CheckBox();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(76, 85);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(29, 13);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(150, 205);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Log in";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(291, 205);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Remembertick
            // 
            this.Remembertick.AutoSize = true;
            this.Remembertick.Location = new System.Drawing.Point(150, 182);
            this.Remembertick.Name = "Remembertick";
            this.Remembertick.Size = new System.Drawing.Size(94, 17);
            this.Remembertick.TabIndex = 4;
            this.Remembertick.Text = "Remember me";
            this.Remembertick.UseVisualStyleBackColor = true;
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(150, 78);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(216, 20);
            this.Usertxt.TabIndex = 5;
            this.Usertxt.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(150, 142);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '*';
            this.Passtxt.Size = new System.Drawing.Size(216, 20);
            this.Passtxt.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(446, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(16, 17);
            this.lblErr.Text = "...";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(188, 246);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(123, 39);
            this.Btn_Register.TabIndex = 9;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Registerclick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 297);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Remembertick);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User);
            this.Name = "FrmLogin";
            this.Text = "From Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.CheckBox Remembertick;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.Button Btn_Register;
    }
}

