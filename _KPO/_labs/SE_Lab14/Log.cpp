#include "stdafx.h"

using namespace std;

namespace Log
{
	LOG getlog(wchar_t logfile[])
	{
		LOG log;
		log.stream = new std::ofstream;
		log.stream->open(logfile);
		if (!log.stream->is_open()) { throw ERROR_THROW(112); }
		wcscpy_s(log.logfile, logfile);

		return log;
	}

	void WriteLine(LOG log, char* c, ...) {
		char** pc = &c;
		while (*pc != "") {
			*log.stream << *pc;
			*pc++;
		}
		*log.stream << std::endl;
	}

	void WriteLine(LOG log, wchar_t* c, ...)
	{
		wchar_t** pc = &c;
		char l[1024] = "";
		char f[1024] = "";
		while (*pc != L"")
		{
			//Converts a sequence of wide characters from the array whose 
			//first element is pointed to by src to its narrow multibyte 
			//representation that begins in the initial shift state.
			wcstombs_s(0, l, *pc, IN_MAX_LEN_TEXT);
			strcat_s(f, l);
			pc++;
		}
		*log.stream << f;
	}

	void WriteLog(LOG log)
	{
		char date[100];
		tm local;
		time_t currentTime;
		currentTime = time(NULL);
		localtime_s(&local, &currentTime);
		strftime(date, 100, "%d.%m.%Y %H:%M:%S", &local);
		*log.stream << "--Report-- Date: " << date << endl;
	}

	void WriteParm(LOG log, Parm::PARM parm) {
		char buff[PARM_MAX_SIZE];
		size_t tsize = 0;

		*log.stream << "---- Parameters -----" << endl;
		wcstombs_s(&tsize, buff, parm.log, PARM_MAX_SIZE);
		*log.stream << "-log: " << buff << endl;
		wcstombs_s(&tsize, buff, parm.out, PARM_MAX_SIZE);
		*log.stream << "-out: " << buff << endl;
		wcstombs_s(&tsize, buff, parm.in, PARM_MAX_SIZE);
		*log.stream << "-in: " << buff << endl;
	}

	void WriteIn(LOG log, In::IN in) {
		*log.stream << "---Source data---" << endl;
		*log.stream << "Char amount: " << in.size << endl;
		*log.stream << "Ignored: " << in.ignore << endl;
		*log.stream << "String amount: " << in.lines << endl;
	}

	void WriteError(LOG log, Error::ERROR error)
	{
		*log.stream << " -- errors --" << endl;
		*log.stream << "Error " << error.id << ": " << error.message << endl;

		if (error.inext.line != -1)
			*log.stream << "Line " << error.inext.line << "Character: " << error.inext.col << endl << endl;
	}

	void Close(LOG log) {
		log.stream->close();
		delete log.stream;
	}
};