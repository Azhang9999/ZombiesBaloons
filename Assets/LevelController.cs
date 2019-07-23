using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Transform[] path;
    public GameObject[] zombies;
    public Text textAvailable;
    public int deploysAvailable;
    public int level = 1;

    private void Start()
    {
        deploysAvailable = level * 5;
    }

    private void Update()
    {
        textAvailable.text = "Deploy\n(" + deploysAvailable.ToString() + " Left)" ;
    }

    public void Deploy()
    {
        if (deploysAvailable > 0)
        {
            Instantiate(zombies);
            deploysAvailable--;
        }
    }
}
