using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    public static int Pl1Character = 0;
    public static int Pl2Character = 1;

    public Image Player1image;
    public Image Player2image;

    public Sprite Man1;
    public Sprite Man2;

    private void Update()
    {
        Debug.Log(Pl1Character);
        Debug.Log(Pl2Character);
    }

    public void Next1()
    {
        if (Pl1Character == 1)
        {
            Pl1Character = 0;
            Player1image.sprite = Man1;
        }
        else
        {
            Pl1Character = 1;
            Player1image.sprite = Man2;
        }
    }            

    public void Next2()
    {
        if (Pl2Character == 1)
        {
            Pl2Character = 0;
            Player2image.sprite = Man1;
        }
        else
        {
            Pl2Character = 1;
            Player2image.sprite = Man2;
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

}
