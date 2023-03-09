#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* Declaración de la estructura */
struct alumno {
    int matricula;
    char nombre[20];
    char carrera[20];
    float promedio;
    char direccion[20];
};

/* Prototipo de función */
void Lectura(struct alumno *);

int main(void) {
    /* Declaración de variables */
    struct alumno a0 = {120, "María", "Contabilidad", 8.9, "Querétaro"};
    struct alumno *a3, *a4, *a5;
    struct alumno a6;

    /* Asignación de direcciones de memoria */
    a3 = &a0;
    a4 = (struct alumno *) malloc(sizeof(struct alumno));
    a5 = (struct alumno *) malloc(sizeof(struct alumno));

    /* Lectura de datos del alumno 4 */
    printf("\nIngrese la matrícula del alumno 4: ");
    scanf("%d", &(a4->matricula));
    fflush(stdin);

    printf("Ingrese el nombre del alumno 4: ");
    gets(a4->nombre);

    printf("Ingrese la carrera del alumno 4: ");
    gets(a4->carrera);

    printf("Ingrese el promedio del alumno 4: ");
    scanf("%f", &(a4->promedio));
    fflush(stdin);

    printf("Ingrese la dirección del alumno 4: ");
    gets(a4->direccion);

    /* Lectura de datos del alumno 5 */
    Lectura(a5);

    /* Lectura de datos del alumno 6 */
    Lectura(&a6);

    /* Impresión de datos */
    printf("\nDatos del alumno 3\n");
    printf("%d\t%s\t%s\t%.2f\t%s\n", a3->matricula, a3->nombre, a3->carrera, a3->promedio, a3->direccion);

    printf("\nDatos del alumno 4\n");
    printf("%d\t%s\t%s\t%.2f\t%s\n", a4->matricula, a4->nombre, a4->carrera, a4->promedio, a4->direccion);

    printf("\nDatos del alumno 5\n");
    printf("%d\t%s\t%s\t%.2f\t%s\n", a5->matricula, a5->nombre, a5->carrera, a5->promedio, a5->direccion);

    printf("\nDatos del alumno 6\n");
    printf("%d\t%s\t%s\t%.2f\t%s\n", a6.matricula, a6.nombre, a6.carrera, a6.promedio, a6.direccion);

    /* Liberación de memoria */
    free(a4);
    free(a5);

    return 0;
}

/* Esta función permite leer los campos de un apuntador de tipo estructura alumno. */
void Lectura(struct alumno *a) {
    printf("\nIngrese la matrícula del alumno: ");
    scanf("%d", &(a->matricula));
    fflush(stdin);

    printf("Ingrese el nombre del alumno: ");
    gets(a->nombre);

    printf("Ingrese la carrera del alumno: ");
    gets(a->carrera);

    printf("Ingrese el promedio del alumno: ");
    scanf("%f", &(a->promedio));
    fflush(stdin);

    printf("Ingrese la dirección del alumno: ");
    gets(a->direccion);
}
