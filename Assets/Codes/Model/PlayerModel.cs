using UnityEngine;
public class PlayerModel
{
    public static PlayerModel singleton = null;
    public PlayerController controller = new PlayerController();
    public GameObject game_object = GameObject.Find("Player");
    public CharacterController characterController = null;
    public Transform sphereTransform = GameObject.Find("Sphere").transform;
    public float walkSpeed = 15f;
    public float jumpForce = 5f;
    public float gravity = -10f;
    public float velocity = 0f;
    public bool hasLanded = false;
    public bool hasJumped = false;
    public PlayerModel()
    {
        characterController = game_object.GetComponent<CharacterController>();
    }
}