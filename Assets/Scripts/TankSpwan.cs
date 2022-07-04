using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwan : MonoBehaviour
{
    public GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
    Instantiate(Tank, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
