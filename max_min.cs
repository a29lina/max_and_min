int a = 5;
int b = 7;
int max = a;
int min = a;

//if (a > a) max = a;
//if (a < a) min = a;
if (b > a) max = b;
if (b < a) min = b;

Console.WriteLine ($"max = {max}");
Console.WriteLine ($"min = {min}");
