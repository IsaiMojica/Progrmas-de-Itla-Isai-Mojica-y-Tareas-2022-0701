#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>

//Se incluyen las librerías necesarias para el funcionamiento del programa, que son "stdio.h", "stdlib.h", "string.h" y "unistd.h".


void imprime( int *tab, int fil, int col, int ultNum )
{

//Esta es una función que se encarga de imprimir el estado actual de la torre de Hanoi.
//Recibe un puntero a la matriz que representa el estado de la torre, la cantidad de filas y columnas de la matriz y el número máximo de discos.


    int f, c;
    int i, esp;




    for( c=col-1; c >= 0; c-- )
    {
        for( f=0; f < fil; f++ )
        {
            esp = ( ultNum - tab[col*f+c] )/2;


            for( i=0; i < esp; i++ )
                printf( " " );


            for( i=0; i < tab[col*f+c]; i++ )
                printf( "*" );



            for( i=0; i < esp; i++ )
                printf( " " );



            printf( "\t" );
        };



        printf( "\n" );
    };




};




void mueveDisco( int *tab, int fil, int col, int ultNum, int filOrig, int filDest )
{


//Esta es una función que se encarga de mover un disco de una posición a otra.
//Recibe un puntero a la matriz que representa el estado de la torre, la cantidad de filas y columnas de la matriz, el número máximo de discos, la fila de origen y la fila de destino.


    int cO=col-1, cD=col-1;



    while( cO >= 0  &&  tab[col*filOrig+cO] == 0 )
    {
        cO--;
    };
    if( cO < 0 )
        cO = 0;



    while( cD >= 0  &&  tab[col*filDest+cD] == 0 )
    {
        cD--;
    };


    tab[col*filDest+cD+1] = tab[col*filOrig+cO];
    tab[col*filOrig+cO] = 0;



    imprime( tab, fil, col, ultNum );
};



void delay(int tiempo)
{


//Esta es una función que se encarga de hacer una pausa en la ejecución del programa. Recibe como parámetro la cantidad de tiempo en segundos que se desea esperar.

    int c, d;
    while(tiempo >= 0)
    {
        for (c = 1; c <= 10000; c++)
            for (d = 1; d <= 10000; d++)
            {}
        tiempo--;
    }



}



void hanoi( int *tab, int fil, int col, int disc, int ultNum, int O, int A, int D )
{


//Esta es una función recursiva que se encarga de mover los discos de una posición a otra.
//Recibe un puntero a la matriz que representa el estado de la torre, la cantidad de filas y columnas de la matriz,
//la cantidad de discos, el número máximo de discos, las filas de origen, auxiliar y destino.


    if( disc==1 )
    {

        system("cls");
      //system("clear");
        mueveDisco( tab, fil, col, ultNum, O, D );
        if(col<=5) delay(4);
        else if(col<=10) delay(3);
        else if(col<=15) delay(2);
        else if(col>15) delay(1);
    }
    else
    {
        hanoi( tab, fil, col, disc-1, ultNum, O, D, A );



        system("cls");
        mueveDisco( tab, fil, col, ultNum, O, D );
        if(col<=5) delay(4);
        else if(col<=10) delay(3);
        else if(col<=15) delay(2);
        else if(col>15) delay(1);



        hanoi( tab, fil, col, disc-1, ultNum, A, O, D );
    };



};





int main()
{
    int fil=3, col, *tablero = NULL;
    int f, c, disc=1, ultNum;

//Esta es la función principal del programa, donde se inicializan las variables necesarias, se solicita al usuario la cantidad de discos,
// se crea la matriz que representa el estado de la torre y se llama a la función recursiva "hanoi".


    printf( "Indique el numero de discos: " );
    scanf( "%i", &col );




    tablero = (int *)malloc( sizeof(int)*fil*col );



    for( f=0; f < fil; f++ )
        for( c=col-1; c >= 0; c-- )
            if( f==0 )
            {
                tablero[col*f+c] = disc;
                disc+=2;
            }
            else
                tablero[col*f+c] = 0;



    ultNum = disc;



    system("clear");
    imprime( tablero, fil, col, ultNum );
    delay(6);




    hanoi( tablero, fil, col, col, ultNum, 0, 1, 2 );
};
