#include <stdio.h>
#include <stdlib.h>
#define MAX 20

int main(void)
{
    char *cad0 = "Buenos dias";
    char cad1[MAX] = "Hola";
    char cad2[] = "Mexico";
    char cad3[] = {'B', 'i', 'e', 'n', 'v', 'e', 'n', 'i', 'd', 'o', '\0'};
    char cad4[MAX], cad5[MAX], cad6[MAX];
    char p;
    int i = 0;

    printf("\nLa cadena cad0 es: %s\n", cad0);
    printf("La cadena cad1 es: %s\n", cad1);
    printf("La cadena cad2 es: %s\n", cad2);
    printf("La cadena cad3 es: %s\n", cad3);

    printf("\nIngrese una linea de texto: \n");
    fgets(cad4, MAX, stdin);
    printf("La cadena cad4 es: %s", cad4);

    printf("\nIngrese una linea de texto: \n");
    scanf("%19s", cad5);
    printf("La cadena cad5 es: %s", cad5);

    printf("\nIngrese una linea de texto: \n");
    while ((p = getchar()) != '\n' && i < MAX - 1)
    {
        cad6[i++] = p;
    }
    cad6[i] = '\0';
    printf("La cadena cad6 es: %s", cad6);

    return 0;
}
