# Control_work
## Задача:
Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше или равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*Примеры:*
["hello","2","world", ":-)"] -> ["2", ":-)"]
["1234", "1567","-2","computer science"] -> ["-2"]
["Russia","Denmark", "Kazan"] -> []
### Блок-схема алгоритма
[Ссылка на блок-схему](blockDiagram.png)

### Описание решения:
Для решения задачи сначала задаем количество элементов в строковом массиве методом InputNumbers;
Затем задаем массив строк ArrayString;
В методе arrStringNumElements 
* в массиве первым циклом находим количество элементов(count),размер которых меньше трех символов;
* задаем новый массив arrTemp с количеством элементов count найденных в предыдущем цикле, 
если количество не равно нулю; или массив arrTemp с количеством элементов 0;
* следующим циклом заполняем массив arrTemp элементами первого массива длина которых меньше трех символов.
Вывод массива вызовом метода PrintArray.
