#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

/* Prototipo de función */
void mayuscula(char *cadena);

/* Minúsculas y mayúsculas */
int main(void)
{
    int i, n;
    char FRA[20][50];

    /* Lectura del número de filas del arreglo */
    printf("\nIngrese el numero de filas del arreglo: ");
    scanf("%d", &n);

    /* Lectura de cada fila del arreglo */
    for (i = 0; i < n; i++)
    {
        printf("Ingrese la linea %d de texto: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], 50, stdin);
    }

    printf("\n\n");

    /* Cálculo de minúsculas y mayúsculas para cada fila del arreglo */
    for (i = 0; i < n; i++)
    {
        mayuscula(FRA[i]);
    }

    return 0;
}

/* Función que calcula el número de minúsculas y mayúsculas en una cadena */
void mayuscula(char *cadena)
{
    int i = 0, mi = 0, ma = 0;

    /* Conteo de minúsculas y mayúsculas */
    while (cadena[i] != '\0')
    {
        if (islower(cadena[i]))
            mi++;
        else if (isupper(cadena[i]))
            ma++;
        i++;
    }

    printf("\n\nNumero de letras minúsculas: %d", mi);
    printf("\nNumero de letras mayúsculas: %d", ma);
}
