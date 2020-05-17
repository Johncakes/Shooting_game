using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController charactercontroller;
    public int Charspeed;
    
    private Vector2 movedirection = Vector2.zero;
    void Start()
    {
        charactercontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movedirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movedirection *= Charspeed;

        charactercontroller.Move(movedirection*Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Charspeed /= 2;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Charspeed *= 2;
        }
        
    }
}
