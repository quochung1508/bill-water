namespace Bill_Water
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                string name = tbName.Text;
                string pass = tbPass.Text;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter your name !");
                    tbName.Focus();
                }

                else if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please enter password !");
                    tbPass.Focus();
                }

                else
                {
                    if (name == "Tong Quoc Hung" && pass == "15082005")
                    {
                        Form2 MainForm = new Form2();
                        MainForm.Show();
                        this.Hide();
                }
                    else
                        MessageBox.Show("Your name or password is incorrect");
                }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check_comform = MessageBox.Show("Do you want to exit ?");

            if (check_comform == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continue...");
            }
        }
    }
}
