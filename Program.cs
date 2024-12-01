Console.WriteLine("Здравствуйте, введите число и проверьте является ли оно полиндромом");
int polindrome = Convert.ToInt32(Console.ReadLine());
int copyPolindrome = polindrome;
int backPolindrome = 0;
Console.WriteLine("Вы ввели: " + polindrome);
do
{
    int temp = polindrome % 10;
    backPolindrome = backPolindrome * 10 + temp;
    polindrome /= 10;
} 
while (polindrome != 0);
if (backPolindrome == copyPolindrome)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}
