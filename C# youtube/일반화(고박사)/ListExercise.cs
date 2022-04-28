using System.Collections.Generic;
using UnityEngine;

public class ListExercise : MonoBehaviour
{
	private void Awake()
	{
		// 일반화 컬렉션 자료구조는 변수 선언/메모리 할당 시
		// 형식매개변수 <T>에 사용되는 데이터 형식을 지정한다.
		List<int> list = new List<int>();

		// 요소 추가 (순차)
		for ( int i = 0; i < 5; ++ i )
		{
			list.Add(i);
		}

		// 리스트의 모든 요소 출력
		// 변수를 선언할 때 list의 형식매개변수가 <int>로 정의되었기 때문에
		// PrintList() 메소드를 호출할 때 T를 다시 정의하지 않아도 된다.
		PrintList<int>(list);

		// 요소 추가 (원하는 위치)
		list.Insert(0, 10000);

		// 리스트의 모든 요소 출력
		PrintList(list);

		// 요소 삭제 (매개변수에 입력된 위치의 요소)
		list.RemoveAt(1);

		// 리스트의 모든 요소 출력
		PrintList(list);

		// 현재 리스트에 저장된 요소의 개수
		Debug.Log($"List Count : {list.Count}");

		// 모든 요소 삭제
		list.Clear();

		// 현재 리스트에 저장된 요소의 개수
		Debug.Log($"List Count : {list.Count}");
	}

	public void PrintList<T>(List<T> list)
	{
		Debug.Log("======================================");

		for ( int i = 0; i < list.Count; ++ i )
		{
			Debug.Log($"list[{i}] = {list[i]}");
		}
	}
}

