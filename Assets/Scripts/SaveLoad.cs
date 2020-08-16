using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// We need to use UI here
using UnityEngine.UI;

/**
 * This class contains all actions about saving and loading.
 */
public class SaveLoad : MonoBehaviour
{

    // Source to get our text contents.
    public Text ourNote;

    // Destination to display our text contents.
    public InputField inputField;
    
    // Store a Text object which contains Animation we need when text content is saved successfully.
    public Text savedText;

    // Store the Animator component of the savedText object.
    private Animator savedAnimator;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Get text contents we save to the PlayerPrefs by the key and display it.
        inputField.text = PlayerPrefs.GetString("NoteContents");
    }

    /**
     * Save text contends when user clicks the save button.
     */
    public void SaveNote()
    {
        // Store current text contents through PlayerPrefs class with a key we name(NoteContents here).
        PlayerPrefs.SetString("NoteContents", ourNote.GetComponent<Text>().text);
        
        // Starts a coroutine named SavedTextRoll(a method).
        // A coroutine is a function that can suspend its execution (yield) until the given YieldInstruction finishes.
        StartCoroutine(SavedTextRoll());
    }

    /**
     * An IEnumerator object Supports a simple iteration over a non-generic collection.
     * For this method, it plays save animation once after the user clicks the save button.
     */
    private IEnumerator SavedTextRoll()
    {
        // Store the animator component of the savedText object
        savedAnimator = savedText.GetComponent<Animator>();
        // Plays "SavedAnim" animation once.
        savedAnimator.Play("SavedAnim");
        // Suspend the coroutine for 1 second.
        yield return new WaitForSeconds(1);
        // Set animation to default state(no animations are playing now).
        // You can comment or delete the below line of code now since it wont affect anything for now.
        savedAnimator.Play("New State");
    }
}
