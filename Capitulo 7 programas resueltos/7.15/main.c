#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

/* Decodifica.
El programa decodifica una cadena de caracteres compuesta por números y
letras. */

int interpreta(char *); /* Prototipo de función. */

int main(void)
{
    char cad[50];
    printf("\nIngrese la cadena de caracteres: ");
    fgets(cad, 50, stdin);
    interpreta(cad);
    return 0;
}

int interpreta(char *cadena)
/* Esta función se utiliza para decodificar la cadena de caracteres. */
{
    int i = 0, j, k;
    while (cadena[i] != '\0')
    {
        if (isalpha(cadena[i])) /* Se utiliza isalpha para observar si el caracter
                                    es una letra. */
        {
            k = cadena[i] - '0';
            /* En la variable entera k se almacena el ascii del número —convertido
            en caracter— que nos interesa, menos '0' que corresponde al ascii
            del dígito 0. */
            for (j = 0; j < k; j++)
                printf("%c", cadena[i]);
        }
        i++;
    }
    return 0;
}
