#include <stdio.h>

int main(void)
{
    char cad[50];
    int res;
    FILE *ar;

    if ((ar = fopen("arc.txt", "w")) == NULL)
    {
        printf("No se puede abrir el archivo");
        return 1;
    }

    do
    {
        fflush(stdin);
        printf("\n¿Desea ingresar una cadena de caracteres? Si-1 No-0:");
        scanf("%d", &res);

        if (res)
        {
            printf("Ingrese la cadena: ");
            fflush(stdin);
            fgets(cad, sizeof(cad), stdin);
            fputs(cad, ar);
            fputs("\n", ar);
        }
    } while (res);

    fclose(ar);

    if ((ar = fopen("arc.txt", "r")) == NULL)
    {
        printf("No se puede abrir el archivo");
        return 1;
    }

    while (fgets(cad, sizeof(cad), ar))
    {
        printf("%s", cad);
    }

    fclose(ar);

    return 0;
}
