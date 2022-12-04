//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
    // //Создаем массив с днями недели
    // string[] dayofWeek = new string[7];
    // dayOfWeek[0] = "понедельник";
    // dayOfWeek[1] = "вторник";
    // dayOfWeek[2] = "среда";
    // dayOfWeek[3] = "четверг";
    // dayOfWeek[4] = "пятница";
    // dayOfWeek[5] = "суббота";
    // dayOfWeek[6] = "воскресенье";
        //Парсим введеное число
        int inputNumber = int.Parse(inputLine);
    // //Находим название дня недели по введенному номеру
    //string outDayOfWeek = dayOfWeek[inputNumber-1];
    // switch (inputNumber)    
    // {
    //      case1: outDayOfWeek = "понедельник"; break;
    //      case2: outDayOfWeek = "вторник"; break;
    //      case3: outDayOfWeek = "среда"; break;
    //      case4: outDayOfWeek = "четверг"; break;
    //      case5: outDayOfWeek = "пятница"; break;
    //      case6: outDayOfWeek = "суббота"; break;
    //      case7: outDayOfWeek = "воскресенье"; break;
    //      default: outDayOfWeek = "'это не день недели"; break;
    // }

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));

        //Выводим данные в консоль
        Console.WriteLine(outDayOfWeek);
}
