using System;
using System.Collections;

namespace TEST06
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        protected abstract Pizza CreatePizza(string type);
    }

    public class DOMINOPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese")) return new CheesePizza();
            // 피자 종류를 추가         
            else if (type.Equals("pepperoni")) return new PepperoniPizza();
            else if (type.Equals("veggie")) return new VeggiePizza();
            else return null;
        }
    }

    //만약 스토어를 추가한다면 아래 주석 해제 
    //public class ChicagoPizzaStore : PizzaStore
    //{
    //    protected override Pizza CreatePizza(string type)
    //    {
    //        if (type.Equals("cheese")) return new ChicagoStyleCheesePizza();
    //        else return null;
    //    }

    //}

    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected ArrayList toppings = new ArrayList();

        public virtual void Prepare()
        {
            string orderToppings = null;

            Console.WriteLine( name + " 준비 중");
            Console.WriteLine( dough+ " 도우를 굽는 중 입니다.");
            Console.WriteLine( sauce + " 소스를 추가 중 입니다.");
            //Console.Write("토핑:");
            //for (int i = 0; i < toppings.Count; i++)
            //    Console.WriteLine(toppings[i]);
            foreach (string topping in this.toppings)
                orderToppings = orderToppings + topping;

            Console.WriteLine($"토핑 : {orderToppings}");
        }

        public virtual void Bake()
        {
            Console.WriteLine("350도에서 25분 굽습니다.");

        }

        public virtual void Cut()
        {
            Console.WriteLine("피자를 컷팅 합니다.");
        }

        public virtual void Box()
        {
            Console.WriteLine("피자 박스에 포장 합니다.");
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "치즈 피자";
            dough = "얇은 크러스트";
            sauce = "토마토";

            toppings.Add("치즈 듬뿍");
            toppings.Add(", 모짜렐라");
            toppings.Add(", 파마산");
        }
    }

    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "페퍼로니 피자";
            dough = "얇은 크러스트";
            sauce = "토마토";

            toppings.Add("치즈와 페퍼로니");
        }
    }
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            name = "야채 피자";
            dough = "얇은 크러스트";
            sauce = "토마토";

            toppings.Add("치즈와 신선한 야채");
        }
    }

    //public class ChicagoStyleCheesePizza : Pizza
    //{
    //    public ChicagoStyleCheesePizza()
    //    {
    //        name = "Chicago  Style Deep Dish Cheese Pizza";
    //        dough = "Extra Thick Crust Dough";
    //        sauce = "Plum Tomato Sauce";

    //        toppings.Add("Shredded Mozzarella Cheese");
    //    }

    //    public override void Cut()
    //    {
    //        Console.WriteLine("Cutting the pizza into square slice");
    //    }

    //}

    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore DOMINOStore = new DOMINOPizzaStore();
           

            Pizza pizza1 = DOMINOStore.OrderPizza("cheese");
            Console.WriteLine("주문하신 " + pizza1.Name + "나왔습니다.\n");

            Pizza pizza2 = DOMINOStore.OrderPizza("pepperoni");
            Console.WriteLine("주문하신 " + pizza2.Name + "나왔습니다.\n");

            Pizza pizza3 = DOMINOStore.OrderPizza("veggie");
            Console.WriteLine("주문하신 " + pizza3.Name + "나왔습니다.\n");


            //PizzaStore chicagoStore = new ChicagoPizzaStore();
            //pizza = chicagoStore.OrderPizza("cheese");
            //Console.WriteLine("ordered a " + pizza.Name + "\n");
        }
    }


}
