using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericMethodExercise : MonoBehaviour
{
	private void Awake()
	{
		// 매개변수의 데이터 타입으로 T에 어떤 데이터형식을 사용할 지 알고 있기 때문에
		// 메소드를 호출할 때 형식매개변수를 쓰지 않아도 된다.
		DataInformation<int>(36);
		DataInformation<float>(12.3f);
		DataInformation<string>("안녕하세요. 고박사입니다.");
	}

	public void DataInformation<T>(T value)
	{
		Debug.Log($"value의 값 : {value}");
		Debug.Log($"value의 형식 : {value.GetType()}");
	}
}

