using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Myball : MonoBehaviour
{
    public int Score;
    public float jumpPower;
    bool isjump;
    Rigidbody rigid;
    AudioSource audio;
    public GameManager manager;

    void Awake()
    {
       rigid = GetComponent<Rigidbody>();
       isjump = false;
       audio = GetComponent<AudioSource>();
    }

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
        if (collision.gameObject.tag == "Floor")
            isjump = false; 
    }

    void   OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            Score++;
            audio.Play();
            other.gameObject.SetActive(false);
        }
        if (other.tag == "Finish")
        {
            if (Score == manager.totalItemCount)
                Debug.Log("Hello");
        }
    }
}
