// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int FindCoordinates(int arg)
 
{
 if (arg == 1 )
 {
    Console.Write("x = (0 --> ∞) : y = (0 --> ∞)");
 }

if (arg == 2 )
{
    Console.Write("x = (0 --> -∞) : y = (0 --> ∞)");
}
if (arg == 3 )
{
    Console.Write("x = (0 --> -∞) : y = (0 --> -∞)");
}
if (arg == 3 )
{
    Console.Write("x = (0 --> ∞) : y = (0 --> -∞)");
}
return 0;
}
 Console.WriteLine("Введите ноиер четверти ");
 int number_1_4 = int.Parse(Console.ReadLine());

 FindCoordinates(number_1_4);
