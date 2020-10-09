using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject playButton;
    public GameObject exitButton;

    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            //playButton.GetComponent<BoxCollider2D>().On
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                paused = true;
                Instantiate(pauseMenu, new Vector3(0.0f, 0.0f), Quaternion.identity);
                Instantiate(playButton, new Vector3(-1.8f, -1.48f), Quaternion.identity);
                Instantiate(exitButton, new Vector3(2.43f, -1.48f), Quaternion.identity);
            }
        }
    }
}
