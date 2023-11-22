#pragma once
#include <fstream>
#include "In.h"
#include "Parm.h"
#include "Error.h"

namespace Log
{
	struct LOG
	{
		wchar_t logfile[PARM_MAX_SIZE];
		std::ofstream* stream;
	};

	static const LOG INITLOG{ L"", NULL }; // Инициализация структуры LOG с пустым именем файла и нулевым указателем на поток
	LOG getlog(wchar_t logfile[]); // Получение структуры LOG
	void WriteLine(LOG log, char* c, ...); // Запись строки в лог с переменными аргументами
	void WriteLine(LOG log, wchar_t* c, ...); // Запись строки в лог с переменными аргументами (широкие символы)
	void WriteLog(LOG log); // Запись содержимого лога в файл
	void WriteParm(LOG log, Parm::PARM parm); // Запись информации о параметрах в лог
	void WriteIn(LOG log, In::IN in); // Запись информации о входном потоке в лог
	void WriteError(LOG log, Error::ERROR error); // Запись информации об ошибке в лог
	void Close(LOG log); // Закрытие лога
};