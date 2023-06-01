#include<string>
#include<iostream>
using namespace std;
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
	void scan(std::istream& in);//ввод
	void print(std::ostream& out);//вывод
	bool Voter();//избиратель
	bool Lastname(std::string surname);//сопостовление фамилии

	void SetAge(unsigned int age);//установить возраст
	void SetAddress(string address);//установить адрес
};

//#include "TMan.h"

//ввод
void TMan::scan(std::istream& in)
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
bool TMan::Lastname(std::string surname)
{
	return Surname == surname;//сравниваем поле фамилия у объекта  с переданым значением surname
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
	cout << "Укажите кол-во людей: ";
	cin >> N;
	ManArray = new TMan[N];//создаём массив объектов

	cout << "Заполните данные:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "Человек " << i + 1 << ')';
		ManArray[i].scan(cin);//вызываем для каждого оюъекта метод scan - передаём cin - ввод данных из консоли
	}

	cout << "Ваш массив:\n";
	for (int i = 0; i < N; i++)//выписываем все объекты
	{
		cout << "Человек " << i + 1 << ')';
		ManArray[i].print(cout);//вызываем для каждого оюъекта метод print - передаём cout - вывод данных в консоль
		cout << endl;
	}

	string sur;//переменная для фамилии
	int kol = 0;//счётчик подходящих избирателей
	cout << "Введите Фамилию по которой будет искаться избиратель: ";
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

	if (kol == 0)//если избиратели не найдены
		cout << "Избиратели с данной фамилией не найдены\n";

	delete[] ManArray;
	system("pause");
	return 0;
} 










































