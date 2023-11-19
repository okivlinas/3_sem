#include<iostream>
#include<queue>
#include<vector>
#include<stack>
using namespace std;

vector<vector<int>> graph;
stack<int> stk;
vector<bool> used;

void addEdge(int vertex, int to)
{
	graph[vertex].push_back(to);
}

void BFS(int start)
{
	queue<int>q;
	vector<bool> used;
	used.resize(11);
	q.push(start);
	used[start] = true;
	int current;
	while (!q.empty())
	{
		current = q.front();
		q.pop();
		cout << current << " ";
		for (int neighbor : graph[current])
		{
			if (!used[neighbor])
			{
				q.push(neighbor);
			}
			used[neighbor] = true;
		}
	}
}

void DFS(int start)
{
	stk.push(start);
	used.resize(11);
	int current;
	while (!stk.empty())
	{
		int currentNode = stk.top();
		stk.pop();

		if (!used[currentNode]) {
			cout << currentNode << " "; 
			used[currentNode] = true;

			for (int i = graph[currentNode].size() - 1; i >= 0; --i) {
				int neighbor = graph[currentNode][i];
				if (!used[neighbor]) {
					stk.push(neighbor);
				}
			}
		}
	}
}

void main()
{
	int start;
	int graph1[10][10] =
	{
	{0, 1, 0, 0, 1, 0, 0, 0, 0, 0},
	{1, 0, 0, 0, 0, 0, 1, 1, 0, 0},
	{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
	{0, 0, 0, 0, 0, 1, 0, 0, 1, 0},
	{1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
	{0, 0, 0, 1, 1, 0, 0, 0, 1, 0},
	{0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
	{0, 1, 1, 0, 0, 0, 1, 0, 0, 0},
	{0, 0, 0, 1, 0, 1, 0, 0, 0, 1},
	{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
	};
	int graph3[20][2] = {
		{1,2},{2,1},{1,5},{5,1},{3,8},{8,3},{2,7},{7,2},{2,8},{8,2},{5,6},{6,5},{6,4},{4,6},{4,9},{9,4},{9,10}
	};
	graph.resize(11);
	//1
	addEdge(1, 2);
	addEdge(1, 5);
	//2
	addEdge(2, 7);
	addEdge(2, 8);
	addEdge(2, 1);
	//3
	addEdge(3, 8);
	//4
	addEdge(4, 6);
	addEdge(4, 9);
	//5
	addEdge(5, 1);
	addEdge(5, 6);
	//6
	addEdge(6, 5);
	addEdge(6, 4);
	addEdge(6, 9);
	//7
	addEdge(7, 2);
	addEdge(7, 8);
	//8
	addEdge(8, 7);
	addEdge(8, 2);
	addEdge(8, 3);
	//9
	addEdge(9, 4);
	addEdge(9, 6);
	addEdge(9, 10);
	//10
	addEdge(10, 9);

	cin >> start;
	BFS(start);
	cout << endl;
	DFS(start);
}