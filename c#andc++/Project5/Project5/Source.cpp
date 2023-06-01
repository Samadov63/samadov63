
class ReadStream {
private:
    //Приватное поле - файл
    ifstream f;
public:
    //Конструктор, открывающий файл
    ReadStream(const char* FileName) {
        f.open(FileName);
        if (!f.is_open()) cout << "Файл не открыт";
    }
    //Метод чтения массива символов-байт с указанной позиции
    //который возвращает этот массив
    char* read(int position, int count) {
        if (!f.is_open()) return 0;
        f.seekg(position);
        if (f.eof()) return 0;
        char* buffer = new char[count];
        f.read(buffer, count);
        return buffer;
    }
    //Деструктор, закрывающий файл
    ~ReadStream() {
        f.close();
    }
};