using System;


namespace Builder
{
    class SuvBuilder : CarBuilder {
        private Car car = new Car();
        public void BuildType() {
            car.Type = "Carro SUV";
        }
        public void BuildColor() {
            car.Color = "Verde";
        }
        public void BuildPotencia() {
            car.Potencia = 160;
        }
        public void BuildPlaca() {
            car.Placa = "HRF8969";
        }
        public Car GetResult() {
            return car;
        }
    }
}
