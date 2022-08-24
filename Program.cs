// Урок 6
// 1 Задание 
/*

void counter(void);
int main()
{
    int number;

    do 
    {
        printf("\nEnter a number: ");
        scanf("%d", &number);

        if(number >= 0)
        while(number >= 0);
    }

    printf("\nPress any key to continue...");
    getch();

    return 0;
}

void counter(void)
 */

 // 2 Задание 
/*
 {
    public static Point lineLineIntersection(Point A, Point B, Point C, Point D)
    {
        double a1 = B.y - A.y;
        double b1 = A.x - B.x;
        double c1 = a1 * (A.x) + b1 * (A.y);
        double a2 = D.y - C.y;
        double b2 = C.x - D.x;
        double c2 = a2 * (C.x) + b2 * (C.y);
 
        double determinant = a1 * b2 - a2 * b1;
 
        if (determinant == 0)
        {
            return new Point(double.MaxValue, double.MaxValue);
        }
        else
        {
            double x = (b2 * c1 - b1 * c2) / determinant;
            double y = (a1 * c2 - a2 * c1) / determinant;
            return new Point(x, y);
        }
    }
 }
 */ 