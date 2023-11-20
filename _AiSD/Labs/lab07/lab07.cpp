#include <iostream>
#include <ctime>
#include <vector>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	srand(time(0));
	vector<int> posl;
	vector<int> maxposl;
	int n;
	int max = 0;
	int end = 0;
	cout << "Введите длину исходной последовательности: ";
	cin >> n;
	cout << "Сгенерированная последовательность чисел:" << endl;
	for (int i = 0; i < n; i++)
	{
		posl.push_back(rand() % 20 + 1);
		cout << posl[i] << "  ";
	}
	vector<int> dp(n, 1);
	vector<int> prev(n, -1);
	for (int i = 1; i < n; i++)
	{
		for (int j = 0; j < i; j++)
		{
			if (posl[i] > posl[j] && dp[i] < dp[j] + 1)
			{
				dp[i] = dp[j] + 1;
				prev[i] = j;
			}
		}
		if (dp[i] > max)
		{
			max = dp[i];
			end = i;
		}
	}
	while (end != -1)
	{
		maxposl.push_back(posl[end]);
		end = prev[end];
	}
	reverse(maxposl.begin(), maxposl.end());
	cout << endl;
	for (int i = 0; i < maxposl.size(); i++)
	{
		cout << maxposl[i] << "  ";
	}
	return 0;
}