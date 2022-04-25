using System;

namespace TEST03
{
    interface Liftable
    {
        void move(int x, int y);
        void stop();
    }

    class Building
    {

    }

    class LiftableImpl : Liftable
    {
        public void move(int x, int y)
        {

        }
        public void stop()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}