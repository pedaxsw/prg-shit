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
            wrongL.Visible = false;
            correctL.Visible = false;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;


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
            wrongL.Visible = false;
            correctL.Visible = false;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;


            menu.Text = "Menu";
            correct = 0;
            wrong = 0;

            wrongL.Text = "Wrong: ";
            correctL.Text = "Correct: ";
            yourAnswer.Text = "";


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
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;


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

            if (currentIndex == dictionary.Count - 1)
            {
                learning_next.Visible = false;
            }
            else
            {
                learning_next.Visible = true;
            }

            int ubrany = currentIndex - 1;
            if (yourAnswer.Text == dictionary[ubrany].Value)
            {
                correct += 1;
                correctL.Text = "Correct: " + correct;
                pusa.Visible = true;
                ruka.Visible= true;
                bad.Visible = false;
            }
            else
            {   //"Wrong: " + wrong;
                wrong += 1;
                wrongL.Text = "Wrong: " + wrong;
                bad.Visible = true;
                pusa.Visible = false;
                ruka.Visible = false;
            }
            yourAnswer.Text = "";

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
            wrongL.Visible = true;
            correctL.Visible = true;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;



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

        private void correctL_Click(object sender, EventArgs e)
        {

        }

        private void wrongL_Click(object sender, EventArgs e)
        {

        }
    }
}