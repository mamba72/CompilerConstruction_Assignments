#include <stdio.h>

//Created a program does factorial
int main()
{
    int num = 3;

    int product = 1;

    while(num > 0)
    {
        product *= num;

        num = num - 1;
    }

    printf("Product:",product);

    return 0;
}