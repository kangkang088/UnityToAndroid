using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        using(AndroidJavaClass ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using(AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                ajo.Call("showToast", "Hello from Unity!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
