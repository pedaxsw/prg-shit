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
            this.learn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tom)).BeginInit();
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
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // tom
            // 
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
            this.Welcome_text.Location = new System.Drawing.Point(74, 43);
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
            this.learn.Location = new System.Drawing.Point(66, 152);
            this.learn.Name = "learn";
            this.learn.Size = new System.Drawing.Size(256, 89);
            this.learn.TabIndex = 5;
            this.learn.Text = "Learn";
            this.learn.UseVisualStyleBackColor = false;
            this.learn.Click += new System.EventHandler(this.learn_Click);
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.White;
            this.test.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test.Location = new System.Drawing.Point(768, 152);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(256, 89);
            this.test.TabIndex = 6;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // learn_text
            // 
            this.learn_text.AutoSize = true;
            this.learn_text.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learn_text.Location = new System.Drawing.Point(50, 53);
            this.learn_text.Name = "learn_text";
            this.learn_text.Size = new System.Drawing.Size(1002, 40);
            this.learn_text.TabIndex = 7;
            this.learn_text.Text = "Hej! You are now in Learn section, you can learn new words here! Lycka till!";
            this.learn_text.Click += new System.EventHandler(this.learn_text_Click);
            // 
            // learn_start
            // 
            this.learn_start.BackColor = System.Drawing.Color.White;
            this.learn_start.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learn_start.Location = new System.Drawing.Point(62, 293);
            this.learn_start.Name = "learn_start";
            this.learn_start.Size = new System.Drawing.Size(256, 89);
            this.learn_start.TabIndex = 5;
            this.learn_start.Text = "Start Learning";
            this.learn_start.UseVisualStyleBackColor = false;
            this.learn_start.Click += new System.EventHandler(this.learn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prg_projekt.Properties.Resources.swedish;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.learn_text);
            this.Controls.Add(this.test);
            this.Controls.Add(this.learn_start);
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
        private Button learn_start;
    }
}