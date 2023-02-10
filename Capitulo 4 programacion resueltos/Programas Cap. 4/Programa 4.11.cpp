# include <stdio.h>
/* Mayor divisor.
El programa, al recibir como dato un número entero positivo, calcula
? su mayor divisor. */
int mad(int); /* Prototipo de función. */
int main(void)
{
int NUM, RES;
printf("\nIngresa el número: ");
scanf("%d", &NUM);
RES = mad(NUM);
printf("\nEl mayor divisor de %d es: %d", NUM, RES);
}
int mad(int N1)
/* Esta función calcula el mayor divisor del número N1. */
{
	int I = (N1 / 2);
/* I se inicializa con el máximo valor posible que puede ser divisor
? de N1. */
while (N1 % I)
I--;
return I;
}
