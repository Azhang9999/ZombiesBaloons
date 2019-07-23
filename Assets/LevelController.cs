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

    private void Start()
    {
        deploysAvailable = level * 5;
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
            Instantiate(zombies);
            deploysAvailable--;
            currency -= 120;
        }
    }
}
