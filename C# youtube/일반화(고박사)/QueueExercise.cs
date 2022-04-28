using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
	private void Awake()
	{
		// 일반화 컬렉션 자료구조는 변수 선언/메모리 할당 시
		// 형식매개변수 <T>에 사용되는 데이터 형식을 지정한다.
		Queue<int> queue = new Queue<int>();

		// 후단에 새로운 요소 추가
		for ( int i = 0; i < 5; ++ i )
		{
			queue.Enqueue(i);
		}

		// 현재 큐에 저장된 요소의 개수
		Debug.Log($"Queue Count : {queue.Count}");

		// queue.Count가 0이 될 때까지 반복
		while ( queue.Count > 0 )
		{
			// 전단에 있는 요소를 삭제하고, Debug.Log()로 데이터 출력
			Debug.Log($"Queue Data : {queue.Dequeue()}");
		}

		// 현재 큐에 저장된 요소의 개수
		Debug.Log($"Queue Count : {queue.Count}");
	}
}

