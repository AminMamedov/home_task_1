

#region task1


//string ay = "yanvar";
//if (ay == "mart" || ay == "aprel" || ay == "may" || ay == "iyun")
//{
//    Console.WriteLine( "yaz");
//}
//else if (ay == "iyul" || ay == "avqust" || ay == "sentyabr")
//{
//    Console.WriteLine("yay");
//}
//else if (ay == "oktyabr" || ay == "noyabr " || ay == "dekabr")
//{
//    Console.WriteLine( "payiz");
//}
//else if (ay == "noyabr" || ay == "yanvar" || ay == "fevral")
//{
//    Console.WriteLine( "qis");
//}
//else
//{
//    Console.WriteLine( "yanlis ad daxil etdiniz");
//}
#endregion


//2.İnput olaraq integer bir dəyər gəlir siz bu ədədin neçə mərtəbəli olduğunu console-a yazdırmalısınız. Məs: input - 2543; ouptput - 4.

#region task2
int number = 300;
int mertebe = 0;
while (number > 0)
{
    number = number / 10;
    mertebe++;
}
Console.WriteLine("mertebe " + mertebe);
#endregion

//Daxil edilən ədədin faktorialını tapın. (3!=3*2*1). Məs: input - 3, output: 6

#region task3 
//int a = 10;
//int n ;
//int faktorial = 1;


//for( n= 1; n<= a; n++)
//{
//    faktorial= faktorial  * n;
//}
//    Console.WriteLine(faktorial);
#endregion
