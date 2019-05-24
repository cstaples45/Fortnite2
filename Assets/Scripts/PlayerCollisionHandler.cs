using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollisionHandler : MonoBehaviour
{

    public Transform Player1;
    public Transform Player2;

    public Text Player1ScoreDis;
    public Text Player2ScoreDis;

    public static int Player1Score = 10;
    public static int Player2Score = 10;

    public AudioSource DeathSound;


    private void Start()
    {
        Player1Score = 10;
        Player2Score = 10;
        Player1ScoreDis.text = Player1Score.ToString();
        Player2ScoreDis.text = Player2Score.ToString();
    }

    public void UpdatePlayer1()
    {
        //Player1 score goes up
        Player2Score = Player2Score - 1;
        Player2ScoreDis.text = Player2Score.ToString();
        //Player 2 Position reset
        Player2.position = new Vector3(4.94f, 6.23f, -1f);
        DeathSound.Play();
        if (Player2Score == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void UpdatePlayer2()
    {
        //Player2 score goes up
        Player1Score = Player1Score - 1;
        Player1ScoreDis.text = Player1Score.ToString();
        //Player 1 Position reset
        Player1.position = new Vector3(Random.Range(0,10), 6.23f, -1f);
        DeathSound.Play();
        if (Player1Score == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
