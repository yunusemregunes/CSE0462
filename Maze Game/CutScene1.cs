using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene1 : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene(1);

    }

    public void ContinueButton()
    {

        SceneManager.LoadScene(3);

    }
}
