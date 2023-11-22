//#include "stdafx.h"
//#include "In.h"
//#include "Error.h"
//
//namespace In
//{
//	IN getin(wchar_t infile[])
//	{
//		int lines = 0;
//		int cols = 0;
//		int ignors = 0;
//		int iter = 0;
//		char* str = new char[MAX_LINE_LEN];
//		unsigned char* objcod = new unsigned char[IN_MAX_LEN_TEXT];
//		IN in;
//		in.size = 0;
//		std::fstream file(infile, std::fstream::in);
//
//		if (!file.is_open()) { throw ERROR_THROW(110); }
//		while (!file.eof()) {
//			lines++;
//			file.getline(str, MAX_LINE_LEN);
//			int str_length = strlen(str);
//			for (int i = 0; i < str_length + 1; i++)
//			{
//				cols++;
//				in.size++;
//				if (in.code[int((unsigned char)str[i])] == IN::F)
//				{
//					throw ERROR_THROW_IN(111, lines, cols);
//				}
//				else if (in.code[int((unsigned char)str[i])] == IN::I) {
//					ignors++;
//					str_length--;
//					skip(str, i);
//				}
//				else if (
//					in.code[int((unsigned char)str[i])] != IN::I &&
//					in.code[int((unsigned char)str[i])] != IN::F &&
//					in.code[int((unsigned char)str[i])] != IN::T
//					)
//				{
//					str[i] = in.code[int((unsigned char)str[i])];
//				}
//			}
//			str[str_length + 1] = '\0';
//			//str[strlen(str)] = '|';
//
//			for (int i = 0; i < strlen(str); i++)
//			{
//				objcod[iter++] = (unsigned char)str[i];
//			}
//
//			cols = 0;
//		}
//		objcod[iter] = '\0';
//		in.ignore = ignors;
//		in.lines = lines;
//		in.text = objcod;
//		delete[] str;
//		return in;
//	}
//
//	void skip(char* str, int index)
//	{
//		for (int i = index; i < strlen(str); i++)
//		{
//			str[i] = str[i + 1];
//		}
//	}
//}