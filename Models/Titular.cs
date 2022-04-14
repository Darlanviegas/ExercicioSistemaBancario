namespace Projeto_Sistema_Bancario.Models
{
    public class Titular
    {
        private string Nome { get; set; }
        private string CPF { get; set; }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetCPF(string cpf)
        {
            CPF = CPF;
        }
        public string GetCPF()
        {
            return CPF;
        }


    }

}