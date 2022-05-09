string[] array = new string[] {"hello", "2", "world", ":-)"};
int count = 0;
int len = array.Length; 
for (int index = 0; index < len; index++)
{
    if (array[index].Length <= 3)
    {
        array[count++] = array[index];
    }
}
Array.Resize(ref array, count);
Console.WriteLine("[\"{0}\"]",string.Join("\", \"", array));