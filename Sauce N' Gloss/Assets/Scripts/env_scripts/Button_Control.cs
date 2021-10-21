using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Control : MonoBehaviour
{
    public void Replay(string screenName)
    {
        SceneManager.LoadScene(screenName);
    }
}
