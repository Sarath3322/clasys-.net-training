
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;


namespace register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=JOHN_WICK\SQLEXPRESS;Initial Catalog=mine;Integrated Security=True");
        public int employee_id;

        private void Form1_Load(object sender, EventArgs e)
        {

            employee_details();

        }

        private void employee_details()
        {

            SqlCommand cmd = new SqlCommand("select * from employee", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sd = cmd.ExecuteReader();
            dt.Load(sd);
            conn.Close();
            employee.DataSource = dt;

        }
        private void name_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into employee values(@name,@department_name,@phone_no)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", textBox4.Text);
                cmd.Parameters.AddWithValue("@department_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@phone_no", textBox2.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("new employee successfully registered", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                employee_details();

            }
        }

        private bool IsValid()
        {
            if (name.Text == string.Empty)
            {
                MessageBox.Show("student name required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employee_id = Convert.ToInt32(employee.SelectedRows[0].Cells[0].Value);
            textBox4.Text = employee.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = employee.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = employee.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(employee_id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE employee SET name = @name, department_name= @department_name,phone_no=@phone_no WHERE employee_id = @id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", textBox4.Text);
                cmd.Parameters.AddWithValue("@department_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@phone_no", textBox2.Text);
                cmd.Parameters.AddWithValue("@id", this.employee_id);
                conn.Open();
               
                conn.Close();
                MessageBox.Show(" employee successfully updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                employee_details();

            }
            else {
                MessageBox.Show(" select a proper employee details", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}