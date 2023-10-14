//Saturday Tasks

#region     Tek ededler
//Tək ədədlərin sayı
Console.WriteLine("Eded araliqini daxil edin:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int count = 0;
for (int i = num1; i < num2; i++)
{
    if (i % 2 == 1)
    {
        count = count + 1;
    }


}
Console.WriteLine(count);
#endregion



#region sade Murekkeb mueyyen et
//Sade yoxsa murekkeb
Console.WriteLine("Ededi daxil edin:");
int num = int.Parse(Console.ReadLine());
int divisor = 1;
int countDivisor = 0;
for (int a = divisor; a <= num; a++)
{
    if (num % a == 0)
    {
        countDivisor++;
    }

}
if (countDivisor > 2)
{
    Console.WriteLine("Daxil etdiyiniz eded murekkebdir");
}
else
{
    Console.WriteLine("Daxil etdiyiniz eded sadedir");
}
#endregion




#region             2 nin quvveti?
//2nin quvvetidirmi
Console.WriteLine("Ededi daxil edin:");
int power = 0;
int num = int.Parse(Console.ReadLine());
while (num % 2 == 0)
{
    num /= 2;
    power++;
}
if (num == 1)
{
    Console.WriteLine("Eded 2nin quvvetidir. " + "2^" + power + " demekdir");
}
else
{
    Console.WriteLine("Eded 2nin quvveti deyil");
}
#endregion




#region Mertebe sayi
//mertebe sayi
int a = int.Parse(Console.ReadLine());
int floor = 0;
while (a > 0)
{
    a /= 10;
    floor++;
}

Console.WriteLine("Daxil etdiyiniz eded " + floor + " mertebelidir");
#endregion
