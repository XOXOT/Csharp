using System;

namespace 제품
{
	public class Product
	{
		public int price;

		public Product()
		{
			
		}
	}

	class Tv : Product
	{
		public Tv()
		{
			price = 100;
		}
	}

	class Audio : Product
	{
		public Audio()
		{
			price = 50;
		}
	}

	class Computer : Product
	{
		public Computer()
		{
			price = 200;
		}
	}

	class Buyer
	{

		int money = 350;
		Product[] cart = new Product[3];
		int i = 0;

		public void buy(Product p)
		{

			if (money < p.price)
			{
				Console.WriteLine("잔액이 부족하여 " + p.GetType().Name + "를 살 수 없습니다.");
				return;

			}
			else
			{
				money -= p.price;
				add(p);
			}

		}

		public void add(Product p)
		{
			if (cart.Length == i)
			{
				Product[] temp = new Product[cart.Length * 2];

				for (int i = 0; i < cart.Length; i++)
				{
					temp[i] = cart[i];
				}
				cart = temp;
			}
			cart[i++] = p;
		}

		public void summary()
		{
			int temp = 0;
			for (int j = 0; j < i; j++)
			{
				temp += cart[j].price;
			}

			Console.WriteLine("  ");
			Console.WriteLine("  ");

			for (int j = 0; j < i; j++)
			{
				Console.WriteLine(cart[j].GetType().Name + "를 구입하셨습니다.");
			}

			Console.WriteLine("\n구입하신 물품의 총금액은 " + temp + "만원 입니다.");

			Console.Write("구입하신 제품은 ");
			for (int j = 0; j < i; j++)
			{

				Console.Write(cart[j].GetType().Name + ',');

			}
			Console.WriteLine("입니다.");

			Console.WriteLine("  ");

			Console.WriteLine("남은 돈은 " + money + "만원 입니다.");

		}
	}
	public class BasketTest
	{

		public static void Main(string[] args)
		{

			Buyer b = new Buyer();

			b.buy(new Tv());
			b.buy(new Computer());
			b.buy(new Audio());
			// 100+200+50 = 350

			b.buy(new Computer());
			b.buy(new Audio());
			b.buy(new Computer());
			b.buy(new Tv());
			// 200+50+200+100 = 550

			b.summary();

		}

	}
}

