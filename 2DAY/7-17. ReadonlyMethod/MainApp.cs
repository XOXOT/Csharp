using System;

namespace ReadonlyMothod
{
    struct ACSetting
    {
        public double currentInCelsius; // 현재 온도(°C)
        public double target; // 희망 온도

        public readonly double GetFahrenheit()
        {
            //target = currentInCelsius * 1.8 + 32; // 화씨(°F) 계산 결과를 target에 저장
            //return target; // target 반환
            return currentInCelsius * 1.8 + 32; //readonly에 따른 타겟값 변경 불가 리턴 값을 변경
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}"); //$을 붙이면 문자열로 인식을 안하고 멤버 변수로 인식하기 때문에 target 값만 출력됨
            Console.WriteLine($"{acs.target}");
        }
    }
}
