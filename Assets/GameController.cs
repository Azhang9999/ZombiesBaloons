using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public GameObject panel;
    public Text gameOverMessage;
    public Text timer;
    
    private LevelController _levelController;
    private double time;
    public double maxTime = 60;
    private List<ZombiePath> path;
    public GameObject tower;
    private int towerNumber = 0;



    public enum GAMESTATE {
        ON_PROGRESS, WINNING, LOSING, INITIALIZATION
    };

    private GAMESTATE currentState;

    // Start is called before the first frame update
    void Start()
    {
        _levelController = GameObject.FindGameObjectWithTag("LevelGrid").GetComponent<LevelController>();
        currentState = GAMESTATE.INITIALIZATION;
        path = _levelController.path;
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
            if ((Time.time - time) / 2 > towerNumber)
            {
                SpawnTowers();
                towerNumber++;
            }
            timer.text = "Time Left: " + ((int)(_levelController.maxTime - (Time.time - time))).ToString();
            if(_levelController.targetsRemaining == 0)
            {
                currentState = GAMESTATE.WINNING;
            }
            else if(_levelController.NumberOfZombiesAvailable() < _levelController.targetsRemaining || (Time.time - time) > _levelController.maxTime)
            {
                currentState = GAMESTATE.LOSING;
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

    public void SpawnTowers()
    {
        // Generate the coordinates of the new tower
        float xPos = (float)Random.Range(-9.0f, 9.0f);
        int index = 0;
        int pathNumber = Random.Range(0, path.Count);
        while (path[pathNumber].getPath()[index].transform.position.x < xPos)
        {
            index++;
        }
        float topBottom = Random.Range(0.0f, 1.0f);
        float yPos = path[pathNumber].getPath()[index - 1].transform.position.y;
        if (topBottom > 0.5)
        {
            yPos += 1.0f;
        } else
        {
            yPos -= 1.0f;
        }
        // Generate new tower
        GameObject newTower = Instantiate(tower);
        newTower.transform.position = new Vector2(xPos, yPos);
    }
}
