#include <cwchar>
#include <iostream>
#include "stdafx.h"
#include "Error.h"   // Обработка ошибок
#include "Parm.h"  // Обработка параметров
#include "In.h"
#include "Log.h"   // Логирование
#include "Out.h"

using namespace std;

int _tmain(int argc, wchar_t* argv[]) {
	setlocale(LC_ALL, "Russian");
	/*cout << "---  Функция Parm::getparm  ---" << endl;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		wcout << "-in:" << parm.in << ", out:" << parm.out << ", log:" <<
			parm.log << endl << endl;
	}
	catch (Error::ERROR e) {
		cout << "Ошибка " << e.id << ": " << e.message << endl << endl;
	};
	system("pause");*/

	cout << "---  Функция In::getin  ---" << endl;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		In::IN in = In::getin(parm.in);
		cout << in.text << endl;
		cout << "Размер файла: " << in.size << endl;
		cout << "Количество строк: " << in.lines << endl;
		cout << "Проигнорировано: " << in.ignore << endl;
	}
	catch (Error::ERROR e)
	{
		cout << "ID: " << e.id << " Описание: " << e.message << " Строка: " << e.inext.line << " Позиция:" << e.inext.col << endl;
		if (e.id == 101)
			return 1;
	}

	Log::LOG log = Log::INITLOG;
	Out::OUT out = Out::INITOUT;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		log = Log::getlog(parm.log);
		out = Out::getout(parm.out);
		/*Log::WriteLine(log, (char*)"Тест", (char*)" для вывода \n", "");
		Log::WriteLine(log, (wchar_t*)L"Тест", (wchar_t*)L" для вывода \n", L"");*/
		Log::WriteLog(log);
		Log::WriteParm(log, parm);
		In::IN in = In::getin(parm.in);
		Log::WriteIn(log, in);
		Log::Close(log);

		Out::WriteToFile(out, in);
		Out::Close(out);
	}
	catch (Error::ERROR e) {
		Log::WriteError(log, e);
		Out::WriteError(out, e);
	}

}