using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MoveScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MoveToNext());
    }

    IEnumerator MoveToNext()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
