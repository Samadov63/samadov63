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
	printf_s("������� ������ ������� = ");
	scanf_s("%d", &n);

	printf_s("������� ������ :\n");
	for (i = 0; i < n; i++) {
		printf_s("a[%d] = ", i);
		scanf_s("%f", &a[i]);

	}
	printf_s("������: ");
	min = a[0];
	for (i = 0; i < n; i++) {
		cout << a[i] << ' ';
		if (a[i] < min) {
			min = a[i];
		}
	}
	printf_s("\n������� ���������� ���������:\t");
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
	printf_s("\n����� ���������� ��������� �� ������� %d \n", kol);

	system("pause");
	return 0;
}
