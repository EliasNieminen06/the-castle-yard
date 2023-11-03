using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonHandler : MonoBehaviour
{
    public GameObject creditPanel;
    public void PlayButton()
    {
        SceneManager.LoadScene("GameMainScene");
    }

    public void CreditButton()
    {
        creditPanel.SetActive(true);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("GameMenuScene");
    }

    public void BackButton()
    {
        creditPanel.SetActive(false);
    }
}
