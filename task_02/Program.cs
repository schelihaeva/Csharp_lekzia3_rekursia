﻿// рекурсия-это функция, кторая вызывает саму себя
// факториал -умножение от 1 до цифры до знака
// 5! = 5*4*3*2*1
//      5*4!
//        4*3!
//          3*2!

double Factorial (int n)   //чтобы не было отриц.значений вместо int ставим double
{  //если дошли до 1 то должны вернуть 1 1!=1, 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
    
}
for (int i = 1; i < 40; i++)
{


Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3=6
}