using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    private float _bombPlantingDelay = 0.3f;
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
        animator.SetBool("isWalking", _characterController.velocity != Vector3.zero);
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        BombPlanting();
    }
    void BombPlanting()
    {
        animator.SetTrigger("isPlantingBomb");
        Invoke("BombPlanted", _bombPlantingDelay);
    }
    private void BombPlanted()
    {
        animator.ResetTrigger("isPlantingBomb");
    }

}
