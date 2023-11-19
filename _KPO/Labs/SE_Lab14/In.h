#pragma once
#define IN_MAX_LEN_TEXT 1024*1024 // ������������ ����� ������
#define IN_CODE_ENDL "\n"  // ��� ������� ����� ������
#define MAX_LINE_LEN 1000

// ����������� ����� �������� �� ������� ������, T = �����, F = ������, I = ������������
// �������� 0 <= ��� < 256 - �� �������� ����� �������

namespace In
{
	void skip(char* str, int index);
	struct IN
	{
		enum
		{
			T = 1024, // �����
			F = 2048, // ������
			I = 4096 // ������������, ������-�����������
		};

		int size,  // ������ �������� ������
			lines, // ���������� �����
			ignore; // ���������� ������������ ��������

		unsigned char* text;
		int code[256] =
		{
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, '|', IN::F, IN::F, IN::F, IN::F, IN::F, // 0
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 16
			IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, // 32
			IN::T, IN::F, IN::T, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 48
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::F, // 64
			IN::F, IN::F, IN::F, IN::T, IN::F, IN::T, IN::F, IN::F, IN::I, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 80
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::F, // 96
			IN::F, IN::F, IN::F, IN::T, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, // 112

			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 128
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 144
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 160
			IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 176
			'-', IN::F, IN::T, IN::F, IN::T, IN::F, IN::T, IN::F, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, // 192
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, // 208
			IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::F, IN::F, IN::T, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::T, // 224
			IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F

		};
	};

	IN getin(wchar_t infile[]);