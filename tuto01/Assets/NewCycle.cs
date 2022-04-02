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
    void    FixedUpdate()
    {
        //physical operation fcn 
        Debug.Log("moveeee!!!");
    }

    // Game logic area

    void    Update()
    {
       if (Input.anyKeyDown)
        Debug.Log("플레이어 키 입력");

       if (Input.GetKeyDown(KeyCode.Return))
        Debug.Log("아이템을 구입");

        if (Input.GetKey(KeyCode.LeftArrow))
        Debug.Log("왼쪽으로 이동중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
        Debug.Log("오른쪽으로 이동");
    
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중 ");

        if (Input.GetMouseButtonUp(0))
        Debug.Log("미사일 발사 !");


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
