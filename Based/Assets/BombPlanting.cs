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
            var position = new Vector3(transform.position.x, 1, transform.position.z);
            Instantiate(Bomb, position, Quaternion.identity);
            Debug.Log("Bomb has been planted!");
        }
    }
}
