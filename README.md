# Итоговая проверочная работа

## Задание

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## Алгоритм решения

1. Так как по условию задачи нет жёстких требований к заданию массива, инициализируем его в самом начале.
2. Просим ввести критерий для отбора элементов массива. В данном случае у нас <= 3 символам.
3. В методе WorldsLessThan считаем колличество элементов удовлетворяющих требованию задачиБ чтобы использовать как длинну конечного массива.
4. В основном методе FillArray инициализируем массив результатов размером, полученным выше. В цикле проходим по каждой строке и сравниваем на каждой итерации длину строки с условием задачи (ограничение 3 символа). Записываем найденную строку в итоговый массив.
5. Печатаем результат методом PrintArray в консоль.

## Примеры массивов и результаты выводов

```
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
```

# Блок-схема основного метода

![Block_Shem](Block_Shem.png)