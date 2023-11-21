using System;

namespace Builder {
    //Interface para a construção do carro
    interface CarBuilder {
        void BuildType();
        void BuildColor();
        void BuildPotencia();
        void BuildPlaca();
        Car GetResult();
    }
}
