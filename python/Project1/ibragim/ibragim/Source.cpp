#include <iostream>
using namespace std;

void main()
{
	setlocale(0, "");
	int s, a, b, h;

	cout << "������: ";
	cin >> h;
	cout << "������ �������: ";
	cin >> a;
	cout << "������ �������: ";
	cin >> b;
	s = h * ((a + b) / 2);
	cout << "�������: " << s << endl;
	system("pause");

}


