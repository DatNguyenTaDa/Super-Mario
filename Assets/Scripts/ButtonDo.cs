using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDo : MonoBehaviour
{
    public void GoHomeScene()
    {
        SceneManager.LoadScene(0);
    }
}
