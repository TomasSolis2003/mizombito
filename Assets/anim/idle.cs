/*using UnityEngine;

public class PlayerIdleAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Captura la entrada de movimiento
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Si no hay movimiento, activar animación Idle
        bool isIdle = horizontal == 0 && vertical == 0;
        animator.SetBool("IDLE", isIdle);
    }
}
*/
using UnityEngine;

public class PlayerIdleAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogWarning("No se encontró un Animator en " + gameObject.name);
        }
    }

    void Update()
    {
        if (animator == null) return; // Evita errores si falta el Animator

        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
                        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        animator.SetBool("IDLE", !isMoving);
    }
}
