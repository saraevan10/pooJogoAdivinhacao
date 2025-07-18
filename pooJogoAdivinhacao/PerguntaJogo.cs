using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class PerguntaJogo
    {
        //Construtor
        public PerguntaJogo()
        {
            this.Pergunta = "";
            this.Resposta = "";
        }
        //Construtor - Sobrecarga
        public PerguntaJogo(String pergunta, String resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }
        //Propriedades
        private String pergunta;
        public String Pergunta
        {
            get { return pergunta; }
            set { pergunta = value.ToUpper(); }
        }
        private String resposta;

        public String Resposta
        {
            get { return resposta; }
            set { resposta = value.ToUpper(); }
        }

    }
}
