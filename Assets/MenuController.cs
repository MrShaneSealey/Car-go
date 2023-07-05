using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void RestrartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
