namespace Quiz
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
            this.editUserBox = new System.Windows.Forms.GroupBox();
            this.deleteUser = new System.Windows.Forms.Button();
            this.userEmail = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.editUser = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteQuestion = new System.Windows.Forms.Button();
            this.deleteQuiz = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.editQuestion = new System.Windows.Forms.Button();
            this.questionsList = new System.Windows.Forms.ComboBox();
            this.editQuiz = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.quizList = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.QuestionBox.SuspendLayout();
            this.editUserBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.adminPanel.SuspendLayout();
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
            this.name_text.Size = new System.Drawing.Size(121, 20);
            this.name_text.TabIndex = 3;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(56, 61);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(121, 20);
            this.email_text.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 170);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 1;
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
            this.QuestionBox.Location = new System.Drawing.Point(218, 12);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(296, 316);
            this.QuestionBox.TabIndex = 3;
            this.QuestionBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quiz";
            // 
            // quiz
            // 
            this.quiz.FormattingEnabled = true;
            this.quiz.Location = new System.Drawing.Point(93, 36);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(184, 21);
            this.quiz.TabIndex = 1;
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(115, 280);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(82, 23);
            this.addQuestion.TabIndex = 11;
            this.addQuestion.Text = "Add";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // checkAnswer4
            // 
            this.checkAnswer4.AutoSize = true;
            this.checkAnswer4.Location = new System.Drawing.Point(15, 248);
            this.checkAnswer4.Name = "checkAnswer4";
            this.checkAnswer4.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer4.TabIndex = 9;
            this.checkAnswer4.UseVisualStyleBackColor = true;
            // 
            // checkAnswer3
            // 
            this.checkAnswer3.AutoSize = true;
            this.checkAnswer3.Location = new System.Drawing.Point(15, 222);
            this.checkAnswer3.Name = "checkAnswer3";
            this.checkAnswer3.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer3.TabIndex = 7;
            this.checkAnswer3.UseVisualStyleBackColor = true;
            // 
            // checkAnswer2
            // 
            this.checkAnswer2.AutoSize = true;
            this.checkAnswer2.Location = new System.Drawing.Point(15, 196);
            this.checkAnswer2.Name = "checkAnswer2";
            this.checkAnswer2.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer2.TabIndex = 5;
            this.checkAnswer2.UseVisualStyleBackColor = true;
            // 
            // checkAnswer1
            // 
            this.checkAnswer1.AutoSize = true;
            this.checkAnswer1.Location = new System.Drawing.Point(15, 170);
            this.checkAnswer1.Name = "checkAnswer1";
            this.checkAnswer1.Size = new System.Drawing.Size(15, 14);
            this.checkAnswer1.TabIndex = 3;
            this.checkAnswer1.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(93, 245);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(184, 20);
            this.answer4.TabIndex = 10;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(92, 219);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(185, 20);
            this.answer3.TabIndex = 8;
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(92, 193);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(185, 20);
            this.answer2.TabIndex = 6;
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(92, 167);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(185, 20);
            this.answer1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Answer 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Answer 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Answer 2";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(93, 63);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(185, 96);
            this.question.TabIndex = 2;
            this.question.Text = "";
            // 
            // editUserBox
            // 
            this.editUserBox.Controls.Add(this.deleteUser);
            this.editUserBox.Controls.Add(this.userEmail);
            this.editUserBox.Controls.Add(this.label14);
            this.editUserBox.Controls.Add(this.editUser);
            this.editUserBox.Controls.Add(this.label12);
            this.editUserBox.Location = new System.Drawing.Point(12, 199);
            this.editUserBox.Name = "editUserBox";
            this.editUserBox.Size = new System.Drawing.Size(200, 99);
            this.editUserBox.TabIndex = 2;
            this.editUserBox.TabStop = false;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(102, 63);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 13;
            this.deleteUser.Text = "Remove";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // userEmail
            // 
            this.userEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userEmail.FormattingEnabled = true;
            this.userEmail.Location = new System.Drawing.Point(56, 36);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(121, 21);
            this.userEmail.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Edit user";
            // 
            // editUser
            // 
            this.editUser.Location = new System.Drawing.Point(22, 63);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(75, 23);
            this.editUser.TabIndex = 12;
            this.editUser.Text = "Edit";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.deleteQuestion);
            this.groupBox2.Controls.Add(this.deleteQuiz);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.editQuestion);
            this.groupBox2.Controls.Add(this.questionsList);
            this.groupBox2.Controls.Add(this.editQuiz);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.quizList);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 316);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // deleteQuestion
            // 
            this.deleteQuestion.Location = new System.Drawing.Point(152, 90);
            this.deleteQuestion.Name = "deleteQuestion";
            this.deleteQuestion.Size = new System.Drawing.Size(69, 23);
            this.deleteQuestion.TabIndex = 9;
            this.deleteQuestion.Text = "Delete";
            this.deleteQuestion.UseVisualStyleBackColor = true;
            // 
            // deleteQuiz
            // 
            this.deleteQuiz.Location = new System.Drawing.Point(150, 34);
            this.deleteQuiz.Name = "deleteQuiz";
            this.deleteQuiz.Size = new System.Drawing.Size(69, 23);
            this.deleteQuiz.TabIndex = 6;
            this.deleteQuiz.Text = "Delete";
            this.deleteQuiz.UseVisualStyleBackColor = true;
            this.deleteQuiz.Click += new System.EventHandler(this.deleteQuiz_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Answers";
            // 
            // editQuestion
            // 
            this.editQuestion.Location = new System.Drawing.Point(76, 90);
            this.editQuestion.Name = "editQuestion";
            this.editQuestion.Size = new System.Drawing.Size(69, 23);
            this.editQuestion.TabIndex = 8;
            this.editQuestion.Text = "Edit";
            this.editQuestion.UseVisualStyleBackColor = true;
            this.editQuestion.Click += new System.EventHandler(this.editQuestion_Click);
            // 
            // questionsList
            // 
            this.questionsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionsList.FormattingEnabled = true;
            this.questionsList.Location = new System.Drawing.Point(13, 119);
            this.questionsList.Name = "questionsList";
            this.questionsList.Size = new System.Drawing.Size(326, 21);
            this.questionsList.TabIndex = 7;
            // 
            // editQuiz
            // 
            this.editQuiz.Location = new System.Drawing.Point(75, 34);
            this.editQuiz.Name = "editQuiz";
            this.editQuiz.Size = new System.Drawing.Size(69, 23);
            this.editQuiz.TabIndex = 5;
            this.editQuiz.Text = "Edit";
            this.editQuiz.UseVisualStyleBackColor = true;
            this.editQuiz.Click += new System.EventHandler(this.editQuiz_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Question";
            // 
            // quizList
            // 
            this.quizList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quizList.FormattingEnabled = true;
            this.quizList.Location = new System.Drawing.Point(13, 63);
            this.quizList.Name = "quizList";
            this.quizList.Size = new System.Drawing.Size(326, 21);
            this.quizList.TabIndex = 4;
            this.quizList.SelectedIndexChanged += new System.EventHandler(this.quizList_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(110, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Edit Quiz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Quiz";
            // 
            // adminPanel
            // 
            this.adminPanel.AutoSize = true;
            this.adminPanel.Controls.Add(this.groupBox1);
            this.adminPanel.Controls.Add(this.groupBox2);
            this.adminPanel.Controls.Add(this.QuestionBox);
            this.adminPanel.Controls.Add(this.editUserBox);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(0, 0);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(880, 346);
            this.adminPanel.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(76, 280);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(143, 20);
            this.txtResult.TabIndex = 10;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 346);
            this.Controls.Add(this.adminPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.QuestionBox.ResumeLayout(false);
            this.QuestionBox.PerformLayout();
            this.editUserBox.ResumeLayout(false);
            this.editUserBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox editUserBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox userEmail;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox quizList;
        private System.Windows.Forms.ComboBox questionsList;
        private System.Windows.Forms.Button editQuiz;
        private System.Windows.Forms.Button editQuestion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button deleteQuestion;
        private System.Windows.Forms.Button deleteQuiz;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.TextBox txtResult;
    }
}