using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject arrow;

    public float radius = 15f;
    public int frequency = 30;
    public int shotNumbers = 1;
    private int currentShot;

    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        currentShot = shotNumbers;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("zombie");

        for (int i = 0, length = zombies.Length; i < length; i++)
        {
            float dist = Vector2.Distance(zombies[i].transform.position, this.transform.position);

            if (radius > dist && counter % frequency == 0 && currentShot != 0)
            {
                GameObject arrowTemp = Instantiate(arrow);
                FollowPath followPath = arrowTemp.GetComponent<FollowPath>();
                var points = new Transform[2];
                points[0] = this.transform; // tower poisition
                points[1] = zombies[i].transform; // zombie position

                followPath.Init(points, 10f);
                currentShot--;
            }
        }
        currentShot = shotNumbers;
        counter++;
    }
}
