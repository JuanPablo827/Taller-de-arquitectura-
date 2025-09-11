using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento izquierda/derecha
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * velocidadMovimiento, rb.linearVelocity.y);

        // Salto SIEMPRE que presiones espacio (sin límite, sin condiciones)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0); // resetear Y
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            Debug.Log("Saltó!");
        }
    }
}
