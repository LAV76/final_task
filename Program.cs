
string[] array = {"один", "two", "three", "four", "five", "six", "su", ".", " ", "2"};
int i = 0, j = 0;
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
Console.WriteLine($"[{String.Join (",",arr)}]");