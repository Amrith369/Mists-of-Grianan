using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charControl;
    public float walkSpeed;
	public float jumpForce;
	public GameObject pauseMenu;
	private bool menuOpen;
	public Component CameraMovement;
	public Component PlayerMovement;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
		menuOpen = false;
    }
		
    void Update()
    {

        MovePlayer();
		PauseGame ();

    }

    void MovePlayer()
    {
      //  float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

       // Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

       // charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);

    }

	void PauseGame()
	{
		if (Input.GetKeyDown (KeyCode.Tab) && menuOpen == false) 
		{
			print("Menu Activated");
			pauseMenu.SetActive (true);
			menuOpen = true;

		} 
		else if (Input.GetKeyDown(KeyCode.Tab) && menuOpen == true )
		{
			print ("Menu Deactivated");
			pauseMenu.SetActive (false);
			menuOpen = false;

		}
	}
}
