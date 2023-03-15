#include <stdio.h>
#include <stdlib.h>

/* Incrementa salarios.
El programa incrementa el salario de los empleados de una empresa
—actualiza el archivo correspondiente— si sus ventas son superiores
al millón de pesos anuales. */

typedef struct /* Declaración de la estructura empleado. */
{
    int clave;
    int departamento;
    float salario;
    float ventas[12];
} empleado;

void incrementa(FILE *); /* Prototipo de función. */

int main(void)
{
    FILE *ar;
    if ((ar = fopen("ad5.dat", "r+")) != NULL)
    /* El archivo se abre en la modalidad para leer y escribir. */
    {
        incrementa(ar);
        rewind(ar);
        fclose(ar);
        return 0;
    }
    else
    {
        printf("El archivo no se puede abrir\n");
        return 1;
    }
}

void incrementa(FILE *ap)
/* Esta función se utiliza para incrementar el salario de todos aquellos
➥empleados que hayan tenido ventas anuales por más de $1,000,000.
➥Actualiza además el archivo correspondiente. */
{
    int i, j;
    float sum;
    empleado emple;
    long t = sizeof(empleado);
    /* La función sizeof se utiliza para conocer el tamaño de la estructura
    ➥empleado. */
    fread(&emple, sizeof(empleado), 1, ap); /* Se lee el primer registro
    ➥del archivo. */
    while(!feof(ap))
    {
        i = ftell(ap) / t;
        /* La función ftell se utiliza para conocer la posición de nuestro
        ➥apuntador en el archivo. La variable i nos proporciona en este caso
        ➥el tamaño de todos los bloques que existen debajo de nuestra
        ➥posición. Si conocemos el tamaño de cada bloque, entonces podemos
        ➥obtener el número de bloques que hay exactamente debajo de nuestra
        ➥posición. */
        sum = 0;
        for (j=0; j<12; j++)
            sum += emple.ventas[j]; /* Se calculan las ventas de cada
        ➥vendedor. */
        if (sum > 1000000)
        {
            emple.salario = emple.salario * 1.10; /* Se incrementa el
            ➥salario. */
            fseek(ap, (i-1)*sizeof(empleado), SEEK_SET);
            /* Nos posicionamos para escribir el registro actualizado. */
            fwrite(&emple, sizeof(empleado), 1, ap);
        }
        fread(&emple, sizeof(empleado), 1, ap);
    }
}
