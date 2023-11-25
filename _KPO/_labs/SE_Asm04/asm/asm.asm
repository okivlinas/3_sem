.586
.MODEL FLAT, STDCALL
includelib kernel32.lib
ExitProcess PROTO : DWORD
.STACK 4096

.CONST

.DATA

INT0	DWORD	2005
STR1	DB	"oleg",0

.CODE
main PROC
START :
push - 1
call ExitProcess
main ENDP
end main
