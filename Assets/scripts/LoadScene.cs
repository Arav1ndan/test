using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    public void LoadScene1() => SceneManager.LoadScene("scene-1");
    public void LoadScene2() => SceneManager.LoadScene("scene-2");
    public void LoadScene3() => SceneManager.LoadScene("scene-3");

    public void OnButtonClick()
    {
        Debug.Log("Test button on run");
    }
}
