using System;
using System.Threading;

Class Program
{
    static void Main()
    {
    Thread T1 = new Thread(PrintSeries(1,3))
    Thread T2 = new Thread(PrintSeries(1,4))
    Thread T3 = new Thread(PrintSeries(1,5))
    
    T1.start();
    T2.start();
    t3.start();    

	t1.Join();
    t2.Join();
    t3.Join();
    }
}

public static PrintSeries(int i , int max)
{
	for (int j = i; j < max; j++)
        {
		Console.WriteLine(i);
 		if (i < max)
                Console.Write(", ");
	}
}
