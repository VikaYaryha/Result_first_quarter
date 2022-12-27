Console.Clear();
Console.Write("Введите строку: ");
string [] firstArray = Console.ReadLine().Split(" ");
string [] dopArray = new string [firstArray.Length];
int len = 3;
int i=0;
int j=0;

while ( i < firstArray.Length)
{
    if (firstArray[i].Length <= len)
    {
        dopArray[j] = firstArray[i];
        j++;
    }
    i++;
}
string [] secondArray = new string [j];
for (int k = 0; k<j; k++)
{
    secondArray[k]= dopArray[k];
}
Console.WriteLine($"[{string.Join(", ",  secondArray)}]");
