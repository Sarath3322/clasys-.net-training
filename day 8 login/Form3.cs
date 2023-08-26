

using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace my1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            employee_details();

        }

        private void employee_details()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=JOHN_WICK\SQLEXPRESS;Initial Catalog=mine;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from employee",conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader sd = cmd.ExecuteReader();
            dt.Load(sd);
            conn.Close();
            employee.DataSource = dt;

        }
      
    }
}
