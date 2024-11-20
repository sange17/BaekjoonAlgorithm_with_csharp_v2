namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05617
    {
        public void solve()
        {
            int triangleCnt = 0;
            int righttriCnt = 0;    //직각(c^2 = a^2 + b^2)
            int acutetriCnt = 0;    //예각(c^2 < a^2 + b^2)
            int obtusetriCnt = 0;   //둔각(c^2 > a^2 + b^2)
            while (true)
            {
                string line = Console.ReadLine()!;
                if (string.IsNullOrEmpty(line))
                {
                    Console.Write(triangleCnt + " " + righttriCnt + " " + acutetriCnt + " " + obtusetriCnt);
                    break;
                }

                int[] array = line.Split(" ").Select(int.Parse).ToArray();
                Array.Sort(array);

                if (array[2] == array[0] + array[1])
                {
                    Console.Write(triangleCnt + " " + righttriCnt + " " + acutetriCnt + " " + obtusetriCnt);
                    break;
                }
                //직각
                else if ((array[2] * array[2]) == (array[0] * array[0] + array[1] * array[1]))
                {
                    righttriCnt++;
                }
                //예각
                else if ((array[2] * array[2]) < (array[0] * array[0] + array[1] * array[1]))
                {
                    acutetriCnt++; 
                }
                //둔각
                else if ((array[2] * array[2]) > (array[0] * array[0] + array[1] * array[1]))
                {
                    obtusetriCnt++;
                }

                triangleCnt++;
            }
        }
    }
}
