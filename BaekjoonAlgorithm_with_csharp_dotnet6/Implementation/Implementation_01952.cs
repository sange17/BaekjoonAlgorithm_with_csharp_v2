namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01952
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int h = Int32.Parse(line.Split(" ")[0]);
            int w = Int32.Parse(line.Split(" ")[1]);

            bool[,] map = new bool[w + 2, h + 2];

            for (int i = 0; i < h + 2; i++)
            {
                for (int j = 0; j < w + 2; j++)
                {
                    if(i == 0 || i == h + 2 - 1) map[j, i] = true;
                    else if(j == 0 || j == w + 2 - 1) map[j,i] = true;
                }
            }

            int x = 1;
            int y = 1;
            int count = 0;

            string direction = "right";
            map[x, y] = true;
            while (true)
            {
                if (map[x + 1, y] == true && map[x, y + 1] == true && map[x - 1, y] == true && map[x, y - 1] == true)
                {
                    Console.Write(count);
                    break;
                }

                map[x, y] = true;

                if (direction == "right")
                {
                    if (map[x + 1, y] == true)
                    {
                        direction = "down";
                        count++;
                    }
                    else
                    {
                        x += 1;
                    }
                }
                else if (direction == "down")
                {
                    if (map[x, y + 1] == true)
                    {
                        direction = "left";
                        count++;
                    }
                    else
                    {
                        y += 1;
                    }
                }
                else if (direction == "left")
                {
                    if (map[x - 1, y] == true)
                    {
                        direction = "up";
                        count++;
                    }
                    else
                    {
                        x -= 1;
                    }
                }
                else if (direction == "up")
                {
                    if (map[x, y - 1] == true)
                    {
                        direction = "right";
                        count++;
                    }
                    else
                    {
                        y -= 1;
                    }
                }
            }
        }
    }
}
