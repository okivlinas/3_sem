#include "Parm.h"
#include "Error.h"

namespace Parm
{
	// Функция getparm получает аргументы командной строки и возвращает структуру PARM.
	// Аргументы функции: argc - количество аргументов (int, >= 1),
	// argv - массив аргументов командной строки (wchar_t* - указатель на массив wchar_t).

	PARM getparm(int argc, wchar_t* argv[])
	{
		PARM parm;

		bool in_found = false, out_found = false, log_found = false;
		for (int i = 1; i < argc; i++)
		{
			// Функция wcslen возвращает длину строки в символах wchar_t.
			// Если длина строки превышает PARM_MAX_SIZE, генерируется исключение ERROR_THROW(104).
			if (wcslen(argv[i]) > PARM_MAX_SIZE) { throw ERROR_THROW(104); }

			// Функция wcsstr ищет первое вхождение подстроки в строке.
			// Если подстрока найдена, возвращается указатель на начало подстроки в строке.
			// Если подстрока не найдена, возвращается nullptr.
			if (wcsstr(argv[i], PARM_IN))
			{
				if (wcslen(argv[i] + wcslen(PARM_IN)) == 0)
					throw ERROR_THROW(101);
				wcscpy_s(parm.in, argv[i] + wcslen(PARM_IN));
				in_found = true;
			}
			if (wcsstr(argv[i], PARM_OUT) and (wcslen(argv[i] + wcslen(PARM_OUT)) != 0)) {
				wcscpy_s(parm.out, argv[i] + wcslen(PARM_OUT));
				out_found = true;
			}
			if (wcsstr(argv[i], PARM_LOG) and (wcslen(argv[i] + wcslen(PARM_LOG)) != 0)) {
				wcscpy_s(parm.log, argv[i] + wcslen(PARM_LOG));
				log_found = true;
			}
		}
		if (!in_found) throw ERROR_THROW(100);
		if (!out_found) {
			wcscpy_s(parm.out, parm.in);
			wcscat_s(parm.out, PARM_OUT_DEFAULT_EXT);
		}
		if (!log_found) {
			wcscpy_s(parm.log, parm.in);
			wcscat_s(parm.log, PARM_LOG_DEFAULT_EXT);
		}
		return parm;
	}
}