// ConsoleApplication1.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
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

