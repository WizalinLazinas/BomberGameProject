using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    private CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_characterController.velocity != Vector3.zero)
        {
            Debug.Log("IsWAlking+Plant bomb");
            animator.SetBool("isWalking", true);
            BombPlanting();
        }
        else
        {
            animator.SetBool("isWalking", false);
            BombPlanting();
        }

    }
    void BombPlanting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isPlantingBomb", true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isPlantingBomb", false);
        }
    }
}