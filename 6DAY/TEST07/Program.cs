using System;
using System.Collections;
using System.Text;

namespace TEST07
{
    //주제 인터페이스
    public interface ISubject
    {
        //옵져버등록
        void RegisterObserver(IObserver o);
        //옵져버탈퇴
        void RemoveObserver(IObserver o);

        //주제(subject)객체의 상태가 변경되었을 때

        //모든 옵저버들한테 알리기 위해 호출되는 메서드.
        void notifyObservers();
    }

    //옵져버 인터페이스
    public interface IObserver
    {
        //옵져버에게 측정값을 알리기 위한 메서드.
        void Update(float temp, float humidity, float pressure); //온도,습도,기압
    }

    //모든 디스플레이를 항목에서 구현하는 인터페이스
    public interface IDisplayElement
    {
        void Display();
    }

    //ISubject 인터페이스를 구현하며, 가상스테이션으로 부터 데이터를 받는 WeatherData객체를 구현합니다.

    //옵저버에 변화된 측정값을 알리는 주제객체
    public class WeatherData : ISubject
    {
        private ArrayList observers; //observer객체를 저장하기위한 ArrayList

        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        //옵져버 등록
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        //옵져버 탈퇴
        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        //옵져버에게 상태변화를 알려주는 메서드.
        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }

        //기상 스테이션으로부터 갱신된 측정치를 받으면 옵저버들에게 알리는 메서드.
        public void measurementsChanged()
        {
            notifyObservers();
        }

        //기상스테이션으로 부터 기상정보를 받는 메서드.
        //기상스테이션에서 이메서드를 호출해서 기상정보를 알리면 옵져버까지 정보가 전해지게된다.
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }

    //기상 조건을 디스플레이하는 옵져버 클래스 (옵져버 인터페이스와 디스플레이 인터페이스를 구현하였다.)
    //WeatherData 객체로 부터 변화하는 기상 데이터를 갱신 받는 옵져버 객체들을 구현해보겠습니다.
    //옵져버 객체들은 옵져버 인터페이스(IObserver)와 디스플레이 인터페이스(IDisplayElement) 를 구현하면 얼마든지 추가가 가능합니다.
    //WeatherData객체도 주제 인터페이스(ISubject)를 구현한다면 얼마든지 추가가 가능합니다.
    //이러한 구조를 느슨한 결합(Loose Coupling)이라 하며, 주제와 옵저버가 바뀌거나 추가 되더라도 서로에게 전혀 영향이 없습니다.
    //기상 조건은 기온과 습도를 갱신받아 그대로 표시해줍니다.

    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData; //주제객체에 대한 레퍼런스



        //생성자에 weatherData라는 주제객체가 전달되며,

        // 그 객체를 써서 디스플레이를 옵저버로 등록한다.
        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        //update()메서드가 호출되면 기온과 습도를 저장하고 display()메서드를 호출한다.
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        //IDisplayElement 인터페이스를 구현한 메서드
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }

    //기상 통계 옵저버 클래스
    //기상 통계는 갱신된 온도의 총합, 갱신된 횟수를 저장해 평균을 계산하고 , 최고온도, 최저온도를 계산해서 표시합니다.
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float temperatureSum = 0.0f; //평균을 구하기위한 온도의 합
        private int numReadings = 0;  //데이터가 갱신된 횟수
        private ISubject weatherData;



        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            temperatureSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + RoundFloatToString(temperatureSum / numReadings) +
                "F/" + maxTemp + "F/" + minTemp + "F");

        }

        //평균온도의 출력형식을 지정
        public static string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }

        //기상 예보 옵져버 클래스
        //기상 예보는 이전기압과 최근기압을 저장, 비교해서 글로써 표시해줍니다.
        public class ForecastDisplay : IObserver, IDisplayElement
        {
            private float currentPressure = 29.92f;
            private float lastPressure;
            private ISubject weatherData;

            public ForecastDisplay(ISubject weatherData)
            {
                this.weatherData = weatherData;
                weatherData.RegisterObserver(this);
            }

            public void Update(float temperature, float humidity, float pressure)
            {
                lastPressure = currentPressure;
                currentPressure = pressure;
                Display();
            }

            public void Display()
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Forecast: ");

                if (currentPressure > lastPressure)
                {
                    sb.Append("Improving weather on the way!");
                }
                else if (currentPressure == lastPressure)
                {
                    sb.Append("More of the same");
                }
                else if (currentPressure < lastPressure)
                {
                    sb.Append("Watch out for cooler, rainy weather");
                }

                Console.WriteLine(sb.ToString());
            }

        }

        //테스트 클래스
        //WeatherData 객체 (주제객체)를 생성하고 이 객체를 매개변수로 디스플레이 객체 (옵저버객체)를 생성합니다.
        //디스플레이 객체들은 생성자에서 주제객체의 레퍼런스를 저장하고 주제객체의 옵져버 등록 메서드 (RegisterObserver)를 호출하여 자신을 주제객체에 등록시킵니다.
        //주제 객체는 옵져버 객체들을 ArrayList로 저장하고 있다가 setMeasurements메서드가 기상 스테이션으로부터 호출이된다면
        //넘겨받은 기상 데이터를 옵져버 객체로 자동으로 전달해 줍니다.

        class Program
        {
            static void Main(string[] args)
            {
                WeatherData weatherData = new WeatherData();

                CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
                StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
                ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);


                //기상 스테이션이 호출한다고 가정
                weatherData.setMeasurements(80, 65, 30.4f);
                weatherData.setMeasurements(82, 70, 29.2f);
                weatherData.setMeasurements(78, 90, 29.2f);
            }
        }
    }



}
