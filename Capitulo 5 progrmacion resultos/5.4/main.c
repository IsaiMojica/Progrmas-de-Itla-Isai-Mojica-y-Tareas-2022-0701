#include <stdio.h>
#include <stdlib.h>

/* Product of vectors.
The program calculates the product of two vectors and stores the result
in another one-dimensional array. */
const int MAX = 10; /* A constant is defined for the size of the arrays. */
void Lectura(int VEC[], int T);
void Imprime(int VEC[], int T); /* Function prototypes. */
void Producto(int X[], int Y[], int Z[], int T); // Observe that in the parameters, to indicate that what is received is an array, you can write VEC[] or *VEC. *//

int main(void)
{
  int VE1[MAX], VE2[MAX], VE3[MAX];
  /* Three integer arrays of 10 elements are declared. */
  Lectura(VE1, MAX);
  /* The Lectura function is called. Observe that the passing of the array to the function is by reference. Only the name of the array should be included. */
  Lectura(VE2, MAX);
  Producto(VE1, VE2, VE3, MAX);
  /* The Producto function is called. The names of the three arrays are passed. */
  printf("\nProduct of Vectors\n");
  Imprime(VE3, MAX);
  return 0;
}

void Lectura(int VEC[], int T)
/* The Lectura function is used to read a one-dimensional integer array of T elements. */
{
  int I;
  printf("\n");
  for (I = 0; I < T; I++)
  {
    printf("Enter element %d: ", I + 1);
    scanf("%d", &VEC[I]);
  }
}

void Imprime(int VEC[], int T)
/* The Imprime function is used to print a one-dimensional integer array of T elements. */
{
  int I;
  for (I = 0; I < T; I++)
    printf("\nVEC[%d]: %d", I + 1, VEC[I]);
}

void Producto(int X[], int Y[], int Z[], int T)
/* This function is used to calculate the product of two one-dimensional integer arrays of T elements. */
{
  int I;
  for (I = 0; I < T; I++)
    Z[I] = X[I] * Y[I];
}
