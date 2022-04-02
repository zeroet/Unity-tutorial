using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anykey : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어  랜덤키 입력");    
    }
}
