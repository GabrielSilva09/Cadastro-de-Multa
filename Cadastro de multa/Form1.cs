using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_multa
{
    public partial class Multas : Form
    {
        //Funções
        //Função para limpar campos
        void limparcampos()
        {
            txtcpf.Clear();
            txtdata.Clear();
            txtinfra.Clear();
            txtplaca.Clear();
            txtpontos.Clear();
            txtvalor.Clear();
        }
        //Função para verificar os pontos
        int verificapontos(string infra)
        {
            if (infra == "leve" || infra == "Leve")
            {
                return 3;
            }
            if (infra == "média" || infra == "Média")
            {
                return 4;
            }
            if (infra == "grave" || infra == "Grave")
            {
                return 5;
            }
            if (infra == "gravíssima" || infra == "Gravíssima")
            {
                return 7;
            }
            else
            {
                return 0;
            }
        }
        //Função para verificar valor de multa
        double verificavalor(string infra)
        {
            if (infra == "leve" || infra == "Leve")
            {
                return 88.38;
            }
            if (infra == "média" || infra == "Média")
            {
                return 130.16;
            }
            if (infra == "grave" || infra == "Grave")
            {
                return 195.23;
            }
            if (infra == "gravíssima" || infra == "Gravíssima")
            {
                return 293.47;
            }
            else
            {
                return 0;
            }
        }
        //Função para verificar CPF
        string verificacpf(string cpf)
        {
            string valor = cpf.Replace(".", "");

            valor = valor.Replace("-", "");



            if (valor.Length != 11)

                return "cpf inválido";



            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;



            if (igual || valor == "12345678909")

                return "cpf inválido";



            int[] numeros = new int[11];



            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(

                  valor[i].ToString());



            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];



            int resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[9] != 0)

                    return "cpf inválido";

            }

            else if (numeros[9] != 11 - resultado)

                return "cpf inválido";



            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];



            resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[10] != 0)

                    return "cpf inválido";

            }

            else

                if (numeros[10] != 11 - resultado)

                return "cpf inválido";



            return cpf;
        }
        //Função para verificar placa
        string verificaplaca(string placa)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}|[a-zA-Z]{3}[0-9]{4}$");

            if (regex.IsMatch(placa))
            {
                return placa;
            }

            return "placa inválida";
        }
        //Função para verificar data
        string verificardata(string data)
        {
            string dateString = data;
            DateTime dateValue;
            if (DateTime.TryParse(dateString, out dateValue))
                return dateValue.ToString();
            else
                return "Data inválida";
        }
        //Parte dos controles
        public Multas()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            txtpontos.Text = verificapontos(txtinfra.Text).ToString();
            txtvalor.Text = "R$" + verificavalor(txtinfra.Text).ToString();
            txtcpf.Text = verificacpf(txtcpf.Text).ToString();
            txtplaca.Text = verificaplaca(txtplaca.Text).ToString();
            txtdata.Text = verificardata(txtdata.Text).ToString();
            if (txtpontos.Text == "0" || txtvalor.Text == "R$0" || txtcpf.Text == "cpf inválido" || txtplaca.Text == "placa inválida" || txtdata.Text == "data inválida")
            {
                MessageBox.Show("ERROR: informações inválidas, reescreva corretamente");
                limparcampos();
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void consultaDeMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
