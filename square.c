#include "stdio.h"
#include "unistd.h"
#include <stdlib.h>

#define SIZE 5

void clearScreen() {
    system("clear");
}
void drawSquare(int x, int y);
void moveSquare(char inputWord, int *x, int *y);

int main()
{
    char inputWord;
    int x = 0, y = 0;

    drawSquare(x, y);
    
    do
    {
        printf("Select 'w' to move up the square, 'a' to move to the left, 'd' to move it to the right and 's' to move it down");
        printf("\n");
        printf("Or, write 'f' if you want to finish: ");
        scanf(" %c", &inputWord);

        moveSquare(inputWord, &x, &y);
        //usleep(2000000); // 2 seconds
        clearScreen();
        drawSquare(x, y);
    }while(inputWord != 'f');

    printf("See you :3 \n");
    return 0;
}

void drawSquare(int x, int y)
{
    system("clear");

    for (int i = 0; i < y; i++)
    {
        printf("\n");
    }

    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < x; j++)
        {
            printf(" ");
        }

        for (int j = 0; j < SIZE; j++)
        {
            if (i == 0 || i == SIZE - 1 || j == 0 || j == SIZE - 1)
            {
                printf("*");
            }
            else
            {
                printf(" ");
            }
            printf(" ");
        }
        printf("\n");
    }
}

void moveSquare(char inputWord, int *x, int *y)
{
    switch (inputWord)
    {
    case 'a':
        if (*x > 0)
        {
            (*x)--;
        }
        break;
    case 'd':
        if (*x < 80 - SIZE) 
        {
            (*x)++;
        }
        break;
    case 'w':
        if (*y > 0)
        {
            (*y)--;
        }
        break;
    case 's':
        if (*y < 24 - SIZE)
        {
            (*y)++;
        }
        break;
    default:
        break;
    }
}
