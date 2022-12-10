//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int num = numberSintezator.Next(100, 1000);
Console.WriteLine (num);

//int result = (num/100)*10 + num%10;

//Выводим данные в консоль
Console.WriteLine((num/100)*10 + num%10);
