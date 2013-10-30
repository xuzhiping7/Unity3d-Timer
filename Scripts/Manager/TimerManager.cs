using UnityEngine;
using System.Collections;

public class TimerManager : MonoBehaviour
{
    Timer test;

	// Use this for initialization
	void Start () {
        test = new Timer(3.0f);
        test.tick += Test;
        test.tick += Test2;
        test.Start();
	}
	
	// Update is called once per frame
	void Update () {
        test.Update();
	}
	
	//Some time u may need this to avoid conflict when re-init something , just a tip .
	void OnDestory(){
	    test.tick -= Test;
        test.tick -= Test2;
	}
	
    void Test()
    {
        Debug.Log("1");
    }


    void Test2()
    {
        Debug.Log("2");
    }
}
