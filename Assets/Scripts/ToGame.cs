using UnityEngine.SceneManagement;
using UnityEngine;

public class ToGame : MonoBehaviour

{

    public void GameStart()
    {

        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MenuStart()
    {
        SceneManager.LoadScene(0);
    }


}
