#include <stdio.h>
/* Prueba de parámetros por referencia. */
int f1(int *);
/* Prototipo de función. El parámetro es de tipo entero y por referencia
—observa el uso del operador de indirección. */
int main(void)
{
int I, K = 4;
for (I = 1; I <= 3; I++)
{
printf("\n\nValor de K antes de llamar a la función: %d", ++K);
printf("\nValor de K después de llamar a la función: %d", f1(&K));

}
}
int f1(int *R)

{
*R += *R;
}
