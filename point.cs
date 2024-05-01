using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public Logic hitung; 
    void Start()
    {
    GameObject hitungObject = GameObject.FindGameObjectWithTag("hitung");
    if (hitungObject == null)
    {
        Debug.LogError("No GameObject found with tag hitung");
        return;
    }

    hitung = hitungObject.GetComponent<Logic>();
    if (hitung == null)
    {
        Debug.LogError("No Logic component found on GameObject with tag hitung");
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    Debug.Log("OnTriggerEnter2D called");
    hitung.addScore(1);
    }
}