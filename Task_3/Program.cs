// Напишите программу, которая задает массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = createArray(number);
string printedArray = printArray(arr);

Console.WriteLine(number + " -> " + printedArray);

int[] createArray(int num)
{
    int[] result = new int[num];
    var rand = new Random();
    
    for (int i = 0; i < num; i++) {
        result[i] = rand.Next(0, 100);
    }

    return result;
}

string printArray(int[] arr)
{
    string result = "";
    for (int i = 0; i < arr.Length; i++) {
        if (i == 0) {
            result += "[";
        }
        result += arr[i];
        if (i <= arr.Length - 2) {
            result += ", ";
        } else {
            result += "]";
        }
    }

    return result;
}
