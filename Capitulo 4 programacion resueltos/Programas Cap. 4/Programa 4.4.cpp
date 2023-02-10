#include <stdio.h>
/* Prueba de variables globales, locales y estáticas.
El programa utiliza funciones en las que se usan diferentes tipos de
? variables. */
int f1(void);
int f2(void);
int f3(void); /* Prototipos de funciones. */
int f4(void);
int K = 3; /* Variable global. */
int main(void)
{
int I;
for (I = 1; I <= 3; I++)
{
printf("\nEl resultado de la función f1 es: %d", f1());
printf("\nEl resultado de la función f2 es: %d", f2());
printf("\nEl resultado de la función f3 es: %d", f3());
printf("\nEl resultado de la función f4 es: %d", f4());
}
}
int f1(void)
{
K += K;
return (K);
}
int f2(void)
{
int K = 1;
K++;
return (K);
}
int f3(void)
{
static int K = 8;
K += 2;
return (K);
}
int f4(void)
{
int K = 5;
K = K + ::K; 
return (K);
}
