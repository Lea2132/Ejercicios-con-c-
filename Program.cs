// Ejercicio 1 operaciones con fraccionarios
/*Console.WriteLine("escriba el numerador de la primer fraccion:");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("escriba el denominador de la primer fraccion:");
int den1=int.Parse(Console.ReadLine());
Console.WriteLine("escriba el numerador de la segunda fraccion");
int num2=int.Parse(Console.ReadLine());
Console.WriteLine("escriba el denominador de la segunda fraccion");
int den2=int.Parse(Console.ReadLine());
int Rnume=0;
int Rdeno=0;

if(den1!=0 && den2!=0){
Console.WriteLine("**ESCOJA UNA OPCION**");
Console.WriteLine("1.sumar (+)");
Console.WriteLine("2.restar (-)");
Console.WriteLine("3.multiplicar (x)");
Console.WriteLine("4.dividir (/)");
int opc=int.Parse(Console.ReadLine());
switch(opc){
    case 1:
        Rnume=(num1*den2)+(den1*num2);
        Rdeno=den1*den2;
        Console.WriteLine($"la fraccion resultante es:{Rnume}/{Rdeno}");
        
    break;
    case 2:
        Rnume=(num1*den2)-(den1*num2);
        Rdeno=den1*den2;
        Console.WriteLine($"la fraccion resultante es:{Rnume}/{Rdeno}");
    break;
    case 3:
        Rnume=num1*num2;
        Rdeno=den1*den2;
        Console.WriteLine($"la fraccion resultante es:{Rnume}/{Rdeno}");
    break;
    case 4:
        Rnume=num1*den2;
        Rdeno=den1*num2;
        Console.WriteLine($"la fraccion resultante es:{Rnume}/{Rdeno}");
    break;

    default:
        Console.WriteLine("Numero fuera de rango de opciones");
    break;
}
}
else {
    Console.WriteLine("recuerda que no se puede dividir entre 0");
}*/
///Ejercicio 2 numero especial
/*Console.WriteLine("¿escriba el numero?");
int numero=int.Parse(Console.ReadLine());

if(numero%5==0){
    if (numero%2!=0){
        if(numero%3!=0){
        Console.WriteLine("el numero es especial");
        }
        else{Console.WriteLine("el numero es divisible por 3 entonces no es especial");}
        }
    else{Console.WriteLine("el numero es divisible por 5 pero tambien por 2, entonces no es especial");}
    }
else {
    Console.WriteLine("el numero no es especial porque no es divisible por 5");
}*/

///Ejercicio 3 Dias y semanas
/*Console.WriteLine("cuantos años tiene:");
int edad=int.Parse(Console.ReadLine());
int auxi=edad;
int i=0;
int cont=0;
//ciclo while para ver según la edad cuantas veces cabe el 4 entero sin decimales
while(i==0){
    if(auxi>=4){
        auxi-=4;
        cont+=1;
    }
    else{
    i=1;
    }
}
//dias biciestos convertidos a semanas;
double semanabi=cont/7;
int dias=(edad*365+cont);
//el año corresponde a 52 semanas mas un dia
double semanas=(edad*52.143+semanabi);
Console.WriteLine("la cantidad de dias que han pasado desde que ud nacio han sido de: "+dias);
Console.WriteLine("la cantidad de semanas que han pasado desde que ud nacio es de "+semanas);
*/

// Ejercicio 4 programa que simule inicio de sesión
/*string usuario="admin";
string contraseña="12345";
int intentos=0;
int posiblesintentos=3;
bool inicio=false;
do{
Console.WriteLine("cual es el usuario:");
string usuarioTemporal=Console.ReadLine(); 
if(usuarioTemporal==usuario){
    Console.WriteLine("cual es la contraseña:");
    string password=Console.ReadLine();
    if(password==contraseña){
        Console.WriteLine("el inicio de sesion fue exitoso");
        Console.WriteLine("****ESTAS DENTRO DEL SISTEMA****");
        inicio=true;
        intentos=3;
    }
    else{
        intentos+=1;
        posiblesintentos-=1;
        if(posiblesintentos!=0){Console.WriteLine("el usuario o la contraseña son incorrectos, vuelva a insertar usuario y contraseña porfavor");}
        else{Console.WriteLine("el usuario o la contraseña son incorrrectos");}
    }
}
else{
    intentos+=1;
    posiblesintentos-=1;
    if(posiblesintentos!=0){Console.WriteLine("el usuario o la contraseña son incorrectos, vuelva a insertar usuario");}
    else{Console.WriteLine("el usuario o la contraseña son incorrectos");}
}
if(inicio!=true){Console.WriteLine("intentos restantes: "+posiblesintentos);}
}while(intentos!=3);

if(inicio!=true){
    Console.WriteLine("sistema bloqueado por exceso de intentos ");
}*/

