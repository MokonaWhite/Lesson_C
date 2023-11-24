int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int num = array.Length; 
int find = 31;
int index = 0;

while (index < num)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
}
