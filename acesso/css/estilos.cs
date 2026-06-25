/* Error: Module loop: this module is already being loaded.
 *   ,--> sass\_mixins.scss
 * 2 | @use 'variaveis';
 *   | ^^^^^^^^^^^^^^^^ new load
 *   '
 *   ,--> sass\estilos.scss
 * 1 | @use 'variaveis';
 *   | ================ original load
 *   '
 *   sass\_mixins.scss 2:1     @use
 *   sass\_variaveis.scss 2:2  @use
 *   sass\estilos.scss 1:1     root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Module loop: this module is already being loaded.\a   \250c \2500 \2500 > sass\\_mixins.scss\a 2 \2502  @use 'variaveis';\d\a   \2502  ^^^^^^^^^^^^^^^^ new load\a   \2575 \a   \250c \2500 \2500 > sass\\estilos.scss\a 1 \2502  @use 'variaveis';\d\a   \2502  \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501 \2501  original load\a   \2575 \a   sass\\_mixins.scss 2:1     @use\a   sass\\_variaveis.scss 2:2  @use\a   sass\\estilos.scss 1:1     root stylesheet";
}
