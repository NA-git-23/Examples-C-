int [] array = {1,43,7,3,4,16,779,408,49,16};
int n = array.Length;
int find = 16;
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
