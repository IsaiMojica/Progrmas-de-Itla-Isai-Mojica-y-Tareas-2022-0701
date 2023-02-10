#include <stdio.h>
/* Combinación de variables globales y locales, y parámetros por valor
? y por referencia. */
int a, b, c, d; /* Variables globales. */
void funcion1(int *, int *);
/* Prototipo de función. Observa que los dos parámetros son por
? referencia. */
int funcion2(int, int *);
/* En este prototipo el primer parámetro es por valor y el segundo por
? referencia. */
int main(void)
{
int a; 
a = 1; 
b = 2; 
c = 3;
d = 4;
printf("\n%d %d %d %d", a, b, c, d);
funcion1 (&b, &c);
printf("\n%d %d %d %d", a, b, c, d);
a = funcion2(c, &d);
printf("\n%d %d %d %d", a, b, c, d);
}
void funcion1(int *b, int *c)
{
int d;
a = 5; 
d = 3; 
(*b)++;
(*c) += 2;
printf("\n%d %d %d %d", a, *b, *c, d);
}
int funcion2(int c, int *d)
{
int b;
a++;
b = 7;
c += 3;
(*d) += 2;
printf("\n%d %d %d %d", a, b, c, *d);
return (c);
}
