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

	static const OUT INITOUT{ L"", NULL }; // ������������� ��������� OUT � ������ ������ ����� � ������� ���������� �� �����
	OUT getout(wchar_t outfile[]); // ��������� ��������� OUT � �������� ������ �����
	void WriteToFile(OUT out, In::IN in); // ������ �������� ������ � ��������� ����
	void WriteError(OUT out, Error::ERROR error); // ������ ���������� �� ������ � ��������� ����
	void Close(OUT out); // �������� ��������� ������
}