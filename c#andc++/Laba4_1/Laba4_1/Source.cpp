//#pragma once
#include<string>
#include<iostream>
#include<iostream>
#include<Windows.h>
using namespace std;
//#include "TMan.h"

class TMan//Объявляем класс
{
public://Публичные свойства(конструкторы и деструктор)
	TMan()//Конструктор по умолчанию
		:Firstname("Иван"), Surname("Иванов"), Patronymic("Иванович"),//список инициализации
		Age(0), Address("ул. Маркса д.1")
	{}

	TMan(std::string firstname, std::string surname, std::string patronymic)//Констурктор с параметрами
		:Firstname(firstname), Surname(surname), Patronymic(patronymic), Age(10)
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

private://Приватные свойства(Поля класса)
	string Firstname;//имя
	string Surname;//фамилия
    string Patronymic;//отчество
	unsigned int Age;//возраст
	string Address;//адрес

public://Публичные свойства(методы)
	friend istream& operator >>(istream& in, TMan& man);
	friend ostream& operator <<(ostream& out, TMan const& man);
	bool Voter();//избиратель
	bool Lastname(string surname);//сопостовление фамилии
	bool operator ==(string surname);

	void SetAge(unsigned int age);//установить возраст
	void SetAddress(string address);//установить адрес
};

//#include "TMan.h"




//избирателем считается человек от 18 лет
bool TMan::Voter()
{
	return Age >= 18;
}

//Сопоставление фамилии
bool TMan::Lastname(string surname)
{
	return Surname == surname;//сравниваем поле фамилия у объекта  с переданым значением surname
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
	cout << "Введите Фамилию: ";
	in >> man.Surname;
	cout << "Введите Имя: ";
	in >> man.Firstname;
	cout << "Введите Отчество: ";
	in >> man.Patronymic;

	cout << "\nВведите возраст\n";
	in >> man.Age;

	cout << "\nВведите адрес\n";
	in.ignore();
	getline(in, man.Address);
	return in;
}

ostream& operator<<(ostream& out, TMan const& man)
{
	out << man.Surname << ' ' << man.Firstname << ' ' << man.Patronymic << std::endl;
	out << man.Age << " лет\n";
	out << "Проживает по адресу: " << man.Address << std::endl;
	return out;
}






int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	unsigned int N;
	TMan* ManArray;
	cout << "Укажите кол-во людей: ";
	cin >> N;
	ManArray = new TMan[N];//создаём массив объектов

	cout << "Заполните данные:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "Человек " << i + 1 << ')';
		cin >> ManArray[i];//вызываем для каждого оюъекта метод scan - передаём cin - ввод данных из консоли
	}

	cout << "Ваш массив:\n";
	for (int i = 0; i < N; i++)//выписываем все объекты
	{
		cout << "Человек " << i + 1 << ')';
		cout << ManArray[i];//вызываем для каждого оюъекта метод print - передаём cout - вывод данных в консоль
		cout << endl;
	}

	string sur;//переменная для фамилии
	int kol = 0;//счётчик подходящих избирателей
	cout << "Введите Фамилию по которой будет искаться избиратель: ";
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

	if (kol == 0)//если избиратели не найдены
		cout << "Избиратели с данной фамилией не найдены\n";

	delete[] ManArray;
	system("pause");
	return 0;
}