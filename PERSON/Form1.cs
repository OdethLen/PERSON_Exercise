namespace PERSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student studentone = new Student(Convert.ToString(txtCareer.Text), Convert.ToDouble(numericUpDown1.Text), Convert.ToString(txtMatricula.Text), Convert.ToDateTime(dateTimePicker.Text), Convert.ToString(txtName.Text), Convert.ToString(txtFLastName.Text), Convert.ToString(txtMLastName.Text));
            lblcreatePerson.Text = studentone.ToString();

        }

        private void lblcreatePerson_Click(object sender, EventArgs e)
        {

        }
    }
}
