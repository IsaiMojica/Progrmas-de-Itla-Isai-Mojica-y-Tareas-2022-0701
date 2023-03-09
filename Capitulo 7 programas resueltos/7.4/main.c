#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
    char *cad0;
    cad0 = "Argentina";
    puts(cad0);
    cad0 = "Brasil";
    puts(cad0);

    char *cad1 = "";
    fgets(cad1, 100, stdin);

    char cad2[20] = "México";
    puts(cad2);
    fgets(cad2, 20, stdin);
    puts(cad2);

    cad2[10] = 'G';
    cad2[11] = 'u';
    cad2[12] = 'a';
    cad2[13] = 't';
    cad2[14] = 'e';
    cad2[15] = 'm';
    cad2[16] = 'a';

    return 0;
}

