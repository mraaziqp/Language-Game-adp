using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Game
{
    public partial class AfrikaansLevel2 : Form
    {
        int correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;

        public AfrikaansLevel2()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void checkAnswerEvents(object sender, EventArgs e)
        {
            //linking the button to the question-senders
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag); //convert function from the sender object
            //int saved as tag

            //correct answer button
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                //work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz has Ended!!!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }
            //for question to go to the next one`
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.English;

                    lblQuestion.Text = "What is the gender of baby Alexah?";

                    button1.Text = "Boy";
                    button2.Text = "Girl";
                    button3.Text = "Mixed";
                    button4.Text = "Unknown";

                    correctAnswer = 2;

                    break;



                case 2:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "How much did Alexah weigh at birth?";
                    button1.Text = "3.5kg";
                    button2.Text = "1.5kg";
                    button3.Text = "3.2kg";
                    button4.Text = "2.3kg";

                    correctAnswer = 3;

                    break;



                case 3:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "How often must a newborn baby be fed?";
                    button1.Text = "Every 24 hours";
                    button2.Text = "Every 3 hours";
                    button3.Text = "Demand feeding";
                    button4.Text = "Every 6 hours";

                    correctAnswer = 3;

                    break;



                case 4:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "A baby needs milk to be healthy. Which of the following feeding methods will be good for a baby?";
                    button1.Text = "Breast fed";
                    button2.Text = "Cup fed";
                    button3.Text = "Bottle fed";
                    button4.Text = "All of the above";

                    correctAnswer = 4;

                    break;



                case 5:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "A dad can assist with care of a newborn baby by doing the following:";
                    button1.Text = "Rub out the winds after feeding";
                    button2.Text = "Change the nappy";
                    button3.Text = "Bath the baby";
                    button4.Text = "All of the above";

                    correctAnswer = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "How often does a baby need burping?";
                    button1.Text = "Never";
                    button2.Text = "After eating";
                    button3.Text = "Once a day";
                    button4.Text = "Every three hours";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "How long does it take to give birth?";
                    button1.Text = "10 hours";
                    button2.Text = "5 minutes";
                    button3.Text = "3 hours";
                    button4.Text = "Differs between women";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "When would you know a baby is hungry or in need of burping?";
                    button1.Text = "Stares at you";
                    button2.Text = "Grips fist with a frown";
                    button3.Text = "Cries";
                    button4.Text = "button &2 and button &3";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "In which way was Alexah born";
                    button1.Text = "Natural birth";
                    button2.Text = "C-Section";
                    button3.Text = "Induced Labour";
                    button4.Text = "Amniotomy";

                    correctAnswer = 1;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "At which time was Alexah born?";
                    button1.Text = "02:50am";
                    button2.Text = "16:39pm";
                    button3.Text = "23:06pm";
                    button4.Text = "12:19pm";

                    correctAnswer = 3;

                    break;


            }
        }
        }
}
