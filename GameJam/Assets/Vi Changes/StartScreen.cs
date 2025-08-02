using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] GameObject StartCanvas;
    [SerializeField] GameObject PlayHelpChange;
    [SerializeField] GameObject Help;
    [SerializeField] GameObject[] Slideshow;
    [SerializeField] GameObject SelectionCanvas;
    [SerializeField] GameObject CreditsCanvas;
    int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreditsCanvas.SetActive(false);
        SelectionCanvas.SetActive(false);
        StartCanvas.SetActive(true);
        PlayHelpChange.SetActive(false);
        Help.SetActive(false);

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
        PlayHelpChange.SetActive(true);
        Help.SetActive(false);
    }
    public void Startplay()
    {
        if (PlayerPrefs.GetInt("Difficulty") != 0 && PlayerPrefs.GetInt("Difficulty") != 1 && PlayerPrefs.GetInt("Difficulty") != 2) PlayerPrefs.SetInt("Difficulty", 0);
        SceneManager.LoadScene("Game");
    }
    public void canvasHelp()
    {
        CreditsCanvas.SetActive(false);
        SelectionCanvas.SetActive(false);
        StartCanvas.SetActive(false);
        PlayHelpChange.SetActive(false);
        Help.SetActive(true);
        if (Slideshow.Length < 1) play();
        Slideshow[0].SetActive(true);
        index = 0;
        for (int i = 1; i < Slideshow.Length; i++)
        {
            Slideshow[i].SetActive(false);
        }
    }
    public void NextSlide()
    {
        Slideshow[index].SetActive(false);
        index++;
        if (index < Slideshow.Length)
        {
            Slideshow[index].SetActive(true);
        }
        else
        {
            play();
        }
    }
    public void Credits()
    {
        CreditsCanvas.SetActive(true);
        SelectionCanvas.SetActive(false);
        StartCanvas.SetActive(false);
        PlayHelpChange.SetActive(false);
        Help.SetActive(false);
    }
    public void Selection()
    {
        CreditsCanvas.SetActive(false);
        SelectionCanvas.SetActive(true);
        StartCanvas.SetActive(false);
        PlayHelpChange.SetActive(false);
        Help.SetActive(false);
    }
    public void Dificulty(int d)
    {
        PlayerPrefs.SetInt("Difficulty", d);
    }
}
