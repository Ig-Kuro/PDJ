using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace Vehicle {
    public class VehicleBuilder {
        // Variáveis de estado para armazenar componentes do veículo em construção
        private Chassis Chassis;
        private readonly Dictionary<PosicaoPneus, Pneus> pneu = new Dictionary<PosicaoPneus, Pneus>();
        private Vector3 Posicao;
        private Quaternion Rotacao;
        private Vehicle Veiculo;


        // Define o chassi do veículo
        public VehicleBuilder WithChassis(Chassis chassis) {
            Chassis = chassis;
            return this;
        }

        // Adiciona um pneu à posição especificada no veículo
        public VehicleBuilder WithTyre(PosicaoPneus position, Pneus tyre) {
            // Remove pneu existente na posição, se houver
            if (pneu.ContainsKey(position)) {
                pneu.Remove(position);
            }
            // Adiciona o novo pneu na posição especificada
            pneu.Add(position, tyre);
            return this;
        }

        // Define a posição inicial do veículo
        public VehicleBuilder WithPosition(Vector3 position) {
            Posicao = position;
            return this;
        }

        // Define a rotação inicial do veículo
        public VehicleBuilder WithRotation(Quaternion rotation) {
            Rotacao = rotation;
            return this;
        }

        // Define o veículo usando um prefab existente
        public VehicleBuilder FromVehiclePrefab(Vehicle vehicle) {
            Veiculo = vehicle;
            return this;
        }

        // Constrói o veículo com base nas configurações fornecidas
        public Vehicle Build() {
            // Verifica as condições prévias antes de construir o veículo
            CheckPreConditions();

            // Instancia o veículo
            var vehicle = Object.Instantiate(Veiculo, Posicao, Rotacao);

            // Instancia o chassi do veículo
            var chassis = Object.Instantiate(Chassis, vehicle.transform, true);

            // Instancia os pneus do veículo nas posições especificadas
            var tyres = new Dictionary<PosicaoPneus, Pneus>();
            foreach (var tyre in pneu) {
                var tyreInstance = Object.Instantiate(tyre.Value, chassis.GetTyrePosition(tyre.Key));
                tyres.Add(tyre.Key, tyreInstance);
            }

            // Configura os componentes do veículo
            vehicle.SetComponents(tyres, chassis);

            // Retorna o veículo construído
            return vehicle;
        }

        // Verifica as condições prévias necessárias para a construção do veículo
        public void CheckPreConditions() {
            Assert.IsNotNull(Veiculo);
            Assert.IsNotNull(Chassis);
            Assert.AreEqual(4, pneu.Count);
            Assert.IsNotNull(pneu[PosicaoPneus.FrenteEsquerda]);
            Assert.IsNotNull(pneu[PosicaoPneus.FrenteDireita]);
            Assert.IsNotNull(pneu[PosicaoPneus.AtrasEsquerda]);
            Assert.IsNotNull(pneu[PosicaoPneus.AtrasDireita]);
        }
    }
}