using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {


    public void chose_level(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void chose_level(string level)
    {
        if (level == "exit")
        {
            print("exit");
            Application.Quit();
        }
    }
    // Use this for initialization

}
