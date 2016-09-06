using System;

namespace SistemaEstacionamento
{
    class Estacionamento 
    {
        public byte carrosEstacionadosNoDia;
        private byte carrosEstacionadosNoMomento;
        public byte vagasDisponiveis;
        public float total;

        public string porte;
        public string marca;
        public string modelo;
        private string placa;

        public void RegistrarEntrada(object novoCarro)
        {
            Console.WriteLine("Registrando a entrada do veículo:\nMarca {0}\nModelo {1},\nPlaca {2}, Porte {3}", this.marca, this.modelo, this.placa, this.porte);
            carrosEstacionadosNoMomento++;
            carrosEstacionadosNoDia++;
            vagasDisponiveis--;
        }
        public void RegistrarSaida(object novaCarro)
        {
            Console.WriteLine("Registrando a saida do veículo:\nMarca {0}\nModelo {1},\nPlaca {2}, Porte {3}", this.marca, this.modelo, this.placa, this.porte);
            carrosEstacionadosNoMomento--;
            vagasDisponiveis++;

            if (this.porte == "P")
            {
                total = 10;
            }
            else if (this.porte == "M")
            {
                total = 15;
            }
            else if (this.porte == "G")
            {
                total = 20;
            }
        }
    }
}
