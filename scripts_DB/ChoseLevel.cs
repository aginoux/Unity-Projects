using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseLevel : MonoBehaviour {

    public void chose_level(int level)
    {
        SceneManager.LoadScene(level);
    }
}
