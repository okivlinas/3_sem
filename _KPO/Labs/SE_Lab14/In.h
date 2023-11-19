#pragma once
#define IN_MAX_LEN_TEXT 1024*1024 // Максимальная длина текста
#define IN_CODE_ENDL "\n"  // Код символа конца строки
#define MAX_LINE_LEN 1000

// Определение типов символов во входном потоке, T = буква, F = пробел, I = игнорировать
// Значение 0 <= код < 256 - не является кодом символа

namespace In
{
	void skip(char* str, int index);
	struct IN
	{
		enum
		{
			T = 1024, // Буква
			F = 2048, // Пробел
			I = 4096 // Игнорируемый, символ-разделитель
		};

		int size,  // Размер входного потока
			lines, // Количество строк
			ignore; // Количество игнорируемых символов

		unsigned char* text;
		int code[256] =
		{
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, '|', IN::F, IN::F, IN::F, IN::F, IN::F, // 0
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 16
			IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, // 32
			IN::T, IN::F, IN::T, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 48
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::F, // 64
			IN::F, IN::F, IN::F, IN::T, IN::F, IN::T, IN::F, IN::F, IN::I, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 80
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::F, // 96
			IN::F, IN::F, IN::F, IN::T, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, // 112

			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 128
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 144
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 160
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 176
			'-', IN::F, IN::T, IN::F, IN::T, IN::F, IN::T, IN::F, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, // 192
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 208
			IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::F, IN::F, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::T, // 224
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F

		};
	};

	IN getin(wchar_t infile[]);