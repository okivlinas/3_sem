#include<iostream>
#include"Deserealizer.h"
using namespace std;

void main()
{
	std::ifstream inputFile("D:\\stream.bin", std::ios::binary);
	std::vector<std::pair<int, char*>> result = Deserealizator::Deserelization(inputFile);
    for (const auto & item : result)
    {
        if (item.first != NULL)
        {
            std::cout << "Integer value: " << item.first << std::endl;
        }
        else if (item.second != NULL)
        {
            std::cout << "String value: " << item.second << std::endl;
        }
    }
    inputFile.close();
}