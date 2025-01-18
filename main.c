// main.c

#include <stdio.h>

extern int add_numbers(int a, int b);

int main() {
    int result = add_numbers(5, 3);
    printf("Сумма: %d\n", result);
    return 0;
}
