using System;

namespace Builder {
    class CarBuildDirector {
        //define a ordem de chamada das etapas de construção
        public Car Construct(CarBuilder builder) {
            builder.BuildType();
            builder.BuildColor();
            builder.BuildPotencia();
            builder.BuildPlaca();
            return builder.GetResult();
        }
    }
}
