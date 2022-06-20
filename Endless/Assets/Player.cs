using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text healthDisplay;
    Vector2 targetpos;
    public float Yincreament;
    public float speed,maxht,minht;
    public int health =3;
    public GameObject gameOver;
    public GameObject scoreno;

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();

        if(health<=0){
            gameOver.SetActive(true);
            scoreno.SetActive(false);
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);
        /*
        if(SwipeManager.swipeUp && transform.position.y<maxht){
            targetpos = new Vector2(transform.position.x,transform.position.y + Yincreament );
            transform.position = targetpos;
        }
        else if(SwipeManager.swipeDown && transform.position.y>minht){
            targetpos = new Vector2(transform.position.x,transform.position.y - Yincreament );
            transform.position = targetpos;
        }
        */


    }

    public void DownPress()
    {
        if(transform.position.y > minht)
        {
            targetpos = new Vector2(transform.position.x, transform.position.y - Yincreament);
            transform.position = targetpos;
        }
    }

    public void UpPress()
    {
        if (transform.position.y < maxht)
        {
            targetpos = new Vector2(transform.position.x, transform.position.y + Yincreament);
            transform.position = targetpos;
        }
            
    }

}
