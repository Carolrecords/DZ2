Console.Write("Введите пожалуйста цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день недели является выходным) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это день недели, вообще не день недели)");
  }
  else Console.WriteLine("(этот день недели не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);

