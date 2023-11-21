using System;

namespace Builder {
    class Car {
        //Atributos que serão construidos no carro
        public string Type { get; set; }
        public string Color { get; set; }
        public int Potencia { get; set; }
        public string Placa { get; set; }

        public void Mostrar() {
            Console.WriteLine($"Tipo:{Type}, Cor:{Color}, Potência:{Potencia}, Placa:{Placa}.");
        }
    }
}
