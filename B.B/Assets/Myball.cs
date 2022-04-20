using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    // Start is called before the first frame update
    public int Score;
    public float jumpPower;
    bool isjump;
    Rigidbody rigid;
    void Awake()
    {
       rigid = GetComponent<Rigidbody>();
       isjump = false;
    }

    // Update is called once per frame
    void  Update()
    {
        if(Input.GetButtonDown("Jump") && !isjump)
         {   
            isjump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
         }
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, 0, v);
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
            isjump = false;
    }
}
