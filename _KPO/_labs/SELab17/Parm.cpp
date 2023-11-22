#include "stdafx.h"
#include "Parm.h"
#include "Error.h"

namespace Parm
{
	// Параметры: argc - количество аргументов (int, >= 1),
	// argv - массив аргументов командной строки (в формате wchar_t)

	PARM getparm(int argc, wchar_t* argv[])
	{
		PARM parm;

		bool in_found = false, out_found = false, log_found = false;
		for (int i = 1; i < argc; i++)
		{
			if (wcslen(argv[i]) > PARM_MAX_SIZE) { throw ERROR_THROW(104); }
			// Функция wcsstr выполняет поиск первого вхождения подстроки в строке.
			// Если подстрока не найдена, функция возвращает nullptr.
			if (wcsstr(argv[i], PARM_IN))
			{
				if (wcslen(argv[i] + wcslen(PARM_IN)) == 0)
					throw ERROR_THROW(101);
				wcscpy_s(parm.in, argv[i] + wcslen(PARM_IN));
				in_found = true;
			}
			if (wcsstr(argv[i], PARM_OUT) && (wcslen(argv[i] + wcslen(PARM_OUT)) != 0)) {
				wcscpy_s(parm.out, argv[i] + wcslen(PARM_OUT));
				out_found = true;
			}
			if (wcsstr(argv[i], PARM_LOG) && (wcslen(argv[i] + wcslen(PARM_LOG)) != 0)) {
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