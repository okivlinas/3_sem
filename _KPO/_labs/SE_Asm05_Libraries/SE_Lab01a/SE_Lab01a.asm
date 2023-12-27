.586P
.MODEL FLAT, STDCALL

getmin		PROTO : DWORD, : DWORD
getmax		PROTO : DWORD, : DWORD

.STACK 4096

.CODE
getmin PROC parm1 : DWORD, parm2 : DWORD
START:
	mov ecx, parm2       ; Загрузка количества элементов в ecx
	mov esi, parm1       ; Загрузка адреса массива в esi
	mov eax, [esi]       ; Загрузка первого элемента в eax
	loop_start:
		cmp eax, [esi]   ; Сравнение текущего элемента с eax
		jle skip         ; Переход, если текущий элемент меньше или равен eax
		mov eax, [esi]   ; Обновление значения eax, если текущий элемент больше
		skip:
		add esi, type parm1 ; Увеличение адреса на размер элемента
	loop loop_start
	ret                  ; Возврат результата
getmin ENDP

getmax PROC parm1 : DWORD, parm2 : DWORD
START:
	mov ecx, parm2       ; Загрузка количества элементов в ecx
	mov esi, parm1       ; Загрузка адреса массива в esi
	mov eax, [esi]       ; Загрузка первого элемента в eax
	loop_start:
		cmp eax, [esi]   ; Сравнение текущего элемента с eax
		jge skip         ; Переход, если текущий элемент больше или равен eax
		mov eax, [esi]   ; Обновление значения eax, если текущий элемент меньше
		skip:
		add esi, type parm1 ; Увеличение адреса на размер элемента
	loop loop_start
	ret                  ; Возврат результата
getmax ENDP

end                    ; Конец программы
