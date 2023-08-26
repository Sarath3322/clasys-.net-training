namespace my1
{
    partial class Form3
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
            employee = new DataGridView();
            insert = new Button();
            update = new Button();
            delete = new Button();
            select = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            employee_id = new TextBox();
            name = new TextBox();
            phone_no = new TextBox();
            age = new TextBox();
            address = new TextBox();
            salary = new TextBox();
            department_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)employee).BeginInit();
            SuspendLayout();
            // 
            // employee
            // 
            employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employee.Location = new Point(66, 401);
            employee.Name = "employee";
            employee.RowHeadersWidth = 51;
            employee.RowTemplate.Height = 29;
            employee.Size = new Size(1103, 259);
            employee.TabIndex = 0;
            // 
            // insert
            // 
            insert.Location = new Point(79, 354);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 1;
            insert.Text = "insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += button1_Click;
            // 
            // update
            // 
            update.Location = new Point(394, 354);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 2;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(755, 354);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 3;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            select.Location = new Point(1026, 354);
            select.Name = "select";
            select.Size = new Size(94, 29);
            select.TabIndex = 4;
            select.Text = "select";
            select.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(491, 214);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(418, 250);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 6;
            label2.Text = "department_name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(463, 178);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "phone_no";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(503, 104);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 8;
            label4.Text = "age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(491, 71);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(443, 35);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 10;
            label6.Text = "employee_id";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(477, 141);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 11;
            label7.Text = "address";
            // 
            // employee_id
            // 
            employee_id.Location = new Point(691, 35);
            employee_id.Name = "employee_id";
            employee_id.Size = new Size(339, 27);
            employee_id.TabIndex = 12;
            employee_id.TextChanged += textBox1_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(691, 71);
            name.Name = "name";
            name.Size = new Size(339, 27);
            name.TabIndex = 13;
            name.TextChanged += textBox2_TextChanged;
            // 
            // phone_no
            // 
            phone_no.Location = new Point(691, 174);
            phone_no.Name = "phone_no";
            phone_no.Size = new Size(339, 27);
            phone_no.TabIndex = 14;
            // 
            // age
            // 
            age.Location = new Point(691, 104);
            age.Name = "age";
            age.Size = new Size(339, 27);
            age.TabIndex = 15;
            // 
            // address
            // 
            address.Location = new Point(691, 141);
            address.Name = "address";
            address.Size = new Size(339, 27);
            address.TabIndex = 16;
            // 
            // salary
            // 
            salary.Location = new Point(691, 207);
            salary.Name = "salary";
            salary.Size = new Size(339, 27);
            salary.TabIndex = 17;
            // 
            // department_name
            // 
            department_name.Location = new Point(691, 243);
            department_name.Name = "department_name";
            department_name.Size = new Size(339, 27);
            department_name.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1281, 672);
            Controls.Add(department_name);
            Controls.Add(salary);
            Controls.Add(address);
            Controls.Add(age);
            Controls.Add(phone_no);
            Controls.Add(name);
            Controls.Add(employee_id);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(select);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(employee);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employee;
        private Button insert;
        private Button update;
        private Button delete;
        private Button select;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox employee_id;
        private TextBox name;
        private TextBox phone_no;
        private TextBox age;
        private TextBox address;
        private TextBox salary;
        private TextBox department_name;
    }
}