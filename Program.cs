// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] a = { 1, 2, 10, 50, 5 };

int temp = 0;

for(int i=0; i<a.Length; i++) 
{
  for(int j = i + 1; j < a.Length; j++) 
  {

        if (a[i] > a[j]) 
        {
            temp = a[j];
            a[j] = a[i];
            a[i] = temp;
        }
  }
}
foreach(int i in a) 
{
    Console.WriteLine(i);
}