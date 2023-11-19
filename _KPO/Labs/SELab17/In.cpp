#include "stdafx.h"
#include "In.h"
#include "Error.h"

namespace In
{
	IN getin(wchar_t infile[])
	{
		int lines = 1; // количество строк
		int cols = 0; // количество столбцов
		int ignors = 0; // количество игнорируемых символов
		int iter = 0; // итератор
		char ch; // текущий символ
		unsigned char* objcod = new unsigned char[IN_MAX_LEN_TEXT]; // массив для хранения кодированных символов
		IN in; // структура ввода
		in.size = 0; // размер ввода
		std::ifstream file(infile); // открытие файла

		if (!file.is_open()) { throw ERROR_THROW(110); } // ошибка: не удалось открыть файл
		while (file.get(ch)) {
			cols++;
			in.size++;
			if (ch == '\n') {
				lines++;
				cols = 0;
			}
			if (in.code[int((unsigned char)ch)] == IN::F) // символ не принадлежит языку
			{
				throw ERROR_THROW_IN(111, lines, cols);
			}
			else if (in.code[int((unsigned char)ch)] == IN::I) { // символ игнорируется
				ignors++;
				continue;
			}
			else if (
				in.code[int((unsigned char)ch)] != IN::I &&
				in.code[int((unsigned char)ch)] != IN::F &&
				in.code[int((unsigned char)ch)] != IN::T
				)
			{
				ch = in.code[int((unsigned char)ch)]; // замена символа на его код
			}
			objcod[iter++] = (unsigned char)ch; // сохранение кодированного символа
		}
		objcod[iter] = '\0'; // добавление завершающего нулевого символа
		in.ignore = ignors; // количество игнорируемых символов
		in.lines = lines; // количество строк
		in.text = objcod; // текст
		return in;
	}

	void skip(char* str, int index)
	{
		for (int i = index; i < strlen(str); i++)
		{
			str[i] = str[i + 1];
		}
	}
}