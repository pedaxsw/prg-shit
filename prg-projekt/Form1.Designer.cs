namespace prg_projekt
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
            this.button1 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.tom = new System.Windows.Forms.PictureBox();
            this.Welcome_text = new System.Windows.Forms.Label();
            this.menu_text = new System.Windows.Forms.Label();
            this.learn = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.learn_text = new System.Windows.Forms.Label();
            this.learning_next = new System.Windows.Forms.Button();
            this.yourAnswer = new System.Windows.Forms.TextBox();
            this.selected = new System.Windows.Forms.Label();
            this.start_learning = new System.Windows.Forms.Button();
            this.learning_text = new System.Windows.Forms.Label();
            this.correctL = new System.Windows.Forms.Label();
            this.wrongL = new System.Windows.Forms.Label();
            this.pusa = new System.Windows.Forms.PictureBox();
            this.ruka = new System.Windows.Forms.PictureBox();
            this.bad = new System.Windows.Forms.PictureBox();
            this.learn_score = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.start_test = new System.Windows.Forms.Button();
            this.trans = new System.Windows.Forms.Label();
            this.test_next = new System.Windows.Forms.Button();
            this.test_text = new System.Windows.Forms.Label();
            this.testing_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pusa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(62, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu.Location = new System.Drawing.Point(768, 523);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(284, 97);
            this.menu.TabIndex = 1;
            this.menu.Text = "Go to Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // tom
            // 
            this.tom.BackColor = System.Drawing.Color.White;
            this.tom.ErrorImage = null;
            this.tom.Image = global::prg_projekt.Properties.Resources.tom_prg;
            this.tom.InitialImage = null;
            this.tom.Location = new System.Drawing.Point(389, 254);
            this.tom.Name = "tom";
            this.tom.Size = new System.Drawing.Size(300, 386);
            this.tom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tom.TabIndex = 2;
            this.tom.TabStop = false;
            this.tom.Click += new System.EventHandler(this.tom_Click);
            // 
            // Welcome_text
            // 
            this.Welcome_text.AutoSize = true;
            this.Welcome_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Welcome_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_text.Location = new System.Drawing.Point(129, 53);
            this.Welcome_text.Name = "Welcome_text";
            this.Welcome_text.Size = new System.Drawing.Size(951, 40);
            this.Welcome_text.TabIndex = 3;
            this.Welcome_text.Text = "Hej! My name is Tom and I wil be your tutor at your swedish journey :))";
            this.Welcome_text.Click += new System.EventHandler(this.Welcome_text_Click);
            // 
            // menu_text
            // 
            this.menu_text.AutoSize = true;
            this.menu_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_text.Location = new System.Drawing.Point(12, 53);
            this.menu_text.Name = "menu_text";
            this.menu_text.Size = new System.Drawing.Size(1095, 40);
            this.menu_text.TabIndex = 4;
            this.menu_text.Text = "Hej! Do you wish to start learning or take a test? (I recommend start learning fi" +
    "rst)";
            this.menu_text.Click += new System.EventHandler(this.menu_text_Click);
            // 
            // learn
            // 
            this.learn.BackColor = System.Drawing.Color.White;
            this.learn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learn.Location = new System.Drawing.Point(768, 158);
            this.learn.Name = "learn";
            this.learn.Size = new System.Drawing.Size(256, 89);
            this.learn.TabIndex = 5;
            this.learn.Text = "Test";
            this.learn.UseVisualStyleBackColor = false;
            this.learn.Click += new System.EventHandler(this.learn_Click);
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.White;
            this.test.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test.Location = new System.Drawing.Point(62, 174);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(256, 89);
            this.test.TabIndex = 6;
            this.test.Text = "Learn";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // learn_text
            // 
            this.learn_text.AutoSize = true;
            this.learn_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learn_text.Location = new System.Drawing.Point(213, 53);
            this.learn_text.Name = "learn_text";
            this.learn_text.Size = new System.Drawing.Size(1002, 40);
            this.learn_text.TabIndex = 7;
            this.learn_text.Text = "Hej! You are now in Learn section, you can learn new words here! Lycka till!";
            this.learn_text.Click += new System.EventHandler(this.learn_text_Click);
            // 
            // learning_next
            // 
            this.learning_next.BackColor = System.Drawing.Color.White;
            this.learning_next.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learning_next.Location = new System.Drawing.Point(800, 323);
            this.learning_next.Name = "learning_next";
            this.learning_next.Size = new System.Drawing.Size(195, 75);
            this.learning_next.TabIndex = 8;
            this.learning_next.Text = "next";
            this.learning_next.UseVisualStyleBackColor = false;
            this.learning_next.Click += new System.EventHandler(this.learning_next_Click);
            // 
            // yourAnswer
            // 
            this.yourAnswer.Location = new System.Drawing.Point(451, 199);
            this.yourAnswer.Name = "yourAnswer";
            this.yourAnswer.Size = new System.Drawing.Size(210, 23);
            this.yourAnswer.TabIndex = 9;
            this.yourAnswer.TextChanged += new System.EventHandler(this.yourAnswer_TextChanged);
            // 
            // selected
            // 
            this.selected.AutoSize = true;
            this.selected.BackColor = System.Drawing.Color.White;
            this.selected.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selected.Location = new System.Drawing.Point(522, 124);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(202, 40);
            this.selected.TabIndex = 10;
            this.selected.Text = "Selected word";
            this.selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_learning
            // 
            this.start_learning.BackColor = System.Drawing.Color.White;
            this.start_learning.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_learning.Location = new System.Drawing.Point(62, 269);
            this.start_learning.Name = "start_learning";
            this.start_learning.Size = new System.Drawing.Size(232, 95);
            this.start_learning.TabIndex = 11;
            this.start_learning.Text = "Start the Test";
            this.start_learning.UseVisualStyleBackColor = false;
            this.start_learning.Click += new System.EventHandler(this.start_learning_Click);
            // 
            // learning_text
            // 
            this.learning_text.AutoSize = true;
            this.learning_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learning_text.Location = new System.Drawing.Point(309, 53);
            this.learning_text.Name = "learning_text";
            this.learning_text.Size = new System.Drawing.Size(521, 40);
            this.learning_text.TabIndex = 12;
            this.learning_text.Text = "Translate the Swedish word to English:";
            // 
            // correctL
            // 
            this.correctL.AutoSize = true;
            this.correctL.BackColor = System.Drawing.Color.White;
            this.correctL.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.correctL.Location = new System.Drawing.Point(36, 124);
            this.correctL.Name = "correctL";
            this.correctL.Size = new System.Drawing.Size(128, 40);
            this.correctL.TabIndex = 13;
            this.correctL.Text = "Correct: ";
            this.correctL.Click += new System.EventHandler(this.correctL_Click);
            // 
            // wrongL
            // 
            this.wrongL.AutoSize = true;
            this.wrongL.BackColor = System.Drawing.Color.White;
            this.wrongL.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wrongL.Location = new System.Drawing.Point(36, 176);
            this.wrongL.Name = "wrongL";
            this.wrongL.Size = new System.Drawing.Size(122, 40);
            this.wrongL.TabIndex = 14;
            this.wrongL.Text = "Wrong: ";
            this.wrongL.Click += new System.EventHandler(this.wrongL_Click);
            // 
            // pusa
            // 
            this.pusa.BackColor = System.Drawing.Color.Transparent;
            this.pusa.Image = global::prg_projekt.Properties.Resources.pusa_prg;
            this.pusa.Location = new System.Drawing.Point(558, 345);
            this.pusa.Name = "pusa";
            this.pusa.Size = new System.Drawing.Size(79, 41);
            this.pusa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pusa.TabIndex = 15;
            this.pusa.TabStop = false;
            // 
            // ruka
            // 
            this.ruka.BackColor = System.Drawing.Color.White;
            this.ruka.Image = global::prg_projekt.Properties.Resources.thum_up;
            this.ruka.Location = new System.Drawing.Point(353, 371);
            this.ruka.Name = "ruka";
            this.ruka.Size = new System.Drawing.Size(176, 145);
            this.ruka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ruka.TabIndex = 16;
            this.ruka.TabStop = false;
            // 
            // bad
            // 
            this.bad.Image = global::prg_projekt.Properties.Resources.bad;
            this.bad.Location = new System.Drawing.Point(389, 345);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(179, 182);
            this.bad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bad.TabIndex = 17;
            this.bad.TabStop = false;
            // 
            // learn_score
            // 
            this.learn_score.AutoSize = true;
            this.learn_score.BackColor = System.Drawing.Color.White;
            this.learn_score.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learn_score.Location = new System.Drawing.Point(158, 83);
            this.learn_score.Name = "learn_score";
            this.learn_score.Size = new System.Drawing.Size(154, 47);
            this.learn_score.TabIndex = 18;
            this.learn_score.Text = "score je:";
            this.learn_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.BackColor = System.Drawing.Color.White;
            this.question.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.question.ForeColor = System.Drawing.Color.Red;
            this.question.Location = new System.Drawing.Point(74, 53);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(73, 40);
            this.question.TabIndex = 19;
            this.question.Text = "0/15";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // start_test
            // 
            this.start_test.BackColor = System.Drawing.Color.White;
            this.start_test.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.start_test.Location = new System.Drawing.Point(62, 299);
            this.start_test.Name = "start_test";
            this.start_test.Size = new System.Drawing.Size(232, 99);
            this.start_test.TabIndex = 20;
            this.start_test.Text = "Start Learning";
            this.start_test.UseVisualStyleBackColor = false;
            this.start_test.Click += new System.EventHandler(this.start_test_Click);
            // 
            // trans
            // 
            this.trans.AutoSize = true;
            this.trans.BackColor = System.Drawing.Color.White;
            this.trans.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trans.Location = new System.Drawing.Point(522, 182);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(158, 40);
            this.trans.TabIndex = 21;
            this.trans.Text = "translation";
            this.trans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test_next
            // 
            this.test_next.BackColor = System.Drawing.Color.White;
            this.test_next.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test_next.Location = new System.Drawing.Point(820, 328);
            this.test_next.Name = "test_next";
            this.test_next.Size = new System.Drawing.Size(191, 64);
            this.test_next.TabIndex = 22;
            this.test_next.Text = "next";
            this.test_next.UseVisualStyleBackColor = false;
            this.test_next.Click += new System.EventHandler(this.test_next_Click);
            // 
            // test_text
            // 
            this.test_text.AutoSize = true;
            this.test_text.BackColor = System.Drawing.Color.White;
            this.test_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test_text.Location = new System.Drawing.Point(203, 39);
            this.test_text.Name = "test_text";
            this.test_text.Size = new System.Drawing.Size(744, 40);
            this.test_text.TabIndex = 23;
            this.test_text.Text = "You are in Learn section, you can learn new words here.";
            // 
            // testing_text
            // 
            this.testing_text.AutoSize = true;
            this.testing_text.BackColor = System.Drawing.Color.White;
            this.testing_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testing_text.Location = new System.Drawing.Point(213, 39);
            this.testing_text.Name = "testing_text";
            this.testing_text.Size = new System.Drawing.Size(767, 40);
            this.testing_text.TabIndex = 24;
            this.testing_text.Text = "Here are the Swedish words and their English translation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prg_projekt.Properties.Resources.swedish;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.testing_text);
            this.Controls.Add(this.test_text);
            this.Controls.Add(this.test_next);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.start_test);
            this.Controls.Add(this.question);
            this.Controls.Add(this.learn_score);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.ruka);
            this.Controls.Add(this.pusa);
            this.Controls.Add(this.wrongL);
            this.Controls.Add(this.correctL);
            this.Controls.Add(this.learning_text);
            this.Controls.Add(this.start_learning);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.yourAnswer);
            this.Controls.Add(this.learning_next);
            this.Controls.Add(this.learn_text);
            this.Controls.Add(this.test);
            this.Controls.Add(this.learn);
            this.Controls.Add(this.menu_text);
            this.Controls.Add(this.Welcome_text);
            this.Controls.Add(this.tom);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pusa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button menu;
        private PictureBox tom;
        private Label Welcome_text;
        private Label menu_text;
        private Button learn;
        private Button test;
        private Label learn_text;
        private Button learning_next;
        private TextBox yourAnswer;
        private Label selected;
        private Button start_learning;
        private Label learning_text;
        private Label correctL;
        private Label wrongL;
        private PictureBox pusa;
        private PictureBox ruka;
        private PictureBox bad;
        private Label learn_score;
        private Label question;
        private Button start_test;
        private Label trans;
        private Button test_next;
        private Label test_text;
        private Label testing_text;
    }
}