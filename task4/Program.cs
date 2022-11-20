// Найти максимальное из трех чисел

int a = 3;
int b = 5;
int c = 1;
int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);