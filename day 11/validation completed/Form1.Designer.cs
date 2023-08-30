namespace validation
{
    partial class Form1
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
            cpass = new TextBox();
            pass = new TextBox();
            mobile = new TextBox();
            mail = new TextBox();
            last = new TextBox();
            first = new TextBox();
            label1 = new Label();
            firstname = new Label();
            lastname = new Label();
            email = new Label();
            phone = new Label();
            password = new Label();
            confirmpassword = new Label();
            button1 = new Button();
            calender = new DateTimePicker();
            agee = new Label();
            dob = new Label();
            g = new Label();
            ageee = new TextBox();
            female = new RadioButton();
            other = new RadioButton();
            male = new RadioButton();
            old = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            address = new TextBox();
            city = new ComboBox();
            state = new ComboBox();
            label5 = new Label();
            username = new TextBox();
            SuspendLayout();
            // 
            // cpass
            // 
            cpass.BorderStyle = BorderStyle.FixedSingle;
            cpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpass.Location = new Point(603, 753);
            cpass.Name = "cpass";
            cpass.Size = new Size(278, 34);
            cpass.TabIndex = 2;
            // 
            // pass
            // 
            pass.BorderStyle = BorderStyle.FixedSingle;
            pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(603, 709);
            pass.Name = "pass";
            pass.Size = new Size(278, 34);
            pass.TabIndex = 3;
            pass.TextChanged += pass_TextChanged;
            // 
            // mobile
            // 
            mobile.BorderStyle = BorderStyle.FixedSingle;
            mobile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mobile.Location = new Point(603, 605);
            mobile.Name = "mobile";
            mobile.Size = new Size(278, 34);
            mobile.TabIndex = 4;
            mobile.TextChanged += mobile_TextChanged;
            mobile.Leave += mobile_Leave;
            // 
            // mail
            // 
            mail.BorderStyle = BorderStyle.FixedSingle;
            mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Location = new Point(603, 556);
            mail.Name = "mail";
            mail.Size = new Size(278, 34);
            mail.TabIndex = 5;
            mail.Validating += mail_Validating;
            // 
            // last
            // 
            last.BorderStyle = BorderStyle.FixedSingle;
            last.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            last.Location = new Point(603, 229);
            last.Name = "last";
            last.Size = new Size(274, 34);
            last.TabIndex = 6;
            last.TextChanged += last_TextChanged;
            // 
            // first
            // 
            first.BorderStyle = BorderStyle.FixedSingle;
            first.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            first.Location = new Point(603, 177);
            first.Name = "first";
            first.Size = new Size(274, 34);
            first.TabIndex = 7;
            first.TextChanged += first_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(380, 9);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(30);
            label1.Size = new Size(557, 141);
            label1.TabIndex = 10;
            label1.Text = "REGISTER FORM";
            label1.Click += label1_Click;
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.BackColor = SystemColors.ButtonHighlight;
            firstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstname.Location = new Point(407, 179);
            firstname.Name = "firstname";
            firstname.Size = new Size(93, 28);
            firstname.TabIndex = 9;
            firstname.Text = "firstname";
            firstname.Click += label2_Click;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.BackColor = SystemColors.ButtonHighlight;
            lastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastname.Location = new Point(410, 231);
            lastname.Name = "lastname";
            lastname.Size = new Size(90, 28);
            lastname.TabIndex = 10;
            lastname.Text = "lastname";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = SystemColors.ButtonHighlight;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(437, 558);
            email.Name = "email";
            email.Size = new Size(59, 28);
            email.TabIndex = 11;
            email.Text = "email";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = SystemColors.ButtonHighlight;
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(428, 607);
            phone.Name = "phone";
            phone.Size = new Size(68, 28);
            phone.TabIndex = 12;
            phone.Text = "phone";
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = SystemColors.ButtonHighlight;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(410, 709);
            password.Name = "password";
            password.Size = new Size(95, 28);
            password.TabIndex = 13;
            password.Text = "password";
            // 
            // confirmpassword
            // 
            confirmpassword.AutoSize = true;
            confirmpassword.BackColor = SystemColors.ButtonHighlight;
            confirmpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmpassword.Location = new Point(352, 753);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(162, 28);
            confirmpassword.TabIndex = 14;
            confirmpassword.Text = "confirmpassword";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(531, 828);
            button1.Name = "button1";
            button1.Size = new Size(202, 74);
            button1.TabIndex = 15;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // calender
            // 
            calender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calender.Location = new Point(603, 269);
            calender.Name = "calender";
            calender.Size = new Size(278, 34);
            calender.TabIndex = 16;
            calender.ValueChanged += calender_ValueChanged;
            // 
            // agee
            // 
            agee.AutoSize = true;
            agee.BackColor = SystemColors.ButtonHighlight;
            agee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agee.Location = new Point(480, 216);
            agee.Name = "agee";
            agee.Size = new Size(0, 25);
            agee.TabIndex = 17;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.BackColor = SystemColors.ButtonHighlight;
            dob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dob.Location = new Point(442, 274);
            dob.Name = "dob";
            dob.Size = new Size(48, 28);
            dob.TabIndex = 18;
            dob.Text = "dob";
            // 
            // g
            // 
            g.AutoSize = true;
            g.BackColor = SystemColors.ButtonHighlight;
            g.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            g.Location = new Point(426, 358);
            g.Name = "g";
            g.Size = new Size(74, 28);
            g.TabIndex = 19;
            g.Text = "gender";
            // 
            // ageee
            // 
            ageee.BorderStyle = BorderStyle.FixedSingle;
            ageee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ageee.Location = new Point(603, 309);
            ageee.Name = "ageee";
            ageee.Size = new Size(278, 34);
            ageee.TabIndex = 20;
            ageee.TextChanged += age_TextChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.BackColor = SystemColors.ButtonHighlight;
            female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            female.Location = new Point(716, 352);
            female.Name = "female";
            female.Size = new Size(91, 32);
            female.TabIndex = 21;
            female.TabStop = true;
            female.Text = "female";
            female.UseVisualStyleBackColor = false;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // other
            // 
            other.AutoSize = true;
            other.BackColor = SystemColors.ButtonHighlight;
            other.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            other.Location = new Point(836, 354);
            other.Name = "other";
            other.Size = new Size(80, 32);
            other.TabIndex = 22;
            other.TabStop = true;
            other.Text = "other";
            other.UseVisualStyleBackColor = false;
            other.CheckedChanged += other_CheckedChanged;
            // 
            // male
            // 
            male.AutoSize = true;
            male.BackColor = SystemColors.ButtonHighlight;
            male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            male.Location = new Point(603, 352);
            male.Name = "male";
            male.Size = new Size(75, 32);
            male.TabIndex = 23;
            male.TabStop = true;
            male.Text = "male";
            male.UseVisualStyleBackColor = false;
            male.CheckedChanged += male_CheckedChanged;
            // 
            // old
            // 
            old.AutoSize = true;
            old.BackColor = SystemColors.ButtonHighlight;
            old.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            old.Location = new Point(442, 315);
            old.Name = "old";
            old.Size = new Size(44, 28);
            old.TabIndex = 24;
            old.Text = "age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(418, 412);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 25;
            label2.Text = "address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(442, 460);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 26;
            label3.Text = "state";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(449, 507);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 27;
            label4.Text = "city";
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.FixedSingle;
            address.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(603, 407);
            address.Name = "address";
            address.Size = new Size(278, 30);
            address.TabIndex = 28;
            // 
            // city
            // 
            city.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            city.FormattingEnabled = true;
            city.Location = new Point(603, 507);
            city.Name = "city";
            city.Size = new Size(278, 33);
            city.TabIndex = 29;
            city.SelectedIndexChanged += city_SelectedIndexChanged;
            // 
            // state
            // 
            state.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            state.FormattingEnabled = true;
            state.Items.AddRange(new object[] { "kerala", "tamilnadu", "karnataka" });
            state.Location = new Point(603, 457);
            state.Name = "state";
            state.Size = new Size(278, 33);
            state.TabIndex = 30;
            state.SelectedIndexChanged += state_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(418, 658);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 31;
            label5.Text = "username";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(603, 656);
            username.Name = "username";
            username.Size = new Size(278, 34);
            username.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1290, 954);
            Controls.Add(username);
            Controls.Add(label5);
            Controls.Add(state);
            Controls.Add(city);
            Controls.Add(address);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(old);
            Controls.Add(male);
            Controls.Add(other);
            Controls.Add(female);
            Controls.Add(ageee);
            Controls.Add(g);
            Controls.Add(dob);
            Controls.Add(agee);
            Controls.Add(calender);
            Controls.Add(button1);
            Controls.Add(confirmpassword);
            Controls.Add(password);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(label1);
            Controls.Add(first);
            Controls.Add(last);
            Controls.Add(mail);
            Controls.Add(mobile);
            Controls.Add(pass);
            Controls.Add(cpass);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox cpass;
        private TextBox pass;
        private TextBox mobile;
        private TextBox mail;
        private TextBox last;
        private TextBox first;
        private Label label1;
        private Label firstname;
        private Label lastname;
        private Label email;
        private Label phone;
        private Label password;
        private Label confirmpassword;
        private Button button1;
        private DateTimePicker calender;
        private Label dob;
        private Label g;
        private TextBox ageee;
        private RadioButton female;
        private RadioButton other;
        private RadioButton male;
        internal Label agee;
        private Label old;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox address;
        private ComboBox city;
        private ComboBox state;
        private Label label5;
        private TextBox username;
    }
}