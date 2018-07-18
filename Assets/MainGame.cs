using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour {
    
    public void ExitGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
}

