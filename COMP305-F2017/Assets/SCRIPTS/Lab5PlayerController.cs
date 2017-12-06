using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lab5PlayerController : MonoBehaviour {

    public float speed;
    public Text text;
    public GameObject bomb;
    public GameObject box;
    public GameObject coin;
    public double leftTime = 30.0;
    private double spawnTime = 1.0;
    private Rigidbody2D rBody;
    private Camera camera;
	public Lab5ItemCollector itemCollector;
    

    // Use this for initialization
    void Start ()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    void Update()
    {
        leftTime -= Time.deltaTime;
        spawnTime -= Time.deltaTime;

        if (leftTime >= 0)
        {
            text.text = "Countdown: " + ((int)leftTime);

            if (spawnTime <= 0)
            {
                int objectNumber = Random.Range(1, 4);

                if (objectNumber == 1)
                {
                    Vector3 position = new Vector3(Random.Range(-7, 6), 3, 0);
                    Instantiate(bomb, position, Quaternion.identity);
                }
                else if (objectNumber == 2)
                {
                    Vector3 position = new Vector3(Random.Range(-7, 6), 3, 0);
                    Instantiate(box, position, Quaternion.identity);
                }
                else if (objectNumber == 3)
                {
                    Vector3 position = new Vector3(Random.Range(-7, 6), 3, 0);
                    Instantiate(coin, position, Quaternion.identity);
                }

                spawnTime = 1.0;
            }
        }
        else
        {
            SceneManager.LoadScene("Lab5GameOver");
        }


    }

    // Use this for physics
    void FixedUpdate()
    {
        float horizMove = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizMove, 0, 0);
        rBody.velocity = movement * speed;

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Detected collision");

		if (collider.gameObject.name.Contains("Bomb"))
        {
            Debug.Log("Detected collision with bomb");
			itemCollector.BombCollected++;
            
        }
		else if (collider.gameObject.name.Contains("Box"))
        {
            Debug.Log("Detected collision with box");
			itemCollector.BoxCollected++;

        }
		else if (collider.gameObject.name.Contains("Coin"))
        {
            Debug.Log("Detected collision with coin");
			itemCollector.CoinCollected++;
        }

        Destroy(collider.gameObject);

    }
}
