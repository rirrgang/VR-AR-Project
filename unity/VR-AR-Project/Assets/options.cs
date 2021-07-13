using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
{

    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("Reload Scene...");
            ReloadScene();
        }

        if (Input.GetKeyDown("ESC"))
        {
            print("Reload Scene...");
            ReloadScene();
        }
    }

    void ReloadScene(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Application.LoadLevel(scene.name);
        Application.Quit();
    }
}
