#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct direccion {
    char calle[50];
    int numero;
    int cp;
    char localidad[50];
};

struct empleado {
    char nombre[50];
    char departamento[50];
    float sueldo;
    struct direccion direccion;
};

void Lectura(struct empleado *e) {
    printf("Ingrese el nombre del empleado: ");
    scanf("%s", e->nombre);
    printf("Ingrese el departamento del empleado: ");
    scanf("%s", e->departamento);
    printf("Ingrese el sueldo del empleado: ");
    scanf("%f", &e->sueldo);
    printf("Ingrese la calle de la direccion del empleado: ");
    scanf("%s", e->direccion.calle);
    printf("Ingrese el numero de la direccion del empleado: ");
    scanf("%d", &e->direccion.numero);
    printf("Ingrese el codigo postal de la direccion del empleado: ");
    scanf("%d", &e->direccion.cp);
    printf("Ingrese la localidad de la direccion del empleado: ");
    scanf("%s", e->direccion.localidad);
}

int main() {
    struct empleado *e1 = malloc(sizeof(struct empleado));
    Lectura(e1);

    struct empleado e4;
    Lectura(&e4);

    printf("Datos del empleado 1\n");
    printf("%s\t%s\t%.2f\t%s\t%d\t%d\t%s\n", e1->nombre, e1->departamento,
           e1->sueldo, e1->direccion.calle, e1->direccion.numero, e1->direccion.cp,
           e1->direccion.localidad);

    printf("Datos del empleado 4\n");
    printf("%s\t%s\t%.2f\t%s\t%d\t%d\t%s\n", e4.nombre, e4.departamento,
           e4.sueldo, e4.direccion.calle, e4.direccion.numero, e4.direccion.cp,
           e4.direccion.localidad);

    free(e1);

    return 0;
}
