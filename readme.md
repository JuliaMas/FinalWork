## Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Решение задачи

По условиям задачи, первоначальный массив можно ввести с клавиатуры.

Сначала необходимо ввести количество строк массива (ввод реализован в виде функции *InputNumbers*), затем заполнить этот массив.

Переменная *length* - по условиям задачи равна **3**

*CheckArray* - метод подсчёта количества элементов, размер которых меньше *length*
Подсчёт осуществляется перебором элементов массива *arrStrings* и сравнением количества их элементов с переменной *length*.
Результат выводится в переменную *Items*.
Инициализируется новый массив строк *newArray*, размером, равным переменной *Items*.

*FillNewArray* - метод, который формирует новый массив строк (элементы массива *arrStrings* сравниваются с *length*, затем элементы удовлетворяющие условию задачи добавляются в массив *finalArray*).
*PrintArray* - выводит на экран полученный массив.