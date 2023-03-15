#include <stdio.h>
#include <stdlib.h>

//Aquí se incluye la librería estándar de C que provee funciones para entrada y salida de datos.

void hanoi(int n, char origen, char destino, char auxiliar);

//Esta línea define la función "hanoi". Recibe cuatro parámetros: el número de discos "n", las torres "origen", "destino" y "auxiliar".


int main()

//Esta es la función principal del programa. Aquí se pide al usuario que ingrese el número de discos que desea mover y se llama a la función "hanoi".

{
    int n;

    printf("Ingrese el número de discos: ");

    //Esta línea muestra un mensaje en la pantalla para que el usuario ingrese el número de discos que desea mover.
    scanf("%d", &n);

    /*Esta línea utiliza la función "scanf" para leer el número de discos ingresado por el usuario y lo guarda en la variable "n".*/

    hanoi(n, 'A', 'C', 'B'); // 'A': torre origen, 'C': torre destino, 'B': torre auxiliar

    //Esta línea llama a la función "hanoi" con los parámetros correspondientes: el número de discos ingresado por el usuario, la torre "A" como origen, la torre "C" como destino y la torre "B" como auxiliar.


    return 0;
}

void hanoi(int n, char origen, char destino, char auxiliar) //Aquí se define la función "hanoi". Como se mencionó antes, recibe cuatro parámetros: el número de discos "n" las torres "origen", "destino" y "auxiliar".
{
    if (n == 1) {
        printf("Mover disco 1 de %c a %c\n", origen, destino); //Si el número de discos es 1, el programa simplemente mueve el disco desde la torre origen a la torre destino.
        return;
    }

    hanoi(n-1, origen, auxiliar, destino);
    printf("Mover disco %d de %c a %c\n", n, origen, destino); //Esta línea muestra en la pantalla el movimiento que se ha realizado, indicando la torre origen y la torre destino.
    hanoi(n-1, auxiliar, destino, origen);
}
