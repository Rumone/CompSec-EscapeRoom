using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    public string areaToLoad;
    // Start is called before the first frame update
    public void PlayGame()
    {
       SceneManager.LoadScene(areaToLoad);
    }
}
