#include <stdio.h>
#include <stdlib.h>

//Aqu� se incluye la librer�a est�ndar de C que provee funciones para entrada y salida de datos.

void hanoi(int n, char origen, char destino, char auxiliar);

//Esta l�nea define la funci�n "hanoi". Recibe cuatro par�metros: el n�mero de discos "n", las torres "origen", "destino" y "auxiliar".


int main()

//Esta es la funci�n principal del programa. Aqu� se pide al usuario que ingrese el n�mero de discos que desea mover y se llama a la funci�n "hanoi".

{
    int n;

    printf("Ingrese el n�mero de discos: ");

    //Esta l�nea muestra un mensaje en la pantalla para que el usuario ingrese el n�mero de discos que desea mover.
    scanf("%d", &n);

    /*Esta l�nea utiliza la funci�n "scanf" para leer el n�mero de discos ingresado por el usuario y lo guarda en la variable "n".*/

    hanoi(n, 'A', 'C', 'B'); // 'A': torre origen, 'C': torre destino, 'B': torre auxiliar

    //Esta l�nea llama a la funci�n "hanoi" con los par�metros correspondientes: el n�mero de discos ingresado por el usuario, la torre "A" como origen, la torre "C" como destino y la torre "B" como auxiliar.


    return 0;
}

void hanoi(int n, char origen, char destino, char auxiliar) //Aqu� se define la funci�n "hanoi". Como se mencion� antes, recibe cuatro par�metros: el n�mero de discos "n" las torres "origen", "destino" y "auxiliar".
{
    if (n == 1) {
        printf("Mover disco 1 de %c a %c\n", origen, destino); //Si el n�mero de discos es 1, el programa simplemente mueve el disco desde la torre origen a la torre destino.
        return;
    }

    hanoi(n-1, origen, auxiliar, destino);
    printf("Mover disco %d de %c a %c\n", n, origen, destino); //Esta l�nea muestra en la pantalla el movimiento que se ha realizado, indicando la torre origen y la torre destino.
    hanoi(n-1, auxiliar, destino, origen);
}
