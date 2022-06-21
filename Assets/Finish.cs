using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("flag"))
        {
            SceneManager.LoadScene("RedLevel");
            //Debug.Log("Finish!!");
        }
    }
}
