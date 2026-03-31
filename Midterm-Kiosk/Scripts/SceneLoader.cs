using UnityEngine;
using UnityEngine.SceneManagement; // Required namespace

public class SceneLoaderScript : MonoBehaviour
{
    public string SceneName;
    
    // Public function to be called by the button
    public void LoadTargetScene()
    {
        // Load the scene by its exact name as it appears in Build Settings
        SceneManager.LoadScene(SceneName); 
    }

    // Optional: Load the next scene in the build order by index
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}