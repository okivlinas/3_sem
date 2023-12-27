#include <iostream>
#include <Windows.h>
#include <ctime>
#pragma warning(disable: 4996)
extern "C"
{
	__declspec(dllexport) int getmax(int* arr, int size)
	{
		int max = 0;
		for (int i = 0; i < size; i++)
		{
			if (max < arr[i])
			{
				max = arr[i];
			}
		}
		return max;
	}
	void print_int()
	{
		char i[20];
		std::cin.getline(i, 20);
		std::cout << i;
	}
	__declspec(dllexport) int getmin(int* arr, int size)
	{
		int min = 0;
		for (int i = 0; i < size; i++)
		{
			if (min > arr[i]) min = arr[i];
		}
		return min;
	}
	
}