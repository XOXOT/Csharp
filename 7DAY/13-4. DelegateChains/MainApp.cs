using System;

namespace DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //대리자 객체 초기화 (출력용 개체)
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            //대리자 체인(출력 3번)
            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail."); //콜백 1

            Console.WriteLine();

            //대리자2 제거
            notifier.EventOccured -= listener2.SomethingHappend; //대리자 체인에서 하나 제거
            notifier.EventOccured("Download complete."); //콜백 2

            Console.WriteLine(); 

            notifier.EventOccured = new Notify(listener2.SomethingHappend) 
                                  + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected."); //콜백 3

            Console.WriteLine();

            //대리자 체인
            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured =
                (Notify)Delegate.Combine( notify1, notify2);
            notifier.EventOccured("Fire!!"); //콜백 4

            Console.WriteLine();

            notifier.EventOccured = 
                (Notify)Delegate.Remove( notifier.EventOccured, notify2); //가비지 컬렉터 대상            
            notifier.EventOccured("RPG!"); //콜백 5
        }
    }
}
