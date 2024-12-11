namespace MiniProjects
{
    class DiceGame
    {
        static void Main(string[] args)
        {
            const int tries = 3;
            Random random = new Random();
            int p1,enemy;
            int[] playerPoints = new int[2];

            for(int i = 0; i < tries; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
                
                p1 = random.Next(1,7);
                Console.WriteLine($"Player 1, round {i+1}: {p1}");

                enemy = random.Next(1,7);
                Console.WriteLine($"Enemy, round {i+1}: {enemy}");

                if(p1 > enemy){
                    playerPoints[0]++;
                }else{
                    playerPoints[1]++;
                }
            }
            
            if(playerPoints[0] > playerPoints[1])
            {
                Console.WriteLine("Player 1 wins!");
            }else if(playerPoints[1] > playerPoints[0])
            {
                Console.WriteLine("Enemy wins!");
            }else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}