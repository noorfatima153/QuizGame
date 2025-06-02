
using System.Data;
using MySql.Data.MySqlClient;


namespace QuizApp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=quizdb;password=Noor457495");
        DataTable questions = new DataTable();
        int currentQuestionIndex = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadQuestionsFromDB();
            DisplayQuestion();
        }
        void LoadQuestionsFromDB()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM questions";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(questions);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions from database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        void DisplayQuestion()
        {
            if(currentQuestionIndex < questions.Rows.Count)
            {
                DataRow row = questions.Rows[currentQuestionIndex];
                lblQuestion.Text = row["question"].ToString();
                rbOption1.Text = row["option1"].ToString();
                rbOption2.Text = row["option2"].ToString();
                rbOption3.Text = row["option3"].ToString();
                rbOption4.Text = row["option4"].ToString();

                rbOption1.Checked = rbOption2.Checked = rbOption3.Checked = rbOption4.Checked = false;
            }
            else
            {
                lblQuestion.Text = "Quiz Completed!";
                lblScore.Text = $"Your Score: {score} / {questions.Rows.Count}";
                btnNext.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= questions.Rows.Count) return;

            DataRow row = questions.Rows[currentQuestionIndex];
            int correctOption = Convert.ToInt32(row["correct_option"]);

            int selected = 0;
            if (rbOption1.Checked) selected = 1;
            else if (rbOption2.Checked) selected = 2;
            else if (rbOption3.Checked) selected = 3;
            else if (rbOption4.Checked) selected = 4;

            if (selected == correctOption)
            {
                score++;
            }

            currentQuestionIndex++;
            DisplayQuestion();
        }
    }
}
