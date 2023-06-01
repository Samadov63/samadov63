#include<string>
#include<iostream>
using namespace std;
class TMan//��������� �����
{
public://��������� ��������(������������ � ����������)
	TMan()//����������� �� ���������
		:Firstname("����"), Surname("������"), Patronymic("��������"),//������ �������������
		Age(0), Address("��. ������ �.1")
	{}

	TMan(std::string firstname, std::string surname, std::string patronymic)//����������� � �����������
		:Firstname(firstname), Surname(surname), Patronymic(patronymic), Age(10)
	{}

	TMan(const TMan& a)//����������� �����������
	{
		Firstname = a.Firstname;//Firstname ������������ ������� ����������� ��� Firstname ������� ���������� � ���������� ������������
		Surname = a.Surname;
		Patronymic = a.Patronymic;
		Age = a.Age;
		Address = a.Address;
	}

	~TMan()//����������
	{}

private://��������� ��������(���� ������)
	string Firstname;//���
	string Surname;//�������
	string Patronymic;//��������
	unsigned int Age;//�������
	string Address;//�����

public://��������� ��������(������)
	void scan(std::istream& in);//����
	void print(std::ostream& out);//�����
	bool Voter();//����������
	bool Lastname(std::string surname);//������������� �������

	void SetAge(unsigned int age);//���������� �������
	void SetAddress(string address);//���������� �����
};

//#include "TMan.h"

//����
void TMan::scan(std::istream& in)
{
	cout << "������� �������: ";
	in >> Surname;
	cout << "������� ���: ";
	in >> Firstname;
	cout << "������� ��������: ";
	in >> Patronymic;

	cout << "\n������� �������\n";
	in >> Age;

	cout << "\n������� �����\n";
	in.ignore();
	getline(in, Address);
}

//�����
void TMan::print(ostream& out)
{
	out << Surname << ' ' << Firstname << ' ' << Patronymic << std::endl;
	out << Age << " ���\n";
	out << "��������� �� ������: " << Address << std::endl;
}

//����������� ��������� ������� �� 30 ���
bool TMan::Voter()
{
	return Age >= 18;
}

//������������� �������
bool TMan::Lastname(std::string surname)
{
	return Surname == surname;//���������� ���� ������� � �������  � ��������� ��������� surname
}


void TMan::SetAge(unsigned int age)
{
	Age = age;
}

void TMan::SetAddress(std::string address)
{
	Address = address;
}

//#include<iostream>
#include<Windows.h>
//#include "TMan.h"



int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	unsigned int N;
	TMan* ManArray;
	cout << "������� ���-�� �����: ";
	cin >> N;
	ManArray = new TMan[N];//������ ������ ��������

	cout << "��������� ������:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "������� " << i + 1 << ')';
		ManArray[i].scan(cin);//�������� ��� ������� ������� ����� scan - ������� cin - ���� ������ �� �������
	}

	cout << "��� ������:\n";
	for (int i = 0; i < N; i++)//���������� ��� �������
	{
		cout << "������� " << i + 1 << ')';
		ManArray[i].print(cout);//�������� ��� ������� ������� ����� print - ������� cout - ����� ������ � �������
		cout << endl;
	}

	string sur;//���������� ��� �������
	int kol = 0;//������� ���������� �����������
	cout << "������� ������� �� ������� ����� �������� ����������: ";
	cin >> sur;
	for (int i = 0; i < N; i++)
	{
		if (ManArray[i].Voter() && ManArray[i].Lastname(sur))
		{
			ManArray[i].print(cout);
			cout << endl;
			kol++;
		}
	}

	if (kol == 0)//���� ���������� �� �������
		cout << "���������� � ������ �������� �� �������\n";

	delete[] ManArray;
	system("pause");
	return 0;
} 










































