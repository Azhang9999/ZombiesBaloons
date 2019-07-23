using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Length: " + GameObject.FindGameObjectsWithTag("zombie").Length);

        if (GameObject.FindGameObjectsWithTag("zombie").Length == 0)
        {
            renderer.enabled = true;
        }
    }
}
