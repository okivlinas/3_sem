.586P													
.MODEL FLAT, STDCALL									
includelib kernel32.lib									
includelib user32.lib

ExitProcess PROTO : DWORD								
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD	

.STACK 4096												

.DATA												
		a dd 3											
		b dd 5
		str0 db "НАЗВАНИЕ ОКНА", 0								
		str1 db "РЕЗУЛЬТАТ = < >", 0


.CODE													
main PROC												
start:													
		mov eax, a
		add eax, b
		add eax, 30h
		
		mov str1+13, al									;младшая половина подрегистра
		
		invoke MessageBoxA, 0, offset str1, offset str0, 0

		push 0											
		call ExitProcess								

main ENDP											

end main