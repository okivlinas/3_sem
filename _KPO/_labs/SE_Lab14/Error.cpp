#include "stdafx.h"
#include "Error.h"

namespace Error
{
    // Ñïèñîê îøèáîê:  0 - 99 - ñèñòåìíûå îøèáêè
    //                 100 - 109 - îøèáêè ëåêñè÷åñêîãî àíàëèçà
    //                 110 - 119 - îøèáêè ñèíòàêñè÷åñêîãî àíàëèçà è ñåìàíòèêè
    ERROR errors[ERROR_MAX_ENTRY] =
    {
        ERROR_ENTRY(0, "Íåèçâåñòíàÿ îøèáêà"),
        ERROR_ENTRY(1, "Íåêîğğåêòíàÿ êîìàíäà"),
        ERROR_ENTRY_NODEF(2), ERROR_ENTRY_NODEF(3), ERROR_ENTRY_NODEF(4), ERROR_ENTRY_NODEF(5),
        ERROR_ENTRY_NODEF(6), ERROR_ENTRY_NODEF(7), ERROR_ENTRY_NODEF(8), ERROR_ENTRY_NODEF(9),
        ERROR_ENTRY_NODEF10(10), ERROR_ENTRY_NODEF10(20), ERROR_ENTRY_NODEF10(30), ERROR_ENTRY_NODEF10(40), ERROR_ENTRY_NODEF10(50),
        ERROR_ENTRY_NODEF10(60), ERROR_ENTRY_NODEF10(70), ERROR_ENTRY_NODEF10(80), ERROR_ENTRY_NODEF10(90),
        ERROR_ENTRY(100, "Îòñóòñòâóåò àğãóìåíò -in äëÿ âõîäíîãî ôàéëà"), ERROR_ENTRY(101, "Íåêîğğåêòíûé àğãóìåíò -in äëÿ âõîäíîãî ôàéëà"),
        ERROR_ENTRY_NODEF(102), ERROR_ENTRY_NODEF(103),
        ERROR_ENTRY(104, "Îøèáêà ÷òåíèÿ âõîäíîãî ôàéëà"),
        ERROR_ENTRY_NODEF(105), ERROR_ENTRY_NODEF(106), ERROR_ENTRY_NODEF(107),
        ERROR_ENTRY_NODEF(108), ERROR_ENTRY_NODEF(109),
        ERROR_ENTRY(110, "Íå íàéäåí àğãóìåíò äëÿ óêàçàíèÿ âõîäíîãî ôàéëà (-in)"),
        ERROR_ENTRY(111, "Îøèáî÷íîå óêàçàíèå âõîäíîãî ôàéëà (-in)"),
        ERROR_ENTRY(112, "Íå íàéäåí àğãóìåíò äëÿ óêàçàíèÿ ëîã-ôàéëà (-log)"),
        ERROR_ENTRY(113, "Íå íàéäåí àğãóìåíò äëÿ óêàçàíèÿ âûõîäíîãî ôàéëà (-out)"),
        ERROR_ENTRY_NODEF(114), ERROR_ENTRY_NODEF(115),
        ERROR_ENTRY_NODEF(116), ERROR_ENTRY_NODEF(117), ERROR_ENTRY_NODEF(118), ERROR_ENTRY_NODEF(119),
        ERROR_ENTRY_NODEF10(120), ERROR_ENTRY_NODEF10(130), ERROR_ENTRY_NODEF10(140), ERROR_ENTRY_NODEF10(150),
        ERROR_ENTRY_NODEF10(160), ERROR_ENTRY_NODEF10(170), ERROR_ENTRY_NODEF10(180), ERROR_ENTRY_NODEF10(190),
        ERROR_ENTRY_NODEF100(200), ERROR_ENTRY_NODEF100(300), ERROR_ENTRY_NODEF100(400), ERROR_ENTRY_NODEF100(500),
        ERROR_ENTRY_NODEF100(600), ERROR_ENTRY_NODEF100(700), ERROR_ENTRY_NODEF100(800), ERROR_ENTRY_NODEF100(900)
    };

    ERROR geterror(int id)
    {
        return (id > 0 && id < ERROR_MAX_ENTRY) ? errors[id] : errors[0];
    }

    ERROR geterrorin(int id, int line = -1, int col = -1)
    {
        if (id > 0 && id < ERROR_MAX_ENTRY) {
            errors[id].inext.col = col;
            errors[id].inext.line = line;
            return errors[id];
        }
        else
            return errors[0];
    }
}