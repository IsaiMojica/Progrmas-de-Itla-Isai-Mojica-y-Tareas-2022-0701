#include <stdio.h>
#include <stdlib.h>

/* Primos.
El programa almacena en un arreglo unidimensional los primeros 100 números primos. */

const int TAM = 100;

void Imprime(int[], int); /* Prototipos de funciones. */
void Primo(int, int*);

int main(void) {
    int p[TAM] = {2};
    int FLA, J = 1, PRI = 3;
    while (J < TAM) {
        FLA = 1;
        Primo(PRI, &FLA);
        /* Si FLA es 1, entonces PRI es primo. */
        if (FLA) {
            p[J] = PRI;
            J++;
        }
        PRI += 2;
    }
    Imprime(p, TAM);
    return 0;
}

void Primo(int A, int *B) {
    int DI = 3;
    while (*B && (DI <= (A / 2))) {
        if ((A % DI) == 0) *B = 0;
        DI++;
    }
}

void Imprime(int Primos[], int T) {
    int I;
    for (I = 0; I < T; I++)
        printf("\nPrimos[%d]: %d", I, Primos[I]);
}
