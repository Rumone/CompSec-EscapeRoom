using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D m_Rigidbody;
    public float moveSpeed;

    public Animator m_Animator;

    public static PlayerController instance;

    public string areaTransitionName;

    public bool canMove;
    public bool HasKey;
    public bool didDTree;
    // Start is called before the first frame update
    void Start()
    {
        didDTree = false;
        canMove = true;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            m_Rigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
        }
        else
        {
            m_Rigidbody.velocity = Vector2.zero;
        }

        m_Animator.SetFloat("moveX", m_Rigidbody.velocity.x);
        m_Animator.SetFloat("moveY", m_Rigidbody.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            if(canMove)
            {
                m_Animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                m_Animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }   
        }
    }
}
