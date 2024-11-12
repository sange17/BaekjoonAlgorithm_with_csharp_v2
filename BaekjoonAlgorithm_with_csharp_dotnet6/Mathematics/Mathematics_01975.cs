namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01975
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(sr.ReadLine()!);
                int A = 2;
                int sum = 0;

                // N < A 때까지 반복. 그 이상 반복은 같은 값으로 변환되어 의미없음.
                while (true)
                {
                    if (N < A)
                    {
                        sw.WriteLine(sum);
                        break;
                    }

                    // 2,3,4...진법 변환을 반복한다.
                    int tempN = N;
                    string num = "";

                    while (true)
                    {
                        // 진수의 뒷자리 연속된 0의 개수만 구한다.
                        if (tempN % A != 0) break;

                        sum++;
                        tempN /= A;
                    }

                    //아래는 Overflow Error가 낫던 부분으로 추정되어 주석 처리함.
                    //정확히는 57, 58 line

                    //while (true)
                    //{
                    //    // 진법 변환이 끝나면 뒤집힌 결과 생성 완료
                    //    if (tempN < A)
                    //    {
                    //        num += (tempN % A).ToString() + "1";
                    //        break;
                    //    }

                    //    num += (tempN % A).ToString();
                    //    tempN /= A;
                    //}

                    //// 끝자리 0이 있는 값 - 끝자리 0이 없는 값 = 끝자리 0의 개수
                    //// 뒤집지 않고 길이만 비교
                    //int beforeLength = Convert.ToInt32(num).ToString().Length;
                    //int afterLength = num.Length;

                    //sum += (afterLength - beforeLength);

                    A++;
                }
            }

            sr.Close();
            sw.Close();
        }

        //public void solve()
        //{
        //    StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        //    StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //    int T = Int32.Parse(sr.ReadLine()!);
        //    for (int i = 0; i < T; i++)
        //    {
        //        int count = 0;
        //        int N = Int32.Parse(sr.ReadLine()!);
        //        //N의 진수들을 계산하는 거기에 N까지만 반복
        //        for (int j = 2; j <= N; j++)
        //        {
        //            int val = N;
        //            //해당 진수의 숫자마다 반복 횟수가 달라지기 때문에 무한 루프
        //            while (true)
        //            {
        //                //뒷자리 0의 연속된 개수만 필요하므로
        //                //val을 j로 나눠서 나머지가 0이 아니면 무한루프 종료
        //                if (val % j != 0)
        //                {
        //                    break;
        //                }
        //                count++;
        //                val /= j;
        //            }
        //        }
        //        sw.WriteLine(count);
        //    }

        //    sr.Close();
        //    sw.Close();
        //}
    }
}
