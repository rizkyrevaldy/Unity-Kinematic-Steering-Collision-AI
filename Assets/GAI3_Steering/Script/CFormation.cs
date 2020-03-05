using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFormation : MonoBehaviour
{
    public GameObject obj;

    private int points;
    private double radius;
    private Vector3 center;

    // Start is called before the first frame update
    void Start()
    {
        points = 20;
        radius = 10;
        center = new Vector3(0, 0, 0);

        float slice = 2 * Mathf.PI / points;
        for (int i = 0; i < points; i++)
        {
            float angle = slice * i;
            int newX = (int)(center.x + radius * Mathf.Cos(angle));
            int newZ = (int)(center.z + radius * Mathf.Sin(angle));
            GameObject clone = (GameObject)Instantiate(obj, new Vector3(newX, 0, newZ), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
