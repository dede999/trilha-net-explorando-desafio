namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            var numeroHospedes = hospedes.Count();
            var capacidade = Suite!.Capacidade;
            if (numeroHospedes <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"não há lugar para {numeroHospedes} nesse quarto");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados * 1.0m;

            if (DiasReservados >= 10)
            {
                valor *= 0.9m;
            }

            return valor;
        }
    }
}