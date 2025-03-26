namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02511
    {
        public void solve()
        {
            int[] aArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] bArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int aScore = 0;
            int bScore = 0;
            string lastWinner = string.Empty;

            for (int i = 0; i < aArray.Length; i++)
            {
                if (aArray[i] > bArray[i])
                {
                    aScore += 3;
                    lastWinner = "A";
                }
                else if (aArray[i] < bArray[i])
                {
                    bScore += 3;
                    lastWinner = "B";
                }
                else
                {
                    aScore++;
                    bScore++;
                }
            }

            if (aScore > bScore)
            {
                Console.Write(aScore + " " + bScore + "\n" + "A");
            }
            else if(aScore < bScore)
            {
                Console.Write(aScore + " " + bScore + "\n" + "B");
            }
            else
            {
                if(lastWinner == "A")
                    Console.Write(aScore + " " + bScore + "\n" + "A");
                else if(lastWinner == "B")
                    Console.Write(aScore + " " + bScore + "\n" + "B");
                else
                    Console.Write(aScore + " " + bScore + "\n" + "D");
            }
        }
    }
}
