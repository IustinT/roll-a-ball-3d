using UnityEngine;
using System.Collections;

public class GameControler : MonoBehaviour
{
    public GUIText countText;
    public GUIText winText;
    public GUIText gameOverText;
    public GUIText restartText;
    private int count;
    private bool gameOver;
    private bool restart;


    // Use this for initialization
    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";

        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            restartText.text = "Press 'R' for Restart!";
            restart = true;
        }

        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    public void IncrementScore()
    {
        count++;
        SetCountText();
    }

    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12)
        {
            winText.text = "YOU WIN!";
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
