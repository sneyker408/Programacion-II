using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Variables para manejar los componentes del jugador
    private Rigidbody2D rb;           // Componente para manejar la física del personaje
    private Animator animator;        // Componente para controlar las animaciones
    private Vector2 direccion;        // Dirección en la que se moverá el jugador

    // Variables para las estadísticas del jugador
    [Header("Estadisticas")]
    public float velocidadDeMovimiento = 10;   // Velocidad de movimiento horizontal del jugador
    public float fuerzaDeSalto = 5;            // Fuerza de salto del jugador

    // Variables booleanas para el control de estados del jugador
    [Header("Booleanos")]
    public bool puedeMover = true;   // Controla si el jugador puede moverse
    public bool enSuelo = true;      // Indica si el jugador está tocando el suelo

    // Variables para detectar colisiones y determinar si el jugador está en el suelo
    [Header("Colisiones")]
    public Vector2 abajo;            // Desplazamiento desde la posición del jugador hacia abajo
    public float radioColision;      // Radio del círculo de detección de colisiones
    public LayerMask layerPiso;      // Capa del suelo para la detección de colisiones

    // Método para detectar si el jugador está en el suelo
    private void Agarres() {
        // Usamos OverlapCircle para crear un círculo que detecta si el jugador toca el suelo
        enSuelo = Physics2D.OverlapCircle((Vector2)transform.position + abajo, radioColision, layerPiso);
    }

    // Método que se llama cuando el script se inicializa
    private void Awake()
    {
        // Obtenemos el componente Rigidbody2D para manejar la física del jugador
        rb = GetComponent<Rigidbody2D>();
        // Obtenemos el componente Animator para controlar las animaciones del jugador
        animator = GetComponent<Animator>();
    }

    // Método para controlar el movimiento del jugador
    private void Movimiento() {
        // Capturamos la entrada horizontal y vertical del jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        direccion = new Vector2 (x, y);  // Creamos un vector con la dirección en la que se mueve el jugador
        caminar(direccion);  // Llamamos al método caminar para realizar el movimiento

        // Detectamos si el jugador presiona la barra espaciadora (salto)
        if (Input.GetKeyDown(KeyCode.Space)) {
            // Verificamos si el jugador está en el suelo antes de permitir que salte
            if (enSuelo) {
                animator.SetBool("saltar", true);  // Activamos la animación de salto
                Saltar();  // Llamamos al método Saltar para realizar el salto
            }   
        }

        // Si el jugador está en el suelo, desactivamos la animación de caída
        if (enSuelo) {
            animator.SetBool("caer", false);
        }
    }

    // Método para finalizar el salto (animaciones)
    private void FinalizarSalto() {
        animator.SetBool("saltar", false);  // Desactivamos la animación de salto
        animator.SetBool("caer", true);     // Activamos la animación de caída
    }

    // Método para controlar el caminar del jugador
    private void caminar(Vector2 direccion) {
        if (puedeMover) {
            // Si el jugador no está en el suelo, activamos la animación de caída
            if (!enSuelo) {
                animator.SetBool("caer", true);
            } else {
                // Si está en el suelo y se está moviendo, activamos la animación de caminar
                animator.SetBool("caminar", true);
            }

            // Aplicamos la velocidad horizontal según la dirección de movimiento
            rb.velocity = new Vector2(direccion.x * velocidadDeMovimiento, rb.velocity.y);

            // Verificamos la dirección para voltear el sprite del personaje
            if (direccion != Vector2.zero) {
                // Si se mueve hacia la izquierda, volteamos el sprite
                if (direccion.x < 0 && transform.localScale.x > 0) {
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                } 
                // Si se mueve hacia la derecha, aseguramos que el sprite mire hacia la derecha
                else if (direccion.x > 0 && transform.localScale.x < 0) {
                    transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                }
            } else {
                // Si no se está moviendo, desactivamos la animación de caminar
                animator.SetBool("caminar", false);
            }
        }
    }

    // Método para mejorar la sensación del salto, ajustando la gravedad según la velocidad
    private void mejorarSalto() {
        // Si el jugador está cayendo, aplicamos más gravedad para una caída más rápida
        if (rb.velocity.y < 0) {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (2.5f - 1) * Time.deltaTime;
        }
        // Si el jugador está subiendo pero no mantiene la barra espaciadora, disminuimos la fuerza del salto
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (2.0f - 1) * Time.deltaTime;
        }
    }

    // Método que realiza el salto
    private void Saltar() {
        // Reiniciamos la velocidad vertical y aplicamos una fuerza hacia arriba (salto)
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += Vector2.up * fuerzaDeSalto;
    }

    // Método que se llama al inicio del juego
    void Start() {
        // Aquí puedes inicializar valores o ejecutar código al comienzo del juego
    }

    // Método que se llama en cada frame
    void Update() {
        // Llamamos al método de movimiento para controlar el jugador
        Movimiento();
        // Llamamos al método de agarres para verificar si el jugador está en el suelo
        Agarres();
    }
}
