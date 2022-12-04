//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{

    //Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    int startMumber = inputNumber*(-1);
    
    //Выходное значение
    string outLine = string.Empty;

    while(startMumber<inputNumber)
    {
        outLine = outLine + startMumber + ",";
        startMumber++;
        //startNumber=startNumber+1;
    }
    outLine = outLine + inputNumber;

    //Выводим данные в консоль
        Console.WriteLine(outLine);
}
