using System;
using System.Collections;
using System.Text;

public class GenericClassExercise
{
	static void Main(string[] args)
	{
		Player<int> player01 = new Player<int>();
		player01.value = 10;
		Console.WriteLine(player01.value);

		Player<string> player02 = new Player<string>();
		player02.value = "안녕하세요. 고박사입니다.";
		Console.WriteLine(player02.value);
	}
}

public class Player<T>
{
	public T value;
}

