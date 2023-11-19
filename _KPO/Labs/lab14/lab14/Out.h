#pragma once
#include <fstream>
#include "stdafx.h"
#include "In.h"
#include "Error.h"
#include "Log.h"
#include "Parm.h"

namespace Out {
	struct OUT {
		wchar_t outfile[PARM_MAX_SIZE];
		std::ofstream* stream;
	};

	static const OUT INITOUT{ L"", NULL };//Структура для начальной инициализации OUT
	OUT getout(wchar_t outfile[]);//сформировать структуру OUT
	void WriteToFile(OUT out, In::IN in);//вывести в выходной файл результат преобразования
	void WriteError(OUT out, Error::ERROR error);//вывести в выходной файл протокол об ошибке
	void Close(OUT out);
}