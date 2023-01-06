using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene5 : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene(9);

    }

    public void ContinueButton()
    {

        SceneManager.LoadScene(11);

    }
}
