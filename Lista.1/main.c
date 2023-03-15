#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX_NOMBRES 100
#define MAX_LONGITUD_NOMBRE 50

int main() {
    char nombres[MAX_NOMBRES][MAX_LONGITUD_NOMBRE];
    int cantidad_nombres = 0;

    FILE* archivo = NULL;

    int opcion = 0;
    do {
        printf("Elija una opción:\n");
        printf("1. Leer lista de nombres\n");
        printf("2. Agregar nombres a la lista\n");
        printf("3. Salir\n");
        fflush(stdin);
        scanf("%d", &opcion);

        switch (opcion) {
            case 1:
                printf("Escriba el nombre del archivo: ");
                char nombre_archivo[MAX_LONGITUD_NOMBRE];
                fflush(stdin);
                gets(nombre_archivo);
                archivo = fopen(nombre_archivo, "r");
                if (archivo == NULL) {
                    printf("No se pudo abrir el archivo '%s'.\n", nombre_archivo);
                } else {
                    int i = 0;
                    while (fgets(nombres[i], MAX_LONGITUD_NOMBRE, archivo) != NULL) {
                        printf("%d. %s", i + 1, nombres[i]);
                        i++;
                    }

                    if (i == 0) {
                        printf("No hay nombres guardados.\n");
                    }

                    fclose(archivo);
                }
                break;
            case 2:
                printf("Escriba el nombre del archivo: ");
                fflush(stdin);
                gets(nombre_archivo);
                archivo = fopen(nombre_archivo, "a+");
                if (archivo == NULL) {
                    printf("No se pudo abrir el archivo '%s'.\n", nombre_archivo);
                } else {
                    int i = 0;
                    while (cantidad_nombres < MAX_NOMBRES) {
                        printf("Escriba el nombre a agregar (o ENTER para terminar): ");
                        fflush(stdin);
                        gets(nombres[cantidad_nombres]);
                        if (strlen(nombres[cantidad_nombres]) == 0) {
                            break;
                        }
                        cantidad_nombres++;
                        fprintf(archivo, "%s\n", nombres[cantidad_nombres - 1]);
                    }
                    fclose(archivo);

                    printf("\nLista de nombres actualizada:\n");
                    for (i = 0; i < cantidad_nombres; i++) {
                        printf("%d. %s", i + 1, nombres[i]);
                    }
                }
                break;
            case 3:
                printf("Saliendo...\n");
                break;
            default:
                printf("Opcion invalida.\n");
        }

        printf("\n");
    } while (opcion != 3);

    return 0;
}
