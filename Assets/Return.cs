using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{

    public void Back()
    {

        SceneManager.LoadSceneAsync(0);
    }

    public void Credits()
    {

        SceneManager.LoadSceneAsync(2);
    }



    // Start is called before the first frame update
}
