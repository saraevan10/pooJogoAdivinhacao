using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de perguntas
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
            //Pergunta que será exibida para o usuário
            Random r = new Random();
            int pos = r.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];
            //Lógica da resposta
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";
            while (tentativas < 3 && flag == false)
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                if (resposta == pergunta.Resposta)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Errou!! Dica: "+pergunta.Dica);
                }
                    tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabéns!! Você ganhou o jogo.");
            }
            else
            {
                Console.WriteLine("Que pena!! Você perdeu o jogo.");
            }
            Console.ReadKey();
        }
        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            lista.Add(new NovaPergunta("Qual a cor do céu?", "Azul", "Informe uma cor que comece com a letra A"));
            lista.Add(new NovaPergunta("Qual o menor país do mundo?", "Vaticano", "Onde o Papa mora"));
            lista.Add(new NovaPergunta("Qual artista é conhecido como o Rei do Pop?", "Michael Jackson", "COnhecido pelo passo de dança moonwalk"));
            lista.Add(new NovaPergunta("Qual é a plataforma mais famosa para escutar músicas?", "Spotify", "App de Música"));
            lista.Add(new NovaPergunta("O vinho é feito com qual fruta?", "Uva", "Tem a cor roxa"));
            lista.Add(new NovaPergunta("O pão de queijo é um prato típico de qual estado brasileiro?", "Minas Gerais", "Sua capital é Belo Horizonte"));
            lista.Add(new NovaPergunta("Qual a cor que resulta da mistura das cores amarelo e vermelho?", "Laranja", "Nome de uma fruta"));
            lista.Add(new NovaPergunta("Qual animal nais alto do mundo?", "Girafa", "Tem pescoço característico"));
            lista.Add(new NovaPergunta("Qual é o maior rio do Brasil?", "O rio Amazonas", "Fica na região norte do Brasil"));
            lista.Add(new NovaPergunta("Qual fruta envenenada comeu a Branca de Neve?", "Maça", "Cor vermelha"));
            return lista;
        }
    }
}
