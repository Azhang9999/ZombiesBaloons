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
    public int currency = 0;
    public Text textCurrency;
    public int targetsRemaining;

    private void Start()
    {
        init();
    }

    private void Update()
    {
        textAvailable.text = "Deploy\n(" + deploysAvailable.ToString() + " Left)" ;
        textCurrency.text = currency.ToString() + " Gold Coins";
        currency++;
    }

    public void init()
    {
        deploysAvailable = level * 10;
        targetsRemaining = deploysAvailable / 2;
    }
	
    public void Deploy(int choice, int cost)
    {
        if (deploysAvailable > 0 && currency > cost)
        {
            Instantiate(zombies[choice]);
            deploysAvailable--;
            currency -= cost;
        }
    }

    public int NumberOfZombiesAvailable()
    {
        return deploysAvailable + GameObject.FindGameObjectsWithTag("zombie").Length;
    }
}
