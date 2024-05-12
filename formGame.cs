using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class formGame : Form
    {
        // Custom controls for close, score, and time boxes
        CustomCloseBox customCloseBox = new CustomCloseBox();
        CustomScoreBox customScoreBox = new CustomScoreBox();
        CustomTimeBox customTimeBox = new CustomTimeBox();
        
        // Random number generator
        private Random random = new Random();
        
        // Lists to hold all questions and selected questions
        private List<Question> questions;
        private List<Question> selectedQuestions;

        // Variables to track game progress
        private int questionNumber = 1;
        private int questionIndex = 0;
        private int countCorrect = 0;
        private int countIncorrect = 0;
        private int countNull = 0;

        // Timer for each question
        private Timer timer;
        private int time = 15;

        public formGame()
        {
            // Initialize lists and components
            questions = new List<Question>();
            selectedQuestions = new List<Question>();
            InitializeComponent();
            
            // Create questions, select random questions, and start showing questions
            CreateQuestions();
            CreateRandomQuestions();
            ShowQuestion();
            StartTimer();
        }

        // Method to start the timer
        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Method to create questions
        private void CreateQuestions()
        {
            // Add questions and answers to the list
            questions = new List<Question>
            {
                // Question("Question text", "Correct answer", new List<string>{"Option1", "Option2", "Option3", "Option4"})
                // Add more questions here...
            };
        }

        // Method to handle timer tick event
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update timer label
            time -= 1;
            lblTimer.Text = $"Time left: {time} seconds";
            
            // If time runs out, stop the timer, show time up dialog, and move to the next question
            if (time == 0)
            {
                timer.Stop();
                customTimeBox.ShowDialog();
                countNull++;
                questionIndex++;
                ShowQuestion();
                timer.Start();
            }
        }

        // Method to display the question and options
        private void ShowQuestion()
        {
            // Randomize the order of options
            HashSet<int> indexesSet = new HashSet<int>();
            List<int> indexesList = new List<int>();

            while (indexesSet.Count < 4)
            {
                int index = random.Next(0, 4);
                if (!indexesSet.Contains(index))
                {
                    indexesSet.Add(index);
                    indexesList.Add(index);
                }
            }

            // Display the question and options
            // If all questions have been answered, show the final score
            if (indexesSet.Count == 4)
            {
                if (questionNumber <= 20)
                {
                    lblQuestionNumber.Text = $"Question: {questionNumber}";
                    time = 15;
                }
                else
                {
                    lblQuestionNumber.Text = $"Quiz finished!";
                    time = 0;
                }
                
                lblTimer.Text = $"Time left: {time} seconds";
                if (questionIndex < selectedQuestions.Count)
                {
                    lblQuestions.Text = selectedQuestions[questionIndex].QuestionText;
                    btnA.Text = selectedQuestions[questionIndex].Options[indexesList[0]];
                    btnB.Text = selectedQuestions[questionIndex].Options[indexesList[1]];
                    btnC.Text = selectedQuestions[questionIndex].Options[indexesList[2]];
                    btnD.Text = selectedQuestions[questionIndex].Options[indexesList[3]];
                }
                else
                {
                    // Calculate total score and display the final score dialog
                    int totalPoint = (countCorrect * 5);
                    if (totalPoint < 0)
                    {
                        timer.Stop();
                        totalPoint = 0;
                        string latestscore = $"Total questions: {selectedQuestions.Count}\nCorrect answers: {countCorrect}\nIncorrect answers: {countIncorrect}\nNull answers: {countNull}\nScore: {totalPoint}";
                        customScoreBox.lblScore.Text = latestscore;
                        customScoreBox.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        timer.Stop();
                        string latestscore = $"Total questions: {selectedQuestions.Count}\nCorrect answers: {countCorrect}\nIncorrect answers: {countIncorrect}\nNull answers: {countNull}\nScore: {totalPoint}";
                        customScoreBox.lblScore.Text = latestscore;
                        customScoreBox.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        // Method to handle minimize button click
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Method to handle close button click
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Show custom close box to confirm exit
            if (customCloseBox.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        // Method to handle form move on mouse drag
        private void moveableBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        // Method to handle option button click
        private async void btnOption_Click(object sender, EventArgs e)
        {
            timer.Stop();
            var btn = (Button)sender;
            string answer = btn.Text;
            
            // Check if the selected answer is correct or not
            if (selectedQuestions[questionIndex].IsRightAnswer(answer))
            {
                // If correct, update UI, increment correct count, and move to next question
                btn.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                await Task.Delay(1000);
                countCorrect++;
                questionNumber++;
            }
            else
            {
                // If incorrect, update UI, increment incorrect count, and move to next question
                foreach (var optionBtn in new Button[] {btnA, btnB, btnC, btnD})
                {
                    if (selectedQuestions[questionIndex].IsRightAnswer(optionBtn.Text))
                    {
                        btn.BackColor = Color.Red;
                        optionBtn.BackColor = Color.Green;
                        btnA.Enabled = false;
                        btnB.Enabled = false;
                        btnC.Enabled = false;
                        btnD.Enabled = false;
                        await Task.Delay(1000);
                        optionBtn.BackColor = Color.FromArgb(118, 171, 174);
                        break;
                    }
                }
                countIncorrect++;
                questionNumber++;
            }
            questionIndex++;
            ShowQuestion();
            // Start or stop the timer based on quiz status
            if (lblQuestionNumber.Text == "Quiz finished!")
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
            // Reset button background color
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btn.BackColor = Color.FromArgb(118, 171, 174);
        }

        // Question class to represent a question
        public class Question
        {
            public string QuestionText { get; set; }
            public string RightAnswer { get; set; }
            public List<string> Options { get; set; }

            public Question(string questionText, string rightAnswer, List<string> options)
            {
                QuestionText = questionText;
                RightAnswer = rightAnswer;
                Options = new List<string>(options);
            }

            public void AddOption(string option)
            {
                Options.Add(option);
            }

            public bool IsRightAnswer(string answer)
            {
                return answer == RightAnswer;
            }
        }

        // Method to select random questions
        private void CreateRandomQuestions()
        {
            HashSet<int> indexesSet = new HashSet<int>();
            List<int> selectedIndexes = new List<int>();

            while (indexesSet.Count < 20)
            {
                int index = random.Next(0, questions.Count);
                if (!indexesSet.Contains(index))
                {
                    indexesSet.Add(index);
                    selectedIndexes.Add(index);
                }
            }

            foreach (int index in selectedIndexes)
            {
                selectedQuestions.Add(questions[index]);
            }
        }
    }
}
