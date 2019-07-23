using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public LevelController levelController;
    public int zombieChoice = 0;

    public void OnZombie0Click()
    {
        zombieChoice = 0;
    }

    public void OnZombie1Click()
    {
        zombieChoice = 1;
    }

    public void OnZombie2Click()
    {
        zombieChoice = 2;
    }

    public void OnDeployButtonClick()
    {
        levelController.Deploy(zombieChoice);
    }
}
