using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[System.Serializable]
	public class MoveSettings
	{
		public float forwardVel = 12f;
		public float rotateVel = 100f;
		public float jumpVel = 24f;
		public float distToGrounded = 0.1f;
		public LayerMask ground;
	}

	[System.Serializable]
	public class PhysSettings
	{
		public float downAccel = 0.75f;
	}

	[System.Serializable]
	public class InputSettings
	{
		public float inputDelay = 0.1f;
		public string FORWARD_AXIS = "Vertical";
		public string TURN_AXIS = "Horizontal";
		public string JUMP_AXIS = "Jump";
	}

	public MoveSettings moveSetting = new MoveSettings();
	public PhysSettings physSetting = new PhysSettings();
	public InputSettings inputSetting = new InputSettings();

	Vector3 velocity = Vector3.zero;
	Quaternion targetRotation;
	Rigidbody rBody;
	float forwardInput, turnInput, jumpInput;
	public Quaternion TargetRotation
	{
		get {return targetRotation;}
	}

	bool Grounded ()
	{
		return Physics.Raycast(transform.position, Vector3.down, moveSetting.distToGrounded, moveSetting.ground);
	}

	void Start ()
	{
		targetRotation = transform.rotation;
		if (GetComponent<Rigidbody> ()) {
			rBody = GetComponent<Rigidbody> ();
		} 
		else 
		{
			Debug.LogError("Character Has No RigidBody!");
		}

		forwardInput = turnInput = jumpInput = 0f;
	}

	void GetInput ()
	{
		forwardInput = Input.GetAxis(inputSetting.FORWARD_AXIS);//Can Be Decimals
		turnInput = Input.GetAxis(inputSetting.TURN_AXIS);
		jumpInput = Input.GetAxisRaw(inputSetting.JUMP_AXIS);//Can Only Be -1, 0, 1
	}

	void Update ()
	{
		GetInput();
		Turn();
		if (moveSetting.distToGrounded >=0.1) {
			velocity.y -= physSetting.downAccel;
		}
	}

	void FixedUpdate ()
	{
		Run();
		Jump();

		rBody.velocity = transform.TransformDirection(velocity);
	}

	void Run ()
	{
		if (Mathf.Abs (forwardInput) > inputSetting.inputDelay) {
			//move
			velocity.z = moveSetting.forwardVel * forwardInput;
		} 
		else 
		{
			//stand there
			velocity.z = 0f;
		}
	}

	void Turn ()
	{
		if (Mathf.Abs (turnInput) > inputSetting.inputDelay) 
		{
			targetRotation *= Quaternion.AngleAxis (moveSetting.rotateVel * turnInput * Time.deltaTime, Vector3.up);
		}
		transform.rotation = targetRotation;

	}

	void Jump ()
	{
		if (jumpInput > 0 && Grounded ()) 
		{
			velocity.y = moveSetting.jumpVel;
		} 
		else if (jumpInput == 0 && Grounded ()) 
		{
			velocity.y = 0f;
		} 
		else 
		{
			velocity.y -= physSetting.downAccel;
		}
	}
}
