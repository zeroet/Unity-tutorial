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
        //rigid.velocity = new Vector3(2, 4, 3);
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 1, ForceMode.Impulse);// 점프에 이 식 사용
            Debug.Log(rigid.velocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0,Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        rigid.AddTorque(Vector3.up);
    }

    private void OntriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);

    }
}
