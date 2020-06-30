using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        Button button0;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Button button7;
        Button button8;
        Button start;
        Label winnerlabel;
        RadioButton startplayer;
        RadioButton startai;
        GroupBox startcheck;
        GroupBox difficultycheck;
        RadioButton easy;
        RadioButton medium;
        RadioButton difficult;
        Label aipoints;
        Label userpoints;
        Label drawcount;
        Label aicaption;
        Label usercaption;
        Label drawcaption;
        Button resetbutton;

        public MainForm()
        {

            InitializeComponent();

            button0 = new Button();
            button0.Size = new Size(40, 40);
            button0.Location = new Point(30, 30);
            Controls.Add(button0);
            button0.Click += Button0_Click;
            button0.Text = "T";

            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(80, 30);
            Controls.Add(button1);
            button1.Click += Button1_Click;
            button1.Text = "I";

            button2 = new Button();
            button2.Size = new Size(40, 40);
            button2.Location = new Point(130, 30);
            Controls.Add(button2);
            button2.Click += Button2_Click;
            button2.Text = "C";

            button3 = new Button();
            button3.Size = new Size(40, 40);
            button3.Location = new Point(30, 80);
            Controls.Add(button3);
            button3.Click += Button3_Click;
            button3.Text = "T";

            button4 = new Button();
            button4.Size = new Size(40, 40);
            button4.Location = new Point(80, 80);
            Controls.Add(button4);
            button4.Click += Button4_Click;
            button4.Text = "A";

            button5 = new Button();
            button5.Size = new Size(40, 40);
            button5.Location = new Point(130, 80);
            Controls.Add(button5);
            button5.Click += Button5_Click;
            button5.Text = "C";

            button6 = new Button();
            button6.Size = new Size(40, 40);
            button6.Location = new Point(30, 130);
            Controls.Add(button6);
            button6.Click += Button6_Click;
            button6.Text = "T";

            button7 = new Button();
            button7.Size = new Size(40, 40);
            button7.Location = new Point(80, 130);
            Controls.Add(button7);
            button7.Click += Button7_Click;
            button7.Text = "O";

            button8 = new Button();
            button8.Size = new Size(40, 40);
            button8.Location = new Point(130, 130);
            Controls.Add(button8);
            button8.Click += Button8_Click;
            button8.Text = "E";

            start = new Button();
            start.Size = new Size(95, 40);
            start.Location = new Point(180, 130);
            Controls.Add(start);
            start.Click += RunGame;
            start.Text = "New Game";

            resetbutton = new Button();
            resetbutton.Size = new Size(95, 40);
            resetbutton.Location = new Point(295, 130);
            Controls.Add(resetbutton);
            resetbutton.Click += Resetbutton_Click;
            resetbutton.Text = "Reset scores";

            winnerlabel = new Label();
            winnerlabel.Size = new Size(400, 40);
            winnerlabel.Location = new Point(30, 230);
            winnerlabel.Font = new Font("arial", 24);
            Controls.Add(winnerlabel);

            startplayer = new RadioButton();
            startplayer.Location = new Point(20, 15);
            startplayer.Size = new Size(70, 20);
            startplayer.Text = "Player";
            startplayer.Checked = true;
            Controls.Add(startplayer);

            startai = new RadioButton();
            startai.Location = new Point(100, 15);
            startai.Size = new Size(70, 20);
            startai.Text = "AI";
            Controls.Add(startai);

            startcheck = new GroupBox();
            startcheck.Location = new Point(180, 30);
            startcheck.Size = new Size(260, 40);
            startcheck.Text = "Start player";
            startcheck.Controls.Add(startai);
            startcheck.Controls.Add(startplayer);
            Controls.Add(startcheck);

            difficultycheck = new GroupBox();
            difficultycheck.Location = new Point(180, 80);
            difficultycheck.Size = new Size(260, 40);
            difficultycheck.Text = "Difficulty";
            Controls.Add(difficultycheck);

            easy = new RadioButton();
            easy.Location = new Point(20, 15);
            easy.Size = new Size(70, 20);
            easy.Text = "Easy";
            Controls.Add(easy);
            difficultycheck.Controls.Add(easy);

            medium = new RadioButton();
            medium.Location = new Point(100, 15);
            medium.Size = new Size(70, 20);
            medium.Text = "Medium";
            Controls.Add(medium);
            difficultycheck.Controls.Add(medium);

            difficult = new RadioButton();
            difficult.Location = new Point(180, 15);
            difficult.Size = new Size(70, 20);
            difficult.Text = "Difficult";
            difficult.Checked = true;
            Controls.Add(difficult);
            difficultycheck.Controls.Add(difficult);

            usercaption = new Label();
            usercaption.Size = new Size(70, 40);
            usercaption.Location = new Point(30, 270);
            usercaption.Text = "User";
            usercaption.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(usercaption);

            drawcaption = new Label();
            drawcaption.Size = new Size(70, 40);
            drawcaption.Location = new Point(130, 270);
            drawcaption.Text = "Draw";
            drawcaption.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(drawcaption);

            aicaption = new Label();
            aicaption.Size = new Size(70, 40);
            aicaption.Location = new Point(230, 270);
            aicaption.Text = "AI";
            aicaption.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(aicaption);

            userpoints = new Label();
            userpoints.Size = new Size(70, 40);
            userpoints.Location = new Point(30, 310);
            userpoints.Text = "0";
            userpoints.TextAlign = ContentAlignment.MiddleCenter;
            userpoints.Font = new Font("arial", 24);
            Controls.Add(userpoints);

            drawcount = new Label();
            drawcount.Size = new Size(70, 40);
            drawcount.Location = new Point(130, 310);
            drawcount.Text = "0";
            drawcount.TextAlign = ContentAlignment.MiddleCenter;
            drawcount.Font = new Font("arial", 24);
            Controls.Add(drawcount);

            aipoints = new Label();
            aipoints.Size = new Size(70, 40);
            aipoints.Location = new Point(230, 310);
            aipoints.Text = "0";
            aipoints.TextAlign = ContentAlignment.MiddleCenter;
            aipoints.Font = new Font("arial", 24);
            Controls.Add(aipoints);

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            aipoints.Text = "0";
            userpoints.Text = "0";
            drawcount.Text = "0";

        }

        public void PrintBoard(TicTacToeCell[] board)
        {
            button0.Text = board[0] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button1.Text = board[1] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button2.Text = board[2] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button3.Text = board[3] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button4.Text = board[4] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button5.Text = board[5] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button6.Text = board[6] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button7.Text = board[7] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };

            button8.Text = board[8] switch
            {
                TicTacToeCell.AI => "O",
                TicTacToeCell.User => "X",
                _ => ""
            };
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            HandleUserInput(8);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            HandleUserInput(7);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            HandleUserInput(6);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            HandleUserInput(5);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HandleUserInput(4);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HandleUserInput(3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HandleUserInput(2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HandleUserInput(1);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            HandleUserInput(0);
        }

        public TicTacToeCell[] Board { get; protected set; }

        public bool HasWinner { get; protected set; }

        bool IsUserTurn { get; set; }

        TicTacToeAI AI { get; set; }

        int Round { get; set; }

        public void RunGame(object sender, EventArgs e)
        {
            HasWinner = false;
            IsUserTurn = startplayer.Checked;
            winnerlabel.Text = "";
            Round = 0;

            TicTacToeDifficulty difficulty;
            if (easy.Checked) difficulty = TicTacToeDifficulty.Easy;
            else if (medium.Checked) difficulty = TicTacToeDifficulty.Medium;
            else difficulty = TicTacToeDifficulty.Difficult;

            AI = new TicTacToeAI(difficulty);

            Board = new TicTacToeCell[9];

            for (int i = 0; i < 9; i++)
            {
                Board[i] = TicTacToeCell.None;
            }

            PrintBoard(Board);

            if (startai.Checked) HandleAIInput(AI.ComputeNextMove(Board));

        }

        public void HandleUserInput(int Cell)
        {
            if (HasWinner || !IsUserTurn) return;

            if (Board[Cell] == TicTacToeCell.None) Board[Cell] = TicTacToeCell.User;
            else return;

            IsUserTurn = false;
            PrintBoard(Board);
            Round++;

            HandleWinScenario();

            if (Round == 9) return;

            
            HandleAIInput(AI.ComputeNextMove(Board));

        }
        void HandleAIInput(int Cell)
        {

            if (HasWinner || IsUserTurn) return;

            if (Board[Cell] == TicTacToeCell.None) Board[Cell] = TicTacToeCell.AI;
            else throw new ArgumentException();

            IsUserTurn = true;
            PrintBoard(Board);
            Round++;

            HandleWinScenario();

        }

        void HandleWinScenario()
        {
            List<List<int>> combinations = new List<List<int>>
            {
                new List<int> {0,1,2},
                new List<int> {3, 4, 5},
                new List<int> {6,7,8},
                new List<int> {0,3,6},
                new List<int> {1,4,7},
                new List<int> {2,5,8},
                new List<int> {0,4,8},
                new List<int> {2,4,6}
            };

            TicTacToeCell winner = TicTacToeCell.None;

            foreach (List<int> l in combinations)
            {
                TicTacToeCell cw = CheckForWinner(Board, l);
                if (cw != TicTacToeCell.None) winner = cw;
            }

            if (winner == TicTacToeCell.AI)
            {
                HasWinner = true;
                winnerlabel.Text = "AI wins!";
                int aipointsscore = int.Parse(aipoints.Text) + 1;
                aipoints.Text = aipointsscore.ToString();
            }
            else if (winner == TicTacToeCell.User)
            {
                HasWinner = true;
                winnerlabel.Text = "User wins!";
                int userscore = int.Parse(userpoints.Text) + 1;
                userpoints.Text = userscore.ToString();
            }
            else if (winner == TicTacToeCell.None)
            {
                int c = 0;
                foreach (TicTacToeCell tttc in Board)
                {
                    if (tttc != TicTacToeCell.None) c++;
                }

                if (c == 9 )
                {
                    HasWinner = true;
                    winnerlabel.Text = "Draw!";
                    int draws = int.Parse(drawcount.Text) + 1;
                    drawcount.Text = draws.ToString();
                }
            }
        }

        TicTacToeCell CheckForWinner(TicTacToeCell[] board, List<int> comb)
        {
            List<int> ai = new List<int>();
            List<int> user = new List<int>();
            foreach (int i in comb)
            {
                if (board[i] == TicTacToeCell.AI) ai.Add(i);
                else if (board[i] == TicTacToeCell.User) user.Add(i);
            }

            if (ai.Count == 3) return TicTacToeCell.AI;
            else if (user.Count == 3) return TicTacToeCell.User;
            else return TicTacToeCell.None;
        }
    }
}
