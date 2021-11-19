using System;
using System.Collections;
using System.Collections.Generic;
using InputController;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMouvement : MonoBehaviour
{
    

    private float velocity;

    public Camera m_camera;
    public float m_turnSpeed = 10f;

    private Vector3 m_directionOfMove;

    public enum STATE
    {
        DEFAULT,
        AIMING
    }

    public STATE m_currentState = STATE.DEFAULT;

    public GameObject m_aimingCamera;
    private float aimVelocityX;
    private float aimVelocityZ;

    public RigManipulator m_rigManipulator;
    public Animator m_animator;
    
    private Vector2 m_moveVector;

    void Awake()
    {
        
    }

    public void SwitchToAim(InputAction.CallbackContext _context)
    {
        if (_context.started)
        {
            SwitchToAimState();
        }

        if (_context.canceled)
        {
            SwitchToDefaultState();
        }
    }

    private void SwitchToDefaultState()
    {
        m_currentState = STATE.DEFAULT;
        m_animator.SetBool("SwitchToAimBool",false);
        m_aimingCamera.SetActive(false);
        m_rigManipulator.DeactivateAimingRig();
    }

    private void SwitchToAimState()
    {
        m_currentState = STATE.AIMING;
        m_animator.SetBool("SwitchToAimBool",true);
        m_aimingCamera.SetActive(true);
        m_rigManipulator.ActivateAimingRig();
    }

    public void Move(InputAction.CallbackContext _context)
    {
        m_moveVector = _context.ReadValue<Vector2>();
    }
    

    // Update is called once per frame
    void Update()
    {

        switch (m_currentState)
        {
            case STATE.DEFAULT:

                var value = m_moveVector;

                var speed = Mathf.Abs(value.x) + Mathf.Abs(value.y);
                speed = Mathf.Clamp(speed, 0f, 1f);
                speed = Mathf.SmoothDamp(m_animator.GetFloat("Speed"), speed, ref velocity, .1f);
                m_animator.SetFloat("Speed", speed);

                m_directionOfMove = ExtractDirectionFromCamera();

                if (!(value.magnitude > .1f)) return;

                var moveVector = new Vector3(value.x, 0, value.y);
                var rotation = Quaternion.LookRotation(m_directionOfMove, Vector3.up) * Quaternion.LookRotation(moveVector, Vector3.up);
                var lerpRotation = Quaternion.Lerp(transform.rotation, rotation, m_turnSpeed * Time.deltaTime);

                transform.rotation = lerpRotation;
                
                break;
            case STATE.AIMING:

                var currentCameraForward = m_camera.transform.forward;
                var forwardCameraOnXZplane = Vector3.ProjectOnPlane(currentCameraForward, Vector3.up);
                transform.rotation = Quaternion.LookRotation(forwardCameraOnXZplane, Vector3.up);

                var inputValue = m_moveVector;
                var inputValueX = Mathf.SmoothDamp(m_animator.GetFloat("SpeedAimX"), inputValue.x, ref aimVelocityX, .1f);
                var inputValueZ = Mathf.SmoothDamp(m_animator.GetFloat("SpeedAimZ"), inputValue.y, ref aimVelocityZ, .1f);
                
                m_animator.SetFloat("SpeedAimX",inputValueX);
                m_animator.SetFloat("SpeedAimZ",inputValueZ);
  
                break;
        }
        

    }

    private Vector3 ExtractDirectionFromCamera()
    {
        return Vector3.ProjectOnPlane(m_camera.transform.forward, Vector3.up);
    }
    
}
