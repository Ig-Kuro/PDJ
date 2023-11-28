using System.Collections.Generic;
using UnityEngine;

namespace Vehicle {
    public class Vehicle : MonoBehaviour {
        private Dictionary<PosicaoPneus, Pneus> pneus;
        private Chassis chassis;

        public void SetComponents(Dictionary<PosicaoPneus, Pneus> tyres, Chassis chassis) {
            pneus = tyres;
            chassis = chassis;
        }
    }

}