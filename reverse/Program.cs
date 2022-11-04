char[] arr = { 'h', 'e', 'l', 'l', 'o' };

int i = 0;

while (i <= arr.Length - i)
{
    char c = arr[i];
    arr[i] = arr[arr.Length - i];
    arr[arr.Length - 1] = c;
}


for (int j = 0; j < arr.Length; j++)
{
    Console.WriteLine(arr[i]);
}