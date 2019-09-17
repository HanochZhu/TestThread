using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainProject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Core.AddEventListener("creatgo",CreatAGameObjectInScene);
        
        MultiThread mt = new MultiThread();
        mt.CreatAThread();
    }

    private void Update() {
        if (Core.eventQueue.Count  != 0)
        {
            Core.InvokeEvnet(Core.eventQueue.Dequeue());
        }
    }


    public void CreatAGameObjectInScene()
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
