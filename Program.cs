/*
//Задача 2. Написать прогу, кот на вход принимает два числа 
//и выдает, какое число большее, а какое меньшее

int num1;
int num2;

// Ввод данных
Console.Write("a= ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b= ");
num2 = Convert.ToInt32(Console.ReadLine());

//вычисление и вывод данных
if(num1 > num2 ){
    Console.WriteLine("max = " + num1 );
}
else{
    Console.WriteLine("max = " + num2 );
}


*/


/*


//Задача 4. Написать прогу, кот на вход принимает три числа 
//и выдает max из этих чисел

int num1;
int num2;
int num3;

// Ввод данных
Console.Write("a= ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b= ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("c= ");
num3 = Convert.ToInt32(Console.ReadLine());

// Вычисление и вывод данных

if(num1 > num2 ){
    if(num1 > num3){
    Console.WriteLine("max = " + num1 );
}
else{Console.WriteLine("max = " + num3 );}
}

else if(num2 > num3){
    Console.WriteLine("max = " + num2 );
}
else{
   Console.WriteLine("max = " + num3 ); 
}


*/


/*


//Задача 6. Написать прогу, кот на вход принимает число 
//и выдает, является ли это число четным (делится ли оно на два без остатка)

int n;

// Ввод данных
Console.Write("Введите число= ");
n = Convert.ToInt32(Console.ReadLine()); 

//вычисление и вывод данных

if(n % 2 == 0)
{

     Console.WriteLine("четное" );
} 
else
{
     Console.WriteLine("нечетное" );
}


*/


/*

// Задача 8. Наисать прогу, кот на входе принимает число (N),
// а на выходе показывает все четные числа от 1 до N.


int n;

// Ввод данных
Console.Write("Введите число= ");
n = Convert.ToInt32(Console.ReadLine()); 

//вычисление и вывод данных

 int current=1;
 
while(current<=n)
{
    if(current % 2 == 0)
    {
       Console.Write( current + " " );
       current++;
    }
    else
    {
        current++;

    }
}

*/