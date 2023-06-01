//#pragma once
#include<string>
#include<iostream>
#include<iostream>
#include<Windows.h>
using namespace std;
//#include "TMan.h"

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
	friend istream& operator >>(istream& in, TMan& man);
	friend ostream& operator <<(ostream& out, TMan const& man);
	bool Voter();//����������
	bool Lastname(string surname);//������������� �������
	bool operator ==(string surname);

	void SetAge(unsigned int age);//���������� �������
	void SetAddress(string address);//���������� �����
};

//#include "TMan.h"




//����������� ��������� ������� �� 18 ���
bool TMan::Voter()
{
	return Age >= 18;
}

//������������� �������
bool TMan::Lastname(string surname)
{
	return Surname == surname;//���������� ���� ������� � �������  � ��������� ��������� surname
}

bool TMan::operator==(std::string surname)
{
	return Lastname(surname);
}


void TMan::SetAge(unsigned int age)
{
	Age = age;
}

void TMan::SetAddress(string address)
{
	Address = address;
}

istream& operator>>(istream& in, TMan& man)
{
	cout << "������� �������: ";
	in >> man.Surname;
	cout << "������� ���: ";
	in >> man.Firstname;
	cout << "������� ��������: ";
	in >> man.Patronymic;

	cout << "\n������� �������\n";
	in >> man.Age;

	cout << "\n������� �����\n";
	in.ignore();
	getline(in, man.Address);
	return in;
}

ostream& operator<<(ostream& out, TMan const& man)
{
	out << man.Surname << ' ' << man.Firstname << ' ' << man.Patronymic << std::endl;
	out << man.Age << " ���\n";
	out << "��������� �� ������: " << man.Address << std::endl;
	return out;
}






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
		cin >> ManArray[i];//�������� ��� ������� ������� ����� scan - ������� cin - ���� ������ �� �������
	}

	cout << "��� ������:\n";
	for (int i = 0; i < N; i++)//���������� ��� �������
	{
		cout << "������� " << i + 1 << ')';
		cout << ManArray[i];//�������� ��� ������� ������� ����� print - ������� cout - ����� ������ � �������
		cout << endl;
	}

	string sur;//���������� ��� �������
	int kol = 0;//������� ���������� �����������
	cout << "������� ������� �� ������� ����� �������� ����������: ";
	cin >> sur;
	for (int i = 0; i < N; i++)
	{
		if (ManArray[i].Voter() && ManArray[i] == sur)
		{
			cout << ManArray[i];
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