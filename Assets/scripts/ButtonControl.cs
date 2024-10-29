using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonControl : MonoBehaviour
{
    public TMP_InputField theText;
    public AudioSource clearSound;
    public GameObject thePanel;

    public void ClearText()
    {
        clearSound.Play();
        theText.text = "";
    }

    public void CancelButton()
    {
        thePanel.SetActive(false);
    }

    public void CloseButton()
    {
        thePanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
