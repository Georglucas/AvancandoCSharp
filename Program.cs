using System;
using System.Globalization;
using static System.Console;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace AvancandoCSharp
{

    class Program
    {
        class Carro

        {
            private string _marca;
            public string Marca//{ get; set; }  forma mais simples, não há nenhuma regra para o get/set
            {
                get => _marca;
                set => _marca = value.Equals("Fusca") ? "Outro carro" : value;
            }
            private int _anoFabricacao;
            public int AnoFabricacao
            {
                get => _anoFabricacao;
                set => _anoFabricacao = value;
            }

            static void Main(string[] args)
            {//Listas
                ArrayList arrayList = new System.Collections.ArrayList();//ArrayList aceita qqr tipo de dado/heterogeneo
                arrayList.Add("Lucas");
                arrayList.Add(35);
                arrayList.Add(new object());


                List<string> dias = new List<string>();
                dias.Add("Dom");
                dias.Add("Seg");
                dias.Add("Ter");
                dias.Add("Qua");
                dias.Add("Qui");
                dias.Add("Sex");
                dias.Add("Sab");

                List<Carro> carros = new List<Carro>();
                Carro carro = new Carro();
                carro.Marca = "Civic";
                carro.AnoFabricacao = 2020;
                carros.Add(carro);

                Carro carro2 = new Carro();
                carro2.Marca = "GM";
                carro2.AnoFabricacao = 2019;
                carros.Add(carro2);

                Carro carro3 = new Carro();
                carro3.Marca = "Fusca";
                carro3.AnoFabricacao = 1980;
                carros.Add(carro3);


                foreach(Carro veiculo in carros)
                {
                WriteLine($"Eu tenho um {veiculo.Marca} fabricado em {veiculo.AnoFabricacao}");
                }

            }
        }
    }
}
