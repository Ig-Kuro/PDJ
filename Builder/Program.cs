using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            //Criação de instancias
            CarBuildDirector director = new CarBuildDirector();

            //Criação de um carro sport
            CarBuilder sportCarBuilder = new SportCarBuilder();
            Car sportcar = director.Construct(sportCarBuilder);
            sportcar.Mostrar();

            //Construção de um SUV
            CarBuilder suvBuilder = new SuvBuilder();
            Car suv = director.Construct(suvBuilder);
            suv.Mostrar();
        }
    }
}
