namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04922
    {
        public void solve()
        {
            //while (true)
            //{
            //    int N = Int32.Parse(Console.ReadLine()!);
            //    int[,] array = new int[N, N];
                
            //    if (N == 0) break;

            //    int x = 0;
            //    int y = 0;
            //    int qCircle = 1;
            //    int count = 1;
            //    bool flag = false;  //반시계: false, 시계: true
            //    array[x, y] = 1;
                
            //    while(N * N != count)
            //    {
            //        //반시계
            //        if (!flag)
            //        {
            //            //오른쪽
            //            if (x + 1 == qCircle)
            //            {
            //                x++;
            //                count++;
            //                array[x, y] = count;
            //            }
            //            //위
            //            else if (x + 1 > qCircle && y + 1 <= qCircle)
            //            {
            //                for (int j = 0; j < qCircle; j++)
            //                {
            //                    y++;
            //                    count++;
            //                    array[x, y] = count;
            //                }
            //            }
            //            //왼쪽
            //            else if (x + 1 > qCircle && y + 1 > qCircle)
            //            {
            //                for (int j = 0; j < qCircle; j++)
            //                {
            //                    x--;
            //                    count++;
            //                    array[x, y] = count;
            //                }
            //                qCircle++;
            //                flag = true;
            //            }
            //        }
            //        //시계
            //        else
            //        {
            //            //위
            //            if (y + 1 == qCircle)
            //            {
            //                y++;
            //                count++;
            //                array[x,y] = count;
            //            }
            //            //오른쪽
            //            else if (x + 1 <= qCircle && y + 1 > qCircle)
            //            {
            //                for (int j = 0; j < qCircle; j++)
            //                {
            //                    x++;
            //                    count++;
            //                    array[x, y] = count;
            //                }
            //            }
            //            //아래
            //            else if (x + 1 > qCircle && y + 1 > qCircle)
            //            {
            //                for (int j = 0; j < qCircle; j++)
            //                {
            //                    y--;
            //                    count++;
            //                    array[x, y] = count;
            //                }
            //                qCircle++;
            //                flag = false;
            //            }
            //        }
            //    }

            //    Console.WriteLine(array[N - 1, N - 1]);
            //}

            while (true)
            {
                int N = Int32.Parse(Console.ReadLine()!);
                Console.WriteLine(N * N - N + 1);
            }
        }
    }
}
