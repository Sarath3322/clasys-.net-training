namespace register
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
            name = new Label();
            department = new Label();
            phone_no = new Label();
            label5 = new Label();
            insert = new Button();
            update = new Button();
            delete = new Button();
            select = new Button();
            employee = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)employee).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = SystemColors.ButtonHighlight;
            name.Location = new Point(596, 164);
            name.Name = "name";
            name.Size = new Size(46, 20);
            name.TabIndex = 1;
            name.Text = "name";
            name.Click += name_Click;
            // 
            // department
            // 
            department.AutoSize = true;
            department.BackColor = SystemColors.ButtonHighlight;
            department.Location = new Point(555, 196);
            department.Name = "department";
            department.Size = new Size(87, 20);
            department.TabIndex = 2;
            department.Text = "department";
            // 
            // phone_no
            // 
            phone_no.AutoSize = true;
            phone_no.BackColor = SystemColors.ButtonHighlight;
            phone_no.Location = new Point(568, 236);
            phone_no.Name = "phone_no";
            phone_no.Size = new Size(74, 20);
            phone_no.TabIndex = 3;
            phone_no.Text = "phone_no";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(584, 9);
            label5.Name = "label5";
            label5.Size = new Size(264, 81);
            label5.TabIndex = 4;
            label5.Text = "Register";
            // 
            // insert
            // 
            insert.Location = new Point(201, 366);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 5;
            insert.Text = "insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.Location = new Point(555, 366);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 6;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(826, 366);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 7;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            select.Location = new Point(1146, 366);
            select.Name = "select";
            select.Size = new Size(94, 29);
            select.TabIndex = 8;
            select.Text = "select";
            select.UseVisualStyleBackColor = true;
            // 
            // employee
            // 
            employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employee.Location = new Point(139, 418);
            employee.Name = "employee";
            employee.RowHeadersWidth = 51;
            employee.RowTemplate.Height = 29;
            employee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employee.Size = new Size(1127, 214);
            employee.TabIndex = 9;
            employee.CellClick += employee_CellClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(706, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(706, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(706, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1396, 659);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(employee);
            Controls.Add(select);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(label5);
            Controls.Add(phone_no);
            Controls.Add(department);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label name;
        private Label department;
        private Label phone_no;
        private Label label5;
        private Button insert;
        private Button update;
        private Button delete;
        private Button select;
        private DataGridView employee;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}