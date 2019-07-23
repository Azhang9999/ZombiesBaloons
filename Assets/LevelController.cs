using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Transform[] path;
    public GameObject zombie;
    public Text textAvailable;
    public int deploysAvailable;
    public int level = 1;
    public int currency = 0;
    public Text textCurrency;
    public int targetsRemaining;

    private void Start()
    {
        deploysAvailable = level * 5;
        targetsRemaining = deploysAvailable / 2;
    }

    private void Update()
    {
        textAvailable.text = "Deploy\n(" + deploysAvailable.ToString() + " Left)" ;
        textCurrency.text = currency.ToString() + " Gold Coins";
        currency++;
    }

    public void Deploy()
    {
        if (deploysAvailable > 0 && currency > 120)
        {
            Instantiate(zombie);
            deploysAvailable--;
            currency -= 120;
        }
    }

    public int NumberOfZombiesAvailable()
    {
        return deploysAvailable + GameObject.FindGameObjectsWithTag("zombie").Length;
    }
}
