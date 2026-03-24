using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class SceneLoader : MonoBehaviour
{
    // Public function to load a scene by name
    public void LoadSpecificScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); //
    }

    // Public function to load the next scene in the build settings list
    public void LoadNextScene()
    {
        // Gets the current scene's index and adds 1 to load the next one
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}