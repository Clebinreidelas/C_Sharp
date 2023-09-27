using System;
using Microsoft.VisualBasic;
using  Microsoft;
using System.Runtime.CompilerServices;
//diretiva using que faz referência ao namespace System. Namespaces fornecem um meio hierárquico de organizar bibliotecas e programas em C#. Os namespaces contêm tipos e outros namespaces — por exemplo, o namespace System contém uma quantidade de tipos

class Teste
//A classe Hello declarada pelo programa "Hello, World" tem um único membro, o método chamado Main. O método Main é declarado com o modificador static
{
    static void Main()
    //embora os métodos de instância possam fazer referência a uma determinada instância de objeto delimitador usando a palavra-chave this, métodos estáticos operam sem referência a um objeto específico. Por convenção, um método estático denominado Main serve como ponto de entrada de um programa C#


    {
        // code aqui
        Console.WriteLine("teste");
        // a saída do programa é produzida pelo método WriteLine da classe Console no namespace System. Essa classe é fornecida pelas bibliotecas de classe padrão, que, por padrão, são referenciadas automaticamente pelo compilador.

        //tipos em c#
        //INTEIROS
        int a = 34 ; //inteiro(integer(int)) 
            //inteiro assinado de 32 bits sem sinal
            // tipos de inteiro :
                //SBYTE :
                    //INTERVALO :  -128 a 127 
                    //TAMANHO : INTEIRO DE 8 BITS COM SINAL
                //BYTE :
                    //INTERVALO : 	0 a 255
                    // TAMANHO :Inteiro de 8 bits sem sinal
                // SHORT :
                    //INTERVALO : -32.768 a 32.767
                    //TAMANHO :INTEIRO DE 16 BITS COM SINAL
                //USHORT:
                    //INTERVALO : 0 a 65.535
                    //TAMANHO : INTEIRODE 16 BITS SEM SINAL

                //INT :
                    //INTERVALO : -2.147.483.648 a 2.147.483.647   
                    //TAMANHO :Inteiro assinado de 32 bits
                //UINT :
                    //INTERVALO :0 a 4.294.967.295
                    //TAMANHO :INTEIRO DE 32 BITS SEM SINAL
                //LONG:
                    //INTERVALO : -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
                    //TAMANHO : INTEIRO ASSINADO DE 64 BITS
                //ULONG :
                    //INTERVALO : 0 a 18.446.744.073.709.551.615
                    //TAMANHO : INTEIRO DE 64 BITS SEM SINAL

             

        Console.WriteLine(a);
        //nao gosto de warnings
        
         





            
        


        
        
        
        
        




    }
}