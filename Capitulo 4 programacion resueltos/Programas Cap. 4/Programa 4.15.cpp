#include <stdio.h>
/* Productoria.
El programa calcula la productoria de los N primeros números naturales. */
int Productoria(int); /* Prototipo de función. */
int main(void)
{
int NUM;
do
{
printf("Ingresa el número del cual quieres calcular la productoria: ");
scanf("%d", &NUM);
}
while (NUM >100 , NUM < 1);
printf("\nLa productoria de %d es: %d", NUM, Productoria(NUM));
}
int Productoria(int N)
{
int I, PRO = 1;
for (I = 1; I <= N; I++)
PRO *= I;
return (PRO);
}
