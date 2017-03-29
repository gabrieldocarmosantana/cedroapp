using System.Collections.Generic;
using System.Linq;

namespace Cedro.UI.ResultApi
{
    public class ResultApi<T>
    {
        /// <summary>
        /// Gabriel Santana - gabriel.carmo.santana@gmail.com || 11-993884353 || www.gabrielsantana.net
        /// São Paulo, 18 de Janeiro de 2017
        /// Classe Padrão de Retorno WebApi
        /// </summary>
        public ResultApi(bool success, IEnumerable<T> data, string message = null)
        {
            Success = success;
            Message = message;
            Data = data;
            Count = Data.Count();
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
        public IEnumerable<T> Data { get; set; }
        public int Count { get; private set; }
    }
}
