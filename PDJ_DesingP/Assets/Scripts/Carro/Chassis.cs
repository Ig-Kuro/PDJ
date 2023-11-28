using System;
using UnityEngine;

namespace Vehicle {
    public abstract class Chassis : MonoBehaviour {
        public Transform FrenteDireitaPn;
        public Transform FrenteEsquerdaPn;
        public Transform AtrasDireitaPn;
        public Transform AtrasEsquerdaPn;

        // Método que retorna a posição de um pneu com base na enumeração PosicaoPneus
        public Transform GetTyrePosition(PosicaoPneus position) {
            switch (position) {
                case PosicaoPneus.FrenteDireita:
                    return FrenteDireitaPn;
                case PosicaoPneus.FrenteEsquerda:
                    return FrenteEsquerdaPn;
                case PosicaoPneus.AtrasDireita:
                    return AtrasDireitaPn;
                case PosicaoPneus.AtrasEsquerda:
                    return AtrasEsquerdaPn;
            }

            throw new ArgumentOutOfRangeException(nameof(position), position, null);
        }
        protected abstract void OnCollisionEnter(Collision other);
    }
}




