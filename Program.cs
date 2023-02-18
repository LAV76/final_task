
List<string> array = new List<string>();
Console.WriteLine("Построчно заполните массив по окончании нажмите Esc");
do
{
    array.Add(Console.ReadLine()!); 
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);

array.RemoveAll(person => person.Length > 3);
Console.WriteLine($"Массив содержащий строки в которых не более 3 символов: [{String.Join (",",array)}]");