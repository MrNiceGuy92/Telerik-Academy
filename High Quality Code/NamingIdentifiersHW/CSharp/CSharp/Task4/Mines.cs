namespace MineGame
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CSharp.Task4;

    public class Mines
    {
        public static void Main(string[] arguments)
        {
            const int FiledsWithoutMines = 35;
            string command = string.Empty;
            int row = 0;
            int column = 0;
            int pointsStandingInfoCounter = 0;
            List<PointsStandingInfo> highScores = new List<PointsStandingInfo>(6);
            char[,] playFieldArray = CreatePlayingField();
            char[,] mineFieldArray = PlaceMines();
            bool hasExploded = false;
            bool isNewGame = true;
            bool maxPointsStandingInfoReached = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Lets play Mines! Try to find the fields without mines." +
                    " Command 'top' shows the results, command 'restart' starts a new game, command 'exit' exits the game!");
                    PrintPlayingField(playFieldArray);
                    isNewGame = false;
                }

                Console.Write("Input row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playFieldArray.GetLength(0) && column <= playFieldArray.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowResults(highScores);
                        break;
                    case "restart":
                        playFieldArray = CreatePlayingField();
                        mineFieldArray = PlaceMines();
                        PrintPlayingField(playFieldArray);
                        hasExploded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (mineFieldArray[row, column] != '*')
                        {
                            if (mineFieldArray[row, column] == '-')
                            {
                                ShowFieldValue(playFieldArray, mineFieldArray, row, column);
                                pointsStandingInfoCounter++;
                            }

                            if (FiledsWithoutMines == pointsStandingInfoCounter)
                            {
                                maxPointsStandingInfoReached = true;
                            }
                            else
                            {
                                PrintPlayingField(playFieldArray);
                            }
                        }
                        else
                        {
                            hasExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("{0} Invalid command! {1}", Environment.NewLine);
                        break;
                }

                if (hasExploded)
                {
                    PrintPlayingField(mineFieldArray);
                    Console.Write("Game over! You have {0} PointsStandingInfo. Enter your nickname: ", pointsStandingInfoCounter);
                    string playerNickname = Console.ReadLine();
                    PointsStandingInfo playerScore = new PointsStandingInfo(playerNickname, pointsStandingInfoCounter);

                    if (highScores.Count < 5)
                    {
                        highScores.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Points < playerScore.Points)
                            {
                                highScores.Insert(i, playerScore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((PointsStandingInfo r1, PointsStandingInfo r2) => r2.Name.CompareTo(r1.Name));
                    highScores.Sort((PointsStandingInfo r1, PointsStandingInfo r2) => r2.Points.CompareTo(r1.Points));
                    ShowResults(highScores);

                    playFieldArray = CreatePlayingField();
                    mineFieldArray = PlaceMines();
                    pointsStandingInfoCounter = 0;
                    hasExploded = false;
                    isNewGame = true;
                }

                if (maxPointsStandingInfoReached)
                {
                    Console.WriteLine("Congartulations! You've won!");
                    PrintPlayingField(mineFieldArray);
                    Console.WriteLine("Player name: ");
                    string playerName = Console.ReadLine();
                    PointsStandingInfo newPointsStandingInfo = new PointsStandingInfo(playerName, pointsStandingInfoCounter);
                    highScores.Add(newPointsStandingInfo);
                    ShowResults(highScores);
                    playFieldArray = CreatePlayingField();
                    mineFieldArray = PlaceMines();
                    pointsStandingInfoCounter = 0;
                    maxPointsStandingInfoReached = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Thanks for playing!");
            Console.Read();
        }

        private static void ShowResults(List<PointsStandingInfo> points)
        {
            Console.WriteLine("{0} PointsStandingInfo:", Environment.NewLine);

            if (points.Count > 0)
            {
                for (int rank = 0; rank < points.Count; rank++)
                {
                    Console.WriteLine("{0}. {1} --> {2} fields open", rank + 1, points[rank].Name, points[rank].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No results! {0}", Environment.NewLine);
            }
        }

        private static void ShowFieldValue(char[,] playingField, char[,] minesField, int row, int column)
        {
            char minesCount = NumberOfMines(minesField, row, column);
            minesField[row, column] = minesCount;
            playingField[row, column] = minesCount;
        }

        private static void PrintPlayingField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------{0}", Environment.NewLine);
        }

        private static char[,] CreatePlayingField()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playingField[i, j] = '?';
                }
            }

            return playingField;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playingField = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    playingField[row, col] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        private static void CalculateFieldValues(char[,] playingField)
        {
            int columns = playingField.GetLength(0);
            int rows = playingField.GetLength(1);

            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (playingField[col, row] != '*')
                    {
                        char bombCounter = NumberOfMines(playingField, col, row);
                        playingField[col, row] = bombCounter;
                    }
                }
            }
        }

        private static char NumberOfMines(char[,] playingField, int row, int col)
        {
            int mineCounter = 0;
            int rows = playingField.GetLength(0);
            int columns = playingField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playingField[row - 1, col] == '*')
                {
                    mineCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (playingField[row + 1, col] == '*')
                {
                    mineCounter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playingField[row, col - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (col + 1 < columns)
            {
                if (playingField[row, col + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playingField[row - 1, col - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < columns))
            {
                if (playingField[row - 1, col + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playingField[row + 1, col - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < columns))
            {
                if (playingField[row + 1, col + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }
    }
}