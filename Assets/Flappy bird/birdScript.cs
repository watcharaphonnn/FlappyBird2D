using UnityEngine;
using UnityEngine.InputSystem;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigibody;

    private void Start()
    {
        
    }

    public float jumpForce = 10f;

    private void Update()
    {
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                myRigibody.linearVelocity = new Vector2(0, jumpForce * 2);
            }
        }
    }
}
