#include "stdafx.h"
#include "In.h"
#include "Error.h"

namespace In
{
	IN getin(wchar_t infile[])
	{
		int lines = 1; // ���������� �����
		int cols = 0; // ���������� ��������
		int ignors = 0; // ���������� ������������ ��������
		int iter = 0; // ��������
		char ch; // ������� ������
		unsigned char* objcod = new unsigned char[IN_MAX_LEN_TEXT]; // ������ ��� �������� ������������ ��������
		IN in; // ��������� �����
		in.size = 0; // ������ �����
		std::ifstream file(infile); // �������� �����

		if (!file.is_open()) { throw ERROR_THROW(110); } // ������: �� ������� ������� ����
		while (file.get(ch)) {
			cols++;
			in.size++;
			if (ch == '\n') {
				lines++;
				cols = 0;
			}
			if (in.code[int((unsigned char)ch)] == IN::F) // ������ �� ����������� �����
			{
				throw ERROR_THROW_IN(111, lines, cols);
			}
			else if (in.code[int((unsigned char)ch)] == IN::I) { // ������ ������������
				ignors++;
				continue;
			}
			else if (
				in.code[int((unsigned char)ch)] != IN::I &&
				in.code[int((unsigned char)ch)] != IN::F &&
				in.code[int((unsigned char)ch)] != IN::T
				)
			{
				ch = in.code[int((unsigned char)ch)]; // ������ ������� �� ��� ���
			}
			objcod[iter++] = (unsigned char)ch; // ���������� ������������� �������
		}
		objcod[iter] = '\0'; // ���������� ������������ �������� �������
		in.ignore = ignors; // ���������� ������������ ��������
		in.lines = lines; // ���������� �����
		in.text = objcod; // �����
		return in;
	}

	void skip(char* str, int index)
	{
		for (int i = index; i < strlen(str); i++)
		{
			str[i] = str[i + 1];
		}
	}
}