.586P
.MODEL FLAT, STDCALL

getmin		PROTO : DWORD, : DWORD
getmax		PROTO : DWORD, : DWORD

.STACK 4096

.CODE
getmin PROC parm1 : DWORD, parm2 : DWORD
START:
	mov ecx, parm2       ; �������� ���������� ��������� � ecx
	mov esi, parm1       ; �������� ������ ������� � esi
	mov eax, [esi]       ; �������� ������� �������� � eax
	loop_start:
		cmp eax, [esi]   ; ��������� �������� �������� � eax
		jle skip         ; �������, ���� ������� ������� ������ ��� ����� eax
		mov eax, [esi]   ; ���������� �������� eax, ���� ������� ������� ������
		skip:
		add esi, type parm1 ; ���������� ������ �� ������ ��������
	loop loop_start
	ret                  ; ������� ����������
getmin ENDP

getmax PROC parm1 : DWORD, parm2 : DWORD
START:
	mov ecx, parm2       ; �������� ���������� ��������� � ecx
	mov esi, parm1       ; �������� ������ ������� � esi
	mov eax, [esi]       ; �������� ������� �������� � eax
	loop_start:
		cmp eax, [esi]   ; ��������� �������� �������� � eax
		jge skip         ; �������, ���� ������� ������� ������ ��� ����� eax
		mov eax, [esi]   ; ���������� �������� eax, ���� ������� ������� ������
		skip:
		add esi, type parm1 ; ���������� ������ �� ������ ��������
	loop loop_start
	ret                  ; ������� ����������
getmax ENDP

end                    ; ����� ���������
