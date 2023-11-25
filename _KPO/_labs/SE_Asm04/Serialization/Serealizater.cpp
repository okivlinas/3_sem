#include"Serealizater.h"

size_t Serealizer::Serialize(int intVal, std::ostream& os)
{
	auto pos = os.tellp();
	std::uint8_t byteVal = 0x01;
	os.write(reinterpret_cast<const char*>(&byteVal), 1);
	os.write(reinterpret_cast<const char*>(&intVal), sizeof(intVal));
	return static_cast<std::size_t>(os.tellp() - pos);
}
size_t Serealizer::Serialize(char* strVal, std::ostream& os)
{
	auto pos = os.tellp();
	std::uint8_t byteVal = 0x02;
	const auto len = static_cast<std::uint8_t>(strlen(strVal));
	os.write(reinterpret_cast<const char*>(&byteVal), 1);
	os.write(reinterpret_cast<const char*>(&len), sizeof(len));
	for (int i = 0; i < len; i++)
	{
		os.write(reinterpret_cast<const char*>(&strVal[i]), sizeof(strVal[i]));
	}
	return static_cast<std::size_t>(os.tellp() - pos);
}