#include <stdio.h>
int trueque(int*x,int*y);
int *x;
int *y;
int main()
{
int tem;
tem = *x;
*x = *y;
*y = tem;
}
int suma(int x)
{
return (x+x);
}
