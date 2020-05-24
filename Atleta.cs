using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private int idade;
        private double peso, altura;
        double imc;


        public string Nome
        {
            set
            {
                if ( value!= string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatório!");
                }

            }
            get { return this.nome; }
        }

        public int Idade
        {
            set { this.idade = value; }
            get { return this.idade; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima deve ser de 1 m!");
                }
            }
            get { return this.altura; }
        }

        public double Peso
        {
            set { this.peso = value; }
            get { return this.peso; }
        }

        public double IMC
        {
            set { this.imc = this.peso / (this.altura * this.altura); }
            get { return this.imc; }
        }

        public string ImprimeDados()
        {
            return "\n\nNome: " + this.nome +
                   "\nData de Nascimento: " + this.idade +
                   "\nAltura: " + this.altura.ToString("0.00") + "m." +
                   "\nPeso: " + this.peso.ToString("0.00") + "kg." + 
                   "\nSeu IMC é: " + this.imc.ToString("0.00");
        }

    }
}
