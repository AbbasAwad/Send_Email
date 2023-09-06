namespace Send_to_email
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.btuSendemail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Send_to_email.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(195, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmail.Location = new System.Drawing.Point(55, 245);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(431, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtSub
            // 
            this.txtSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSub.Location = new System.Drawing.Point(55, 295);
            this.txtSub.Multiline = true;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(431, 31);
            this.txtSub.TabIndex = 4;
            this.txtSub.Text = "Subjact";
            this.txtSub.Enter += new System.EventHandler(this.txtSub_Enter);
            this.txtSub.Leave += new System.EventHandler(this.txtSub_Leave);
            // 
            // txtMass
            // 
            this.txtMass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtMass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtMass.Location = new System.Drawing.Point(55, 378);
            this.txtMass.Multiline = true;
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(431, 170);
            this.txtMass.TabIndex = 5;
            this.txtMass.Text = "Massege";
            this.txtMass.Enter += new System.EventHandler(this.txtMassege_Enter);
            this.txtMass.Leave += new System.EventHandler(this.txtMassege_Leave);
            // 
            // btuSendemail
            // 
            this.btuSendemail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btuSendemail.FlatAppearance.BorderSize = 0;
            this.btuSendemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuSendemail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuSendemail.ForeColor = System.Drawing.Color.White;
            this.btuSendemail.Location = new System.Drawing.Point(55, 606);
            this.btuSendemail.Name = "btuSendemail";
            this.btuSendemail.Size = new System.Drawing.Size(431, 49);
            this.btuSendemail.TabIndex = 6;
            this.btuSendemail.Text = "Send Email";
            this.btuSendemail.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Awkward", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 775);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abbas Awad";
            // 
            // txtfrom
            // 
            this.txtfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtfrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfrom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtfrom.Location = new System.Drawing.Point(55, 171);
            this.txtfrom.Multiline = true;
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(431, 31);
            this.txtfrom.TabIndex = 1;
            this.txtfrom.Text = "My Email";
            this.txtfrom.Leave += new System.EventHandler(this.txtfrom_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtpass.Location = new System.Drawing.Point(55, 208);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(431, 31);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "From";
            this.txtpass.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 696);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btuSendemail);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Button btuSendemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button button1;
    }
}

