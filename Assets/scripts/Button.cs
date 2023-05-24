using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void update(){
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("SampleScene");
            GameObject.Destroy(this.gameObject);
        }
    }
    public void OnMouseDown(){
        GameObject.Destroy(this.gameObject);
    }

}
