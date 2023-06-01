#pragma once
#include<string>
#include<iostream>
#include<iostream>
#include<Windows.h>
//#include "TMan.h"


using namespace std;

class TMan//��������� �����
{
public://��������� ��������(������������ � ����������)
	TMan()//����������� �� ���������
		:Firstname("����"), Surname("������"), Patronymic("��������"),//������ �������������
		Age(0), Address("��. ������ �.1")
	{}

	TMan(string firstname, string surname, string patronymic)//����������� � �����������
		:Firstname(firstname), Surname(surname), Patronymic(patronymic), Age(20)
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

protected://���������� ���� (�������� ��� �����������)
	string Firstname;//���
	string Surname;//�������
	string Patronymic;//��������
	unsigned int Age;//�������
	string Address;//�����

public://��������� ��������(������)
	void scan(istream& in);//����
	void print(ostream& out);//�����
	bool Voter();//����������
	bool Lastname(string surname);//������������� �������

	void SetAge(unsigned int age);//���������� �������
	void SetAddress(string address);//���������� �����
};





class Stud : public TMan//��������� ������������ (�� ������ �� ������������� �������)
{
public:
	Stud()//����������� �� ���������
		:UniverName("�����"), GroupNum("���20-01"), AverScore(4.5)
	{}

	Stud(string firstname, string surname, string patronymic,
		string UniverName, string GroupNum, double AverScore)//����������� � �����������
		:TMan(firstname, surname, patronymic),//����� ������������ ����
		UniverName(UniverName), GroupNum(GroupNum), AverScore(AverScore)
	{}

	Stud(const Stud& a)//����������� �����������
		:TMan(a),//����� ������������ ����������� ����
		UniverName(a.UniverName), GroupNum(a.GroupNum), AverScore(a.AverScore)
	{}

	~Stud()//����������
	{}

private:
	string UniverName;//�������� �������
	string GroupNum;//����� ������
	double AverScore;//������� ����


public:
	void SetUniver(string univerName);
	void SetGroupNum(string groupNum);
	void setAverScore(double averScore);


	static void searchExcellentStud(Stud* arr, int N, string GroupNum);//����������� ����� ��� ������ ���������� � ����������� ������


	void scan(istream& in);//����
	void print(ostream& out);//�����
};



//#include "TMan.h"

//����
void TMan::scan(istream& in)
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
	out << Surname << ' ' << Firstname << ' ' << Patronymic << endl;
	out << Age << " ���\n";
	out << "��������� �� ������: " << Address << endl;
}

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


void TMan::SetAge(unsigned int age)
{
	Age = age;
}

void TMan::SetAddress(string address)
{
	Address = address;
}







void Stud::SetUniver(string univerName)
{
	UniverName = univerName;
}

void Stud::SetGroupNum(string groupNum)
{
	GroupNum = groupNum;
}

void Stud::setAverScore(double averScore)
{
	AverScore = averScore;
}

void Stud::searchExcellentStud(Stud* arr, int N, std::string GroupNum)
{
	for (size_t i = 0; i < N; i++)
	{
		if (arr[i].GroupNum == GroupNum && arr[i].AverScore > 4.45)
		{
			arr[i].print(cout);
			cout << endl;
		}
	}
}




void Stud::scan(istream& in)
{
	TMan::scan(in);
	cout << "������� �����������: ";
	getline(in, UniverName);

    cout << "\n������� ����� ������: ";
	getline(in, GroupNum);

	cout << "\n������� ������� ����: ";
	in >> AverScore;
}

void Stud::print(ostream& out)
{
	TMan::print(out);
	out << "�����������: " << UniverName
		<< "\n����� ������: " << GroupNum
		<< "\n������� ����: " << AverScore << std::endl;
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





	Stud* StudArray;
	//cout << "������� ���-�� �����: ";
	cin >> N;
	StudArray = new Stud[N];//������ ������ ��������

	cout << "��������� ������:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "������� " << i + 1 << ')';
		StudArray[i].scan(cin);//�������� ��� ������� ������� ����� scan - ������� cin - ���� ������ �� �������
	}

	cout << "��� ������:\n";
	for (int i = 0; i < N; i++)//���������� ��� �������
	{
		cout << "������� " << i + 1 << ')';
		StudArray[i].print(cout);//�������� ��� ������� ������� ����� print - ������� cout - ����� ������ � �������
		cout << endl;
	}


	string GroupNum;
	cout << "������� ����� ������: ";
	cin.ignore();
	getline(cin, GroupNum);
	cout << "��������� � ������ ������\n\n";
	Stud::searchExcellentStud(StudArray, N, GroupNum);//����� ������������ ������
	delete[] ManArray;
	delete[] StudArray;
	system("pause");
	return 0;
}



