#pragma once
#define PARM_IN L"-in:"  // Входной параметр командной строки
#define PARM_OUT L"-out:"  // Выходной параметр командной строки
#define PARM_LOG L"-log:" // Лог-файл параметр командной строки
#define PARM_MAX_SIZE 300  // Максимальный размер параметра командной строки
#define PARM_OUT_DEFAULT_EXT L".out" // Расширение выходного файла по умолчанию
#define PARM_LOG_DEFAULT_EXT L".log" // Расширение лог-файла по умолчанию

namespace Parm  // Пространство имен Parm
{
	struct PARM  // Структура PARM
	{
		wchar_t in[PARM_MAX_SIZE];   // Путь к входному файлу
		wchar_t out[PARM_MAX_SIZE];  // Путь к выходному файлу
		wchar_t log[PARM_MAX_SIZE];  // Путь к лог-файлу
	};

	PARM getparm(int argc, wchar_t* argv[]);  // Получение параметров командной строки в структуру PARM для использования в функции main
}