.MODEL FLAT, STDCALL
includelib kernel32.lib

ExitProcess PROTO : DWORD
MessageBoxA PROTO : DWORD, : PTR BYTE, : PTR BYTE, : DWORD

.STACK 4096

.CONST

.DATA
myBytes      BYTE 10h, 20h, 30h, 40h
myWords      WORD 8Ah, 3BH, 44h, 5Fh, 99h
myDoubles    DWORD 1, 2, 3, 4, 5, 6
myPointer    DWORD myDoubles
array        DWORD 1, 0, 3, 4, 5, 6
sum          DWORD 0

.CODE

main PROC
START:
	mov ESI, OFFSET myBytes
	mov AH, [ESI]
	mov AL, [ESI+2]

	mov ESI, OFFSET array
	mov ECX, LENGTHOF array
	mov EAX, 0

sum_loop:
	cmp DWORD PTR [ESI], 0  ; Проверить значение текущего элемента
	jz EXIT_WITH_NULL       ; Если равно нулю, выйти из цикла

	add EAX, [ESI]
	add ESI, TYPE array
	loop sum_loop

	jmp Exit

EXIT_WITH_NULL:
	mov EBX, 0
	jmp Exit

Exit:
	push -1
	call ExitProcess
main ENDP

end main