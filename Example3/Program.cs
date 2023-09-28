// 

int [] array = {11,21,3,4,15,6,7,18,15};

int n = array.Length;
int find = 15;


int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}