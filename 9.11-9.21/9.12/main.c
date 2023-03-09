#include <stdio.h>
#include <stdlib.h>

/* Incorpora caracteres.
El programa agrega caracteres al archivo libro.txt. */
int main(void) {
    char p1;
    FILE *ar;
    ar = fopen("libro.txt", "a");
    /* Se abre el archivo con la opción para incorporar caracteres. */
    if (ar != NULL) {
        while ((p1 = getchar()) != '\n')
            fputc(p1, ar);
        fclose(ar);
        return 0;
    } else {
        printf("No se puede abrir el archivo\n");
        return 1;
    }
}
