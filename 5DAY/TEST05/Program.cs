using System;

namespace TEST05
{
    abstract class Pizza
    {
        protected int price;

        public Pizza() { }
        public Pizza(int price)
        {
            this.price = price;
        }

        public void makePizza()
        {
            Console.WriteLine("피자 반죽과 함께 도우를 빚습니다.");
            Console.WriteLine("피자 boxing...");
            Console.WriteLine("피자를 180도에서 10분간 구워냅니다..");
            Console.WriteLine("피자를 8등분으로 자릅니다.");
        }
        public int getPrice()
        {
            return this.price;
        }

        public abstract void topping();

    }
    class ChesseCrustPizza : Pizza
    {
        public ChesseCrustPizza(int price)
        {
            //부모의 필드가 protected로 지정되어서 super 안사용해도 된다.
            this.price = price;
        }
        public override void topping()
        {
            Console.Write("얇은 치즈크러스터 Pizza");
        }
    }
    class ChesseTopping : Pizza
    {
        public ChesseTopping(int price)
        {
            //부모의 필드가 protected로 지정되어서 super 안사용해도 된다.
            this.price = price;
        }
        public override void topping()
        {
            Console.Write(", 치즈");
        }
    }
    class OliveTopping : Pizza
    {
        public OliveTopping(int price)
        {
            //부모의 필드가 protected로 지정되어서 super 안사용해도 된다.
            this.price = price;
        }
        public override void topping()
        {
            Console.Write(", 올리버");
        }
    }



    class PizzaServiceTest
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("=======주문내역=========\n");

            Console.Write("내역:");
            Pizza service = new ChesseCrustPizza(25000);
            service.topping();
            Pizza service1 = new ChesseTopping(2000);
            service1.topping();
            Pizza service2 = new ChesseTopping(2000);
            service2.topping();
            Pizza service3 = new OliveTopping(1500);
            service3.topping();
            Pizza service4 = new OliveTopping(1500);
            service4.topping();

            Console.WriteLine("\n\n피자를 만드는 중...\n");
            service.makePizza();

            int sum = service.getPrice() + service1.getPrice() + service2.getPrice() + service3.getPrice() + service4.getPrice();
            Console.WriteLine("\n총액:"+ sum + "원");

        }

    }
}
