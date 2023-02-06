using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace prg_projekt
{
    public partial class Form1 : Form
    {
        private List<KeyValuePair<string, string>> dictionary = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("hej", "hello"),
            new KeyValuePair<string, string>("tack", "thank you"),
            new KeyValuePair<string, string>("god dag", "good day"),
            new KeyValuePair<string, string>("hej då", "goodbye"),
            new KeyValuePair<string, string>("ja", "yes"),
            new KeyValuePair<string, string>("nej", "no"),
        };
        private int wrong = 0;
        private int correct = 0;
        private int currentIndex = 0;
        private Random random = new Random();

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
            learning_next.Visible = false;
            learning_text.Visible = false;


        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            // move to the next word in the queue
            currentIndex++;
            if (currentIndex == dictionary.Count)
            {
                currentIndex = 0;
            }
            selected.Text = dictionary[currentIndex].Key;
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
            learning_next.Visible = false;
            learning_text.Visible = false;


            menu.Text = "Menu";
          

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
            learning_text.Visible = false;

        }

        private void learn_text_Click(object sender, EventArgs e)
        {

        }

        private void learning_next_Click(object sender, EventArgs e)
        {
            // move to the next word in the queue
            currentIndex++;
            if (currentIndex == dictionary.Count)
            {
                currentIndex = 0;
            }
            selected.Text = dictionary[currentIndex].Key;

            if (dictionary[currentIndex].Key == dictionary[currentIndex].Value)
            {
                correct += 1;
            }
            else
            {
                wrong += 1;
            }
        }

        private void yourAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_learning_Click(object sender, EventArgs e)
        {
            selected.Visible= true;
            yourAnswer.Visible= true;
            start_learning.Visible= false;
            learning_next.Visible= true;
            learn_text.Visible= false;
            learning_text.Visible = true;



            // shuffle the order of words in the dictionary
            int n = dictionary.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                KeyValuePair<string, string> value = dictionary[k];
                dictionary[k] = dictionary[n];
                dictionary[n] = value;
            }

            // set the first word
            currentIndex = 0;
            selected.Text = dictionary[currentIndex].Key;
        }
    }
}