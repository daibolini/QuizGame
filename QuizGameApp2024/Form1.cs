using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameApp2024
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            try
            {
                log.Info("Quiz Application is running");
                InitializeComponent();
                loadQuestions();
            }
            catch(Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error from loading the application and the error message is " + ex.StackTrace + ".");
            }  
        }

        int selectedQuestionIndex;
        int score;
        List<Question> questionsList = new List<Question> { };

        private void loadQuestions()
        {
            try
            {
                log.Info("The list of questions is loaded...");
                string questionInString;

                List<string> questionsList = new List<string>();

                StreamReader inputFile;
                var file = ConfigurationManager.AppSettings["QuestionsPath"];
                inputFile = File.OpenText(file);

                while (!inputFile.EndOfStream)
                {
                    questionInString = inputFile.ReadLine();
                    questionsList.Add(questionInString.Trim());
                }

                foreach (string question in questionsList)
                {
                    Question newQuestion = new Question();
                    string[] parts = question.Split(',');
                    newQuestion.Id = int.Parse(parts[0]);
                    newQuestion.Questions = parts[1];
                    newQuestion.Answers = new string[] { parts[2], parts[3], parts[4], parts[5] };
                    newQuestion.CorrectAnswerIndex = int.Parse(parts[6]);
                    this.questionsList.Add(newQuestion);
                }

                inputFile.Close();

                //Shuffle the questionList
                FisherYatesShuffle(this.questionsList);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error from read CSV File and the error message is " + ex.StackTrace + ".");
            }
            finally
            {
                Console.WriteLine("Successfully read the file and form the Questions objects.");
            }
        }

        private void isEnabledOnButtons(string selectedBtnName)
        {
            try
            {
                string btnName = selectedBtnName.Trim();
                switch (btnName)
                {
                    case "btnAnswer1":
                        btnAnswer2.Enabled = false;
                        btnAnswer3.Enabled = false;
                        btnAnswer4.Enabled = false;
                        break;

                    case "btnAnswer2":
                        btnAnswer1.Enabled = false;
                        btnAnswer3.Enabled = false;
                        btnAnswer4.Enabled = false;
                        break;

                    case "btnAnswer3":
                        btnAnswer1.Enabled = false;
                        btnAnswer2.Enabled = false;
                        btnAnswer4.Enabled = false;
                        break;

                    case "btnAnswer4":
                        btnAnswer1.Enabled = false;
                        btnAnswer2.Enabled = false;
                        btnAnswer3.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error from the status of buttons (enabled or not) and the error message is " + ex.Message + ".");
            }
            finally
            {
                Console.WriteLine("Successfully update the status of buttons from doubled-clicking.");
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                log.Debug("Question no.1 displaying....");
                btnAnswer1.Enabled = true;
                btnAnswer2.Enabled = true;
                btnAnswer3.Enabled = true;
                btnAnswer4.Enabled = true;
                btnStart.Visible = false;
                lblQuestion.Text = questionsList[0].Questions;
                btnAnswer1.Text = questionsList[0].Answers[0];
                btnAnswer2.Text = questionsList[0].Answers[1];
                btnAnswer3.Text = questionsList[0].Answers[2];
                btnAnswer4.Text = questionsList[0].Answers[3];

                btnNext.Visible = true;
                clearBtn.Visible = false;
                lblPresentation.Visible = false;
                lblPresent2.Visible = false;
                btnStart.Visible = false;

                lblQuestion.Visible = true;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                lblPoints.Visible = true;
                lblyourscore.Visible = true;
                lblPoints.Text = $"{score} Points";
                btnExit.Visible = true;


                btnAnswer1.BackColor = Color.White;
                btnAnswer2.BackColor = Color.White;
                btnAnswer3.BackColor = Color.White;
                btnAnswer4.BackColor = Color.White;
                picBoxCorrect.Visible = false;
                picBoxIncorrect.Visible = false;
                picMathlady.Visible = false;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error from Start Button and the error message is " + ex.Message + ".");
            }
            finally
            {
                Console.WriteLine("Successfully display first question.");
            }
        }

        private void checkAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                log.Debug("Answer is checking....");
                //Casting the sender(capture the selected button)
                Button button = sender as Button;

                int currentQuestion = selectedQuestionIndex;

                int answerIndex = questionsList[currentQuestion].CorrectAnswerIndex;

                string rightAnswer = questionsList[currentQuestion].Answers[answerIndex];

                isEnabledOnButtons(button.Name);

                if (button.Text.Equals(rightAnswer))
                {
                    btnAnswer1.Enabled = false;
                    btnAnswer2.Enabled = false;
                    btnAnswer3.Enabled = false;
                    btnAnswer4.Enabled = false;
                    btnNext.Enabled = true;
                    button.BackColor = Color.LightGreen;
                    picBoxCorrect.Visible = true;
                    picBoxIncorrect.Visible = false;
                    lblAnswer.Visible = true;
                    lblAnswer.Text = "Correct!";
                    score += 10;
                }
                else
                {
                    btnAnswer1.Enabled = false;
                    btnAnswer2.Enabled = false;
                    btnAnswer3.Enabled = false;
                    btnAnswer4.Enabled = false;
                    btnNext.Enabled = true;
                    button.BackColor = Color.OrangeRed;
                    picBoxCorrect.Visible = false;
                    picBoxIncorrect.Visible = true;
                    lblAnswer.Visible = true;
                    lblAnswer.Text = "Oops...";
                    
                    picBoxIncorrect.Visible = true;
                    if (answerIndex == 0)
                    {
                        btnAnswer1.BackColor = Color.LightGreen;
                    }
                    else if (answerIndex == 1)
                    {
                        btnAnswer2.BackColor = Color.LightGreen;
                    }
                    else if (answerIndex == 2)
                    {
                        btnAnswer3.BackColor = Color.LightGreen;
                    }
                    else if (answerIndex == 3)
                    {
                        btnAnswer4.BackColor = Color.LightGreen;
                    }
                }

                lblPoints.Text = $"{score} Points";
                selectedQuestionIndex++;

                //Update the GUI
                if (selectedQuestionIndex != questionsList.Count)
                {
                    clearBtn.Visible = false;
                    btnNext.Visible = true;
                }
                else
                {
                    btnNext.Visible = false;
                    clearBtn.Visible = true;
                    lblFinish.Visible = true;
                    lblFinish.Text = $"Well Done! Your final score is {score}";
                }

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error after option button selected and the error message is " + ex.Message + ".");
            }
            finally
            {
                Console.WriteLine("Completed question number: " + selectedQuestionIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                log.Debug("Next question " + selectedQuestionIndex + " is displaying....");
                picBoxCorrect.Visible = false;
                picBoxIncorrect.Visible = false;
                btnAnswer1.BackColor = Color.White;
                btnAnswer2.BackColor = Color.White;
                btnAnswer3.BackColor = Color.White;
                btnAnswer4.BackColor = Color.White;

                //To reset and displayed the selections
                btnAnswer1.Enabled = true;
                btnAnswer2.Enabled = true;
                btnAnswer3.Enabled = true;
                btnAnswer4.Enabled = true;

                btnStart.Visible = false;
                lblQuestion.Visible = true;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                lblAnswer.Visible = true;
                lblPoints.Visible = true;
                lblyourscore.Visible = true;
                lblAnswer.Text = "";
                lblAnswer.Visible = false;

                lblQuestion.Text = questionsList[selectedQuestionIndex].Questions;
                btnAnswer1.Text = questionsList[selectedQuestionIndex].Answers[0];
                btnAnswer2.Text = questionsList[selectedQuestionIndex].Answers[1];
                btnAnswer3.Text = questionsList[selectedQuestionIndex].Answers[2];
                btnAnswer4.Text = questionsList[selectedQuestionIndex].Answers[3];

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error from Next Button and the error message is " + ex.Message + ".");
            }
            finally
            {
                Console.WriteLine("Next question successfully updated.");
            }
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                log.Info("Game restart...");
                Form1 newForm = new Form1();
                newForm.Show();
                this.Dispose(false);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show("Error from Clear Button and the error message is " + ex.Message + ".");
            }
            finally
            {
                Console.WriteLine("Successfully disposed old and create new Form.");
            }
        }
        private static void FisherYatesShuffle<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
