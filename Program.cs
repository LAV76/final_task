
string[] array = {"один", "two", "three", "four", "five", "six", "su", ".", " ", "2"};
int i = 0, j = 0;
Console.WriteLine("Построчно заполните массив по окончании нажмите Esc");
do
{
    
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);

foreach (string item in array)
{
    if (item.Length < 4) i++;
}
string[] arr = new string[i];

foreach (string item in array)
{
    if (item.Length < 4) 
    {
        arr[j] = item;
        j++;
    }
}
Console.WriteLine($"Исходный массив: [{String.Join (",",array)}]");
Console.WriteLine($"Массив содержащий строки в которых не более 3 символов: [{String.Join (",",arr)}]");