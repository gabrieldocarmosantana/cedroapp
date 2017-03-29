using System.Collections.Generic;

namespace Cedro.UI.ResultApi
{
    public class ResultApiBuilder<T>
    {
        /// <summary>
        /// Gabriel Santana - gabriel.carmo.santana@gmail.com || 11-993884353 || www.gabrielsantana.net
        /// São Paulo, 18 de Janeiro de 2017
        /// Objetivo dessa classe é criar gerar um ResultApi - Classe padrão de Retorno para as app webApi 
        /// Utilizando os metodos List ou Single e utilizando o build você consegue gerar ResultAi de diferentes clases utilizando Generics
        /// </summary>
        private bool _success;
        private string _message;
        private IList<T> _data = new List<T>();


        public ResultApi<T> Build()
        {
            return new ResultApi<T>(_success, _data, _message);
        }

        public ResultApiBuilder<T> Error(string error)
        {
            _success = false;
            _message = error;

            return this;
        }

        public ResultApiBuilder<T> Single(T entity)
        {

            _success = true;
            _data.Add(entity);

            return this;
        }

        public ResultApiBuilder<T> List(IList<T> list)
        {

            _success = true;
            _data = list;

            return this;
        }

        public ResultApiBuilder<T> SetMessage(string message)
        {
            _message = message;

            return this;
        }


    }
}
