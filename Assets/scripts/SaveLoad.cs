using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;


public class SaveLoad : MonoBehaviour
{
    public TMP_InputField ourNote;
    public Button ClearButton;
    public GameObject saveAnim;

    void Start()
    {
        // Load saved note contents on start
        ourNote.text = PlayerPrefs.GetString("NoteContents");

        // Check if the Clear button should be interactable at the start
        ClearButton.interactable = !string.IsNullOrEmpty(ourNote.text);

        // Add a listener for the onValueChanged event to handle input changes
        ourNote.onValueChanged.AddListener(delegate { UpdateClearButtonState(); });
    }

    void UpdateClearButtonState()
    {
        // Enable or disable the Clear button based on input field content
        ClearButton.interactable = !string.IsNullOrEmpty(ourNote.text);
    }

    public void SaveNote()
    {
        PlayerPrefs.SetString("NoteContents", ourNote.text);
        StartCoroutine(SaveTextRoll());
    }

    IEnumerator SaveTextRoll() {
        saveAnim.GetComponent<Animator>().Play("SavedAnim");
        yield return new WaitForSeconds(1);
        saveAnim.GetComponent<Animator>().Play("New State");
    }
}
