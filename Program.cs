//  eSCREVA A MENSAGEM "INFORME UM NUMERO"
Console.Write("informe um numero: ");
// CRIAAVARIAVELQUESALVAUMNUMERO, LEIA OQ O USUARIO DIGITAR
// E TRANSFORMA O VALORLIDO DE TEXTO PARA INTEIRO (INT.PARSE)
int variavelquesalvaumnumero = int.Parse(Console.ReadLine()!);

// VERIFICA SE O VALOR DA VARIAVEL QUE SALVA O NUMERO E PAR
if (variavelquesalvaumnumero % 2 ==0)
{
    Console.WriteLine($"numero {variavelquesalvaumnumero} é par"); //verifica a variavel e diz que é par
} else { //se não for par
    Console.WriteLine($"numero {variavelquesalvaumnumero} é ímpar"); //diz que é impar
} // fim se

