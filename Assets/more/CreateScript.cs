using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreateScript : MonoBehaviour
{
    public GameObject Obj_Create;
    private Transform tr;
    private float spawnTime = 10f;
    private float speed = 0.5f;
    private GameObject clone;

    // Use this for initialization
    void Start()
    {   
        InvokeRepeating("launch", 2, 2.0f);
    }

    private void OnEnable()
    {
        tr = transform;
        tr.position = new Vector3(-0.8f, 0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(speed* Time.deltaTime, 0, 0);
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            Destroy(clone);
            if (Obj_Create)
            {
                Destroy(Obj_Create);
      
            }
        }
    }

    void launch()
    {        
        if (!clone)
        {
            clone = Instantiate(Obj_Create);
        }
    }

}