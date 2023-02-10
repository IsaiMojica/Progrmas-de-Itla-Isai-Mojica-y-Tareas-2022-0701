#include <stdio.h>
/* Ordenación por selección directa. */
const int MAX = 100;
int Lectura(int *, int);
int Ordena(int *, int); 
int Imprime(int *, int);
int main(void)
{
int TAM, VEC[MAX];
do
{
printf("Ingrese el tamaño del arreglo: ");
scanf("%d", &TAM);
}
while (TAM>MAX , TAM<1); 
int Lectura(int VEC,int TAM);
int Ordena(int VEC,int TAM);
int Imprime(int VEC,int TAM);
}
int Lectura(int A[], int T)
{
int I;
for (I=0; I<T; I++)
{
printf("Ingrese el elemento %d: ", I+1);
scanf("%d", &A[I]);
}
}
int Imprime(int A[], int T)
{
int I;
for (I=0; I<T; I++)
printf("\nA[%d]: %d", I, A[I]);
}
int Ordena(int A[], int T)

{
int I, J, MEN, L;
for (I=0; I < (T-1); I++)
{
MEN = A[I];
L = I;
for (J=(I+1); J<T; J++)
if (A[J] < MEN)
{
MEN = A[J];
L = J;
}
A[L] = A[I];
A[I] = MEN;
}
}
