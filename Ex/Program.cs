Console.Clear();

string[] array = { "Hello", "2", "world", ":-)" };
int size = array.Length;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

string[] newarray = new string[count];
int j = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        if (j < count)
        {
            newarray[j] = array[i];
            Console.Write(newarray[j]+", ");
        } 
        j++;       
    }    
}

