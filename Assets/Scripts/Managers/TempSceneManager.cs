using UnityEngine;
using UnityEngine.SceneManagement;

public class TempSceneManager : MonoBehaviour
{
    public static TempSceneManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void LoadNextScene()
    {
        int NextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(NextSceneIndex);
    }
}
