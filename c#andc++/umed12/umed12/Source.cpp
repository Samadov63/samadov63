#include <iostream>
//#include "stdafx.h"
#include <clocale>
#include <iostream>
using namespace std;

int main() {
	int n, kol = 0;
	int i;
	float a[50], min;
	setlocale(0, "");
	printf_s("Введите размер массива = ");
	scanf_s("%d", &n);

	printf_s("Введите массив :\n");
	for (i = 0; i < n; i++) {
		printf_s("a[%d] = ", i);
		scanf_s("%f", &a[i]);

	}
	printf_s("Массив: ");
	min = a[0];
	for (i = 0; i < n; i++) {
		cout << a[i] << ' ';
		if (a[i] < min) {
			min = a[i];
		}
	}
	printf_s("\nИндексы подходящих элементов:\t");
	for (i = 0; i < n; i++) {

		if (i == 0) {
			if (a[i]<a[i + 1] && a[i]>min) {
				kol++;
				cout << i << "\t";
			}
		}
		else if (i == n - 1)
		{
			if (a[i]<a[i - 1] && a[i]>min) {
				kol++;
				cout << i << "\t";
			}
		}
		else
		{
			if (a[i] < a[i + 1] && a[i]<a[i - 1] && a[i]>min) {
				kol++;
				cout << i << "\t";
			}
		}
	}
	printf_s("\nОбщее количество элементов по условию %d \n", kol);

	system("pause");
	return 0;
}
