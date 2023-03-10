**Задача**: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры*:  
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

## Ход решения
* ввод первоначального массива с клавиатуры
* создание дополнительного пустого массива с длиной как у первоначального
* заводим значение индекса и ставим условие в цикле "пока индекс меньше длины первоначального массива"
* в теле цикла присваиваем поочередно значения элементов первого массива элементам дополнительного массива, если длинна данного элемента меньше или равна 3
* после выхода из цикла, получаем массив с, возможно, еще пустыми элементами
* чтобы на выходе убрать вывод массива с пустыми элементами, создаем второй (окончательный) массив с количеством элементов, которые удовлетворили условие
* через цикл *for* перезаписываем "непустые" элементы
* выводим в терминал второй результирующий массив, который и является ответом

__*Схема алгоритма:*__  ![схема](схема_алгоритма.png)