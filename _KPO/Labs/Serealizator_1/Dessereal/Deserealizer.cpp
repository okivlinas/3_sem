#include"Deserealizer.h"
vector<pair<int, char*>> Deserealizator::Deserelization(std::istream& os)
{
	vector<pair<int, char*>> des;
	int intValue;
	int len=0;
	char* strValue;
	char firstByte;
	int counter = 0;
	os.read(&firstByte, 1);
	int type= static_cast<int>(static_cast<unsigned char>(firstByte));
	ofstream writeCode("..\\Des_Asm\\des.asm");
	if (os )
	{
		writeCode << HEADER;
		while (os)
		{
			switch (type)
			{
			case 0x01:
				os.read(reinterpret_cast<char*>(&intValue), sizeof(intValue));
				des.push_back(make_pair(intValue, (char*)NULL));
				writeCode << "INT";
				writeCode << counter;
				writeCode << "\tDWORD\t";
				writeCode << intValue;
				writeCode << "\n";
				break;
			case 0x02:
				os.read(reinterpret_cast<char*>(&len), 1);
				strValue = new char[len];
				writeCode << "STR";
				writeCode << counter;
				writeCode << "\t" << "DB";
				writeCode << "\t" << "\"";
				for (int i = 0; i < len; i++)
				{
					os.read(reinterpret_cast<char*>(&strValue[i]), sizeof(char));
					writeCode << strValue[i];
				}
				writeCode << "\",0";
				strValue[len] = '\0';
				des.push_back(make_pair(NULL, strValue));
				break;
			}
			os.read(&firstByte, 1);
			type = static_cast<int>(static_cast<unsigned char>(firstByte));
			counter++;
		}
	}
	writeCode << FOOTER;
	writeCode.close();
	return des;
}