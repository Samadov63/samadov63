#include <iostream>
using namespace std;

void main()
{
	setlocale(0, "");
	int s, a, b, h;

	cout << "Высота: ";
	cin >> h;
	cout << "Первая сторона: ";
	cin >> a;
	cout << "Вторая сторона: ";
	cin >> b;
	s = h * ((a + b) / 2);
	cout << "Площадь: " << s << endl;
	system("pause");

}


