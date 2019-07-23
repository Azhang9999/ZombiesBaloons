using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<FollowPath>().Init(GameObject.FindGameObjectWithTag("LevelGrid").GetComponent<LevelController>().path, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
