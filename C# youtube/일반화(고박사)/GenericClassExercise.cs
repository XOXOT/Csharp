using 일반화;

public class GenericClassExercise : MonoBehaviour
{
	private void Awake()
	{
		Player<int> player01 = new Player<int>();
		player01.value = 10;
		Debug.Log(player01.value);

		Player<string> player02 = new Player<string>();
		player02.value = "안녕하세요. 고박사입니다.";
		Debug.Log(player02.value);
	}
}

public class Player<T>
{
	public T value;
}

