using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject lostScreen;

    private LevelController _levelController;

    public enum GAMESTATE {
        ON_PROGRESS, WINNING, LOSING, INITIALIZATION
    };

    private GAMESTATE currentState;

    // Start is called before the first frame update
    void Start()
    {
        _levelController = GameObject.FindGameObjectWithTag("LevelGrid").GetComponent<LevelController>();
        currentState = GAMESTATE.INITIALIZATION;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == GAMESTATE.INITIALIZATION)
        {
            currentState = GAMESTATE.ON_PROGRESS;
        }
        else if (currentState == GAMESTATE.ON_PROGRESS)
        {
            if (_levelController.NumberOfZombiesAvailable() == 0)
            {
                if (_levelController.targetsRemaining > 0)
                {
                    currentState = GAMESTATE.LOSING;
                } else
                {
                    currentState = GAMESTATE.WINNING;
                }
            }
        }
        else if (currentState == GAMESTATE.WINNING)
        {
            winScreen.SetActive(true);
            EndGameAction();
        }
        else if (currentState == GAMESTATE.LOSING)
        {
            lostScreen.SetActive(true);
            EndGameAction();
        }
    }

    private void EndGameAction()
    {
        
    }
}
