U162. Encontrar objetos en un círculo
Etiquetas: Physics2D.OverlapCircleAll · LayerMask · Capas físicas · Collider2D

Añade un Collider2D a cada enemigo y crea una capa física desde Layer > Add Layer, distinta del orden visual. Asigna los enemigos a ella y selecciónala en un campo LayerMask. Al pulsar una tecla, consulta Physics2D.OverlapCircleAll con radio 3 y ese filtro; muestra cuántos detecta.

Pista
utiliza un único collider por enemigo y excluye al jugador de la capa.

Comprueba: detectas solo enemigos cuyos colliders alcanzan el círculo.

Referencia: Consulta circular con Physics2D.OverlapCircleAll.

★ Conviene guardar: Prácticas posteriores · Futuros proyectos. Conserva el script de detección circular y una nota breve de la capa física y el LayerMask que necesita. Sirve para detectar objetivos cercanos al preparar impulsos, áreas de interacción u otras acciones por proximidad. Retómalo en: U164.