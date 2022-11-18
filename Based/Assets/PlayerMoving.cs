using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController _characterController;
    private float _speed = 30f;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var xDir = Input.GetAxisRaw("Horizontal");
        var zDir = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(xDir, 0, zDir);
        direction = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * direction;
        _characterController.Move(_speed * Time.deltaTime * direction.normalized);
    }
}
