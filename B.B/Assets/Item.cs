using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float rotatespeed;
    
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime, Space.World);      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Myball player = other.GetComponent<Myball>();
            audio.Play();
            gameObject.SetActive(false);
            player.Score++;
        }
    }
}
