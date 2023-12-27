.MODEL FLAT, STDCALL

includelib kernel32.lib
includelib msvcrt.lib
includelib "..\Debug\SE_Lab01a.lib"

getmin PROTO : DWORD, : DWORD

getmax PROTO : DWORD, : DWORD

; Прототипы функций WinAPI
ExitProcess PROTO: DWORD
MessageBoxA PROTO: DWORD, : DWORD, : DWORD, : DWORD
SetConsoleTitleA PROTO : DWORD
GetStdHandle PROTO :DWORD
WriteConsoleA PROTO :DWORD, :DWORD, :DWORD, :DWORD, :DWORD

.STACK 4096

.CONST

.DATA
Array		DWORD	 -20, 3, 4, 5,1, -6, 8, 9, 10     ; Массив чисел
TitleCon	DB		"console",0                 ; Заголовок окна консоли
Text		db		"getmin+getmax=",0          ; Текст для вывода
output		db		10 dup(0)                   ; Буфер для преобразования числа в строку
consolehandle dd	0h                            ; Дескриптор консоли
max			DWORD	?                            ; Максимальное значение

.CODE
; Процедура int_to_char, которая преобразует число в строку
int_to_char PROC uses eax ebx ecx edi esi,
					pstr		: dword, 
					intfield	: sdword 

	mov edi, pstr       ; Загрузка указателя на строку в edi
	mov esi, 0          ; Обнуление счетчика цифр
	mov eax, intfield   ; Загрузка числа в eax
	cdq                 ; Знаковое деление edx:eax на 10
	test eax, eax       ; Проверка знака числа
	mov ebx, 10         ; Загрузка делителя
	idiv ebx            ; Деление edx:eax на 10
	jns plus            ; Переход, если число положительное
	neg eax             ; Инвертирование числа
	neg edx             ; Инвертирование остатка
	mov cl, '-'         ; Загрузка знака '-' в cl
	mov [edi], cl       ; Сохранение знака в строке
	inc edi             ; Увеличение указателя на строку

plus:
	push dx             ; Сохранение остатка от деления на стеке
	inc esi             ; Увеличение счетчика цифр
	test eax, eax       ; Проверка значения eax
	jz fin              ; Переход, если число преобразовано полностью
	cdq                 ; Знаковое деление edx:eax на 10
	idiv ebx            ; Деление edx:eax на 10
	jmp plus            ; Переход к добавлению следующей цифры

fin:                   ; Конец преобразования числа в строку
	mov ecx, esi        ; Загрузка количества цифр в ecx

write:                 ; Вывод числа на консоль
	pop bx              ; Извлечение цифры из стека
	add bl,'0'          ; Преобразование числа в ASCII-код цифры
	mov [edi], bl       ; Сохранение цифры в строке
	inc edi             ; Увеличение указателя на строку
	loop write          ; Повторение вывода для всех цифр
	ret                  ; Возврат из процедуры
	
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
