using System;
using System.Collections.Generic;
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
            yourAnswer.Visible = false;
            learning_next.Visible = false;
            selected.Visible = false;
            start_learning.Visible = false;



        }

        private void vyber()
        {
            int correct = 0;
            int incorrect = 0;
            Dictionary<string, string> swedishDictionary = new Dictionary<string, string>();

            swedishDictionary.Add("bok", "book");
            swedishDictionary.Add("hej", "hello");
            swedishDictionary.Add("sverige", "sweden");
            swedishDictionary.Add("bil", "car");
            swedishDictionary.Add("apelsine", "orange");

            selected.Text = swedishDictionary.ToString();

            /*
            foreach (KeyValuePair<string, string> word in swedishDictionary)
            {
                if (yourAnswer.Text == word.Value) 
                {
                    correct++;
                }
                else
                {
                    incorrect++;
                }
            
            }
            */
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
            learn_text.Visible = false;
            start_learning.Visible = false;
            selected.Visible = false;
            yourAnswer.Visible = false;

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
            start_learning.Visible = true;
           
        }

        private void learn_text_Click(object sender, EventArgs e)
        {

        }

        private void learning_next_Click(object sender, EventArgs e)
        {
          
        }

        private void yourAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_learning_Click(object sender, EventArgs e)
        {
            selected.Visible= true;
            yourAnswer.Visible= true;
            start_learning.Visible= false;
            vyber();
        }
    }
}