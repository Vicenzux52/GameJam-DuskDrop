using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject CreditsCanvas;
    public GameObject SelectionCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreditsCanvas.SetActive(false);
        SelectionCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {
        CreditsCanvas.SetActive(false);
        SelectionCanvas.SetActive(false);
        StartCanvas.SetActive(false);
    }

    public void Credits()
    {
        CreditsCanvas.SetActive(false);
        SelectionCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }

    public void Easy()
    {
        //Salvar a dificuldade por player prefs
        SceneManager.LoadScene("Game");
    }

    public void Normal()
    {
        //Salvar a dificuldade por player prefs
        SceneManager.LoadScene("Game");
    }

    public void Hard()
    {
        //Salvar a dificuldade por player prefs
        SceneManager.LoadScene("Game");
    }
}
