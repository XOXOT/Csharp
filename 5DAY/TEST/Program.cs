using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TEST
{

    public interface ISubject
    {
        void AddObserver(IObserver observer);  // 구독자 추가
        void RemoveObserver(IObserver observer); // 구독자 삭제
        void NotifyObserver(); // 구독자들에게 알림
    }
    public interface IObserver
    {
        void Update(Object obj); // Subject가 갱신된 내용을 전달하는 메소드
    }

    public class WebParser : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public string WebContents { get; set; }

        // 생성자에서 시뮬레이터를 동작시킴
        public WebParser()
        {
            Task.Run(() => SimulateWebParser());
        }

        // 웹 파싱 시뮬레이터 메소드
        private void SimulateWebParser()
        {
            while (true)
            {
                Thread.Sleep(3000);
                WebContents = RandomStringGenerator();
                NotifyObserver();
            }
        }

        // 랜덤으로 String을 생성해주는 메소드
        private string RandomStringGenerator()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Observer가 구독을 신청하는 메소드
        public void AddObserver(IObserver subscriber)
        {
            _observers.Add(subscriber);
        }

        // Observer가 구독을 해지하는 메소드
        public void RemoveObserver(IObserver subscriber)
        {
            if (_observers.Contains(subscriber))
                _observers.Remove(subscriber);
        }

        // 구독중인 Observer들에게 변경을 알려주는 메소드
        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                // Observer의 Update 메소드이용해 갱신해줌.
                observer.Update(this);
            }
        }
    }

    public class DisplayWebContents : IObserver
    {
        public DisplayWebContents(WebParser webParser)
        {
            webParser.AddObserver(this);
        }
        public void Update(object obj)
        {
            if (obj is WebParser)
            {
                var webParser = obj as WebParser;
                Console.WriteLine($"Display {webParser.WebContents}");
            }
        }
    }

    public class EmailWebContents : IObserver
    {
        public EmailWebContents(WebParser webParser)
        {
            webParser.AddObserver(this);
        }
        public void Update(object obj)
        {
            if (obj is WebParser)
            {
                var webParser = obj as WebParser;
                Console.WriteLine($"Email {webParser.WebContents}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebParser wp = new WebParser();

            DisplayWebContents display = new DisplayWebContents(wp);
            EmailWebContents email = new EmailWebContents(wp);

            Thread.Sleep(100000);
        }
    }

}
