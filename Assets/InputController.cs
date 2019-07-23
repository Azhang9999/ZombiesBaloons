using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public LevelController levelController;


    public void OnDeployButtonClick()
    {
        levelController.Deploy();
    }
}
