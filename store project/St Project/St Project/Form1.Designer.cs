namespace St_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelRoleValid = new System.Windows.Forms.Label();
            this.labelPasswordValid = new System.Windows.Forms.Label();
            this.labelUsernameValid = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.labelForename = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.rolelabel = new System.Windows.Forms.Label();
            this.swpic = new System.Windows.Forms.PictureBox();
            this.eyepic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.swpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoleValid
            // 
            this.labelRoleValid.AutoSize = true;
            this.labelRoleValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoleValid.Location = new System.Drawing.Point(583, 292);
            this.labelRoleValid.Name = "labelRoleValid";
            this.labelRoleValid.Size = new System.Drawing.Size(0, 25);
            this.labelRoleValid.TabIndex = 120;
            // 
            // labelPasswordValid
            // 
            this.labelPasswordValid.AutoSize = true;
            this.labelPasswordValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordValid.Location = new System.Drawing.Point(582, 227);
            this.labelPasswordValid.Name = "labelPasswordValid";
            this.labelPasswordValid.Size = new System.Drawing.Size(0, 25);
            this.labelPasswordValid.TabIndex = 119;
            // 
            // labelUsernameValid
            // 
            this.labelUsernameValid.AutoSize = true;
            this.labelUsernameValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameValid.Location = new System.Drawing.Point(581, 159);
            this.labelUsernameValid.Name = "labelUsernameValid";
            this.labelUsernameValid.Size = new System.Drawing.Size(0, 25);
            this.labelUsernameValid.TabIndex = 118;
            // 
            // roleBox
            // 
            this.roleBox.DisplayMember = "Manager";
            this.roleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Agent",
            "User"});
            this.roleBox.Location = new System.Drawing.Point(346, 310);
            this.roleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(237, 25);
            this.roleBox.TabIndex = 116;
            this.roleBox.Tag = "";
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(346, 180);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(237, 23);
            this.usernameText.TabIndex = 111;
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.labelForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForename.Location = new System.Drawing.Point(170, 171);
            this.labelForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(159, 32);
            this.labelForename.TabIndex = 112;
            this.labelForename.Text = "Username :";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSurname.Location = new System.Drawing.Point(170, 240);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(153, 32);
            this.labelSurname.TabIndex = 113;
            this.labelSurname.Text = "Password :";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(346, 249);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = 'x';
            this.passwordText.Size = new System.Drawing.Size(237, 23);
            this.passwordText.TabIndex = 114;
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.LoginBTN.FlatAppearance.BorderSize = 0;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBTN.Location = new System.Drawing.Point(554, 417);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(139, 52);
            this.LoginBTN.TabIndex = 109;
            this.LoginBTN.Text = "Log in";
            this.LoginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click_3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(198, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 42);
            this.label1.TabIndex = 121;
            this.label1.Text = "Store Management System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(371, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 52);
            this.button1.TabIndex = 122;
            this.button1.Text = "Forget password ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(170, 307);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 32);
            this.label19.TabIndex = 115;
            this.label19.Text = "Role :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(123)))), ((int)(((byte)(109)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(598, 240);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 39);
            this.button2.TabIndex = 123;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(108)))));
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(342, 206);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 20);
            this.usernamelabel.TabIndex = 125;
            this.usernamelabel.Click += new System.EventHandler(this.usernamelabel_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(108)))));
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(342, 275);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(0, 20);
            this.passwordlabel.TabIndex = 126;
            this.passwordlabel.Click += new System.EventHandler(this.passwordlabel_Click);
            // 
            // rolelabel
            // 
            this.rolelabel.AutoSize = true;
            this.rolelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(112)))), ((int)(((byte)(83)))));
            this.rolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelabel.Location = new System.Drawing.Point(342, 337);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(0, 20);
            this.rolelabel.TabIndex = 127;
            this.rolelabel.Click += new System.EventHandler(this.rolelabel_Click);
            // 
            // swpic
            // 
            this.swpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.swpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swpic.Image = global::St_Project.Properties.Resources.hidden1;
            this.swpic.Location = new System.Drawing.Point(743, 493);
            this.swpic.Name = "swpic";
            this.swpic.Size = new System.Drawing.Size(31, 36);
            this.swpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swpic.TabIndex = 129;
            this.swpic.TabStop = false;
            this.swpic.Visible = false;
            // 
            // eyepic
            // 
            this.eyepic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.eyepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyepic.Image = global::St_Project.Properties.Resources.eye;
            this.eyepic.Location = new System.Drawing.Point(780, 493);
            this.eyepic.Name = "eyepic";
            this.eyepic.Size = new System.Drawing.Size(31, 36);
            this.eyepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyepic.TabIndex = 128;
            this.eyepic.TabStop = false;
            this.eyepic.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::St_Project.Properties.Resources.hidden;
            this.pictureBox2.Location = new System.Drawing.Point(598, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LoginPic
            // 
            this.LoginPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.LoginPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginPic.Image = ((System.Drawing.Image)(resources.GetObject("LoginPic.Image")));
            this.LoginPic.Location = new System.Drawing.Point(131, 91);
            this.LoginPic.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPic.Name = "LoginPic";
            this.LoginPic.Size = new System.Drawing.Size(65, 55);
            this.LoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPic.TabIndex = 108;
            this.LoginPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 541);
            this.Controls.Add(this.swpic);
            this.Controls.Add(this.eyepic);
            this.Controls.Add(this.rolelabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRoleValid);
            this.Controls.Add(this.labelPasswordValid);
            this.Controls.Add(this.labelUsernameValid);
            this.Controls.Add(this.LoginPic);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.labelForename);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(841, 588);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.swpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRoleValid;
        private System.Windows.Forms.Label labelPasswordValid;
        private System.Windows.Forms.Label labelUsernameValid;
        private System.Windows.Forms.PictureBox LoginPic;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label labelForename;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label rolelabel;
        private System.Windows.Forms.PictureBox eyepic;
        private System.Windows.Forms.PictureBox swpic;
    }
}

