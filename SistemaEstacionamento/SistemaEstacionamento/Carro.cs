using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento
{
    class Carro
    {
        public string porte;
        public string marca;
        public string modelo;
        private string placa;


        public void Exibir()
        {
            Console.WriteLine("Marca {0}\nModelo {1},\nPlaca {2}, Porte {3}", this.marca ,this.modelo, this.placa,this.porte);
        }
    }
}
