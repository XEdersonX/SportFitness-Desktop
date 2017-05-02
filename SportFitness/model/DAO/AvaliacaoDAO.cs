using MySql.Data.MySqlClient;
using sportFitness;
using SportFitness.model.TO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.model.DAO
{
    class AvaliacaoDAO : AvaliacaoTO, ICadastro
    {

        #region Insert
        public void insert()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into avaliacoes(idAluno, peso, altura, pressaoArterial, pressaoArterialMinima, data, imc, torax, cintura, abdome, quadril, antebraco_direito, antebraco_esquerdo, bracoRelaxado_direito, bracoRelaxado_esquerdo, coxa_direita, coxa_esquerda, panturrilha_direita, panturrilha_esquerda, gorduraIdeal, massaGorda, pesoDesejavel, gorduraAtual, massaMagra, bracoFletido_direito, bracoFletido_esquerdo, punho_direito, punho_esquerdo, coxaProximal_direita, coxaProximal_esquerda, coxaDistal_direita, coxaDistal_esquerda, tornozelo_direito, tornozelo_esquerdo, pesoResidual, pesoMuscular, pesoOsseo, biAcromial, toraxicoTransverso, toraxicoAnteroPosterior, biIleocristal, biEpicondiloUmeral, biEstiloide, biCondiloFemural, biMaleolar, biTrocanteriano, subscapular, tricipal, peitoral, axilarMedia, supraIliaca, coxa, abdominal, observacao, situacao) values(@idAluno, @peso, @altura, @pressaoArterial, @pressaoArterialMinima, @data, @imc, @torax, @cintura, @abdome, @quadril, @antebraco_direito, @antebraco_esquerdo ,@bracoRelaxado_direito, @bracoRelaxado_esquerdo, @coxa_direita, @coxa_esquerda, @panturrilha_direita, @panturrilha_esquerda, @gorduraIdeal, @massaGorda, @pesoDesejavel, @gorduraAtual, @massaMagra, @bracoFletido_direito, @bracoFletido_esquerdo, @punho_direito, @punho_esquerdo, @coxaProximal_direita, @coxaProximal_esquerda, @coxaDistal_direita, @coxaDistal_esquerda, @tornozelo_direito, @tornozelo_esquerdo, @pesoResidual, @pesoMuscular, @pesoOsseo, @biAcromial, @toraxicoTransverso, @toraxicoAnteroPosterior, @biIleocristal, @biEpicondiloUmeral, @biEstiloide, @biCondiloFemural, @biMaleolar, @biTrocanteriano, @subscapular, @tricipal, @peitoral, @axilarMedia, @supraIliaca, @coxa, @abdominal, @observacao, @situacao); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@idAluno", this.IdAluno);
                cmd.Parameters.AddWithValue("@peso", this.Peso);
                cmd.Parameters.AddWithValue("@altura", this.Altura);
                cmd.Parameters.AddWithValue("@pressaoArterial", this.PressaoArterial);
                cmd.Parameters.AddWithValue("@pressaoArterialMinima", this.PressaoArterialMinima);
                cmd.Parameters.AddWithValue("@data", this.Data);
                cmd.Parameters.AddWithValue("@imc", this.Imc);
                cmd.Parameters.AddWithValue("@torax", this.Torax);
                cmd.Parameters.AddWithValue("@cintura", this.Cintura);
                cmd.Parameters.AddWithValue("@abdome", this.Abdome);
                cmd.Parameters.AddWithValue("@quadril", this.Quadril);
                cmd.Parameters.AddWithValue("@antebraco_direito", this.Antebraco_direito);
                cmd.Parameters.AddWithValue("@antebraco_esquerdo", this.Antebraco_esquerdo);
                cmd.Parameters.AddWithValue("@bracoRelaxado_direito", this.BracoRelaxado_direito);
                cmd.Parameters.AddWithValue("@bracoRelaxado_esquerdo", this.BracoRelaxado_esquerdo);
                cmd.Parameters.AddWithValue("@coxa_direita", this.Coxa_direia);
                cmd.Parameters.AddWithValue("@coxa_esquerda", this.Coxa_esquerda);
                cmd.Parameters.AddWithValue("@panturrilha_direita", this.Panturrilha_direita);
                cmd.Parameters.AddWithValue("@panturrilha_esquerda", this.Panturrilha_esquerda);
                cmd.Parameters.AddWithValue("@gorduraIdeal", this.GorduraIdeal);
                cmd.Parameters.AddWithValue("@massaGorda", this.MassaGorda);
                cmd.Parameters.AddWithValue("@pesoDesejavel", this.PesoDesejavel);
                cmd.Parameters.AddWithValue("@gorduraAtual", this.GorduraAtual);
                cmd.Parameters.AddWithValue("@massaMagra", this.MassaMagra);
                cmd.Parameters.AddWithValue("@bracoFletido_direito", this.BracoFletido_direito);
                cmd.Parameters.AddWithValue("@bracoFletido_esquerdo", this.BracoFletido_esquerdo);
                cmd.Parameters.AddWithValue("@punho_direito", this.Punho_direito);
                cmd.Parameters.AddWithValue("@punho_esquerdo", this.Punho_direito);
                cmd.Parameters.AddWithValue("@coxaProximal_direita", this.CoxaProximal_direito);
                cmd.Parameters.AddWithValue("@coxaProximal_esquerda", this.CoxaProximal_esquerda);
                cmd.Parameters.AddWithValue("@coxaDistal_direita", this.CoxaDistal_direita);
                cmd.Parameters.AddWithValue("@coxaDistal_esquerda", this.CoxaDistal_esquerda);
                cmd.Parameters.AddWithValue("@tornozelo_direito", this.Tornozelo_direito);
                cmd.Parameters.AddWithValue("@tornozelo_esquerdo", this.Tornozelo_esquerdo);
                cmd.Parameters.AddWithValue("@pesoResidual", this.PesoResidual);
                cmd.Parameters.AddWithValue("@pesoMuscular", this.PesoMuscular);
                cmd.Parameters.AddWithValue("@pesoOsseo", this.PesoOsseo);
                cmd.Parameters.AddWithValue("@biAcromial", this.BiAcromial);
                cmd.Parameters.AddWithValue("@toraxicoTransverso", this.ToracicoTransverso);
                cmd.Parameters.AddWithValue("@toraxicoAnteroPosterior", this.ToraxicoAnteroPosterior);
                cmd.Parameters.AddWithValue("@biIleocristal", this.BiIleocristal);
                cmd.Parameters.AddWithValue("@biEpicondiloUmeral", this.BiEpicondiloUmeral);
                cmd.Parameters.AddWithValue("@biEstiloide", this.BiEstiloide);
                cmd.Parameters.AddWithValue("@biCondiloFemural", this.BiCondiloFemural);
                cmd.Parameters.AddWithValue("@biMaleolar", this.BiMaleolar);
                cmd.Parameters.AddWithValue("@biTrocanteriano", this.BiTrocanteriano);
                cmd.Parameters.AddWithValue("@subscapular", this.Subscapular);
                cmd.Parameters.AddWithValue("@tricipal", this.Tricipal);
                cmd.Parameters.AddWithValue("@peitoral", this.Peitoral);
                cmd.Parameters.AddWithValue("@axilarMedia", this.AxilarMedia);
                cmd.Parameters.AddWithValue("@supraIliaca", this.SupraIliaca);
                cmd.Parameters.AddWithValue("@coxa", this.Coxa);
                cmd.Parameters.AddWithValue("@abdominal", this.Abdominal);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
                cmd.Parameters.AddWithValue("@situacao", this.Situacao);
                cn.Open();
                this.Id = Convert.ToInt16(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Update
        public void update()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update avaliacoes set idAluno=@idAluno, peso=@peso, altura=@altura, pressaoArterial=@pressaoArterial, pressaoArterialMinima=@pressaoArterialMinima, data=@data,imc=@imc, torax=@torax, cintura=@cintura, abdome=@abdome, quadril=@quadril, antebraco_direito=@antebraco_direito, antebraco_esquerdo=@antebraco_esquerdo, bracoRelaxado_direito=@bracoRelaxado_direito, bracoRelaxado_esquerdo=@bracoRelaxado_esquerdo, coxa_direita=@coxa_direita, coxa_esquerda=@coxa_esquerda, panturrilha_direita=@panturrilha_direita, panturrilha_esquerda=@panturrilha_esquerda, gorduraIdeal=@gorduraIdeal, massaGorda=@massaGorda, pesoDesejavel=@pesoDesejavel, gorduraAtual=@gorduraAtual, massaMagra=@massaMagra, bracoFletido_direito=@bracoFletido_direito, bracoFletido_esquerdo=@bracoFletido_esquerdo,punho_direito=@punho_direito,punho_esquerdo=@punho_esquerdo,coxaProximal_direita=@coxaProximal_direita,coxaProximal_esquerda=@coxaProximal_esquerda,coxaDistal_direita=@coxaDistal_direita,coxaDistal_esquerda=@coxaDistal_esquerda,tornozelo_direito=@tornozelo_direito,tornozelo_esquerdo=@tornozelo_esquerdo,pesoResidual=@pesoResidual,pesoMuscular=@pesoMuscular,pesoOsseo=@pesoOsseo,biAcromial=@biAcromial,toraxicoTransverso=@toraxicoTransverso,toraxicoAnteroPosterior=@toraxicoAnteroPosterior,biIleocristal=@biIleocristal,biEpicondiloUmeral=@biEpicondiloUmeral,biEstiloide=@biEstiloide,biCondiloFemural=@biCondiloFemural,biMaleolar=@biMaleolar,biTrocanteriano=@biTrocanteriano,subscapular=@subscapular,tricipal=@tricipal,peitoral=@peitoral,axilarMedia=@axilarMedia,supraIliaca=@supraIliaca,coxa=@coxa,abdominal=@abdominal,observacao=@observacao,situacao=@situacao where id_avaliacao=@id_avaliacao";
                cmd.Parameters.AddWithValue("@id_avaliacao", this.Id);
                cmd.Parameters.AddWithValue("@idAluno", this.IdAluno);
                cmd.Parameters.AddWithValue("@peso", this.Peso);
                cmd.Parameters.AddWithValue("@altura", this.Altura);
                cmd.Parameters.AddWithValue("@pressaoArterial", this.PressaoArterial);
                cmd.Parameters.AddWithValue("@pressaoArterialMinima", this.PressaoArterialMinima);
                cmd.Parameters.AddWithValue("@data", this.Data);
                cmd.Parameters.AddWithValue("@imc", this.Imc);
                cmd.Parameters.AddWithValue("@torax", this.Torax);
                cmd.Parameters.AddWithValue("@cintura", this.Cintura);
                cmd.Parameters.AddWithValue("@abdome", this.Abdome);
                cmd.Parameters.AddWithValue("@quadril", this.Quadril);
                cmd.Parameters.AddWithValue("@antebraco_direito", this.Antebraco_direito);
                cmd.Parameters.AddWithValue("@antebraco_esquerdo", this.Antebraco_esquerdo);
                cmd.Parameters.AddWithValue("@bracoRelaxado_direito", this.BracoRelaxado_direito);
                cmd.Parameters.AddWithValue("@bracoRelaxado_esquerdo", this.BracoRelaxado_esquerdo);
                cmd.Parameters.AddWithValue("@coxa_direita", this.Coxa_direia);
                cmd.Parameters.AddWithValue("@coxa_esquerda", this.Coxa_esquerda);
                cmd.Parameters.AddWithValue("@panturrilha_direita", this.Panturrilha_direita);
                cmd.Parameters.AddWithValue("@panturrilha_esquerda", this.Panturrilha_esquerda);
                cmd.Parameters.AddWithValue("@gorduraIdeal", this.GorduraIdeal);
                cmd.Parameters.AddWithValue("@massaGorda", this.MassaGorda);
                cmd.Parameters.AddWithValue("@pesoDesejavel", this.PesoDesejavel);
                cmd.Parameters.AddWithValue("@gorduraAtual", this.GorduraAtual);
                cmd.Parameters.AddWithValue("@massaMagra", this.MassaMagra);
                cmd.Parameters.AddWithValue("@bracoFletido_direito", this.BracoFletido_direito);
                cmd.Parameters.AddWithValue("@bracoFletido_esquerdo", this.BracoFletido_esquerdo);
                cmd.Parameters.AddWithValue("@punho_direito", this.Punho_direito);
                cmd.Parameters.AddWithValue("@punho_esquerdo", this.Punho_esquerdo);
                cmd.Parameters.AddWithValue("@coxaProximal_direita", this.CoxaProximal_direito);
                cmd.Parameters.AddWithValue("@coxaProximal_esquerda", this.CoxaProximal_esquerda);
                cmd.Parameters.AddWithValue("@coxaDistal_direita", this.CoxaDistal_direita);
                cmd.Parameters.AddWithValue("@coxaDistal_esquerda", this.CoxaDistal_esquerda);
                cmd.Parameters.AddWithValue("@tornozelo_direito", this.Tornozelo_direito);
                cmd.Parameters.AddWithValue("@tornozelo_esquerdo", this.Tornozelo_esquerdo);
                cmd.Parameters.AddWithValue("@pesoResidual", this.PesoResidual);
                cmd.Parameters.AddWithValue("@pesoMuscular", this.PesoMuscular);
                cmd.Parameters.AddWithValue("@pesoOsseo", this.PesoOsseo);
                cmd.Parameters.AddWithValue("@biAcromial", this.BiAcromial);
                cmd.Parameters.AddWithValue("@toraxicoTransverso", this.ToracicoTransverso);
                cmd.Parameters.AddWithValue("@toraxicoAnteroPosterior", this.ToraxicoAnteroPosterior);
                cmd.Parameters.AddWithValue("@biIleocristal", this.BiIleocristal);
                cmd.Parameters.AddWithValue("@biEpicondiloUmeral", this.BiEpicondiloUmeral);
                cmd.Parameters.AddWithValue("@biEstiloide", this.BiEstiloide);
                cmd.Parameters.AddWithValue("@biCondiloFemural", this.BiCondiloFemural);
                cmd.Parameters.AddWithValue("@biMaleolar", this.BiMaleolar);
                cmd.Parameters.AddWithValue("@biTrocanteriano", this.BiTrocanteriano);
                cmd.Parameters.AddWithValue("@subscapular", this.Subscapular);
                cmd.Parameters.AddWithValue("@tricipal", this.Tricipal);
                cmd.Parameters.AddWithValue("@peitoral", this.Peitoral);
                cmd.Parameters.AddWithValue("@axilarMedia", this.AxilarMedia);
                cmd.Parameters.AddWithValue("@supraIliaca", this.SupraIliaca);
                cmd.Parameters.AddWithValue("@coxa", this.Coxa);
                cmd.Parameters.AddWithValue("@abdominal", this.Abdominal);
                cmd.Parameters.AddWithValue("@observacao", this.Observacao);
                cmd.Parameters.AddWithValue("@situacao", this.Situacao);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
        }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
    }
}
        #endregion

        #region Delete
        public void delete()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "delete from avaliacao where id_avaliacao=@id_avaliacao";
                cmd.Parameters.AddWithValue("@id_avaliacao", this.Id);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a avaliação  " + this.Id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Select com INNER JOIN para listar as avaliações na dataGrid
        public DataTable select(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_avaliacao, peso, altura, pressaoArterial, nome, idAluno, data from avaliacoes  inner join alunos on idAluno = id_aluno where avaliacoes.situacao = 1 group by id_avaliacao order by id_avaliacao;" + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Select da pesquisa do sistema
        public DataTable selectPesquisa(string options = "")
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_avaliacao, peso, altura, pressaoArterial, nome, idAluno, data from avaliacoes  inner join alunos on idAluno = id_aluno " + options, dbConnection.Conecta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Update para realizar a exclusao lógica
        public void updateDelete()
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = dbConnection.Conecta;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "update avaliacoes set situacao = 0 where id_avaliacao=@id_avaliacao";
                cmd.Parameters.AddWithValue("@id_avaliacao", this.Id);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region Método para retornar os dados do aluno
        //Metodo para retornar os dados do aluno
        public ArrayList selectArray(string options = "")
        {
            ArrayList dados = new ArrayList();
            MySqlConnection cn = new MySqlConnection(dbConnection.Conecta);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from avaliacoes " + options, cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Avaliacao avaliacoes = new Avaliacao();
                avaliacoes.Id = Convert.ToInt16(dr["id_avaliacao"]);
                avaliacoes.IdAluno = Convert.ToInt16(dr["idAluno"]);
                avaliacoes.Data = dr["data"].ToString();
                avaliacoes.Altura = Convert.ToDouble(dr["altura"]);
                avaliacoes.Peso = Convert.ToDouble(dr["peso"]);
                avaliacoes.Imc = Convert.ToDouble(dr["imc"]);
                avaliacoes.PressaoArterial = Convert.ToInt16(dr["pressaoArterial"]);
                avaliacoes.PressaoArterialMinima = Convert.ToInt16(dr["pressaoArterialMinima"]);
                avaliacoes.Torax = Convert.ToDouble(dr["torax"]);
                avaliacoes.Cintura = Convert.ToDouble(dr["cintura"]);
                avaliacoes.Abdome = Convert.ToDouble(dr["abdome"]);
                avaliacoes.Quadril = Convert.ToDouble(dr["quadril"]);
                avaliacoes.Antebraco_direito = Convert.ToDouble(dr["antebraco_direito"]);
                avaliacoes.Antebraco_esquerdo = Convert.ToDouble(dr["antebraco_esquerdo"]);
                avaliacoes.BracoRelaxado_direito = Convert.ToDouble(dr["bracoRelaxado_direito"]);
                avaliacoes.BracoRelaxado_esquerdo = Convert.ToDouble(dr["bracoRelaxado_esquerdo"]);
                avaliacoes.Coxa_direia = Convert.ToDouble(dr["coxa_direita"]);
                avaliacoes.Coxa_esquerda = Convert.ToDouble(dr["coxa_direita"]);
                avaliacoes.Panturrilha_direita = Convert.ToDouble(dr["panturrilha_direita"]);
                avaliacoes.Panturrilha_esquerda = Convert.ToDouble(dr["panturrilha_direita"]);
                avaliacoes.GorduraIdeal = Convert.ToDouble(dr["gorduraIdeal"]);
                avaliacoes.MassaGorda = Convert.ToDouble(dr["massaGorda"]);
                avaliacoes.PesoDesejavel = Convert.ToDouble(dr["pesoDesejavel"]);
                avaliacoes.GorduraAtual = Convert.ToDouble(dr["gorduraAtual"]);
                avaliacoes.MassaMagra = Convert.ToDouble(dr["massaMagra"]);
                avaliacoes.BracoFletido_direito = Convert.ToDouble(dr["bracoFletido_direito"]);
                avaliacoes.BracoFletido_esquerdo = Convert.ToDouble(dr["bracoFletido_esquerdo"]);
                avaliacoes.Punho_direito = Convert.ToDouble(dr["punho_direito"]);
                avaliacoes.Punho_esquerdo = Convert.ToDouble(dr["punho_esquerdo"]);
                avaliacoes.CoxaProximal_direito = Convert.ToDouble(dr["coxaProximal_direita"]);
                avaliacoes.CoxaProximal_esquerda = Convert.ToDouble(dr["coxaProximal_esquerda"]);
                avaliacoes.CoxaDistal_direita = Convert.ToDouble(dr["coxaDistal_direita"]);
                avaliacoes.CoxaDistal_esquerda = Convert.ToDouble(dr["coxaDistal_esquerda"]);
                avaliacoes.Tornozelo_direito = Convert.ToDouble(dr["tornozelo_direito"]);
                avaliacoes.Tornozelo_esquerdo = Convert.ToDouble(dr["tornozelo_esquerdo"]);
                avaliacoes.PesoResidual = Convert.ToDouble(dr["pesoResidual"]);
                avaliacoes.PesoMuscular = Convert.ToDouble(dr["pesoMuscular"]);
                avaliacoes.PesoOsseo = Convert.ToDouble(dr["pesoOsseo"]);
                avaliacoes.BiAcromial = Convert.ToDouble(dr["biAcromial"]);
                avaliacoes.ToracicoTransverso = Convert.ToDouble(dr["toraxicoTransverso"]);
                avaliacoes.ToraxicoAnteroPosterior = Convert.ToDouble(dr["toraxicoAnteroPosterior"]);
                avaliacoes.BiIleocristal = Convert.ToDouble(dr["biIleocristal"]);
                avaliacoes.BiEpicondiloUmeral = Convert.ToDouble(dr["biEpicondiloUmeral"]);
                avaliacoes.BiEstiloide = Convert.ToDouble(dr["biEstiloide"]);
                avaliacoes.BiCondiloFemural = Convert.ToDouble(dr["biCondiloFemural"]);
                avaliacoes.BiMaleolar = Convert.ToDouble(dr["biMaleolar"]);
                avaliacoes.BiTrocanteriano = Convert.ToDouble(dr["biTrocanteriano"]);
                avaliacoes.Subscapular = Convert.ToDouble(dr["subscapular"]);
                avaliacoes.Tricipal = Convert.ToDouble(dr["tricipal"]);
                avaliacoes.Peitoral = Convert.ToDouble(dr["peitoral"]);
                avaliacoes.AxilarMedia = Convert.ToDouble(dr["axilarMedia"]);
                avaliacoes.SupraIliaca = Convert.ToDouble(dr["supraIliaca"]);
                avaliacoes.Coxa = Convert.ToDouble(dr["coxa"]);
                avaliacoes.Abdominal = Convert.ToDouble(dr["abdominal"]);
                avaliacoes.Observacao = dr["observacao"].ToString();

                //alunos.IdUsuario = Convert.ToInt16(dr["idUsuario"]);
                dados.Add(avaliacoes);
            }

            dr.Close();
            cn.Close();
            return dados;
        }
        #endregion

    }
}