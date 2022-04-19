using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MynewScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void   Update()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 
        Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
    }
}
