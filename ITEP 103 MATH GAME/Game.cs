using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEP_103_MATH_GAME
{
    public partial class Game : Form
    {
        int crrctans;
        int questnum = 0; // Current question index
        int score;
        int totalquest;
        int Playerhp = 100;
        int enemyhp = 100;
        int normalEnemiesDefeated = 0; // Track number of normal enemies defeated
        bool isBossFight = false; // Flag to indicate boss fight
        int currentStage = 1; // Track the current stage
        const int maxStages = 3; // Total number of stages
        List<int> questionOrder;
        List<int> wrongAnswers = new List<int>(); // List to track wrong answers

        public Game()
        {
            InitializeComponent();
            InitializeQuestions();
            totalquest = 20;

            plyerhp.Maximum = Playerhp;
            plyerhp.Value = Playerhp;
            mobhp.Maximum = enemyhp;
            mobhp.Value = enemyhp;

            // Attach mouse enter and leave event handlers
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
            button4.MouseEnter += Button_MouseEnter;
            button4.MouseLeave += Button_MouseLeave;

            AskQust();
        }

        private void InitializeQuestions()
        {
            questionOrder = Enumerable.Range(1, 20).ToList(); // Create a list of question numbers
            Random rng = new Random();
            questionOrder = questionOrder.OrderBy(q => rng.Next()).ToList(); // Shuffle the question numbers
        }

        private async void ChkAnsEvnt(object sender, EventArgs e)
        {
            var senderObjectr = (Button)sender;
            int ButtonTag = Convert.ToInt32(senderObjectr.Tag);

            if (ButtonTag == crrctans)
            {
                score++;
                Scrlb1.Text = score.ToString() + "";
                senderObjectr.BackColor = System.Drawing.Color.LawnGreen; // Correct answer
            }
            else
            {
                // Track the wrong answer
                wrongAnswers.Add(questionOrder[questnum]);
                senderObjectr.BackColor = System.Drawing.Color.Red; // Incorrect answer
            }

            await Task.Delay(300); // Delay for 300 milliseconds

            if (ButtonTag == crrctans)
            {
                int damge = isBossFight ? 50 : 25;
                enemyhp -= damge;
                mobhp.Value = enemyhp;

                // Player attacks
                palyerpic.Image = Properties.Resources.char3action;
                enemypic.Image = isBossFight ? GetBossDamagedImage() : GetEnemyDamagedImage();
                await ResetImages();

                if (enemyhp <= 0)
                {
                    if (isBossFight)
                    {
                        enemypic.Image = GetBossDeathImage();
                        MessageBox.Show($"You defeated the boss of Stage {currentStage}!");

                        if (currentStage >= maxStages)
                        {
                            DialogResult result = MessageBox.Show("Congratulations! You won the game! Do you want to restart?", "Victory", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                ResetGame();
                            }
                            else
                            {
                                // Go back to main menu
                                MENU menu = new MENU();
                                menu.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            currentStage++;
                            isBossFight = false;
                            normalEnemiesDefeated = 0;
                            enemyhp = 100; // Reset for the next stage
                            mobhp.Maximum = enemyhp;
                            mobhp.Value = enemyhp;
                            MessageBox.Show($"Welcome to Stage {currentStage}!");
                        }
                    }
                    else
                    {
                        normalEnemiesDefeated++;
                        if (normalEnemiesDefeated >= 3)
                        {
                            // Spawn boss
                            isBossFight = true;
                            enemyhp = 200; // Boss HP
                            mobhp.Maximum = enemyhp;
                            mobhp.Value = enemyhp;
                            enemypic.Image = GetBossImage();
                            MessageBox.Show("A boss has appeared!");
                        }
                        else
                        {
                            // Spawn a new normal enemy
                            enemyhp = 100; // Reset enemy HP
                            mobhp.Value = enemyhp;
                            enemypic.Image = GetEnemyImage();
                        }
                    }
                }
            }
            else
            {
                int damge = 20;
                Playerhp -= damge;
                plyerhp.Value = Playerhp;

                // Enemy attacks
                palyerpic.Image = Properties.Resources.char2; // Hurt animation for player can be added here
                await ResetImages();

                if (Playerhp <= 0)
                {
                    // Player defeated
                    palyerpic.Image = Properties.Resources.char2action;
                    DialogResult result = MessageBox.Show("Game over! You were defeated. Do you want to restart?", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ResetGame();
                    }
                    else
                    {
                        // Go back to main menu
                        MENU menu = new MENU();
                        menu.Show();
                        this.Close();
                    }
                }
            }

            questnum++;
            AskQust();

            // Reset button colors
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
        }

        private async Task ResetImages()
        {
            await Task.Delay(500); // Delay for 500 milliseconds
            palyerpic.Image = Properties.Resources.char3;
            enemypic.Image = isBossFight ? GetBossImage() : GetEnemyImage();
        }

        private void AskQust()
        {
            if (questnum < totalquest)
            {
                int currentQuestionNumber = questionOrder[questnum];
                DisplayQuestion(currentQuestionNumber);
            }
            else if (wrongAnswers.Count > 0)
            {
                totalquest += wrongAnswers.Count;
                questionOrder.AddRange(wrongAnswers);
                wrongAnswers.Clear();
                AskQust();
            }
            else
            {
                MessageBox.Show("You have completed all questions!");
                // Handle end of game logic here
            }
        }

        private void DisplayQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    pb1q.Image = Properties.Resources.q1;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Proposition";
                    button2.Text = "Not Proposition";
                    button3.Text = "None of the above.";
                    button4.Text = "true";
                    crrctans = 2;
                    break;

                case 2:
                    pb1q.Image = Properties.Resources.q2;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Unordered elements";
                    button2.Text = "Only finite elements";
                    button3.Text = "Unique elements";
                    button4.Text = "Only numerical elements";
                    crrctans = 3;
                    break;

                case 3:
                    pb1q.Image = Properties.Resources.q3;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "crete";
                    button2.Text = "screed";
                    button3.Text = "trees";
                    button4.Text = "dist";
                    crrctans = 1;
                    break;

                case 4:
                    pb1q.Image = Properties.Resources.q4;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "^";
                    button2.Text = "|";
                    button3.Text = "!";
                    button4.Text = ">";
                    crrctans = 1;
                    break;

                case 5:
                    pb1q.Image = Properties.Resources.q5;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "{(2, 1), (4, 3), (6, 5)}";
                    button2.Text = "{(1, 2), (3, 4), (5, 6)}";
                    button3.Text = "{(2, 1), (4, 3), (6, 5),(1, 2), (3, 4), (5, 6)}";
                    button4.Text = "{(1, 3), (2, 4), (3, 5)}";
                    crrctans = 1;
                    break;

                case 6:
                    pb1q.Image = Properties.Resources.q6;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "x > 5";
                    button2.Text = "y + 2";
                    button3.Text = "It is raining.";
                    button4.Text = "z × 4";
                    crrctans = 3;
                    break;

                case 7:
                    pb1q.Image = Properties.Resources.q7;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "𝐾𝑛";
                    button2.Text = "𝐾𝑚,𝑛";
                    button3.Text = "𝐶𝑛";
                    button4.Text = "𝑃𝑛";
                    crrctans = 2;
                    break;

                case 8:
                    pb1q.Image = Properties.Resources.q8;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "P and Q are both true";
                    button2.Text = "P implies Q";
                    button3.Text = "P or Q is true";
                    button4.Text = "P if and only if Q";
                    crrctans = 4;
                    break;

                case 9:
                    pb1q.Image = Properties.Resources.q9;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "^";
                    button2.Text = "|";
                    button3.Text = "!";
                    button4.Text = "v";
                    crrctans = 4;
                    break;

                case 10:
                    pb1q.Image = Properties.Resources.q10;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Proposition";
                    button2.Text = "Not Proposition";
                    button3.Text = "None of the above";
                    button4.Text = "False";
                    crrctans = 2;
                    break;

                case 11:
                    pb1q.Image = Properties.Resources.q11;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "If the Sun is a planet, elephants will fly";
                    button2.Text = "3 +2 = 8 if 5-2 = 7";
                    button3.Text = "1 > 3 and 3 is a positive integer";
                    button4.Text = " -2 > 3 or 3 is a negative integer";
                    crrctans = 1;
                    break;

                case 12:
                    pb1q.Image = Properties.Resources.q12;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Tautology";
                    button2.Text = "Contradiction";
                    button3.Text = "Contingency";
                    button4.Text = "Valid";
                    crrctans = 2;
                    break;

                case 13:
                    pb1q.Image = Properties.Resources.q13;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Ordered pairs";
                    button2.Text = "Combination";
                    button3.Text = "Pairing";
                    button4.Text = "Cartesian product";
                    crrctans = 4;
                    break;

                case 14:
                    pb1q.Image = Properties.Resources.q14;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "2";
                    button2.Text = "3";
                    button3.Text = "4";
                    button4.Text = "5";
                    crrctans = 2;
                    break;

                case 15:
                    pb1q.Image = Properties.Resources.q15;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Symmetric";
                    button2.Text = "Reflexive";
                    button3.Text = "Transitive";
                    button4.Text = "Equivalence";
                    crrctans = 1;
                    break;

                case 16:
                    pb1q.Image = Properties.Resources.q16;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "𝑥 + 2 > 𝑥 + 1";
                    button2.Text = "𝑥 = 𝑥 + 2";
                    button3.Text = "3𝑥 > 3𝑥 + 1";
                    button4.Text = "3𝑥 − 5 > 2𝑥 + 3";
                    crrctans = 2;
                    break;

                case 17:
                    pb1q.Image = Properties.Resources.q17;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "{1,2,3,4,5}";
                    button2.Text = "{4,5,6,7,8}";
                    button3.Text = "{4,6,8,10,12}";
                    button4.Text = "{1,3,5,7,9}";
                    crrctans = 4;
                    break;

                case 18:
                    pb1q.Image = Properties.Resources.q18;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "{1,2,3,4,5}";
                    button2.Text = "{4,5,6,7,8}";
                    button3.Text = "{4,6,8,10,12}";
                    button4.Text = "{1,3,5,7,9}";
                    crrctans = 4;
                    break;

                case 19:
                    pb1q.Image = Properties.Resources.q19;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "Proposition";
                    button2.Text = "Not Proposition";
                    button3.Text = "None of the above";
                    button4.Text = "false";
                    crrctans = 2;
                    break;

                case 20:
                    pb1q.Image = Properties.Resources.q20;
                    lb1Q.Text = "Answer The Question";
                    button1.Text = "9";
                    button2.Text = "11";
                    button3.Text = "14";
                    button4.Text = "13";
                    crrctans = 4;
                    break;

                default:
                    break;
            }
        }

        public void ResetGame()
        {
            score = 0;
            Scrlb1.Text = score.ToString(); // Restart the score to 0
            questnum = 0;
            currentStage = 1;
            Playerhp = 100;
            enemyhp = 100;
            normalEnemiesDefeated = 0;
            isBossFight = false;

            plyerhp.Maximum = Playerhp;
            plyerhp.Value = Playerhp;
            mobhp.Maximum = enemyhp;
            mobhp.Value = enemyhp;

            InitializeQuestions();
            AskQust();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.Gray; // Change color to grey when mouse enters
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = SystemColors.Control; // Revert to default color when mouse leaves
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Submenu smenu = new Submenu();
            smenu.Owner = this;
            smenu.Show();
        }

        private Image GetEnemyImage()
        {
            switch (currentStage)
            {
                case 1:
                    return Properties.Resources.char1_action; // Replace with actual image resource
                case 2:
                    return Properties.Resources.char2action; // Replace with actual image resource
                case 3:
                    return Properties.Resources.char3action; // Replace with actual image resource
                default:
                    return Properties.Resources.char1_action; // Default image
            }
        }

        private Image GetBossImage()
        {
            switch (currentStage)
            {
                case 1:
                    return Properties.Resources.boss1_still; // Replace with actual image resource
                case 2:
                    return Properties.Resources.boss1_still; // Replace with actual image resource
                case 3:
                    return Properties.Resources.boss1_still; // Replace with actual image resource
                default:
                    return Properties.Resources.boss1_still; // Default image
            }
        }

        private Image GetEnemyDamagedImage()
        {
            switch (currentStage)
            {
                case 1:
                    return Properties.Resources.char1; // Replace with actual image resource
                case 2:
                    return Properties.Resources.char2; // Replace with actual image resource
                case 3:
                    return Properties.Resources.char3; // Replace with actual image resource
                default:
                    return Properties.Resources.char3; // Default image
            }
        }

        private Image GetBossDamagedImage()
        {
            switch (currentStage)
            {
                case 1:
                    return Properties.Resources.boss1_damaged; // Replace with actual image resource
                case 2:
                    return Properties.Resources.boss1_damaged; // Replace with actual image resource
                case 3:
                    return Properties.Resources.boss1_damaged; // Replace with actual image resource
                default:
                    return Properties.Resources.boss1_damaged; // Default image
            }
        }

        private Image GetBossDeathImage()
        {
            switch (currentStage)
            {
                case 1:
                    return Properties.Resources.boss1_death; // Replace with actual image resource
                case 2:
                    return Properties.Resources.boss1_death; // Replace with actual image resource
                case 3:
                    return Properties.Resources.boss1_death; // Replace with actual image resource
                default:
                    return Properties.Resources.boss1_death; // Default image
            }
        }
    }
}
