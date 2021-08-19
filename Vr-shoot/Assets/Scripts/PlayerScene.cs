using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class PlayerScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   public void SceneChange()
    {
        SceneManager.LoadScene("EndScene");
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "SafeZone")
        {
            Invoke("SceneChange", 5);
            //SceneChange();
        }
    }
}
