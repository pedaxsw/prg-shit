namespace prg_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menu_text.Visible = false;
            test.Visible = false;
            learn.Visible = false;
            learn_text.Visible = false;
            learn_start.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Welcome_text.Visible= false;
            menu.Visible=false;
            menu_text.Visible = true;
            test.Visible = true;
            learn.Visible = true;
            learn_start.Visible = false;
            learn_text.Visible = false;

        }

        private void tom_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_text_Click(object sender, EventArgs e)
        {

        }

        private void menu_text_Click(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void learn_Click(object sender, EventArgs e)
        {
            Welcome_text.Visible = false;
            menu.Visible = false;
            menu_text.Visible = false;
            test.Visible = false;
            learn.Visible = false;
            menu.Visible = true;
            learn_text.Visible = true;
            learn_start.Visible = true;
        }

        private void learn_text_Click(object sender, EventArgs e)
        {

        }
    }
}