#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

typedef struct alumno{
    char nombre[50];
    char apellido[50];
    char fecha_nacimiento[11];
    char hora_fin[9];
    struct alumno* proximo;
} Alumno;

void imprimir_menu();
void nuevo_alumno();
void borrar_alumno();
void buscar_alumno();
void guardar_alumnos();
void leer_alumnos();

Alumno* primer_alumno = NULL;

int main() {
    int opcion;

    do {
        imprimir_menu();
        scanf("%d", &opcion);
        switch (opcion) {
            case 1:
                nuevo_alumno();
                break;
            case 2:
                borrar_alumno();
                break;
            case 3:
                buscar_alumno();
                break;
            case 4:
                guardar_alumnos();
                break;
            case 5:
                leer_alumnos();
                break;
            case 6:
                printf("Saliendo del programa...\n");
                break;
            default:
                printf("Opcion invalida, por favor ingrese otra opcion\n");
        }
    } while (opcion != 6);

    return 0;
}

void imprimir_menu() {
    printf("MENU\n");
    printf("1. Nuevo alumno\n");
    printf("2. Borrar alumno\n");
    printf("3. Buscar alumno\n");
    printf("4. Guardar alumnos\n");
    printf("5. Leer alumnos\n");
    printf("6. Salir\n");
    printf("Ingrese una opcion: ");
}

void nuevo_alumno() {
    Alumno* nuevo = (Alumno*) malloc(sizeof(Alumno));

    printf("Ingrese el nombre del alumno: ");
    scanf("%s", nuevo->nombre);

    printf("Ingrese el apellido del alumno: ");
    scanf("%s", nuevo->apellido);

    printf("Ingrese la fecha de nacimiento (formato dd/mm/aaaa): ");
    scanf("%s", nuevo->fecha_nacimiento);

    printf("Ingrese la hora de fin de la clase (formato hh:mm:ss): ");
    scanf("%s", nuevo->hora_fin);

    nuevo->proximo = primer_alumno;
    primer_alumno = nuevo;

    printf("Alumno agregado exitosamente\n");
}

void borrar_alumno() {
    char nombre[50];
    char apellido[50];

    printf("Ingrese el nombre del alumno que desea borrar: ");
    scanf("%s", nombre);

    printf("Ingrese el apellido del alumno que desea borrar: ");
    scanf("%s", apellido);

    Alumno* actual = primer_alumno;
    Alumno* anterior = NULL;

    while (actual != NULL) {
        if (strcmp(actual->nombre, nombre) == 0 && strcmp(actual->apellido, apellido) == 0) {
            if (anterior == NULL) {
                primer_alumno = actual->proximo;
            } else {
                anterior->proximo = actual->proximo;
            }
            free(actual);
            printf("Alumno borrado exitosamente\n");
            return;
        }
        anterior = actual;
        actual = actual->proximo;
    }

    printf("No se encontro al alumno\n");
}

void buscar_alumno() {
    char nombre[50];
    char apellido[50];

    printf("Ingrese el nombre del alumno que desea buscar: ");
    scanf("%s", nombre);

    printf("Ingrese el apellido del alumno que desea buscar: ");
    scanf("%s", apellido);

    Alumno* actual = primer_alumno;

while (actual != NULL) {
    if (strcmp(actual->nombre, nombre) == 0 && strcmp(actual->apellido, apellido) == 0) {
        printf("Nombre: %s\n", actual->nombre);
        printf("Apellido: %s\n", actual->apellido);
        printf("Fecha de nacimiento: %s\n", actual->fecha_nacimiento);
        printf("Hora de fin de la clase: %s\n", actual->hora_fin);
        return;
    }
    actual = actual->proximo;
}

printf("No se encontro al alumno\n");
}

void guardar_alumnos() {
FILE* archivo;
Alumno* actual = primer_alumno;


archivo = fopen("alumnos.txt", "w");

if (archivo == NULL) {
    printf("No se pudo crear el archivo\n");
    return;
}

while (actual != NULL) {
    fprintf(archivo, "%s %s %s %s\n", actual->nombre, actual->apellido, actual->fecha_nacimiento, actual->hora_fin);
    actual = actual->proximo;
}

fclose(archivo);
printf("Alumnos guardados exitosamente\n");
}

void leer_alumnos() {
FILE* archivo;
char nombre[50];
char apellido[50];
char fecha_nacimiento[11];
char hora_fin[9];

archivo = fopen("alumnos.txt", "r");

if (archivo == NULL) {
    printf("No se pudo abrir el archivo\n");
    return;
}

while (fscanf(archivo, "%s %s %s %s", nombre, apellido, fecha_nacimiento, hora_fin) != EOF) {
    printf("Nombre: %s\n", nombre);
    printf("Apellido: %s\n", apellido);
    printf("Fecha de nacimiento: %s\n", fecha_nacimiento);
    printf("Hora de fin de la clase: %s\n", hora_fin);
}

fclose(archivo);
}
