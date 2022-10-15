// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*int ShowSecond(int num)
{
    int one = num % 10;
    int two = num /100;
    int result = (num - two * 100 - one) / 10;
    return result;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Second digit is: {ShowSecond(number)}");*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*Console.Write("Digit number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
    if (anyNumberText.Length > 2)
        {
            Console.WriteLine("Third digit is: " + anyNumberText[2]);
        }
    else 
    {
        Console.WriteLine("Third digit not available");
    }*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.Write("Input a number of the day : ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void HolidayOrWork (int dayNum) 
{
  if (dayNum == 6 || dayNum == 7) 
  {
  Console.WriteLine("Holiday");
  }
  else if (dayNum < 1 || dayNum > 7) 
  {
    Console.WriteLine("Number is not available");
  }
  else Console.WriteLine("Work");
}

HolidayOrWork(dayNum);*/
