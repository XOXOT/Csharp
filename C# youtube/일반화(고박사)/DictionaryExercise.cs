using System.Collections.Generic;
using UnityEngine;

public class DictionaryExercise : MonoBehaviour
{
	private void Awake()
	{
		// 일반화 컬렉션 자료구조는 변수 선언/메모리 할당 시
		// 형식매개변수 <T>에 사용되는 데이터 형식을 지정한다.
		Dictionary<string, string> dictionary = new Dictionary<string, string>();

		// 요소 추가 ( [] 연산자 )
		dictionary["1"] = "First";
		dictionary["2"] = "Second";
		dictionary["3"] = "Third";

		// 딕셔너리의 모든 요소 출력
		PrintDictionary(dictionary);

		// 요소 추가 ( Add 메소드 )
		dictionary.Add("사과", "Apple");

		// 딕셔너리의 모든 요소 출력
		PrintDictionary(dictionary);

		// Dictionary에서 매개변수에 입력된 "1"을 키로 가지는 요소 삭제
		dictionary.Remove("1");

		// 딕셔너리의 모든 요소 출력
		PrintDictionary(dictionary);
	}

	public void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dic)
	{
		Debug.Log("===============================");

		// 현재 딕셔너리에 저장된 요소의 개수
		Debug.Log($"Dictionary Count : {dic.Count}");

		// 현재 Dictionary에 저장된 모든 요소 출력
		foreach ( var d in dic.Keys )
		{
			Debug.Log($"dictionary[{d}] = {dic[d]}");
		}
	}
}

