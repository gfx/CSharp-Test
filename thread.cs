using System;
using System.Threading;

class Test {
    static int i = 0;
    public static void Main() {
        Thread t1 = new Thread(Worker);
        Thread t2 = new Thread(Worker);
        Thread t3 = new Thread(Worker);
        t1.Start();
        t2.Start();
        t3.Start();
        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("i = {0}", i);
    }


    private static void Worker() {
        for(int j = 0; j < 1000; j++) {
            i++;
        }
    }
}
