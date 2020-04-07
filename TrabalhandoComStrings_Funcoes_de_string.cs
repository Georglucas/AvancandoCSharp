using System;
using System.Collections.Generic;
using System.Text;

namespace AvancandoCSharp
{
    class TrabalhandoComStrings_Funcoes_de_string
    {
        //Trabalhando Com Strings - Funções de string
        /*
        string pangrama = "Pack, my, box, with, five, dozen, liquor, jugs.";

        WriteLine($"Pandagrama: {pangrama}");
        WriteLine($"Tamanho do pangrama: {pangrama.Length}");//retorna a quantidade de caracteres de uma string

        string[] partes = pangrama.Split(",");//comando que divide a string em array conforme o argumento ()
        for (int i=0; i<partes.Length;  i++){
            WriteLine(partes[i].TrimStart()); //imprime o conteudo do array através dos indices do array; Trim() remove os espaço do começo e do final
                                              //TrimEnd() remove os espaços do final e TrimStart() do começo
                            }


        ************************************************************************************************************************************************************************


        string email = "scirovicza@gmail.com";

        string validaEmail = "@";//verifica se o valor que esta armazenado na string email é um e-mail.
        var retornaEmail = email.Contains(validaEmail);

        if (retornaEmail==true)
        {
            WriteLine("E-mail validado");
        }else WriteLine("E-mail inválido");
        //WriteLine(retornaEmail);

        ************************************************************************************************************************************************************************

        string frase = "“Um otimista vê uma oportunidade em cada calamidade. Um pessimista vê uma calamidade em cada oportunidade.” Sir Winston Churchill";
        string subFrase = "oportunidade";

        int posInicial = frase.IndexOf(subFrase);//IndexOf retorna -1 caso a palavra nao exista
        int posFinal = 10;

        string sub = frase.Substring(posInicial, posFinal );//extrai um intervalo da string; sem a variavel "posFinal" a Substring vai ate o fim da frase

        WriteLine(sub);

        WriteLine(frase);
        //WriteLine(subFrase);
        if(posInicial == -1)
        {
            WriteLine("Palavra inexistente.");

        }else WriteLine($"A palavra {subFrase} está na posição {posInicial}.");
                 WriteLine(posFinal);

        ************************************************************************************************************************************************************************
      
        //Função que coloca as letras contidas em uma variavel do tipo string, em maiusculas ou minusculas.
        string frase = "Trabalhando Com Strings - Funções de strings";
        string frase_Trocada = frase.Replace("Strings", "[dado substituido]", true, CultureInfo.CurrentCulture);// true no terceiro parametro ignora se é maiuscula ou minuscula
        WriteLine(frase.ToUpper());
        WriteLine(frase.ToLower());
        WriteLine(frase_Trocada);
          */
    }
}

