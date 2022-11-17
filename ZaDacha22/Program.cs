Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третье число -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьего числа нет");
}

