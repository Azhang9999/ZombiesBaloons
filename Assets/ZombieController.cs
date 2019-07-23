using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<FollowPath>().Init(GameObject.FindGameObjectWithTag("LevelGrid").GetComponent<LevelController>().path, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
