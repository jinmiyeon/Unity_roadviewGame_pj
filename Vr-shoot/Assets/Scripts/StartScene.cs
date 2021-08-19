using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneChange", 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void SceneChange()
    {
        SceneManager.LoadScene("real");
    }
}
