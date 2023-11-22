#include<fstream>
#include<iostream>
#include<vector>
#define HEADER ".586\n.MODEL FLAT, STDCALL\nincludelib kernel32.lib\nExitProcess PROTO : DWORD\n.STACK 4096\n\n.CONST\n\n.DATA\n\n"
#define FOOTER "\n\n.CODE\nmain PROC\nSTART :\npush - 1\ncall ExitProcess\nmain ENDP\nend main\n"
using namespace std;

static class Deserealizator
{
public:
	static vector<pair<int, char*>> Deserelization(std::istream& os);
};