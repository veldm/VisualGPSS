using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public partial class Block : Operator
    {
        public enum BlockType
        {
            /// <summary>
            /// Определяет точку входа транзакций в модель вместе
            /// с вероятностными характеристиками входящего потока. Попытка входа
            /// в данный блок другой транзакции приводит к ошибке. <para/>
            /// GENERATE [интервал],[разброс],[задержка],[ограничение],[приоритет]
            /// </summary>
            GENERATE,

            /// <summary>
            /// Уничтожает транзакции, входящие в него. Попытка захвата
            /// транзакцией блока всегда успешна<para/>
            /// TERMINATE [вычитаемое]
            /// </summary>
            TERMINATE,

            /// <summary>
            /// Задержка транзакции<para/>
            /// ADVANCE [интервал],[разброс]
            /// </summary>
            ADVANCE,

            /// <summary>
            /// Устанавливает заданное одноканальное устройство в состояние
            /// занятости входящей в него транзакцией<para/>
            /// SEIZE имя_устройства
            /// </summary>
            SEIZE,

            /// <summary>
            /// Освобождение устройства<para/>
            /// RELEASE имя_устройства
            /// </summary>
            RELEASE,

            /// <summary>
            /// Вход в очередь (статистика)
            /// </summary>
            QUEUE,

            /// <summary>
            /// Выход из очереди (статистика)
            /// </summary>
            DEPART,

            /// <summary>
            /// Точка входа в многоканальное устройство
            /// </summary>
            ENTER,

            /// <summary>
            /// Точка выхода из многоканальнго устройства
            /// </summary>
            LEAVE,

            /// <summary>
            /// 
            /// </summary>
            TRANSFER_V,

            /// <summary>
            /// 
            /// </summary>
            TRANSFER_BOTH,

            /// <summary>
            /// 
            /// </summary>
            TRANSFER_UNCON,

            /// <summary>
            /// 
            /// </summary>
            TRANSFER_ALL,

            /// <summary>
            /// 
            /// </summary>
            TRANSFER_PICK,

            /// <summary>
            /// 
            /// </summary>
            PREEMPT,

            /// <summary>
            /// 
            /// </summary>
            RETURN,

            /// <summary>
            /// 
            /// </summary>
            FUNAVAIL,

            /// <summary>
            /// 
            /// </summary>
            FAVAIL,

            /// <summary>
            /// 
            /// </summary>
            SUNAVAIL,

            /// <summary>
            /// 
            /// </summary>
            SAVAIL,

            /// <summary>
            /// 
            /// </summary>
            LOOP,

            /// <summary>
            /// 
            /// </summary>
            ASSIGN,

            /// <summary>
            /// 
            /// </summary>
            MARK,

            /// <summary>
            /// 
            /// </summary>
            TEST,

            /// <summary>
            /// 
            /// </summary>
            GATE,

            /// <summary>
            /// 
            /// </summary>
            SPLIT,

            /// <summary>
            /// 
            /// </summary>
            ASSEMBLE,

            /// <summary>
            /// 
            /// </summary>
            GATHER,

            /// <summary>
            /// 
            /// </summary>
            ADOPT,

            /// <summary>
            /// 
            /// </summary>
            MATCH
        }
    }
}
