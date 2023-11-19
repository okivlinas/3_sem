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

	static const OUT INITOUT{ L"", NULL }; // Инициализация структуры OUT с пустым именем файла и нулевым указателем на поток
	OUT getout(wchar_t outfile[]); // Получение структуры OUT с заданным именем файла
	void WriteToFile(OUT out, In::IN in); // Запись входного потока в указанный файл
	void WriteError(OUT out, Error::ERROR error); // Запись информации об ошибке в указанный файл
	void Close(OUT out); // Закрытие выходного потока
}