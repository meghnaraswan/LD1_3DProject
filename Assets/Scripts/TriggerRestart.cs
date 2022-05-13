using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerRestart : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(waiter());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator waiter()
    {
        //Wait for 3 seconds
        yield return new WaitForSeconds(5);

    }
}
