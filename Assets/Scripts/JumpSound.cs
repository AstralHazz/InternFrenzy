using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if(FindObjectOfType<Invector.vCharacterController.vThirdPersonInput>().disabled == false)
                if(FindObjectOfType<Invector.vCharacterController.vThirdPersonAnimator>().isGrounded == true)
                {
                    sound.Play();
                }
    }
}
