using System;
using UnityEngine;
using UnityEngine.UI;

namespace Vehicle {
    public class UI : MonoBehaviour {
        // Componentes do veículo e botões configuráveis
        public Chassis Chassis1;
        public Chassis Chassis2;
        public Pneus pneu1;
        public Pneus pneu2;
        public Vehicle Veiculo;
        public Button PneuBotao1;
        public Button PneuBotao2;
        public Button ChassiBotao1;
        public Button ChassiBotao2;
        public Button Botao;

        // Construtor de veículos e instância do veículo em construção
        public VehicleBuilder VeiculoBuilder;
        public Vehicle VeiculoInstancia;

        public void Awake() {
            // Inicializa o construtor de veículos usando um prefab existente
            VeiculoBuilder = new VehicleBuilder();
            VeiculoBuilder.FromVehiclePrefab(Veiculo);

            // Configura os listeners para os botões
            PneuBotao1.onClick.AddListener(Pneu1Escolhido);
            PneuBotao2.onClick.AddListener(Pneu2Escolhido);
            ChassiBotao1.onClick.AddListener(Chassis1Escolhido);
            ChassiBotao2.onClick.AddListener(Chassis2Escolhido);
            Botao.onClick.AddListener(BuildPressed);
        }
        
        public void BuildPressed() {
            // Destroi a instância do veículo existente, se houver
            if (VeiculoInstancia != null) {
                Destroy(VeiculoInstancia.gameObject);
            }

            // Constrói e armazena a nova instância do veículo
            VeiculoInstancia = VeiculoBuilder.Build();
        }
      
        public void Chassis1Escolhido() {
            // Configura o Chassis1 no construtor do veículo
            VeiculoBuilder.WithChassis(Chassis1);
        }

        public void Chassis2Escolhido() {
            // Configura o Chassis2 no construtor do veículo
            VeiculoBuilder.WithChassis(Chassis2);
        }
      
        public void Pneu1Escolhido() {
            // Configura o Pneu1 em todas as posições do construtor do veículo
            VeiculoBuilder.WithTyre(PosicaoPneus.FrenteEsquerda, pneu1);
            VeiculoBuilder.WithTyre(PosicaoPneus.FrenteDireita, pneu1);
            VeiculoBuilder.WithTyre(PosicaoPneus.AtrasEsquerda, pneu1);
            VeiculoBuilder.WithTyre(PosicaoPneus.AtrasDireita, pneu1);
        }

        public void Pneu2Escolhido() {
            // Configura o Pneu2 em todas as posições do construtor do veículo
            VeiculoBuilder.WithTyre(PosicaoPneus.FrenteEsquerda, pneu2);
            VeiculoBuilder.WithTyre(PosicaoPneus.FrenteDireita, pneu2);
            VeiculoBuilder.WithTyre(PosicaoPneus.AtrasEsquerda, pneu2);
            VeiculoBuilder.WithTyre(PosicaoPneus.AtrasDireita, pneu2);
        }
    }
}