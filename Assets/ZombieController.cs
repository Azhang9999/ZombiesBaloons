using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetPath(int path)
    {
        GetComponent<FollowPath>().Init(GameObject.FindGameObjectWithTag("LevelGrid").GetComponent<LevelController>().path[path].getPath(), speed);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
