// ConsoleApplication1.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"


int main()
{
	int i = 10;
	int& ref = i;
	ref = 12;
	printf("%d %d", ref, i);
    return 0;
}

