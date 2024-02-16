using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16199
    {
        static int[] CalculateAges(string[] birthDate, string[] referenceDate)
        {
            // 생년월일과 기준 날짜를 DateTime 객체로 변환
            DateTime birthDateTime = new DateTime(int.Parse(birthDate[0]), int.Parse(birthDate[1]), int.Parse(birthDate[2]));
            DateTime referenceDateTime = new DateTime(int.Parse(referenceDate[0]), int.Parse(referenceDate[1]), int.Parse(referenceDate[2]));

            // 만 나이 계산
            int ageYears = referenceDateTime.Year - birthDateTime.Year;
            if (referenceDateTime.Month < birthDateTime.Month || (referenceDateTime.Month == birthDateTime.Month && referenceDateTime.Day < birthDateTime.Day))
            {
                ageYears--;
            }

            // 세는 나이 계산
            int ageKorean = referenceDateTime.Year - birthDateTime.Year + 1;

            // 연 나이 계산
            int ageYearsAbsolute = referenceDateTime.Year - birthDateTime.Year;

            return new int[] { ageYears, ageKorean, ageYearsAbsolute };
        }

        public void solve()
        {
            // 생일과 기준 날짜 입력 받기
            string[] birthDate = Console.ReadLine().Split();
            string[] referenceDate = Console.ReadLine().Split();

            // 나이 계산 및 출력
            int[] ages = CalculateAges(birthDate, referenceDate);
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
