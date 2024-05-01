using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdi : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public Logic hitung;
    public bool birdiIsAlive = true;
    void Start()
    {
    GameObject hitungObject = GameObject.FindGameObjectWithTag("hitung");
    if (hitungObject != null)
    {
        hitung = hitungObject.GetComponent<Logic>();
    }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdiIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }
        if (transform.position.y > 17 || transform);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        hitung.gameOver();
        birdiIsAlive = false;
    }
}
