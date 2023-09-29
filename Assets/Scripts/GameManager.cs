using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Обратите внимание на важность 

// этой строки для интерфейса 



public class GameManager : MonoBehaviour

{

    public Text scoreText;

    public Text gameOverText;



    int playerScore = 0;



    public void AddScore()

    {

        playerScore++;

        // Преобразует счет (число) в строку 

        scoreText.text = playerScore.ToString();

    }

    void Update()
    {

        // Выход из игры, если нажата клавиша Esc
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void PlayerDied()

    {

        gameOverText.enabled = true;


        // Приостанавливает игру 

        Time.timeScale = 0;

    }

}