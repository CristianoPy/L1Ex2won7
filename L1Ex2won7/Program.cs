/*Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura*/

int num1;
Console.WriteLine("Introduce primul numar: ");
num1 = Convert.ToInt32(Console.ReadLine());

int num2;
Console.WriteLine("Introduce al doilea număr: ");
num2 = Convert.ToInt32(Console.ReadLine());

int num3;
Console.WriteLine("Introduce al treilea număr: ");
num3 = Convert.ToInt32(Console.ReadLine());

int media = (num1 + num2 + num3) / 3;

Console.WriteLine("Media aritmetica a trei numere este :" +  media);

Console.ReadLine();