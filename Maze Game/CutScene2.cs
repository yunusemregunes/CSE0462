using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene2 : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene(3);

    }

    public void ContinueButton()
    {

        SceneManager.LoadScene(5);

    }
}
