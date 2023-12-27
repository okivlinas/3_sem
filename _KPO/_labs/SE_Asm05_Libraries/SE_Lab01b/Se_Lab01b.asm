.MODEL FLAT, STDCALL

includelib kernel32.lib
includelib msvcrt.lib
includelib "..\Debug\SE_Lab01a.lib"

getmin PROTO : DWORD, : DWORD

getmax PROTO : DWORD, : DWORD

; ��������� ������� WinAPI
ExitProcess PROTO: DWORD
MessageBoxA PROTO: DWORD, : DWORD, : DWORD, : DWORD
SetConsoleTitleA PROTO : DWORD
GetStdHandle PROTO :DWORD
WriteConsoleA PROTO :DWORD, :DWORD, :DWORD, :DWORD, :DWORD

.STACK 4096

.CONST

.DATA
Array		DWORD	 -20, 3, 4, 5,1, -6, 8, 9, 10     ; ������ �����
TitleCon	DB		"console",0                 ; ��������� ���� �������
Text		db		"getmin+getmax=",0          ; ����� ��� ������
output		db		10 dup(0)                   ; ����� ��� �������������� ����� � ������
consolehandle dd	0h                            ; ���������� �������
max			DWORD	?                            ; ������������ ��������

.CODE
; ��������� int_to_char, ������� ����������� ����� � ������
int_to_char PROC uses eax ebx ecx edi esi,
					pstr		: dword, 
					intfield	: sdword 

	mov edi, pstr       ; �������� ��������� �� ������ � edi
	mov esi, 0          ; ��������� �������� ����
	mov eax, intfield   ; �������� ����� � eax
	cdq                 ; �������� ������� edx:eax �� 10
	test eax, eax       ; �������� ����� �����
	mov ebx, 10         ; �������� ��������
	idiv ebx            ; ������� edx:eax �� 10
	jns plus            ; �������, ���� ����� �������������
	neg eax             ; �������������� �����
	neg edx             ; �������������� �������
	mov cl, '-'         ; �������� ����� '-' � cl
	mov [edi], cl       ; ���������� ����� � ������
	inc edi             ; ���������� ��������� �� ������

plus:
	push dx             ; ���������� ������� �� ������� �� �����
	inc esi             ; ���������� �������� ����
	test eax, eax       ; �������� �������� eax
	jz fin              ; �������, ���� ����� ������������� ���������
	cdq                 ; �������� ������� edx:eax �� 10
	idiv ebx            ; ������� edx:eax �� 10
	jmp plus            ; ������� � ���������� ��������� �����

fin:                   ; ����� �������������� ����� � ������
	mov ecx, esi        ; �������� ���������� ���� � ecx

write:                 ; ����� ����� �� �������
	pop bx              ; ���������� ����� �� �����
	add bl,'0'          ; �������������� ����� � ASCII-��� �����
	mov [edi], bl       ; ���������� ����� � ������
	inc edi             ; ���������� ��������� �� ������
	loop write          ; ���������� ������ ��� ���� ����
	ret                  ; ������� �� ���������
	
int_to_char ENDP

main PROC 
START :
	push offset TitleCon
	call SetConsoleTitleA

	push -11
	call GetStdHandle
	mov consolehandle,eax

	push 0
	push 0
	push sizeof Text
	push offset Text
	push consolehandle
	call WriteConsoleA

	INVOKE getmax, OFFSET Array, LENGTHOF Array
	mov max, eax
	INVOKE getmin, OFFSET Array, LENGTHOF Array
	add eax, max

	INVOKE int_to_char, OFFSET output, eax
	push 0
	push 0
	push sizeof output
	push offset output
	push consolehandle
	call WriteConsoleA

	push -1
	call ExitProcess
main ENDP

end main
