using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public LevelController levelController;
    public int zombieChoice = 0;
    public int zombieCost = 120;

    public void OnZombie0Click()
    {
        zombieChoice = 0;
        zombieCost = 120;
    }

    public void OnZombie1Click()
    {
        zombieChoice = 1;
        zombieCost = 240;
    }

    public void OnZombie2Click()
    {
        zombieChoice = 2;
        zombieCost = 240;
    }

    public void OnDeployButtonClick()
    {
        levelController.Deploy(zombieChoice, zombieCost);
    }

    public void OnGotoButtonClick1()
    {
        Application.LoadLevel("DoubleZombieScene 1");
    }

    public void OnGotoButtonClick2()
    {
        Application.LoadLevel("DoubleZombieScene");
    }
}
