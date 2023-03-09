#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* Alumnos.
El programa lee bloques —variables de tipo estructura alumno— de un archivo
de acceso directo. */

typedef struct {
    int matricula;
    char nombre[20];
    int carrera;
    float promedio;
} alumno;

void lee(FILE *);

int main(void)
{
    FILE *ar;
    if ((ar = fopen("ad1.dat", "rb")) != NULL) {
        lee(ar);
        fclose(ar);
    } else {
        printf("\nEl archivo no se puede abrir");
    }
    return 0;
}

void lee(FILE *ap)
{
    alumno alu;
    fread(&alu, sizeof(alumno), 1, ap);
    while (!feof(ap)) {
        printf("\nMatrícula: %d", alu.matricula);
        printf("\tCarrera: %d", alu.carrera);
        printf("\tPromedio: %f\t ", alu.promedio);
        puts(alu.nombre);
        fread(&alu, sizeof(alumno), 1, ap);
    }
}
