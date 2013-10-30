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
		
		//If u have many timer 
		//u also can serval frame call one time to save some performance, but the deltaTime u should calculate youself
		//like :(u should define lastTime youself-- float)
		
		/*
		if(Time.frameCount%5 == 0)
		{
			delta = Time.time - lastTime;
			test.Update(Time.deltaTime);
			lastTime = Time.time;
		}
		*/
		
        test.Update(Time.deltaTime);
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
