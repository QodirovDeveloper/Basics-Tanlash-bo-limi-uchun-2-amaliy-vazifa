using System;
System.Console.WriteLine("1. Vaqt kalkulyatori");
Console.Write("Daqiqalar sonini kiriting: ");
int daqiqalar = int.Parse(Console.ReadLine());

int soatlar = daqiqalar / 60;
int minutlar = daqiqalar % 60;

Console.WriteLine($"{soatlar}:{minutlar:D2}");

//============================================

System.Console.WriteLine("2. Yosh toifasini aniqlash");
Console.Write("Yoshingizni kiriting: ");
int yosh = int.Parse(Console.ReadLine());

string toifa;

if (yosh <= 12)
    toifa = "bola";
else if (yosh <= 19)
    toifa = "o'smir";
else if (yosh <= 59)
    toifa = "kattalar";
else
    toifa = "katta";

Console.WriteLine(toifa);    

//===================================

System.Console.WriteLine("3. O'rtacha ballni hisoblash");
Console.Write("1-fan bo'yicha ball: ");
int ball1 = int.Parse(Console.ReadLine());

Console.Write("2-fan bo'yicha ball: ");
int ball2 = int.Parse(Console.ReadLine());

Console.Write("3-fan bo'yicha ball: ");
int ball3 = int.Parse(Console.ReadLine());

double ortachaBall = (ball1 + ball2 + ball3) / 3.0;

string natija = ortachaBall >= 80 ? "A'lo" :
                ortachaBall >= 60 ? "Yaxshi" :
                ortachaBall >= 40 ? "Qoniqarli" : "Qoniqarsiz";

Console.WriteLine(natija);

//===================================

System.Console.WriteLine("4. Raqamni toping o'yini");
Random random = new Random();
int sirliRaqam = random.Next(1, 101);
int taxmin = -1;

while (taxmin != sirliRaqam)
{
    Console.Write("1 dan 100 gacha bo'lgan raqamni taxmin qiling: ");
    taxmin = int.Parse(Console.ReadLine());
    
    if (taxmin < sirliRaqam)
        Console.WriteLine("Taxminingiz kichik.");
    else if (taxmin > sirliRaqam)
        Console.WriteLine("Taxminingiz katta.");
    else
        Console.WriteLine("Tabriklaymiz! Siz to'g'ri topdingiz.");
}
