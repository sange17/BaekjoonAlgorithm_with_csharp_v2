namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_20571
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            string building = line.Split(" ")[0];
            int floor = Int32.Parse(line.Split(" ")[1]);

            if (building == "residential")
            {
                if(floor == 1)
                    Console.Write(0);
                else if(floor >= 2 && floor <= 5)
                    Console.Write(1);
                else if(floor >= 6 && floor <= 10)
                    Console.Write(2);
                else if(floor >= 11 && floor <= 15)
                    Console.Write(3);
                else if(floor >= 16 && floor <= 20)
                    Console.Write(4);
            }
            else if (building == "commercial")
            {
                if (floor == 1)
                    Console.Write(0);
                else if (floor >= 2 && floor <= 7)
                    Console.Write(1);
                else if (floor >= 8 && floor <= 14)
                    Console.Write(2);
                else if (floor >= 15 && floor <= 20)
                    Console.Write(3);
            }
            else if (building == "industrial")
            {
                if (floor == 1)
                    Console.Write(0);
                else if (floor >= 2 && floor <= 4)
                    Console.Write(1);
                else if (floor >= 5 && floor <= 8)
                    Console.Write(2);
                else if (floor >= 9 && floor <= 12)
                    Console.Write(3);
                else if (floor >= 13 && floor <= 16)
                    Console.Write(4);
                else if( floor >= 17 && floor <= 20)
                    Console.Write(5);
            }
        }
    }
}
