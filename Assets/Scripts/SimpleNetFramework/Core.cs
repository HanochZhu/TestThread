using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core 
{
    public delegate void CallBack<T>(T t);
    public delegate void CallBack();
    
    enum E_TYPE
    {
        
    }

    private static Dictionary<string, CallBack> eventHandler = new Dictionary<string, CallBack>();

    public static Queue<string> eventQueue = new Queue<string>(); 

    public static void AddEventListener(string key, CallBack func)
    {
        if (eventHandler.ContainsKey(key))
        {
            eventHandler[key] += func;
        }
        else
        {
            eventHandler.Add(key,func);
        }
    }

    public static void RegisterEvent(string key)
    {
        eventQueue.Enqueue(key);
    }


    public static void InvokeEvnet(string key)
    {
        eventHandler[key].Invoke();
    }


}
