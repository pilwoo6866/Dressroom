using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void moveScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
