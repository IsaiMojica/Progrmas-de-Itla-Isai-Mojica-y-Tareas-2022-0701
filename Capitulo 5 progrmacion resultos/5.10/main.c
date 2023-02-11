#include <stdio.h>
#include <stdlib.h>

const int MAX = 100;

void Lectura(int A[], int T);
int Busca(int A[], int T, int E);

int main(void) {
    int RES, ELE, TAM, VEC[MAX];
    do {
        printf("Ingrese el tamaño del arreglo: ");
        scanf("%d", &TAM);
    } while (TAM > MAX || TAM < 1);
    Lectura(VEC, TAM);
    printf("\nIngrese el elemento a buscar:");
    scanf("%d", &ELE);
    RES = Busca(VEC, TAM, ELE);
    if (RES) {
        printf("\nEl elemento se encuentra en la posición: %d", RES);
    } else {
        printf("\nEl elemento no se encuentra en el arreglo");
    }
    return 0;
}

void Lectura(int A[], int T) {
    int I;
    for (I = 0; I < T; I++) {
        printf("Ingrese el elemento %d: ", I + 1);
        scanf("%d", &A[I]);
    }
}

int Busca(int A[], int T, int E) {
    int RES = 0, I = 0;
    while (I < T && A[I] < E) {
        I++;
    }
    if (I < T && A[I] == E) {
        RES = I + 1;
    }
    return RES;
}
