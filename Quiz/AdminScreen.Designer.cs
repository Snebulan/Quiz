﻿namespace Quiz
{
    partial class AdminScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.student = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Button();
            this.QuestionBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.quiz = new System.Windows.Forms.ComboBox();
            this.addQuestion = new System.Windows.Forms.Button();
            this.checkAnswer4 = new System.Windows.Forms.CheckBox();
            this.checkAnswer3 = new System.Windows.Forms.CheckBox();
            this.checkAnswer2 = new System.Windows.Forms.CheckBox();
            this.checkAnswer1 = new System.Windows.Forms.CheckBox();
            this.answer4 = new System.Windows.Forms.TextBox();
            this.answer3 = new System.Windows.Forms.TextBox();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.QuestionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(56, 34);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(100, 20);
            this.name_text.TabIndex = 3;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(56, 61);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(100, 20);
            this.email_text.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Answer 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacher);
            this.groupBox1.Controls.Add(this.student);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.addUser);
            this.groupBox1.Controls.Add(this.name_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.email_text);
            this.groupBox1.Location = new System.Drawing.Point(90, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(56, 110);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(65, 17);
            this.teacher.TabIndex = 6;
            this.teacher.Text = "Teacher";
            this.teacher.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Checked = true;
            this.student.Location = new System.Drawing.Point(56, 87);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(62, 17);
            this.student.TabIndex = 5;
            this.student.TabStop = true;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Role";
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(56, 133);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 10;
            this.addUser.Text = "Add";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Controls.Add(this.label11);
            this.QuestionBox.Controls.Add(this.quiz);
            this.QuestionBox.Controls.Add(this.addQuestion);
            this.QuestionBox.Controls.Add(this.checkAnswer4);
            this.QuestionBox.Controls.Add(this.checkAnswer3);
            this.QuestionBox.Controls.Add(this.checkAnswer2);
            this.QuestionBox.Controls.Add(this.checkAnswer1);
            this.QuestionBox.Controls.Add(this.answer4);
            this.QuestionBox.Controls.Add(this.answer3);
            this.QuestionBox.Controls.Add(this.answer2);
            this.QuestionBox.Controls.Add(this.answer1);
            this.QuestionBox.Controls.Add(this.label9);
            this.QuestionBox.Controls.Add(this.label8);
            this.QuestionBox.Controls.Add(this.label7);
            this.QuestionBox.Controls.Add(this.question);
            this.QuestionBox.Controls.Add(this.label4);
            this.QuestionBox.Controls.Add(this.label5);
            this.QuestionBox.Controls.Add(this.label6);
            this.QuestionBox.Location = new System.Drawing.Point(365, 65);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(355, 327);
            this.QuestionBox.TabIndex = 9;
            this.QuestionBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quiz";
            // 
            // quiz
            // 
            this.quiz.FormattingEnabled = true;
            this.quiz.Location = new System.Drawing.Point(117, 38);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(184, 21);
            this.quiz.TabIndex = 23;
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(139, 282);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(82, 23);
            this.addQuestion.TabIndex = 22;
            this.addQuestion.Text = "Add";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // checkAnswer4
            // 
            this.checkAnswer4.AutoSize = true;
            this.checkAnswer4.Location = new System.Drawing.Point(39, 250);
            this.checkAnswer4.Name = "checkAnswer4";
            this.checkAnswer4.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer4.TabIndex = 21;
            this.checkAnswer4.UseVisualStyleBackColor = true;
            // 
            // checkAnswer3
            // 
            this.checkAnswer3.AutoSize = true;
            this.checkAnswer3.Location = new System.Drawing.Point(39, 224);
            this.checkAnswer3.Name = "checkAnswer3";
            this.checkAnswer3.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer3.TabIndex = 20;
            this.checkAnswer3.UseVisualStyleBackColor = true;
            // 
            // checkAnswer2
            // 
            this.checkAnswer2.AutoSize = true;
            this.checkAnswer2.Location = new System.Drawing.Point(39, 198);
            this.checkAnswer2.Name = "checkAnswer2";
            this.checkAnswer2.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer2.TabIndex = 19;
            this.checkAnswer2.UseVisualStyleBackColor = true;
            // 
            // checkAnswer1
            // 
            this.checkAnswer1.AutoSize = true;
            this.checkAnswer1.Location = new System.Drawing.Point(39, 172);
            this.checkAnswer1.Name = "checkAnswer1";
            this.checkAnswer1.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer1.TabIndex = 18;
            this.checkAnswer1.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(117, 247);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(184, 20);
            this.answer4.TabIndex = 17;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(116, 221);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(185, 20);
            this.answer3.TabIndex = 16;
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(116, 195);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(185, 20);
            this.answer2.TabIndex = 15;
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(116, 169);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(185, 20);
            this.answer1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Answer 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Answer 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Answer 2";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(117, 65);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(185, 96);
            this.question.TabIndex = 10;
            this.question.Text = "";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.QuestionBox.ResumeLayout(false);
            this.QuestionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.GroupBox QuestionBox;
        private System.Windows.Forms.RichTextBox question;
        private System.Windows.Forms.TextBox answer4;
        private System.Windows.Forms.TextBox answer3;
        private System.Windows.Forms.TextBox answer2;
        private System.Windows.Forms.TextBox answer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkAnswer4;
        private System.Windows.Forms.CheckBox checkAnswer3;
        private System.Windows.Forms.CheckBox checkAnswer2;
        private System.Windows.Forms.CheckBox checkAnswer1;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox quiz;
    }
}