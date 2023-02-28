NaturalDegree();
SumOfDigits();
ArrayElements();




//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
#region 
	 static void NaturalDegree()
	{
		Console.Write($" Enter the number: ");
		int a = Convert.ToInt32(Console.ReadLine());

		Console.Write($" Degree: ");
		int b = Convert.ToInt32(Console.ReadLine());

		int resalt = 1;

		for (int i = 0; i < b; i++)
		{
			resalt *= a;
		}
		Console.WriteLine($" Resalt: " + resalt);
	}
#endregion


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
#region 

static void SumOfDigits()
{
 Console.Write($" Enter the number: ");
 int num = Convert.ToInt32(Console.ReadLine());

  int sum = 0;
  while( num > 0 )
 {
	sum = sum + num % 10;
	num = num / 10;
 }
 Console.WriteLine($" Sum of digits: " + sum);

}

#endregion


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

#region 

static void ArrayElements()
{

 Random rnd = new Random();
 int[] arr = new int [8];

 for (int i = 0; i < arr.Length; i++)
 {
	arr[i] = rnd.Next( 1 , 100 );
    Console.Write( "  " + Medhod(i) + "  " );
 }
  

  int Medhod( int a )
 {
	return arr[a];
 }
}


#endregion




