using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Test : MonoBehaviour
{
    private int count;
    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //ここに処理を書いていく
            count++;
            Debug.Log("スペースキーが押された回数：" + count);
        }
    }
}
