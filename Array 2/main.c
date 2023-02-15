#include <stdio.h>
#include <stdlib.h>
#include <time.h>

// función para ordenar en orden descendente
int compare(const void * a, const void * b) {
  return (*(int*)b - *(int*)a);
}

int main() {
  int arr1[5], arr2[5], arr3[10];
  int i, j, k;

  srand(time(NULL)); // inicializar la semilla aleatoria

  // generar valores aleatorios únicos para arr1 y mostrarlos
  printf("Valores aleatorios unicos para arr1: ");
  i = 0;
  while (i < 5) {
    int value = rand() % 100; // valores aleatorios entre 0 y 99
    int exists = 0;
    for (int j = 0; j < i; j++) {
      if (arr1[j] == value) {
        exists = 1;
        break;
      }
    }
    if (!exists) {
      arr1[i] = value;
      printf("%d ", value); // mostrar el valor generado
      i++;
    }
  }
  printf("\n");

  // generar valores aleatorios únicos para arr2 y mostrarlos
  printf("Valores aleatorios unicos para arr2: ");
  i = 0;
  while (i < 5) {
    int value = rand() % 100; // valores aleatorios entre 0 y 99
    int exists = 0;
    for (int j = 0; j < i; j++) {
      if (arr2[j] == value) {
        exists = 1;
        break;
      }
    }
    if (!exists) {
      arr2[i] = value;
      printf("%d ", value); // mostrar el valor generado
      i++;
    }
  }
  printf("\n");

  // ordenar arr1 y arr2 en orden descendente
  qsort(arr1, 5, sizeof(int), compare);
  qsort(arr2, 5, sizeof(int), compare);

  // mezclar los dos arrays ordenados en el tercer array
  i = j = k = 0;
  while (i < 5 && j < 5) {
    if (arr1[i] > arr2[j]) {
      arr3[k++] = arr1[i++];
    } else {
      arr3[k++] = arr2[j++];
    }
  }

  while (i < 5) {
    arr3[k++] = arr1[i++];
  }

  while (j < 5) {
    arr3[k++] = arr2[j++];
  }

  // imprimir el resultado y los arrays generados
  printf("El array mezclado en orden descendente es: ");
  for (i = 0; i < 10; i++) {
    printf("%d ", arr3[i]);
  }
  printf("\n");

  return 0;
}
