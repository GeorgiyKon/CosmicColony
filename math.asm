section .text
global add_numbers

add_numbers:
    ; Входные параметры: a в EDI, b в ESI
    mov eax, edi  ; Копируем a в регистр EAX
    add eax, esi  ; Добавляем b к EAX
    ret            ; Возврат из функции
