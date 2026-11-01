U121. Entrar en una zona invisible

Etiquetas: Triggers 2D · Collider2D · Etiquetas de objetos · Detección de entrada

Crea la etiqueta Jugador y asígnala al personaje de U117. Prepara una zona con BoxCollider2D y activa Is Trigger. Desde un script de la zona, detecta OnTriggerEnter2D y muestra un mensaje únicamente cuando entre el personaje. Comprueba que el área permite atravesarla sin bloquear el movimiento.

Pista
usa void OnTriggerEnter2D(Collider2D otro) y otro.CompareTag("Jugador"); aquí recibes un collider, no un Collision2D.

Comprueba: recibes un mensaje al entrar y puedes seguir caminando.

Referencia: Detección de entrada con OnTriggerEnter2D.
