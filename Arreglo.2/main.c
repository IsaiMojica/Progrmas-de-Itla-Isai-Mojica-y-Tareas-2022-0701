#include <stdio.h>
#include <stdlib.h>

#define ROWS 4
#define COLS 4

int main() {
    int matrix[ROWS][COLS] = { {1, 1, 1, 1},
                               {2, 2, 2, 2},
                               {3, 3, 3, 3},
                               {4, 4, 4, 4} };
    int sum_row[ROWS] = {0};
    int sum_col[COLS] = {0};

    // Sumar los números en columnas y filas
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            sum_row[i] += matrix[i][j];
            sum_col[j] += matrix[i][j];
        }
    }

    // Mostrar los resultados
    printf("Suma por columna:\n");
    for (int j = 0; j < COLS; j++) {
        printf("%d ", sum_col[j]);
    }
    printf("\n");

    printf("Suma por fila:\n");
    for (int i = 0; i < ROWS; i++) {
        printf("%d ", sum_row[i]);
    }
    printf("\n");

    return 0;
}
