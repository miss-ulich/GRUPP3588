﻿
//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Вариант1
//Получаем новое случайное число
//int number = numberSintezator.Next(10, 100);
//Выводим данные в консоль
//Console.WriteLine(number);
//Получаем первое и второе число поотдельности
//int firstNumber = number/10;
//int secondNumber = number%10;
//Сравниваем числа
//if (firstNumber > secondNumber)
//{
    //Выводим данные в консоль
    //Console.WriteLine(firstNumber);
//}
//else
//{
    //Выводим данные в консоль
    //Console.WriteLine(secondNumber);
//}

//Вариант2
char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);

int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber > secondNumber? resultNumber = firstNumber : resultNumber = secondNumber;

Console.WriteLine(resultNumber);
