using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public int m_PlayerNumber = 1;         
    public float m_Speed = 12f;            
    public float m_TurnSpeed = 180f;       
    public AudioSource m_MovementAudio;    
    public AudioClip m_EngineIdling;       
    public AudioClip m_EngineDriving;      
    public float m_PitchRange = 0.2f;

    private string m_MovementAxisName;     
    private string m_TurnAxisName;         
    private Rigidbody m_Rigidbody;         
    private float m_MovementInputValue;    
    private float m_TurnInputValue;        
    private float m_OriginalPitch;         


    /**
     * Gets called as scene is initialized
     * This function initializes some of the variables
     */
    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    /**
     * Gets called as tank turned on
     */
    private void OnEnable ()
    {
        m_Rigidbody.isKinematic = false;
        m_MovementInputValue = 0f;
        m_TurnInputValue = 0f;
    }

    /**
     * Gets called as tank turned off
     */
    private void OnDisable ()
    {
        m_Rigidbody.isKinematic = true;
    }

    /**
     * Set up axis names for movement
     */
    private void Start()
    {
        m_MovementAxisName = "Vertical" + m_PlayerNumber;
        m_TurnAxisName = "Horizontal" + m_PlayerNumber;

        m_OriginalPitch = m_MovementAudio.pitch;
    }

    /**
     * Gets called every frame
     */
    private void Update()
    {
        // Store the player's input and make sure the audio for the engine is playing.
        m_MovementInputValue = Input.GetAxis(m_MovementAxisName);
        m_TurnAxisName = Input.GetAxis(m_TurnAxisName);

        EngineAudio();
    }


    private void EngineAudio()
    {
        // Play the correct audio clip based on whether or not the tank is moving and what audio is currently playing.
    	bool tankIsMoving = Mathf.Abs(m_MovementInputValue) < 0.1f && Mathf.Abs(m_TurnInputValue) < 0.1f;
    	if(tankIsMoving) {

    	} else {

    	}
    }


    private void FixedUpdate()
    {
        // Move and turn the tank.
    }


    private void Move()
    {
        // Adjust the position of the tank based on the player's input.
    }


    private void Turn()
    {
        // Adjust the rotation of the tank based on the player's input.
    }
}