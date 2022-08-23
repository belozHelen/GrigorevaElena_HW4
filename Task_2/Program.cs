// Напишите программу, которая ринимает на вход число и выдает сумму цифр в числе. 
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// решение через деление на 10
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number % 10 != 0) {
    result += number % 10;
    number = number / 10;
}

Console.WriteLine(result);
// конец решения через деление на 10




// решение через строки
// Console.Write("Введите число: ");

// string? numberString = Console.ReadLine();

// int result = 0;

// if (numberString != null) {
//     int len = numberString.Length;
//     for (int i = 0; i < len; i++) {
//         result += Convert.ToInt32(numberString[i].ToString());
//     }
// }

// Console.WriteLine(result.ToString());
// конец решения через строки