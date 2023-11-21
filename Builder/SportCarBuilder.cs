using System;


namespace Builder {
    class SportCarBuilder : CarBuilder {
        private Car car = new Car();
        public void BuildType() {
            car.Type = "Carro esportivo";
        }

        public void BuildColor() {
            car.Color = "Vermelho";
        }

        public void BuildPotencia() {
            car.Potencia = 140;
        }
        public void BuildPlaca() {
            car.Placa = "HLK7540";
        }

        public Car GetResult() {
            return car;
        }
    }
}
