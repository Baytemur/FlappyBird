using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusHareketler : MonoBehaviour
{
    public float yercekimi = 4f;
    public float ziplamaGucu = 2.5f;
    public float yatayHiz = 1.5f;
    public float dikeyHiz = 0f;


    // Update is called once per frame
    void Update()
    {
        dikeyHiz -= yercekimi * Time.deltaTime;
        if (Input.GetMouseButtonDown(0)) ;
        dikeyHiz = ziplamaGucu;

        float egim = 90 * dikeyHiz / yatayHiz;

        if (egim < -50) egim = -50;
        else if (egim > 50) egim = 50;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egim);
        transform.Translate(new Vector3(0, dikeyHiz, 0) *Time.deltaTime, Space.World);

        
    }
}
