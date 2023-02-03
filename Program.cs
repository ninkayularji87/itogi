string [] arr = {"hello", "yes", "no", "4", "world", "ok", "5", "task" };

int x = 0;

for( int i = 0; i< arr.Length; i++)
{
    if( arr[i].Length<4) 
    x++;
}    
string [] arr2 = new string [x];
    
void FillArray()
{
    int j = 0;
    for( int i = 0; i< arr.Length; i++)
    {
        if ( arr[i].Length < 4)
        {
            arr2[j] = arr[i];
            j++;
        }
    }
}


void PrintArray()
{
    for (int i = 0; i < arr2.Length; i++)
    {
        if (i < arr2.Length - 1) 
        Console.Write($"{arr2[i]}  ");
        else 
        Console.Write(arr2[i]);
    }
    Console.WriteLine();
}

FillArray();
PrintArray();


