#include <iostream>
#include <string>
using namespace std;
int main() {
    setlocale(LC_ALL, "rus");
    struct student {
        string fio;
        int group;
        int scor[5];
    };
    cout << "������� ���������� ���������" << endl;
    int n;
    cin >> n;
    student* st = new student[n];
    for (int i = 0; i != n; i++) {
        cout << "������� ���" << endl;
        cin >> st[i].fio;
        cout << "������� ����� ������" << endl;
        cin >> st[i].group;
        cout << "������������" << endl;
        int j = 0;
        do {
            cout << "������" << endl;
            cin >> st[i].scor[j];
            j++;
        } while (j != 5);
        cout << endl;
    }
    cout << endl;
    // ��������� �� ����������� �����
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n - i; i++)
            if (st[j].group > st[j + 1].group)
                swap(st[j].group, st[j + 1].group);
    // ������� ��������� �� ����������� �����
    for (int i = 0; i != n; i++) {

        cout << st[i].fio << endl;
        cout << st[i].group << endl;
        for (int j = 0; j != 5; j++) {
            cout << st[i].scor[j] << " ";
        }
        cout << endl;

    }
    cout << endl;
    int sum = 0;
    int ind;
    int f = 0;
    cout << "�������� ������� ��� >4" << endl;
    for (int i = 0; i != n; i++) {
        if (((st[i].scor[0] + st[i].scor[1] + st[i].scor[2] + st[i].scor[3] + st[i].scor[4]) / 5) > 4) {
            f++;
            ind = i;
        }
        if (f > 0) {
            cout << st[ind].fio << endl;
            cout << st[ind].group << endl;
        }
        else cout << "����� ���" << endl;
    }
    delete[]st;
    system("pause");
    return 0;
}
