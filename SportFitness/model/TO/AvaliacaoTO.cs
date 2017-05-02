using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportFitness.model.TO
{
    class AvaliacaoTO
    {
        public int Id { set; get; }
        public double Peso { set; get; }
        public double Altura { set; get; }
        public int PressaoArterial { set; get; }
        public int PressaoArterialMinima { set; get; }
        public int IdAluno { set; get; }
        public String Data { set; get; }
        public double Imc { set; get; }
        public double Torax { set; get; }
        public double Cintura { set; get; }
        public double Abdome { set; get; }
        public double Quadril { set; get; }
        public double Antebraco_direito { set; get; }
        public double Antebraco_esquerdo { set; get; }
        public double BracoRelaxado_direito { set; get; }
        public double BracoRelaxado_esquerdo { set; get; }
        public double Coxa_direia { set; get; }
        public double Coxa_esquerda { set; get; }
        public double Panturrilha_direita { set; get; }
        public double Panturrilha_esquerda { set; get; }
        public double GorduraIdeal { set; get; }
        public double MassaGorda { set; get; }
        public double PesoDesejavel { set; get; }
        public double GorduraAtual { set; get; }
        public double MassaMagra { set; get; } 
        public double BracoFletido_direito { set; get; }
        public double BracoFletido_esquerdo { set; get; }
        public double Punho_direito { set; get; }
        public double Punho_esquerdo { set; get; }
        public double CoxaProximal_direito { set; get; }
        public double CoxaProximal_esquerda { set; get; }
        public double CoxaDistal_direita { set; get; }
        public double CoxaDistal_esquerda { set; get; }
        public double Tornozelo_direito { set; get; }
        public double Tornozelo_esquerdo { set; get; }
        public double PesoResidual { set; get; }
        public double PesoMuscular { set; get; }
        public double PesoOsseo { set; get; }
        public double BiAcromial { set; get; }
        public double ToracicoTransverso { set; get; }
        public double ToraxicoAnteroPosterior { set; get; }
        public double BiIleocristal { set; get; }
        public double BiEpicondiloUmeral { set; get; }
        public double BiEstiloide { set; get; }
        public double BiCondiloFemural { set; get; }
        public double BiMaleolar { set; get; }
        public double BiTrocanteriano { set; get; }
        public double Subscapular { set; get; }
        public double Tricipal { set; get; }
        public double Peitoral { set; get; }
        public double AxilarMedia { set; get; }
        public double SupraIliaca { set; get; }
        public double Coxa { set; get; }
        public double Abdominal { set; get; }
        public String Observacao { set; get; }
        public Boolean Situacao { set; get; }

    }
}