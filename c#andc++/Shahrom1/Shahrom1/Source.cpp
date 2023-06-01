#ifndef Header_h
#define Header_h
int max_l(int** A, int** B, int N, int M);
int min_l1(int** A, int** C, int N, int M);
int max_c2(int** A, int** B, int N, int M);
int min_c3(int** A, int** C, int N, int M);
#endif


//#include "stdafx.h"
#include <math.h>
#include <iostream>
//#include"Header.h"
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int N, M, i, j, min_l = 0, max_c = 0, min_c = 0, I = 0, J = 0;
	//создание и заполнение массива:
	cout << "Введите количество строк массива: ";
	cin >> N;
	cout << "Введите количество столбцов массива: ";
	cin >> M;
	int** A = new int* [N]; //N строк в массиве
	for (i = 0; i < N; i++)
	{
		A[i] = new int[M];
	}//M столбцов в массиве

	for (i = 0; i < N; i++)
	{
		for (j = 0; j < M; j++)
		{
			cout << "Введите значение элемента A[" << i << "][" << j << "]: ";
			cin >> A[i][j];
		}
	}
	//вывод массива:
	cout << "Массив А: " << endl;
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < M; j++)
		{
			cout << A[i][j] << "\t";
		}
		cout << endl;
	}


	//создание доп. массивов:
	int** B = new int* [N]; //N строк в массиве
	for (int i = 0; i < N; i++)
	{
		B[i] = new int[M];
	}//M столбцов в массиве

	int** C = new int* [N]; //N строк в массиве
	for (int i = 0; i < N; i++)
	{
		C[i] = new int[M];
	}//M столбцов в массиве


//вычисления:
//максимальный в строке 
	max_l(A, B, N, M);
	//минимальный в столбце
	min_c3(A, C, N, M);
	cout << "Седловые точки: " << endl;
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < M; j++)
		{
			if ((B[i][j] == 1) && (C[i][j] == 1))
				cout << "[" << i << "][" << j << "]" << endl;
		}
	}

	//минимальный в строке
	min_l1(A, C, N, M);
	//максимальный в столбце
	max_c2(A, B, N, M);
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < M; j++)
		{
			if ((B[i][j] == 1) && (C[i][j] == 1))
				cout << "[" << i << "][" << j << "]" << endl;
		}
	}
	delete[]A;
	delete[]B;
	delete[]C;
	system("pause");
	return 0;
}


//#include "stdafx.h"
#include <math.h>
#include <iostream>
using namespace std;
//максимальный в строке 
int max_l(int** A, int** B, int N, int M)
{
	for (int i = 0; i < N; i++)
	{
		int max_l = A[i][0];
		int I = 0, J = 0;
		for (int j = 0; j < M; j++)
		{
			B[i][j] = 0;
			if (A[i][j] >= max_l)
			{
				max_l = A[i][j];
				I = i;
				J = j;
			}
		}
		B[I][J] = 1;
	}
	return **B;
}
//Исходный файл (source2.cpp):
//#include "stdafx.h"
#include <math.h>
#include <iostream>
using namespace std;

//минимальный в строке
int min_l1(int** A, int** C, int N, int M)
{
	for (int i = 0; i < N; i++)
	{
		int min_l = A[i][0];
		int I = 0, J = 0;
		for (int j = 0; j < M; j++)
		{
			C[i][j] = 0;
			if (A[i][j] <= min_l)
			{
				min_l = A[i][j];
				I = i;
				J = j;
			}
		}
		C[I][J] = 1;
	}
	return **C;
}
//Исходный файл (source3.cpp):
//#include "stdafx.h"
#include <math.h>
#include <iostream>
using namespace std;

//максимальный в столбце
int max_c2(int** A, int** B, int N, int M)
{

	for (int j = 0; j < M; j++)
	{
		int max_c = A[0][j];
		int I = 0, J = 0;
		for (int i = 0; i < N; i++)
		{
			B[i][j] = 0;
			if (A[i][j] >= max_c)
			{
				max_c = A[i][j];
				I = i;
				J = j;
			}
		}
		B[I][J] = 1;
	}

	return **B;
}
//Исходный файл (source4.cpp):
//#include "stdafx.h"
#include <math.h>
#include <iostream>
using namespace std;

//минимальный в столбце
int min_c3(int** A, int** C, int N, int M)
{
	for (int j = 0; j < M; j++)
	{
		int min_c = A[0][j];
		int I = 0, J = 0;
		for (int i = 0; i < N; i++)
		{
			C[i][j] = 0;
			if (A[i][j] <= min_c)
			{
				min_c = A[i][j];
				I = i;
				J = j;
			}
		}
		C[I][J] = 1;
	}

	return **C;
}
