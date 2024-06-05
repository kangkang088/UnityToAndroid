using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidTest : MonoBehaviour {
    public Text textOld;
    public Text textNew;
    public Text textStaticOld;
    public Text textStaticNew;
    public Text textFunc;
    public Text textStaticFunc;
    AndroidJavaClass javaClass;
    AndroidJavaObject javaObject;

    public Button btnStart;
    void Start() {
        javaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        javaObject = javaClass.GetStatic<AndroidJavaObject>("currentActivity");

        int testI = javaObject.Get<int>("testI");
        textOld.text = testI.ToString();
        javaObject.Set<int>("testI",11);
        testI = javaObject.Get<int>("testI");
        textNew.text = testI.ToString();

        int staticI = javaObject.GetStatic<int>("testStaticI");
        textStaticOld.text = staticI.ToString();
        javaObject.SetStatic<int>("testStaticI",200);
        staticI = javaObject.GetStatic<int>("testStaticI");
        textStaticNew.text = staticI.ToString();

        string testFuncStr = javaObject.Call<string>("testFunc");
        textFunc.text = testFuncStr;
        string testsStaticFuncStr = javaObject.CallStatic<string>("testStaticFunc");
        textStaticFunc.text = testsStaticFuncStr;

        btnStart.onClick.AddListener(() => {
            javaObject.Call("OpenActivity");
        });
    }
    private void OnDestroy() {
        javaClass.Dispose();
        javaClass = null;
        javaObject.Dispose();
        javaObject = null;
    }
}
