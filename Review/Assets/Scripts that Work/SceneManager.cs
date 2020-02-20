using UnityEngine.SceneManagement;
using UnityEngine; 

[CreateAssetMenu]
public class SceneManager : ScriptableObject
{
    public void LoadScene (Object sceneName)
    {
        var newName = sceneName.name;
       // SceneManager.LoadScene(newName);
    }
}