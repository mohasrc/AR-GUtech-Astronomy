using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Load a Scene given the name
    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
