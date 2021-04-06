using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseScene : MonoBehaviour
{

    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BackScene();
    }

    public void BackScene()
    {
        if(Input.GetKeyDown("b"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void SwitchAnimation()
    {
        ani.SetInteger("CatEyeIndex", 1);
    }

}
