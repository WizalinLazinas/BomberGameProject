using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finegalka : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// DO NOT USE GENERICS!!!!!
    /// </summary>
    
    ///DATAS: int, float, string, array, Vector2/Vector3 
    ///float=1s // float=1m 
    ///int=1s // int= 1m
    ///
    ///DO NOT CREATE SCRIPTS FROM HERE!!!!!!
    [SerializeField]///need to control private/protected things in unity
    private float A;
    public float B;
    [SerializeField]
    protected float C;

    public GameObject GO;
    void Start()
    {
        //Transform=GetComponent<Transform>();
        ///transform is inside of any object
        Transform transform = GO.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ///fixedupdate - once per tick -> physics!
    ///lateupdate - after "Update"
    ///awake - before creating an object
}
