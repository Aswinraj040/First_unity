using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotationvector;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationvector * Time.deltaTime);
        
    }
}
