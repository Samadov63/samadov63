
class ReadStream {
private:
    //��������� ���� - ����
    ifstream f;
public:
    //�����������, ����������� ����
    ReadStream(const char* FileName) {
        f.open(FileName);
        if (!f.is_open()) cout << "���� �� ������";
    }
    //����� ������ ������� ��������-���� � ��������� �������
    //������� ���������� ���� ������
    char* read(int position, int count) {
        if (!f.is_open()) return 0;
        f.seekg(position);
        if (f.eof()) return 0;
        char* buffer = new char[count];
        f.read(buffer, count);
        return buffer;
    }
    //����������, ����������� ����
    ~ReadStream() {
        f.close();
    }
};