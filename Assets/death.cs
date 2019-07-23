using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public int hitPoints = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] arrows = GameObject.FindGameObjectsWithTag("arrow");

        for (int i = 0; i < arrows.Length; i++)
        {
            //Debug.Log(Vector2.Distance(arrows[i].transform.position, this.transform.position));
            if (Vector2.Distance(arrows[i].transform.position, this.transform.position) < 0.15f)
            {
                hitPoints--;
                GameObject.Destroy(arrows[i]);

                if (hitPoints == 0)
                {
                    GameObject.Destroy(gameObject);
                } 
            }
        }
        
    }
}
