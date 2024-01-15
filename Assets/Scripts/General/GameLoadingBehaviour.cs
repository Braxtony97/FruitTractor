using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoadingBehaviour : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
        LoadGame();
    }

    private async void LoadGame()
    {
        SceneManager.LoadScene("levelSelection_scene");
    }
}
