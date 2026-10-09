namespace Homework4
{
    class Program
    {
        static void Main()
        {
            Attempt[][] jugged = 
            {
                new Attempt[] {new Attempt(70,1), new Attempt(50, 3)},
                new Attempt[] {new Attempt(30,1), new Attempt(50, 3),new Attempt(35, 4)},
                new Attempt[] {new Attempt(10,5), new Attempt(50, 3), new Attempt(50, 4) },
                new Attempt[] {new Attempt(25,1) }

            };
            BestAttempt(jugged);

        }

        struct Attempt
        {
            public int Score;
            public int Day;

            public Attempt(int Score, int Day)
            {
                this.Score = Score;
                this.Day = Day;
            }
        }

        static void BestAttempt(Attempt[][] jugged)
        {
            Attempt[] a1 = new Attempt[jugged.Length];

            for (int i = 0; i < jugged.Length; i++)
            {
                Attempt best = jugged[i][0];
                for (int j = 0; j < jugged[i].Length; j++)
                {
                    if (best.Score < jugged[i][j].Score)
                        best = jugged[i][j];
                    else if (best.Score == jugged[i][j].Score && jugged[i][j].Day < best.Day)
                        best = jugged[i][j];
                }
                a1[i] = best;
            }

            //print
            for(int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine($"Student {i+1} Best Attemp is : Day - {a1[i].Day}\t Score - {a1[i].Score}");
            }
        }

    }
}