using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    int Score = 0;

    float xMax = 2.5f;

    float yMax = 5f;

    public static GameManager Instance;

    public Text countScore;

    public GameObject endPop;

    public GameObject[] ball;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    { 
        spawnBall();

    }

    // Update is called once per frame
    void Update()
    {
        EndGame();
    }


    void EndGame()
    {
        if (Score >= 40)
        {
            endPop.SetActive(true);
        }
    }

    void spawnBall ()
    {
        foreach (GameObject ball in ball)
        {
            float xPos = Random.Range(-xMax, xMax);
            float yPos = Random.Range(0, yMax);
            xPos = Mathf.Clamp(xPos, -xMax + ball.transform.localScale.x, xMax - ball.transform.localScale.x);
            yPos = Mathf.Clamp(yPos, 0, yMax - ball.transform.localScale.y);
            Vector3 pos = new Vector3 (xPos, yPos, 1);
            Instantiate(ball, pos, Quaternion.identity);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");

        // A noob way to restart game
        //endPop.SetActive(false);
        //spawnBall();
        //Score = 0;
        //countScore.text = Score.ToString();
    }

    public void GetScore()
    {
        Score+=10;
        countScore.text = Score.ToString();
    }
}
