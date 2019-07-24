using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public List<ZombiePath> path;
    public GameObject[] zombies;
    public Text textAvailable;
    public int deploysAvailable;
    public int level = 1;
    public int currency = 0;
    public Text textCurrency;
    public int targetsRemaining;
    public Text textRemaining;

    private void Start()
    {
        init();
    }

    private void Update()
    {
        textAvailable.text = "Deploy\n(" + deploysAvailable.ToString() + " Left)" ;
        textCurrency.text = currency.ToString() + " Gold Coins";
        textRemaining.text = targetsRemaining.ToString() + " Targets Remaining";
        currency++;
    }

    public void init()
    {
        deploysAvailable = level * 15;
        targetsRemaining = (int)(deploysAvailable * 0.6f);
    }
	
    public void Deploy(int choice, int cost, int pathIndex)
    {
        if (deploysAvailable > 0 && currency > cost)
        {
            GameObject zom = Instantiate(zombies[choice]);
            zom.GetComponent<ZombieController>().SetPath(pathIndex);
            deploysAvailable--;
            currency -= cost;
        }
    }

    public int NumberOfZombiesAvailable()
    {
        return deploysAvailable + GameObject.FindGameObjectsWithTag("zombie").Length;
    }
}
