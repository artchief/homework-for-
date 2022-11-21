// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int num =Convert.ToInt32(Console.ReadLine());

int negNum= 1;

while (negNum<=num)
{
    Console.WriteLine(negNum);
    // negNum=negNum+1 тоже самое
    // negNum+=1
    negNum++;
}
if (negNum%2==0);