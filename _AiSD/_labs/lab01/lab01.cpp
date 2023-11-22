#include <iostream>

using namespace std;

void moveDisk(int disk, int source, int destination)
{
    cout << "Переместить диск " << disk << " с " << source << " на " << destination << " стержень" << endl;
}

void hanoiTower(int numDisks, int source, int destination, int auxiliary) 
{
    if (numDisks == 1) {
        moveDisk(numDisks, source, destination);
        return;
    }

    hanoiTower(numDisks - 1, source, auxiliary, destination);
    moveDisk(numDisks, source, destination);
    hanoiTower(numDisks - 1, auxiliary, destination, source);
}

int main() 
{
    setlocale(LC_CTYPE, "Russian");

    int numDisks, numPegs;
    cout << "Введите количество дисков: ";
    cin >> numDisks;
    cout << "Введите количество стержней: ";
    cin >> numPegs;

    if (numDisks < 1 || numPegs < 3) 
    {
        cout << "Ошибка: количество дисков должно быть больше 0, а количество стержней должно быть не менее 3." << endl;
        return 0;
    }

    cout << "Последовательность действий для перекладывания " << numDisks << " дисков с 1-го на " << numPegs << "-ый стержень:" << endl;
    hanoiTower(numDisks, 1, numPegs, 2);

    return 0;
}