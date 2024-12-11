using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public void OnClickToMain() => SceneManager.LoadScene("Main");
}
