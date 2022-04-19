using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCycle : MonoBehaviour
{
    void    Awake()
    {
        Debug.Log("Player Data is Init!");
    }

    void    OnEnable()
    {
        Debug.Log("Player Login !!!");
    }

    void    Start()
    {
        Debug.Log("Player take the weapon!");
    }
    //물 리 연 산 함 수 
    /*void    FixedUpdate()
    {
        //physical operation fcn 
        Debug.Log("moveeee!!!");
    }*/

    // Game logic area

    void    Update()
    {
       if (Input.anyKeyDown)
        {
            Debug.Log("플레이어 키 입력");
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동" + Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동중" + Input.GetAxisRaw("Vertical"));
        }

    }

    void    LastUpdate()
    {
        Debug.Log("level up!");
    }

    void    OnDisable()
    {
        Debug.Log("Player LogOut");

    }

    void    OnDestroy()
    {
        Debug.Log("end game");
    }

}
