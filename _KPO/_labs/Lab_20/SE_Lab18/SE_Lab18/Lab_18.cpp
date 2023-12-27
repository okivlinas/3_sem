#include <iostream>
#include <string>
#include <windows.h>
#include <stack>
using namespace std;

void PolishNotation(string str);

void main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	string str;
	cout << "Введите строку: ", cin >> str;
	cout << "\nНачальная строка: " << str << endl;
	cout << "Выражение после преобразования:";
	PolishNotation(str);
}

void PolishNotation(string str)
{
	int size = str.size();
	char *new_stroke = new char[size];
	stack<char>st;
	static int b = 0;
	char symb;
	int countOfBrackets = 0;

	for (int i = 0; i < str.size(); i++)
	{
		switch (str[i])
		{
		case ')':
		{
			countOfBrackets += 1;
			for (int i = 0; i < str.size(); i++)
			{
				symb = st.top();

				if (symb == '(')
				{
					st.pop();
					break;
				}
				else
				{
					new_stroke[b] = symb;
					b++;
					st.pop();
				}
			}
			break;
		}
		case '(':
		{
			countOfBrackets += 1;
			st.push(str[i]);
			break;
		}
		case '+':
		{
			if (st.empty() == false)
			{
				symb = st.top();
				if (symb == '*' || symb =='/')
				{
					for(int i = 0; st.empty() == true; i++)
					{
						new_stroke[b] = st.top();
						st.pop();
					}
					st.push('+');
				}
				else
				{
					st.push('+');
				}
			}
			else
			{
				st.push(str[i]);
			}

			break;
		}
		case '-':
		{
			if (st.empty() == false)
			{
				symb = st.top();
				
				if (symb == '*' || symb == '/')
				{
					for (int i = 0; st.empty() == true; i++)
					{
						new_stroke[b] = st.top();
						b++;
						st.pop();
					}
					st.push('-');
				}
				else
				{
					st.push('-');
				}
			}
			else
			{
				st.push(str[i]);
			}
			break;
		}
		case '*':
		{
			st.push(str[i]);
			break;
		}
		case '/':
		{
			st.push(str[i]);
			break;
		}

		default:
		{
			new_stroke[b] = str[i];
			b++;
			break;
		}

		}
	}
		for (b; b < str.size(); b++)
		{
			if (st.empty() == false)
			{
				symb = st.top();
				new_stroke[b] = symb;
				st.pop();
			}
			else
			{
				break;
			}
		}

		for (int i = 0; i < str.size() - countOfBrackets; i++)
		{
			cout << new_stroke[i];
		}
		cout << endl;

	delete[] new_stroke;
}