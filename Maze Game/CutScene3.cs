using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene3 : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene(5);

    }

    public void ContinueButton()
    {

        SceneManager.LoadScene(7);

    }
}
