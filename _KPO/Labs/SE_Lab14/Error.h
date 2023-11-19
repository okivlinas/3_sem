#pragma once

#define ERROR_THROW(id) Error::geterror(id);  // throw ERROR_THROW(id)
#define ERROR_THROW_IN(id, l, c) Error::geterrorin(id, l, c); // ERROR_THROW_IN(id, line, column)
#define ERROR_ENTRY(id, m) {id, m, {-1, -1}}    // входная точка ошибки
#define ERROR_MAXSIZE_MESSAGE 200   // максимальный размер сообщения об ошибке
#define ERROR_ENTRY_NODEF(id) ERROR_ENTRY(id, "Неопределенная ошибка") // 1 неопределенная ошибка
// ERROR_ENTRY_NODEF10(id) - 10 неопределенных ошибок
#define ERROR_ENTRY_NODEF10(id) ERROR_ENTRY_NODEF(id + 0), ERROR_ENTRY_NODEF(id + 1), ERROR_ENTRY_NODEF(id + 2), ERROR_ENTRY_NODEF(id + 3), \
                                ERROR_ENTRY_NODEF(id + 4), ERROR_ENTRY_NODEF(id + 5), ERROR_ENTRY_NODEF(id + 6), ERROR_ENTRY_NODEF(id + 7), \
                                ERROR_ENTRY_NODEF(id + 8), ERROR_ENTRY_NODEF(id + 9)
// ERROR_ENTRY_NODEF100(id) - 100 неопределенных ошибок
#define ERROR_ENTRY_NODEF100(id) ERROR_ENTRY_NODEF(id + 0), ERROR_ENTRY_NODEF(id + 10), ERROR_ENTRY_NODEF(id + 2), ERROR_ENTRY_NODEF(id + 3), \
                                 ERROR_ENTRY_NODEF(id + 40), ERROR_ENTRY_NODEF(id + 50), ERROR_ENTRY_NODEF(id + 6), ERROR_ENTRY_NODEF(id + 7), \
                                 ERROR_ENTRY_NODEF(id + 80), ERROR_ENTRY_NODEF(id + 90)
#define ERROR_MAX_ENTRY 1000    // максимальное количество ошибок в списке

namespace Error
{
    struct ERROR   // структура для обработки throw ERROR_THROW | ERROR_THROW_IN и catch(ERROR)
    {
        int id;   // идентификатор ошибки
        char message[ERROR_MAXSIZE_MESSAGE];  // сообщение об ошибке
        struct IN   // входная точка для указания строки и столбца
        {
            short line;   // номер строки (0, 1, 2, ...)
            short col;   // номер столбца в строке (0, 1, 2, ...)
        } inext;
    };

    ERROR geterror(int id); // получение объекта ERROR для ERROR_THROW
    ERROR geterrorin(int id, int line, int col);  // получение объекта ERROR для ERROR_THROW_IN
}