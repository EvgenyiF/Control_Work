# **Задача**:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Решение 
 ## Первый вариант решения
1. Зададим массив с данными.
2. Проверим каждый элемент массива на количество симвлов и если их меньше либо равно 3, то посчитаем их и поставим их друг за дугом.
3. Обрежем массив до нужной нам длинны.
4. Выведем полученный массив в консоль.

 ## Второй вариант решения
1. Зададим массив с данными.
2. Проверим каждый элемент массива на количество симвлов и если их меньше либо равно 3, то посчитаем их и занесем в новый массив в методе. 
3. Выведем полученный массив в консоль.