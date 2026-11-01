U127. Un portal de derecha a izquierda

Etiquetas: Triggers 2D · Teletransporte · Rigidbody2D · Referencias · Coordenadas X/Y

Coloca un portal de entrada a la derecha y una marca de destino a la izquierda. Al entrar el personaje, cambia la posición de su Rigidbody2D al destino mediante una referencia. El destino izquierdo no debe teletransportar de vuelta: el recorrido funciona en un único sentido.

Pista
asigna Rigidbody2D.position para el traslado instantáneo y mantén el destino separado del trigger de entrada.

Comprueba: entrar por la derecha lleva a la izquierda sin provocar un bucle.

★ Conviene guardar: Futuros proyectos. Conserva el portal, su script y la referencia al destino. Así podrás adaptar traslados de un solo sentido entre zonas del mismo escenario.