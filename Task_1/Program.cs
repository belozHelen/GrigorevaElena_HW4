// Напишите цикл, который принимает на вход два числа (А и B) и возводит число А в натуральную степень B.
// 3, 5 -> 243 (3 в пятой степени)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a + "^" + b + " = " + stepen(a, b));

int stepen(int a, int b) {
    int result = 1;

    for (int i = 0; i < b; i++) {
        result = result * a;
    }
          
    return result;
}
