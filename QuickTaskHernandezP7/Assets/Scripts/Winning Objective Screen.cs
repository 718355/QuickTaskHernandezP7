using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningObjectiveScreen : MonoBehaviour
{
    private bool hasWon = false;
    public float winHeight = 10f;
    public GameObject winUI;
    

    // Start is called before the first frame update
    void Start()
    {
        if (winUI != null)
        {
            winUI.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >=winHeight && !hasWon)
        {
            if(winUI != null)
            {
                winUI.SetActive(true);
            }
            hasWon = true;
        }
    }
}
