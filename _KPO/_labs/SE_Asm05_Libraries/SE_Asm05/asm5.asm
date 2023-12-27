.586
.MODEL FLAT, STDCALL
includelib kernel32.lib
includelib "..\Debug\SE_Lab01a.lib"
getmin PROTO : DWORD, : DWORD
getmax PROTO : DWORD, : DWORD

ExitProcess PROTO: DWORD
MessageBoxA PROTO: DWORD, : DWORD, : DWORD, : DWORD
SetConsoleTitleA PROTO : DWORD
.STACK 4096

.CONST

.DATA
Array		DWORD	 2, 3, 4, 5,1, 6, 8, 9, 10
TitleCon	DB		"console",0

.CODE

getmin PROC parm1 : DWORD, parm2 : DWORD
START:
	mov ecx, parm2
	mov esi, parm1
	mov eax, [esi]
	loop_start:
		cmp eax, [esi]
		jle skip
		mov eax, [esi]
		skip:
		add esi, type parm1
	loop loop_start
	ret
getmin ENDP
main PROC 
START :
	INVOKE getmin, OFFSET Array, LENGTHOF Array
	push offset TitleCon
	call SetConsoleTitleA
	push -1
	call ExitProcess
main ENDP

end main