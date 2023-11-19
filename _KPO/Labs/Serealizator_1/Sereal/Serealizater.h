#pragma once
#include<fstream>
static class Serealizer
{
public:
	static size_t Serialize(int intVal, std::ostream& os);
	static size_t Serialize(char* strVal, std::ostream& os);
};