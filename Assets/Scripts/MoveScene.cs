using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This class represents all behaviours when the Nodepad App is run.
 * It actually helps switch scene from the Intro scene to the App's main scene after waiting for certain seconds.
 */
public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // Starts a coroutine named MoveToNext(a method).
        StartCoroutine(MoveToNext());
    }

    /**
     * An IEnumerator object Supports a simple iteration over a non-generic collection.
     * For this method, it waits for 3 seconds and then load the next scene(tha main scene of the App).
     */
    private static IEnumerator MoveToNext()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
