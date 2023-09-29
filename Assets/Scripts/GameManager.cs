using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // �������� �������� �� �������� 

// ���� ������ ��� ���������� 



public class GameManager : MonoBehaviour

{

    public Text scoreText;

    public Text gameOverText;



    int playerScore = 0;



    public void AddScore()

    {

        playerScore++;

        // ����������� ���� (�����) � ������ 

        scoreText.text = playerScore.ToString();

    }

    void Update()
    {

        // ����� �� ����, ���� ������ ������� Esc
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void PlayerDied()

    {

        gameOverText.enabled = true;


        // ���������������� ���� 

        Time.timeScale = 0;

    }

}