using UnityEngine;
public class PlayerController
{
    PlayerModel playerModel = null;
    CharacterController characterController = null;
    Transform playerTransform = null;
    float gravity = 0f;
    void CheckJumpEligibility()
    {
        if (!playerModel.hasJumped)
        {
            if 
            (
                Input.GetKeyDown(KeyCode.Space)
            )
            {
                playerModel.hasJumped = true;
                playerModel.velocity = Mathf.Sqrt
                (
                    -2f * 
                    gravity * 
                    playerModel.jumpForce
                );
            }
        }
        else if (playerModel.velocity < 0f) 
        {
            playerModel.hasJumped = false;
            playerModel.velocity = 0f;
        }
    }
    void MoveVertical()
    {
        if (playerModel.hasLanded) CheckJumpEligibility();
        playerModel.velocity += (gravity * Time.deltaTime);
        characterController.Move
        (
            playerTransform.up * 
            playerModel.velocity * 
            Time.deltaTime
        );
    }
    void MoveHorizontal()
    {
        characterController.Move
        (
            (
                playerTransform.right * Input.GetAxis("Horizontal") + 
                playerTransform.forward * Input.GetAxis("Vertical")
            ) 
            * playerModel.walkSpeed 
            * Time.deltaTime
        );
    }
    public void UpdateMovement()
    {
        MoveHorizontal();
        MoveVertical();
    }
    void StateLanding()
    {
        playerModel.hasLanded = Physics.CheckSphere
        (
            playerModel.sphereTransform.position,
            0.08f,
            3            
        );
    }
    void Setup()
    {
        playerModel = PlayerModel.singleton;
        playerTransform = playerModel.game_object.transform;
        characterController = playerModel.characterController;
        gravity = playerModel.gravity;
    }
    public void FixedUpdateStatus()
    {
        Setup();
        StateLanding();
    }
}