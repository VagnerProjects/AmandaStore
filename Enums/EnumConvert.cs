using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Enums
{
    public class EnumConvert
    {
        public static string ConvertToTipo(int element)
        {
            return Enum.GetName(typeof(TipoUsuario), element).Replace("_"," ");
        }

        public static string ConvertToSexo(int element)
        {
            return Enum.GetName(typeof(Sexo), element);
        }

        public static string ConvertToCartao(int element)
        {
            return Enum.GetName(typeof(TiposCartao), element).Replace("_", " ");
        }
        public static string ConvertToBandeira(int element)
        {
            return Enum.GetName(typeof(Bandeiras), element).Replace("_", " ");
        }

        public static string ConvertToAvaliacao(int element)
        {
            return Enum.GetName(typeof(Avaliacoes), element).Replace("_", " ");
        }

        public static string ConvertToCliente(int element)
        {
            return Enum.GetName(typeof(TipoCliente), element).Replace("_", " ");
        }

        public static string ConvertToTransaction(int element)
        {
            return Enum.GetName(typeof(TipoTransacao), element).Replace("_", " ");
        }

        public static string ConvertToCategoria(int element)
        {
            return Enum.GetName(typeof(CategoriasProdutos), element).Replace("_", " ");
        }

        public static string ConvertToSubMasculino(int element)
        {
            return Enum.GetName(typeof(SubCategoriaMasculino), element).Replace("_", " ");
        }

        public static string ConvertToSubFeminino(int element)
        {
            return Enum.GetName(typeof(SubCategoriaFeminino), element).Replace("_", " ");
        }

        public static string ConvertToSubAcessorios(int element)
        {
            return Enum.GetName(typeof(SubCategoriaAcessorios), element).Replace("_", " ");
        }

        public static string ConvertToSubMaquiagem(int element)
        {
            return Enum.GetName(typeof(SubCategoriaMaquiagem), element).Replace("_", " ");
        }

        public static string ConvertToSubPerfume(int element)
        {
            return Enum.GetName(typeof(SubCategoriaPerfume), element).Replace("_", " ");
        }
    }
}
