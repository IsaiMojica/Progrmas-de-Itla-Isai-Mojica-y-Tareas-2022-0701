#include <stdio.h>
#include <stdlib.h>


/*Arreglo sin elemento repetidos. el programa, al recibir como datos un arreglo unidimensional desordenado en N, el elemento obtiene como salida ese mismo arrreglo pero sin los elementos repetidos. */

void lectura (int *, int);
void Imprime(int *, int);
void Elimina (int *, int);
/* Observa que en el prototipo de Elimina, el segundo parámetro es por referencia. Esto, porque el tamaño del arreglo puede disminuir. */


void main(void)
{
int TAM, ARRE[100];
/* Se escribe un do-while para verificar que el tamaño del arreglo que se
➥ingresa sea correcto. */
do
{
printf("Ingrese el tamano del arreglo: ");
scanf("%d", &TAM);
}
while (TAM > 100 || TAM < 1);
Lectura(ARRE, TAM);
elimina(ARRE, &TAM);
/* Observa que el tamaño del arreglo se pasa por referencia.*/
Imprime(ARRE, TAM);
}
void Lectura(int A[], int T)
/* La función Lectura se utiliza para leer un arreglo unidimensional de T
➥elementos de tipo entero. */
{
printf("\n");
int I;
for (I=0; I<T; I++)
{
printf("Ingrese el elemento %d: ", I+1);
scanf("%d", &A[I]);
}
}
void Imprime(int A[], int T)
/* La función Imprime se utiliza para escribir un arreglo unidimensional, sin
➥repeticiones, de T elementos de tipo entero. */
{
int I;
for (I=0; I<T; I++)
printf("\nA[%d]: %d", I, A[I]);
}
void elimina(int A[], int *T)
/* Esta función se utiliza para eliminar los elementos repetidos de un arreglo
➥unidimensional de T elementos de tipo entero. */
{
int I = 0, K, L;
while (I < (*T-1))
{
K = I + 1;
while (K <= (*T-1))
{
if (A[I] == A[K])
{
for (L = K; L < (*T-1); L++)
A[L] = A[L+1];
*T = *T -1;
}
else
K++;
}
I++;
}
}
