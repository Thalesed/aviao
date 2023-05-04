using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aviao : MonoBehaviour {
    Rigidbody2D fisica;
    public int speed;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void Update () { 
        if(Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
        /*this.fisica.velocity = 
            Vector2.right * speed;*/
    }


    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        //transform.position += new Vector3(0f, this.speed * 10 * Time.deltaTime, 0f);
    }
    void OnCollisionEnter2D(Collision2D colisao){
        SceneManager.LoadScene("GameOver");
    }

    private void OnBecameInvisible(){
         Destroy(gameObject, 1f);
         SceneManager.LoadScene("GameOver");
     }
}