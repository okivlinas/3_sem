#include <cwchar>
#include <iostream>
#include "stdafx.h"
#include "Error.h"   // Errors handling
#include "Parm.h"  // Parms handling
#include "In.h"
#include "Log.h"   // Logs and messages
#include "Out.h"

using namespace std;

int _tmain(int argc, wchar_t* argv[]) {
    setlocale(LC_ALL, "Russian");
    /*cout << "---  Проверка Parm::getparm  ---" << endl;
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

    cout << "---  Проверка In::getin  ---" << endl;
    try
    {   
        Parm::PARM parm = Parm::getparm(argc, argv);
        In::IN in = In::getin(parm.in);
        cout << in.text << endl;
        cout << "Размер файла: " << in.size << endl;
        cout << "Количество строк: " << in.lines << endl;
        cout << "Игнорирование: " << in.ignore << endl;
    }
    catch (Error::ERROR e)
    {
        cout << "ID: " << e.id << " Ошибка: " << e.message << " Строка: " << e.inext.line << " Позиция:" << e.inext.col << endl;
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
        /*Log::WriteLine(log, (char*)"Сообщение", (char*)" для отладки \n", "");
        Log::WriteLine(log, (wchar_t*)L"Сообщение", (wchar_t*)L" для отладки \n", L"");*/
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