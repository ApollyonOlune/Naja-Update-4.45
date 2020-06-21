using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Naja_Update_4._45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        readonly Depuracao dep = new Depuracao(); //iniciando a classe depuração
        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (naja.Checked == true)
            {
                dep.listBox1.Items.Add("O " + naja.Name + " foi selecionado");
            }
            if (naja.Checked == false)
            {
                dep.listBox1.Items.Add("O " + naja.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (naja.Checked == false)
            {
                naja.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + naja.Name + " teve a cor alterada para " + naja.BackColor.Name);
            }
            if (naja.Checked == true)
            {
                naja.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + naja.Name + " teve a cor alterada para " + naja.BackColor.Name);
            }
        }
        private void CheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (naja_service.Checked == true)
            {
                dep.listBox1.Items.Add("O " + naja_service.Name + " foi selecionado");
            }
            if (naja_service.Checked == false)
            {
                dep.listBox1.Items.Add("O " + naja_service.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário 
            if (naja_service.Checked == false)
            {
                naja_service.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + naja_service.Name + " teve a cor alterada para " + naja_service.BackColor.Name);
            }
            if (naja_service.Checked == true)
            {
                naja_service.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + naja_service.Name + " teve a cor alterada para " + naja_service.BackColor.Name);
            }
        }
        private void CheckBox24_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (naja_server.Checked == true)
            {
                dep.listBox1.Items.Add("O " + naja_server.Name + " foi selecionado");
            }
            if (naja_server.Checked == false)
            {
                dep.listBox1.Items.Add("O " + naja_server.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (naja_server.Checked == false)
            {
                naja_server.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + naja_server.Name + " teve a cor alterada para " + naja_server.BackColor.Name);
            }
            if (naja_server.Checked == true)
            {
                naja_server.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + naja_server.Name + " teve a cor alterada para " + naja_server.BackColor.Name);
            }
        }
        private void CheckBox25_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (tabelasCampo.Checked == true)
            {
                dep.listBox1.Items.Add("O " + tabelasCampo.Name + " foi selecionado");
            }
            if (tabelasCampo.Checked == false)
            {
                dep.listBox1.Items.Add("O " + tabelasCampo.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (tabelasCampo.Checked == false)
            {
                tabelasCampo.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + tabelasCampo.Name + " teve a cor alterada para " + tabelasCampo.BackColor.Name);
            }
            if (tabelasCampo.Checked == true)
            {
                tabelasCampo.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + tabelasCampo.Name + " teve a cor alterada para " + tabelasCampo.BackColor.Name);
            }
        }
        private void CheckBox26_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (tabelas.Checked == true)
            {
                dep.listBox1.Items.Add("O " + tabelas.Name + " foi selecionado");
            }
            if (tabelas.Checked == false)
            {
                dep.listBox1.Items.Add("O " + tabelas.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (tabelas.Checked == false)
            {
                tabelas.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + tabelas.Name + " teve a cor alterada para " + tabelas.BackColor.Name);
            }
            if (tabelas.Checked == true)
            {
                tabelas.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + tabelas.Name + " teve a cor alterada para " + tabelas.BackColor.Name);
            }
        }
        private void CheckBox27_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (menu.Checked == true)
            {
                dep.listBox1.Items.Add("O " + menu.Name + " foi selecionado");
            }
            if (menu.Checked == false)
            {
                dep.listBox1.Items.Add("O " + menu.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (menu.Checked == false)
            {
                menu.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + menu.Name + " teve a cor alterada para " + menu.BackColor.Name);
            }
            if (menu.Checked == true)
            {
                menu.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + menu.Name + " teve a cor alterada para " + menu.BackColor.Name);
            }
        }
        private void CheckBox28_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (histversao.Checked == true)
            {
                dep.listBox1.Items.Add("O " + histversao.Name + " foi selecionado");
            }
            if (histversao.Checked == false)
            {
                dep.listBox1.Items.Add("O " + histversao.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (histversao.Checked == false)
            {
                histversao.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + histversao.Name + " teve a cor alterada para " + histversao.BackColor.Name);
            }
            if (histversao.Checked == true)
            {
                histversao.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + histversao.Name + " teve a cor alterada para " + histversao.BackColor.Name);
            }
        }
        private void CheckBox29_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (help.Checked == true)
            {
                dep.listBox1.Items.Add("O " + help.Name + " foi selecionado");
            }
            if (help.Checked == false)
            {
                dep.listBox1.Items.Add("O " + help.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (help.Checked == false)
            {
                help.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + help.Name + " teve a cor alterada para " + help.BackColor.Name);
            }
            if (help.Checked == true)
            {
                help.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + help.Name + " teve a cor alterada para " + help.BackColor.Name);
            }
        }
        private void CheckBox30_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (colunas.Checked == true)
            {
                dep.listBox1.Items.Add("O " + colunas.Name + " foi selecionado");
            }
            if (colunas.Checked == false)
            {
                dep.listBox1.Items.Add("O " + colunas.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (colunas.Checked == false)
            {
                colunas.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + colunas.Name + " teve a cor alterada para " + colunas.BackColor.Name);
            }
            if (colunas.Checked == true)
            {
                colunas.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + colunas.Name + " teve a cor alterada para " + colunas.BackColor.Name);
            }
        }
        private void CheckBox31_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (script_todos.Checked == true)
            {
                dep.listBox1.Items.Add("O " + script_todos.Name + " foi selecionado");
            }
            if (script_todos.Checked == false)
            {
                dep.listBox1.Items.Add("O " + script_todos.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (script_todos.Checked == false)
            {
                script_todos.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + script_todos.Name + " teve a cor alterada para " + script_todos.BackColor.Name);
            }
            if (script_todos.Checked == true)
            {
                script_todos.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + script_todos.Name + " teve a cor alterada para " + script_todos.BackColor.Name);
            }
        }
        private void CheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (suporte.Checked == true)
            {
                dep.listBox1.Items.Add("O " + suporte.Name + " foi selecionado");
            }
            if (suporte.Checked == false)
            {
                dep.listBox1.Items.Add("O " + suporte.Name + " foi deselecionado");
            }
            //Alterando a cor para facilitar visualização de uncheck de programa obrogatório e registando o evento para visualização do usuário
            if (suporte.Checked == false)
            {
                suporte.BackColor = Color.Red;
                dep.listBox1.Items.Add("O " + suporte.Name + " teve a cor alterada para " + suporte.BackColor.Name);
            }
            if (suporte.Checked == true)
            {
                suporte.BackColor = Color.White;
                dep.listBox1.Items.Add("O " + suporte.Name + " teve a cor alterada para " + suporte.BackColor.Name);
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (atendimento_clinico.Checked == true)
            {
                dep.listBox1.Items.Add("O " + atendimento_clinico.Name + " foi selecionado");
            }
            if (atendimento_clinico.Checked == false)
            {
                dep.listBox1.Items.Add("O " + atendimento_clinico.Name + " foi deselecionado");
            }
        }
        private void Central_de_exame_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (central_de_exame.Checked == true)
            {
                dep.listBox1.Items.Add("O " + central_de_exame.Name + " foi selecionado");
            }
            if (central_de_exame.Checked == false)
            {
                dep.listBox1.Items.Add("O " + central_de_exame.Name + " foi deselecionado");
            }
        }
        private void Centro_cirurgico_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (centro_cirurgico.Checked == true)
            {
                dep.listBox1.Items.Add("O " + centro_cirurgico.Name + " foi selecionado");
            }
            if (centro_cirurgico.Checked == false)
            {
                dep.listBox1.Items.Add("O " + centro_cirurgico.Name + " foi deselecionado");
            }
        }
        private void Compras_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (compras.Checked == true)
            {
                dep.listBox1.Items.Add("O " + compras.Name + " foi selecionado");
            }
            if (compras.Checked == false)
            {
                dep.listBox1.Items.Add("O " + compras.Name + " foi deselecionado");
            }
        }
        private void Crm_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (crm.Checked == true)
            {
                dep.listBox1.Items.Add("O " + crm.Name + " foi selecionado");
            }
            if (crm.Checked == false)
            {
                dep.listBox1.Items.Add("O " + crm.Name + " foi deselecionado");
            }
        }
        private void Custos_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (custos.Checked == true)
            {
                dep.listBox1.Items.Add("O " + custos.Name + " foi selecionado");
            }
            if (custos.Checked == false)
            {
                dep.listBox1.Items.Add("O " + custos.Name + " foi deselecionado");
            }
        }
        private void Doctor_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (doctor.Checked == true)
            {
                dep.listBox1.Items.Add("O " + doctor.Name + " foi selecionado");
            }
            if (doctor.Checked == false)
            {
                dep.listBox1.Items.Add("O " + doctor.Name + " foi deselecionado");
            }
        }
        private void Estoque_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (estoque.Checked == true)
            {
                dep.listBox1.Items.Add("O " + estoque.Name + " foi selecionado");
            }
            if (estoque.Checked == false)
            {
                dep.listBox1.Items.Add("O " + estoque.Name + " foi deselecionado");
            }
        }
        private void Faturamento_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (faturamento.Checked == true)
            {
                dep.listBox1.Items.Add("O " + faturamento.Name + " foi selecionado");
            }
            if (faturamento.Checked == false)
            {
                dep.listBox1.Items.Add("O " + faturamento.Name + " foi deselecionado");
            }
        }
        private void Financeiro_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (financeiro.Checked == true)
            {
                dep.listBox1.Items.Add("O " + financeiro.Name + " foi selecionado");
            }
            if (financeiro.Checked == false)
            {
                dep.listBox1.Items.Add("O " + financeiro.Name + " foi deselecionado");
            }
        }
        private void Infusao_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (infusao.Checked == true)
            {
                dep.listBox1.Items.Add("O " + infusao.Name + " foi selecionado");
            }
            if (infusao.Checked == false)
            {
                dep.listBox1.Items.Add("O " + infusao.Name + " foi deselecionado");
            }
        }
        private void Laudo_medico_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (laudo_medico.Checked == true)
            {
                dep.listBox1.Items.Add("O " + laudo_medico.Name + " foi selecionado");
            }
            if (laudo_medico.Checked == false)
            {
                dep.listBox1.Items.Add("O " + laudo_medico.Name + " foi deselecionado");
            }
        }
        private void Naja_bi_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (naja_bi.Checked == true)
            {
                dep.listBox1.Items.Add("O " + naja_bi.Name + " foi selecionado");
            }
            if (naja_bi.Checked == false)
            {
                dep.listBox1.Items.Add("O " + naja_bi.Name + " foi deselecionado");
            }
        }
        private void Naja_exporta_laudo_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (naja_exporta_laudo.Checked == true)
            {
                dep.listBox1.Items.Add("O " + naja_exporta_laudo.Name + " foi selecionado");
            }
            if (naja_exporta_laudo.Checked == false)
            {
                dep.listBox1.Items.Add("O " + naja_exporta_laudo.Name + " foi deselecionado");
            }
        }
        private void Naja_ris_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (naja_ris.Checked == true)
            {
                dep.listBox1.Items.Add("O " + naja_ris.Name + " foi selecionado");
            }
            if (naja_ris.Checked == false)
            {
                dep.listBox1.Items.Add("O " + naja_ris.Name + " foi deselecionado");
            }
        }
        private void Planos_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (planos.Checked == true)
            {
                dep.listBox1.Items.Add("O " + planos.Name + " foi selecionado");
            }
            if (planos.Checked == false)
            {
                dep.listBox1.Items.Add("O " + planos.Name + " foi deselecionado");
            }
        }
        private void Recepcao_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (recepcao.Checked == true)
            {
                dep.listBox1.Items.Add("O " + recepcao.Name + " foi selecionado");
            }
            if (recepcao.Checked == false)
            {
                dep.listBox1.Items.Add("O " + recepcao.Name + " foi deselecionado");
            }
        }
        private void Relcustom_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (relcustom.Checked == true)
            {
                dep.listBox1.Items.Add("O " + relcustom.Name + " foi selecionado");
            }
            if (relcustom.Checked == false)
            {
                dep.listBox1.Items.Add("O " + relcustom.Name + " foi deselecionado");
            }
        }
        private void Same_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (same.Checked == true)
            {
                dep.listBox1.Items.Add("O " + same.Name + " foi selecionado");
            }
            if (same.Checked == false)
            {
                dep.listBox1.Items.Add("O " + same.Name + " foi deselecionado");
            }
        }
        private void Unidade_de_internacao_CheckedChanged(object sender, EventArgs e)
        {
            //registando o evento para visualização do usuário
            if (unidade_de_internacao.Checked == true)
            {
                dep.listBox1.Items.Add("O " + unidade_de_internacao.Name + " foi selecionado");
            }
            if (unidade_de_internacao.Checked == false)
            {
                dep.listBox1.Items.Add("O " + unidade_de_internacao.Name + " foi deselecionado");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caminho = new FolderBrowserDialog();
            if (caminho.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = caminho.SelectedPath;
                dep.listBox1.Items.Add("Foi selecionado o caminho: " + txtCaminho + " ,como o caminho de instalação do naja.");
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            dep.listBox1.Items.Add("O " + botao_atualizar_arquivos.Name + "foi pressionado"); //registando o evento para visualização do usuário

            if (txtCaminho.Text == "")
            {
                MessageBox.Show("O Caminho da instalação não foi preenchido.");
                txtCaminho.BackColor = Color.Red;
                return;
            }
            //Iniciando Variaveis
            string programa;
            string nome_do_arquivo;
            string caminho_interno;
            string concat_caminho_entrada;
            string concat_caminho_saida;
            string caminho_deste_programa;

            caminho_deste_programa = System.Environment.CurrentDirectory; //Pegando caminho deste programa em execução
            dep.listBox1.Items.Add("Caminho de Origem dos Arquivos: " + caminho_deste_programa); //Armazenando caminho para visualização do usuário
            string caminho_da_instacao_naja_do_pc = txtCaminho.Text; //pegando o caminho da instalação naja no pc.

            ////Movendo Programas da Pasta Cliente.
            //Início da Instalação do Atendimento Clínico.
            if (atendimento_clinico.Checked == true)
            {
                programa = ("Atendimento Clínico"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\AtendClinico.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Atendimento Clínico.
            if (central_de_exame.Checked == true)
            {
                programa = ("Atendimento Clínico"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\AtendClinico.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Centro Cirurgico.
            if (centro_cirurgico.Checked == true)
            {
                programa = ("Centro Cirurgico"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\CentroCirurgico.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Compras.
            if (compras.Checked == true)
            {
                programa = ("Compras"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Compras.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do CRM.
            if (crm.Checked == true)
            {
                programa = ("CRM"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\CRM.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Custos.
            if (custos.Checked == true)
            {
                programa = ("Custos"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Custos.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Doctor.
            if (doctor.Checked == true)
            {
                programa = ("Doctor"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Doctor.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Estoque.
            if (estoque.Checked == true)
            {
                programa = ("Estoque"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Estoque.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Faturamento.
            if (faturamento.Checked == true)
            {
                programa = ("Faturamento"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Faturamento.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Financeiro.
            if (financeiro.Checked == true)
            {
                programa = ("Financeiro"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Financeiro.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Infusão.
            if (infusao.Checked == true)
            {
                programa = ("Infusão"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Infusao.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Laudo Médico.
            if (laudo_medico.Checked == true)
            {
                programa = ("Laudo Médico"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\LaudoMedico.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Naja.
            if (naja.Checked == true)
            {
                programa = ("Naja"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Naja.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Naja BI.
            if (naja_bi.Checked == true)
            {
                programa = ("Naja BI"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\NajaBI.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Naja Exporta Laudo.
            if (naja_exporta_laudo.Checked == true)
            {
                programa = ("Naja Exporta Laudo"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\NajaExportaLaudo.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Naja RIS.
            if (naja_ris.Checked == true)
            {
                programa = ("Naja RIS"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\NajaRIS.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Planos.
            if (planos.Checked == true)
            {
                programa = ("Planos"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Planos.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Recepção.
            if (recepcao.Checked == true)
            {
                programa = ("Recepção"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Recepcao.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do RelCustom.
            if (relcustom.Checked == true)
            {
                programa = ("RelCustom"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\RelCustom.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do SAME.
            if (same.Checked == true)
            {
                programa = ("SAME"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\SAME.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Suporte.
            if (suporte.Checked == true)
            {
                programa = ("Suporte"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Suporte.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Unidade de Internação.
            if (unidade_de_internacao.Checked == true)
            {
                programa = ("Unidade de Internação"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\UnidInternacao.exe"); //Nome interno do programa
                caminho_interno = ("\\Clientes" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            ////Movendo Programas da Pasta Servidor.
            //Início da Instalação do Naja Service.
            if (naja_service.Checked == true)
            {
                programa = ("Naja Service"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\NajaService.exe"); //Nome interno do programa
                caminho_interno = ("\\Servidor" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Instalação do Naja Server.
            if (naja_server.Checked == true)
            {
                programa = ("Naja Server"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\NAJAServer.exe"); //Nome interno do programa
                caminho_interno = ("\\Servidor" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            ////Movendo as Tabelas.
            //Início da TabelasCampo.
            if (tabelasCampo.Checked == true)
            {
                programa = ("Tabelas Campo"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\TabelasCampo.naja"); //Nome interno do programa
                caminho_interno = ("\\Tabelas" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = (caminho_da_instacao_naja_do_pc + "\\Atualizacao"); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Tabelas.
            if (tabelas.Checked == true)
            {
                programa = ("Tabelas"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Tabelas.naja"); //Nome interno do programa
                caminho_interno = ("\\Tabelas" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = (caminho_da_instacao_naja_do_pc + "\\Atualizacao"); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Tabelas.
            if (menu.Checked == true)
            {
                programa = ("Menu"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Menu.naja"); //Nome interno do programa
                caminho_interno = ("\\Tabelas" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = (caminho_da_instacao_naja_do_pc + "\\Atualizacao"); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da HistVersao.
            if (histversao.Checked == true)
            {
                programa = ("HistVersão"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\HistVersao.naja"); //Nome interno do programa
                caminho_interno = ("\\Tabelas" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = (caminho_da_instacao_naja_do_pc + "\\Atualizacao"); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Help.
            if (help.Checked == true)
            {
                programa = ("Help"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Help.naja"); //Nome interno do programa
                caminho_interno = ("\\Tabelas" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = (caminho_da_instacao_naja_do_pc + "\\Atualizacao"); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            //Início da Colunas.
            if (colunas.Checked == true)
            {
                programa = ("Colunas"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                nome_do_arquivo = ("\\Colunas.naja"); //Nome interno do programa
                caminho_interno = ("\\Tabelas" + nome_do_arquivo); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = (caminho_da_instacao_naja_do_pc + "\\Atualizacao"); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    System.IO.File.Copy(concat_caminho_entrada, concat_caminho_saida, true);
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
            }
            toolStripProgressBar1.Value += 3;

            ////Movendo Scripts.
            if (script_todos.Checked == true)
            {
                programa = ("Scripts"); //Nome do Programa a ser Colocado.
                dep.listBox1.Items.Add("Selecionado " + programa); //armazenando caminho para visualização do usuário
                caminho_interno = ("\\Scripts"); //caminho interno do programa
                concat_caminho_entrada = string.Concat(caminho_deste_programa, caminho_interno); //caminho de qual arquivo copiar
                dep.listBox1.Items.Add("Arquivo vai ser movido de " + concat_caminho_entrada); //armazenando caminho para visualização do usuário
                concat_caminho_saida = string.Concat(caminho_da_instacao_naja_do_pc, caminho_interno); //caminho de onde colar
                dep.listBox1.Items.Add("Arquivo vai ser colado em " + concat_caminho_saida); //armazenando caminho para visualização do usuário
                toolStripStatusLabel1.Text = ("Movendo " + programa);
                try
                {
                    string[] arquivos = System.IO.Directory.GetFiles(concat_caminho_entrada);
                    foreach (string s in arquivos)
                    {
                        nome_do_arquivo = System.IO.Path.GetFileName(s);
                        dep.listBox1.Items.Add("O script " + nome_do_arquivo + " foi selecionado.");
                        string arquivo_de_destino = System.IO.Path.Combine(concat_caminho_saida, nome_do_arquivo);
                        System.IO.File.Copy(s, arquivo_de_destino, true);
                        dep.listBox1.Items.Add("O script " + nome_do_arquivo + " foi movido.");
                        toolStripStatusLabel1.Text = ("Movendo " + nome_do_arquivo);

                    }
                    toolStripStatusLabel1.Text = (programa + " Movido");
                    dep.listBox1.Items.Add("Programa movido com sucesso"); //armazenando informação para visualização do usuário
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);
                    toolStripStatusLabel1.Text = ("Erro ao Mover " + programa);
                    dep.listBox1.Items.Add("Erro ao move o programa, detalhe do erro: " + exc); //armazenando informação para visualização do usuário
                }
                toolStripProgressBar1.Value += 3;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dep.listBox1.Items.Add("O " + botao_debug.Name + "foi pressionado"); //registando o evento para visualização do usuário
            dep.Show(); //abrindo a janela de depuração
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //Atendimento Clinico
            string caminho = txtCaminho + "\\Clientes\\AtendClinico.xml";
            if (System.IO.File.Exists(@caminho)==true)
            {
                toolStripProgressBar1.Value = 50;
            }
        }
    }
}
