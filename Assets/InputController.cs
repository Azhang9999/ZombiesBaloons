﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public LevelController levelController;
    public int zombieChoice = 0;
    public int zombieCost = 240;

    public void OnZombie0Click()
    {
        zombieChoice = 0;
        zombieCost = 240;
    }

    public void OnZombie1Click()
    {
        zombieChoice = 1;
        zombieCost = 200;
    }

    public void OnZombie2Click()
    {
        zombieChoice = 2;
        zombieCost = 240;
    }

    public void OnDeployButtonClick()
    {
        levelController.Deploy(zombieChoice, zombieCost, 0);
    }

    public void OnDeployButton1Click()
    {
        levelController.Deploy(zombieChoice, zombieCost, 1);
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
