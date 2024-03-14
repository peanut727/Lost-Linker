
using LostLinker.login;
using LostLinker.menu;

namespace LostLinker
{
    public partial class loginn : Form
    {

        public loginn()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            dbconnector dbconn = new dbconnector();
            if (dbconn.ConnectDB() == true )
            {
                statuslbl.ForeColor = Color.Green;
                statuslbl.Text = "Up";
            }
            else
            {
                statuslbl.ForeColor = Color.Red;
                statuslbl.Text = "Down";
                MessageBox.Show("The system will close in 5 seconds");
                Thread.Sleep(5000);
                this.Close();
            }
        }

        private void pass_showCB_CheckedChanged(object sender, EventArgs e)
        {

            if (pass_showCB.Checked)
            {
                // Show password
                passtb.PasswordChar = '\0';
            }
            else
            {
                // Hide password
                passtb.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();

        }
        public static string user;
        private void button1_Click(object sender, EventArgs e)
        {
            userauth ua = new userauth();


            if (usertb.Text == "" || passtb.Text == "")
            {
                MessageBox.Show("Fields can't contain empty values!");
            }
            else
            {
                if (ua.authUser(usertb.Text, passtb.Text))
                {
                    MessageBox.Show("Login successful!");
                    user = usertb.Text;
                    this.Hide();
                    usermenu um = new usermenu();
                    um.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again!");
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            userauth ua = new userauth();


            if (usertb.Text == "" || passtb.Text == "")
            {
                MessageBox.Show("Fields can't contain empty values!");
            }
            else
            {
                if (ua.authAdmin(usertb.Text, passtb.Text))
                {
                    MessageBox.Show("Login successful! Welcome back Admin");
                    this.Hide();
                    querytests admin = new querytests();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again!");
                }

            }
        }
    }
}
