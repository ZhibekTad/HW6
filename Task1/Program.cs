// Пользователь вводит с клавиатуры М чисел. Посчитайте, 
// сколько чисел больше 0 ввел пользователь

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Кол-во элементов > 0: {count}");

