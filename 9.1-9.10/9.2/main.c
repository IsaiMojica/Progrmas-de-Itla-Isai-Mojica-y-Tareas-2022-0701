#include <stdio.h>
#include <stdlib.h>

/* Archivos y caracteres.
El programa lee caracteres de un archivo. */
int main(void)
{
    char p1;
    FILE *ar;
    if ((ar = fopen("arc.txt", "r")) != NULL) /* Se abre el archivo para lectura. */
    {
        while ((p1 = fgetc(ar)) != EOF) /* Se leen caracteres del archivo mientras no se detecte el fin del archivo. */
        {
            putchar(p1); /* Despliega el caracter en la pantalla. */
        }
        fclose(ar);
    }
    else
    {
        printf("No se puede abrir el archivo.\n");
        return 1;
    }
    return 0;
}
