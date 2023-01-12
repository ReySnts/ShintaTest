using UnityEngine;
public class PlayerModel
{
    public static PlayerModel singleton = null;
    public PlayerController controller = null;
    public GameObject game_object = null;
    public CharacterController characterController = null;
    public Transform sphereTransform = null;
    public readonly float walkSpeed = 15f;
    public readonly float jumpForce = 5f;
    public readonly float gravity = -10f;
    public float velocity = 0f;
    public bool hasLanded = false;
    public bool hasJumped = false;
    public PlayerModel()
    {
        controller = new PlayerController();
        game_object = GameObject.Find("Player");
        characterController = game_object.GetComponent<CharacterController>();
        sphereTransform = GameObject.Find("Sphere").transform;
    }
}