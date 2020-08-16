using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// We need to use UI
using UnityEngine.UI;

/**
 * This class represents all behaviours of all buttons except the save button.
 */
public class ButtonControl : MonoBehaviour
{
    // Store a InputFiled object which contains text contents we need to clear.
    public InputField theText;
    // Store an AudioSource object which will play once after we click the clear button.
    public AudioSource clearSound;
    // Store the inner panel(which contains three buttons).
    public GameObject outerPanel;
    /**
     * Clear all contents in theText object's text field and play the clear sound once.
     */
    public void ClearText()
    {
        theText.text = "";
        clearSound.Play();
    }

    public void CancelButton()
    {
        outerPanel.SetActive(false);
    }

    public void CloseButton()
    {
        outerPanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
