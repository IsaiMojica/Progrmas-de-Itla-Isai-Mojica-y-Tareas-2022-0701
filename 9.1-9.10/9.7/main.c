#include <stdio.h>
#include <stdlib.h>

/* Esta función lee los datos de los alumnos desde un archivo, e imprime tanto
   la matrícula como el promedio de cada alumno. */
void calcular_promedios(FILE *archivo) {
    int cantidad_alumnos, matricula;
    float promedio, calificacion;

    fscanf(archivo, "%d", &cantidad_alumnos);

    for (int i = 0; i < cantidad_alumnos; i++) {
        fscanf(archivo, "%d", &matricula);
        printf("%d\t", matricula);

        promedio = 0;
        for (int j = 0; j < 5; j++) {
            fscanf(archivo, "%f", &calificacion);
            promedio += calificacion;
        }
        promedio /= 5;

        printf("\t%.2f\n", promedio);
    }
}

int main() {
    FILE *archivo;
    archivo = fopen("datos_alumnos.txt", "r");

    if (archivo == NULL) {
        printf("No se pudo abrir el archivo\n");
        return 1;
    }

    calcular_promedios(archivo);

    fclose(archivo);
    return 0;
}
