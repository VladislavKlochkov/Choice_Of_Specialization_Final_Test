# Описание решения задачи

## Описание методов
Для решения задачи используются 3 метода:
1. Метод создания массива *"CreateArray"*.
- Пользователь задает количество элементов массива вручную;
- Вводится цикл заполнения массива элементами, начиная с нулевого индекса, и выполняется до тех пор, пока индекс меньше заданной длины массива.
- Т.к. элемент с индексом "0" является первым элементом по счету, с помощью встроенной функции *"Console.WriteLine"* пользователю будет предложено ввести элементы массива, начиная с 1го.
- По завершении цикла метод возвращает массив.
---
2. Метод вывода массива *"PrintArray"*.
- Данный метод принимает на вход массив данных.
- Вводится цикл, который перебирает все элементы данного массива и выводит их в консоль.
---
3. Метод преобразования исходного массива данных в новый массив *"ArrayTransformation"*.
- На вход принимается исходный массив и максимальная размерность "size", которую задает пользователь, для поиска элементов меньшей или равной размерности.
- Вводится переменная "j" для подсчёта количества элементов, которые удовлетворяют условию:
``` 
array[i].Length <= size
```
- где "array[i].Length" - количество символов в элементе массива.
- Данное условие проверяется до тех пор, пока выполняется цикл перебора всех элементов массива.
- Далее вводится новый массив размерностью "j" и заполняется элементами (с индексом "k", начиная с k = 0), которые удовлетворяют условию 
>"array[i].Length <= size" 

- Пока выполняется условие индекс k увеличивается на единицу, а массив заполняется искомыми элементами.
- Метод возвращает массив с искомыми данными.
---
## Описание условий
- Т.к. размерность массива и размерность элемента не могут быть отрицательными, программа делает проверку исходных данных на "отрицательность".
- Если пользователь ввел некорректные данные, программа сообщит ему об этом.
- Если исходные данные введены корректно, программа обращается к методам, описанным выше, в следующем порядке:
1. **"CreateArray"** (Создается исходный массив данных).
2. **"PrintArray"** (Вывод в консоль исходного массива).
3. **"ArrayTransformation"** (Преобразование исходного массива данных в новый массив).
4. **"PrintArray"** (Вывод нового массива).