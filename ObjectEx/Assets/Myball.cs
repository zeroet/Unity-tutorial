using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);// 점프에 이 식 사용 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 0, 1);
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 1, ForceMode.Impulse);// 점프에 이 식 사용
            Debug.Log(rigid.velocity);
        }
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, 0, v);
        rigid.AddForce(vec, ForceMode.Impulse);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cu")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
    
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
