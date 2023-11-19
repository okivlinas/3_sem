#include <iostream>
#include <cstring>

using namespace std;

const int VERT = 8;

void algPrim(int graph[VERT][VERT])
{
    int min = 1e9;
    int kolEdge = 0;
    int row = 0;
    int col = 0;

    int selected[VERT];

    for (int i = 0; i < VERT; i++) {
        selected[i] = false;
    }
    for (int i = 0; i < VERT; i++) {
        for (int j = 0; j < VERT; j++) {
            if (graph[i][j] < min)
                min = graph[i][j];
        }
    }

    selected[min] = true;

    cout << "Edge" << " : " << "Weight";
    cout << endl;

    while (kolEdge < VERT - 1) {
        min = INT_MAX;

        for (int i = 0; i < VERT; i++) {
            if (selected[i]) { 
                for (int j = 0; j < VERT; j++) {
                    if (!selected[j] && graph[i][j]) {
                        if (min > graph[i][j]) 
                        {
                            min = graph[i][j];
                            row = i;
                            col = j;
                        }
                    }
                }
            }
        }

        cout << (row + 1) << " - " << col + 1 << " :  " << graph[row][col];
        cout << endl;

        selected[col] = true; // include the vertex in the MST
        kolEdge++;
    }
}

int main() 
{
    setlocale(LC_CTYPE, "Rus");

    int graph[VERT][VERT] = {
        {0, 2, 0, 8, 2, 0, 0, 0},
        {2, 0, 3, 10, 5, 0, 0, 0},
        {0, 3, 0, 0, 12, 0, 0, 7},
        {8, 10, 0, 0, 14, 3, 1, 0},
        {2, 5, 12, 14, 0, 11, 4, 8},
        {0, 0, 0, 3, 11, 0, 6, 0},
        {0, 0, 0, 1, 4, 6, 0, 9},
        {0, 0, 7, 0, 8, 0, 9, 0}
    };

    cout << "Алгоритм Прима:" << endl;
    algPrim(graph);
}