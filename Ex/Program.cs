Console.Clear();
//1
string[] array = { "Hello", "2", "world", ":-)" };
int size = array.Length;

//2
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

//3
string[] newarray = new string[count];

//4
int j = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        if (j < count)
        {
            newarray[j] = array[i];
            Console.Write(newarray[i] + ", ");
        }
        j++;
    }
}

//5
// for (int i = 0; i < count; i++)
// {
//     Console.Write(newarray[i] + ", ");
// }