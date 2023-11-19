#include<iostream>
#include<fstream>
#include"Serealizater.h"
using namespace std;
void main()
{
	char textString[128];
	cin.getline(textString, 128);
	int intValue ;
	cin >> intValue;
	ofstream file;
	file.open("D:\\stream.bin", std::ios::binary);
	Serealizer::Serialize(intValue, file);
	Serealizer::Serialize(textString, file);
	file.close();

}