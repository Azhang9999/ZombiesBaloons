using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform!=null)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, target.position - transform.position);
        }
    }
}
