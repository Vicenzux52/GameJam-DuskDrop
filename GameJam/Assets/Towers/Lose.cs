using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Start");
    }
}
