using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson3 : MonoBehaviour
{
    public Text acu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TestAndroidCallUnity(string str) {
        acu.text = str;
    }
}
