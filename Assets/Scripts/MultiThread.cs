using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class MultiThread
{
    List<Thread> Threads = new List<Thread>();
    public void CreatAThread()
    {
        Thread t = new Thread(ThreadTest);

        t.Start();
        Debug.Log(t.ManagedThreadId);
        Debug.Log(Thread.CurrentThread.ManagedThreadId);
    }

    public void ThreadTest()
    {
        Debug.Log("Thread Test");
        for(int i = 0;i < 10;i ++)
        {
            Debug.Log("Thread Test" + i);

        }
            
        Core.RegisterEvent("creatgo");
    }

}
