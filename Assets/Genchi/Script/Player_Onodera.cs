using UnityEngine;

// プレイヤー
public class Player_Onodera : MonoBehaviour
{

    [SerializeField] private Vector3 velocity;              // 移動方向
    [SerializeField] private float moveSpeed = 5.0f;        // 移動速度

    public enum CharacterState
    {
        normal,
        talk
    }

    void Update()
    {
        
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.S))
            velocity.z -= 1;
        else if (Input.GetKey(KeyCode.D))
            velocity.x += 1;
        else if (Input.GetKey(KeyCode.W))
            velocity.z += 1;
        else if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;

        
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            transform.position += velocity;
        }
    }
}