namespace CSharp.Task4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mines
    {
        public class tochki
        {
            public string name;
            public int points;

            public string Name
            {
                get 
                { 
                    return this.name; 
                }
                set 
                { 
                    this.name = value; 
                }
            }

            public int Points
            {
                get 
                { 
                    return points; 
                }
                set 
                { 
                    points = value; 
                }
            }

            public tochki() 
            { 
            }

            public tochki(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] field = createPlayingField();
            char[,] bombs = placeBombs();
            int counter = 0;
            bool explosion = false;
            List<tochki> champions = new List<tochki>(6);
            int row = 0;
            int column = 0;
            bool flag = true;
            const int maximum = 35;
            bool isMaximum = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Let's play \"Mines\". Try your best to find the places without mines." +
                    "Command 'top' shows the result, cammand 'restart' starts a new game, and command 'exit' terminates the game.");
                    dumpp(field);
                    flag = false;
                }
                Console.Write("Input row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        Scores(champions);
                        break;
                    case "restart":
                        field = createPlayingField();
                        bombs = placeBombs();
                        dumpp(field);
                        explosion = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Thanks for playing!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                tisinahod(field, bombs, row, column);
                                counter++;
                            }
                            if (maximum == counter)
                            {
                                isMaximum = true;
                            }
                            else
                            {
                                dumpp(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid Command!\n");
                        break;
                }
                if (explosion)
                {
                    dumpp(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    tochki t = new tochki(niknejm, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((tochki r1, tochki r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((tochki r1, tochki r2) => r2.Points.CompareTo(r1.Points));
                    Scores(champions);

                    field = createPlayingField();
                    bombs = placeBombs();
                    counter = 0;
                    explosion = false;
                    flag = true;
                }
                if (isMaximum)
                {
                    Console.WriteLine("\nCongratulations! You've won!");
                    dumpp(bombs);
                    Console.WriteLine("Player name: ");
                    string playerName = Console.ReadLine();
                    tochki to4kii = new tochki(playerName, counter);
                    champions.Add(to4kii);
                    Scores(champions);
                    field = createPlayingField();
                    bombs = placeBombs();
                    counter = 0;
                    isMaximum = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Scores(List<tochki> to4kii)
        {
            Console.WriteLine("\nPoints:");
            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No Scores!\n");
            }
        }

        private static void tisinahod(char[,] field,
            char[,] bombs, int row, int column)
        {
            char kolkoBombi = numberOfBombs(bombs, row, column);
            bombs[row, column] = kolkoBombi;
            field[row, column] = kolkoBombi;
        }

        private static void dumpp(char[,] board)
        {
            int rowLength = board.GetLength(0);
            int columnLength = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] createPlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] placeBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = (i2 / cols);
                int red = (i2 % cols);
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = cols;
                }
                else
                {
                    red++;
                }
                playingField[kol, red - 1] = '*';
            }

            return playingField;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = numberOfBombs(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char numberOfBombs(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            return char.Parse(brojkata.ToString());
        }
    } 
}