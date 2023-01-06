using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene4 : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene(7);

    }

    public void ContinueButton()
    {

        SceneManager.LoadScene(9);

    }
}
