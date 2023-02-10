#include <stdio.h>
/* Elección.
El programa almacena los votos emitidos en una elección en la que hubo cinco
?candidatos e imprime el total de votos que obtuvo cada uno de ellos. */
int main(void)
{
int ELE[5] = {0}; 
int I, VOT;
printf("Ingresa el primer voto (0 - Para terminar):");
scanf("%d", &VOT);
while (VOT)
{
if ((VOT > 0) && (VOT < 6)) 
ELE[VOT-1]++; 
else
printf("\nEl voto ingresado es incorrecto.\n");
printf("Ingresa el siguiente voto (0 - Para terminar): ");
scanf("%d", &VOT);
}
printf("\n\nResultados de la Elección\n");
for (I = 0; I <= 4; I++)
printf("\nCandidato %d: %d", I+1, ELE[I]);
}
