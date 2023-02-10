#include <stdio.h>
/* Primos.
El programa almacena en un arreglo unidimensional los primeros 100 números
?primos. */
const int TAM = 100;
int Imprime(int, int); 
int Primo(int, int *);
int main(void)
{
int P[TAM] = {1,2};
int FLA, J = 2, PRI = 3;
while (J <= TAM)
{
FLA = 1;
Primo(PRI, &FLA); 
if (FLA) {
P[J] = PRI;
J++;
}
PRI += 2;
}
int Imprime(int P, int TAM);
}
int Primo(int A, int *B)

{
int DI = 3;
while (*B && (DI < (A / 2)))
{
if ((A % DI) == 0)
*B = 0;
DI++;
}
}
int Imprime(int Primos[], int T)
{
int I;
for (I=0; I<T; I++)
printf("\nPrimos[%d]: %d", I, Primos[I]);
}
