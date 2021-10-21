using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Control : MonoBehaviour
{
    public int player_lives = 3;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        player_lives --;
        if (player_lives >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //SceneManager.GetActiveScene().buildIndex or "Game Over"
        }
        else
        {
            SceneManager.LoadScene("Game Over");
        }
         
    }

    public void addScore(int amount)
    {
        score += amount;
    }
}
