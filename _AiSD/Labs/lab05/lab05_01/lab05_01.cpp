#include <iostream>
using namespace std;

const int VERT = 8;
int infCost = 1e9;
int visited[VERT];


int interconnected(int i)
{
    while (visited[i] != i)
    {
        i = visited[i];
    }
    return i;
}

void unionCompos(int i, int j)
{
    int a = interconnected(i);
    int b = interconnected(j);
    visited[a] = b;
}

void Kraskl(int graph[VERT][VERT])
{
    int min;
    int edgesCount = 0;
    for (int i = 0; i < VERT; i++)
    {
        visited[i] = i;
    }

    while (edgesCount < VERT - 1)
    {
        min = infCost;
        int a = infCost, b = infCost;
        for (int i = 0; i < VERT; i++)
        {
            for (int j = 0; j < VERT; j++)
            {
                if (interconnected(i) != interconnected(j) && graph[i][j] < min && graph[i][j] != 0)
                {
                    min = graph[i][j];
                    a = i;
                    b = j;
                }
            }
        }
        unionCompos(a, b);
        edgesCount++;
        cout << a + 1 << " - " << b + 1 << endl;
    }
}

int main()
{
    int graph[VERT][VERT] =
    {
        {0, 2, 0, 8, 2, 0, 0, 0 },
        {2, 0, 3, 10, 5, 0, 0, 0},
        {0, 3, 0, 0, 12, 0, 0, 7},
        {8, 10, 0, 0, 14, 3, 1, 0},
        {2, 5, 12, 14, 0, 11, 4, 8},
        {0, 0, 0, 3, 11, 0, 6, 0},
        {0, 0, 0, 1, 4, 6, 0, 9},
        {0, 0, 7, 0, 8, 0, 9, 0}
    };
    setlocale(LC_CTYPE, "Russian");
    cout << "Алгоритм Краскала: " << endl;
    cout << "Edge: " << endl;
    Kraskl(graph);
}