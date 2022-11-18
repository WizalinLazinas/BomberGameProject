using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlanting : MonoBehaviour
{
    public GameObject Bomb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bomb, transform.position, Quaternion.identity);
            Debug.Log("Bomb has been planted!");
        }
    }
}
