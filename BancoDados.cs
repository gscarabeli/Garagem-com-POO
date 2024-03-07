using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    public static class BancoDados
    {
        public static List<Marca> marcas = new List<Marca>();
        public static List<Modelo> modelos = new List<Modelo>();

        public static int CodigoMarca(string descricao)
        {
            foreach (Marca m in BancoDados.marcas)
            {
                if (m.descricao == descricao)
                    return m.codigo;

            }
            return 0;
        }
    }
}
