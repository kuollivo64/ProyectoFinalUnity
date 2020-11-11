using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarScena : MonoBehaviour
{
    public static ReiniciarScena Instance;


    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OnLoadScene(string NameScene)
    {
        SceneManager.LoadScene(NameScene);
    }

    public void OnCloseApplication()
    {
        Application.Quit();
    }
}
