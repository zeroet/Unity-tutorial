using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MynewScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    Vector3 target = new Vector3(8, 1.5f, 0);

    void   Update()
    {
       // transform.position = 
        //Vector3.MoveTowards(transform.position, target, 2f);

        //2. SmmothDamp
       // Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
    
        //3. Lerp (선형 보간)
       // transform.position = 
        //Vector3.Lerp(transform.position, target, 0.1f);
    
        //4.SLerp (구면 선형)
        transform.position = 
        Vector3.Slerp(transform.position, target, 0.05f);
    }
}
