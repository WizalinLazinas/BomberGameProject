using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public GameObject player;
    public Vector2 turn;
    public float sensivity = 0.5f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.y = Input.GetAxisRaw("Mouse X") * sensivity;
        turn.x = Input.GetAxisRaw("Mouse Y") * sensivity;
        player.transform.Rotate(0, turn.y - turn.x, 0);
    }
}
