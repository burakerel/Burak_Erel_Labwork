using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{


    private void Start()
    {
        //Invoke(nameof(FrameThree), 3);
        StartCoroutine(FrameThree());
        print("Start World");
    }

    IEnumerator FrameThree()
    {
        yield return new WaitForSeconds(Time.deltaTime * 1);
        print("Hello World");
    }

    private void Awake()
    {
        
    }
}
