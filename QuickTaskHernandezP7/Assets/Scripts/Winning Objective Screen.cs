using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningObjectiveScreen : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float winHeight = 10f;
    public float minY = -5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (transform.position.y >= winHeight)
        {
            Win();
        }

        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, transform.position.z);
        }
    }

    // Update is called once per frame
    void Win()
    {
        SceneManager.LoadScene("WinScreen");
    }
}
