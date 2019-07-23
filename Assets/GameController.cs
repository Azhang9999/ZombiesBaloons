using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject panel;
    public Text gameOverMessage;
    
    private LevelController _levelController;
    private double time;
    private double maxTime;

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
            time = Time.time;
        }
        else if (currentState == GAMESTATE.ON_PROGRESS)
        {
            if (_levelController.NumberOfZombiesAvailable() == 0)
            {
                if (_levelController.targetsRemaining > 0 || Time.time - time < maxTime)
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
            gameOverMessage.text = "Congratulations!";
            panel.SetActive(true);
        }
        else if (currentState == GAMESTATE.LOSING)
        {
            gameOverMessage.text = "Hey loser!";
            panel.SetActive(true);
        }
    }

    public void OnClick()
    {
        currentState = GAMESTATE.INITIALIZATION;//
        Application.LoadLevel(Application.loadedLevel);
    }
}
