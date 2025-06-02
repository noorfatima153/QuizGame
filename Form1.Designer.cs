namespace QuizApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnNext = new Button();
            lblScore = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuestion.Location = new Point(40, 30);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(117, 32);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question will appear here";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(45, 80);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(108, 29);
            rbOption1.TabIndex = 1;
            rbOption1.TabStop = true;
            rbOption1.Text = "Option 1";
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(45, 120);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(108, 29);
            rbOption2.TabIndex = 2;
            rbOption2.TabStop = true;
            rbOption2.Text = "Option 2";
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(45, 160);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(108, 29);
            rbOption3.TabIndex = 3;
            rbOption3.TabStop = true;
            rbOption3.Text = "Option 3";
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(45, 200);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(108, 29);
            rbOption4.TabIndex = 4;
            rbOption4.TabStop = true;
            rbOption4.Text = "Option 4";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(45, 250);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 35);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.Click += btnNext_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScore.Location = new Point(180, 255);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 28);
            lblScore.TabIndex = 6;
            // 
            // Form1
            // 
            ClientSize = new Size(581, 320);
            Controls.Add(lblQuestion);
            Controls.Add(rbOption1);
            Controls.Add(rbOption2);
            Controls.Add(rbOption3);
            Controls.Add(rbOption4);
            Controls.Add(btnNext);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Quiz App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
