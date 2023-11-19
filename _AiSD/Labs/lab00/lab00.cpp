#include <iostream>
#include <vector>
#include <queue>

using namespace std;

void Dei(int graph[9][9], int start)
{
    int dist[9];
    int prevDist[9];
    bool visited[9];

    for (int i = 0; i < 9; i++) {
        dist[i] = 1e9;
        prevDist[i] = -1;
        visited[i] = false;
    }

    dist[start] = 0;
    queue<int>q;
    q.push(start);

    while (!q.empty()) {
        int cur = q.front();
        q.pop();
        visited[cur] = true;

        for (int i = 0; i < 9; i++) {
            if (!visited[i] && graph[cur][i] && dist[cur] != 1e9 && dist[cur] + graph[cur][i] < dist[i]) {
                dist[i] = dist[cur] + graph[cur][i];
                prevDist[i] = cur;
                q.push(i);
            }
        }
    }
        cout << "Shortest distances and paths: " << endl;
        for (int i = 0; i < 9; i++) {
            char from = static_cast<char>(start + 'A');
            char to = static_cast<char>(i + 'A');
            cout << "From vertex " << from << " to vertex " << to << ": " << dist[i] << ", Path: ";

            if (dist[i] != 1e9) {
                int cur = i;
                while (cur != start) {
                    cout << static_cast<char>(cur + 'A') << " <- ";
                    cur = prevDist[cur];
                }
                cout << from;
            }
            else {
                cout << "Unreachable";
            }
            cout << endl;
    }
}

int main()
{
    setlocale(LC_CTYPE, "Russian");

    char c;
    int start;
    int graph[9][9]{
        {0, 7, 10, 0, 0, 0, 0, 0, 0},  // A
        {7, 0, 0, 0, 0, 9, 27, 0, 0}, // B
        {10, 0, 0, 0, 31, 8, 0, 0, 0},// C
        {0, 0, 0, 0, 32, 0, 0, 17, 21},// D
        {0, 0, 31, 32, 0, 0, 0, 0, 0}, // E
        {0, 9, 8, 0, 0, 0, 0, 11, 0}, // F
        {0, 27, 0, 0, 0, 0, 0, 0, 15},// G
        {0, 0, 0, 17, 0, 11, 0, 0, 15},// H
        {0, 0, 0, 21, 0, 0, 15, 15, 0} // I
    };

    cout << "Введите стартовую вершину: ";
    cin >> c;

    start = (int)c - 'A';

    Dei(graph, start);

}