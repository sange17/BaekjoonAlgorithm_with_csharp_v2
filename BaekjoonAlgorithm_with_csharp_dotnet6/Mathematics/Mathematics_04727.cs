namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04727
    {
        public void solve()
        {
            // 입력 받기 (예시)
            string[] input = Console.ReadLine()!.Split(' ');
            int n = int.Parse(input[0]); // 입력받는 숫자 개수
            double allowedError = double.Parse(input[1]); // 허용 오차

            List<double> numbers = new List<double>();
            string[] numberStrings = Console.ReadLine()!.Split(' ');
            foreach (string numStr in numberStrings)
            {
                numbers.Add(double.Parse(numStr));
            }

            // 문제 해결 로직 (예시)
            // 주어진 연산에 따라 숫자를 처리하고, 허용 오차 내에 있는지 확인
            double result = CalculateResult(numbers); // 사용자 정의 함수

            // 결과 출력
            if (Math.Abs(result - ExpectedResult(numbers)) <= allowedError)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        // 예시 연산 함수 (문제에 따라 변경 필요)
        static double CalculateResult(List<double> numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count; // 예시: 평균 계산
        }

        // 정확한 값 계산 함수 (허용 오차를 검증하기 위한 함수, 문제에 따라 변경 필요)
        static double ExpectedResult(List<double> numbers)
        {
            // 정확한 계산을 수행하는 로직 (예시)
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count; // 예시: 평균 계산
        }
    }
}
