//#pragma once
#include<string>
#include<iostream>
#include<iostream>
#include<Windows.h>
//#include "TMan.h"


using namespace std;

class TMan//Объявляем класс
{
public://Публичные свойства(конструкторы и деструктор)
	TMan()//Конструктор по умолчанию
		:Firstname("Иван"), Surname("Иванов"), Patronymic("Иванович"),//список инициализации
		Age(0), Address("ул. Маркса д.1")
	{}

	TMan(string firstname, string surname, string patronymic)//Констурктор с параметрами
		:Firstname(firstname), Surname(surname), Patronymic(patronymic), Age(20)
	{}

	TMan(const TMan& a)//Конструктор копирования
	{
		Firstname = a.Firstname;//Firstname создаваемого объекта присваиваем ему Firstname объекта полученого в аргументах конструктора
		Surname = a.Surname;
		Patronymic = a.Patronymic;
		Age = a.Age;
		Address = a.Address;
	}

	~TMan()//Деструктор
	{}

protected://Защищённые поля (Доступны для наследников)
	string Firstname;//имя
	string Surname;//фамилия
	string Patronymic;//отчество
	unsigned int Age;//возраст
	string Address;//адрес

public://Публичные свойства(методы)
	void scan(std::istream& in);//ввод
	void print(std::ostream& out);//вывод
	bool Voter();//избиратель
	bool Lastname(std::string surname);//сопостовление фамилии

	void SetAge(unsigned int age);//установить возраст
	void SetAddress(std::string address);//установить адрес
};






class Stud : public TMan//Публичное наследование (не влияет на спецификаторы доступа)
{
public:
	Stud()//Конструктор по умолчанию
		:UniverName("СибГУ"), GroupNum("БПЭ20-01"), AverScore(4.5)
	{}

	Stud(string firstname, string surname, string patronymic,
		string UniverName, string GroupNum, double AverScore)//Констурктор с параметрами
		:TMan(firstname, surname, patronymic),//Вызов конструктора базы
		UniverName(UniverName), GroupNum(GroupNum), AverScore(AverScore)
	{}

	Stud(const Stud& a)//Конструктор копирования
		:TMan(a),//Вызов конструктора копирования базы
		UniverName(a.UniverName), GroupNum(a.GroupNum), AverScore(a.AverScore)
	{}

	~Stud()//Деструктор
	{}

private:
	string UniverName;//Название универа
	string GroupNum;//Номер группы
	double AverScore;//Средний балл


public:
	void SetUniver(string univerName);
	void SetGroupNum(string groupNum);
	void setAverScore(double averScore);


	static void searchExcellentStud(Stud* arr, int N, std::string GroupNum);//статический метод для поиска отличников в определённой группе


	void scan(istream& in);//ввод
	void print(ostream& out);//вывод
};

//#include "TMan.h"

//ввод
void TMan::scan(istream& in)
{
	cout << "Введите Фамилию: ";
	in >> Surname;
	cout << "Введите Имя: ";
	in >> Firstname;
	cout << "Введите Отчество: ";
	in >> Patronymic;

	cout << "\nВведите возраст\n";
	in >> Age;

	cout << "\nВведите адрес\n";
	in.ignore();
	getline(in, Address);
}

//вывод
void TMan::print(ostream& out)
{
	out << Surname << ' ' << Firstname << ' ' << Patronymic << std::endl;
	out << Age << " лет\n";
	out << "Проживает по адресу: " << Address << std::endl;
}

//избирателем считается человек от 30 лет
bool TMan::Voter()
{
	return Age >= 18;
}

//Сопоставление фамилии
bool TMan::Lastname(string surname)
{
	return Surname == surname;//сравниваем поле фамилия у объекта  с переданым значением surname
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
		if (arr[i].GroupNum == GroupNum && arr[i].AverScore >= 4.45 && arr[i].Voter())
		{
			arr[i].print(std::cout);
			cout <<endl;
		}
	}
}




void Stud::scan(istream& in)
{
	TMan::scan(in);
	cout << "Введите Университет: ";
	getline(in, UniverName);

	cout << "\nВведите Номер группы: ";
	getline(in, GroupNum);

	cout << "\nВведите Средний балл: ";
	in >> AverScore;
}

void Stud::print(ostream& out)
{
	TMan::print(out);
	out << "Университет: " << UniverName
		<< "\nНомер группы: " << GroupNum
		<< "\nСредний балл: " << AverScore << std::endl;
}




int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	unsigned int N;
	Stud* SArray;
	cout << "Укажите кол-во людей: ";
	cin >> N;
	SArray = new Stud[N];//создаём массив объектов

	cout << "Заполните данные:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "Студент " << i + 1 << ')';
		SArray[i].scan(cin);//вызываем для каждого оюъекта метод scan - передаём cin - ввод данных из консоли
	}

	cout << "Ваш массив:\n";
	for (int i = 0; i < N; i++)//выписываем все объекты
	{
		cout << "Человек " << i + 1 << ')';
		SArray[i].print(cout);//вызываем для каждого оюъекта метод print - передаём cout - вывод данных в консоль
		cout << endl;
	}

	string sur;//переменная для фамилии
	int kol = 0;//счётчик подходящих избирателей
	cout << "Введите Фамилию по которой будет искаться избиратель: ";
	cin >> sur;
	for (int i = 0; i < N; i++)
	{
		if (SArray[i].Voter() && SArray[i].Lastname(sur))
		{
			SArray[i].print(cout);
			cout << endl;
			kol++;
		}
	}

	if (kol == 0)//если избиратели не найдены
		cout << "Избиратели с данной фамилией не найдены\n";






	string GroupNum;
	cout << "Введите номер группы: ";
	cin.ignore();
	getline(cin, GroupNum);
	cout << "Отличники в данной группе являющихся избирателями\n\n";
	Stud::searchExcellentStud(SArray, N, GroupNum);//вызов статического метода





	delete[] SArray;
	system("pause");
	return 0;
}



