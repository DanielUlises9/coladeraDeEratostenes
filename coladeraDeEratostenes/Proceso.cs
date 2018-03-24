using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladeraDeEratostenes
{
    class Proceso
    {
        private int[] mivector;

        public Proceso (int tamaño)
        {
            mivector = new int[tamaño];
            InicializarVerd();
            LlenadoDeCeros();
        }
        /// <summary>
        /// LLena de numeros 1 al vector
        /// </summary>
        private void InicializarVerd ()
        {
            for (int i = 0; i < mivector.Length; i++)
                mivector[i] = 1;
        }
        /// <summary>
        /// Llena de 0 la pocion del que es multiplo de si mismo 
        /// </summary>
        private void LlenadoDeCeros()
        {
            for (int i = 2; i< mivector.Length; i++)
            {
                if(mivector[i]==1)
                {
                    MultiploCero(i);
                }
            }
        }
        /// <summary>
        /// Trabaja con la funcion llenadodeceros
        /// </summary>
        /// <param name="num"></param>
        private void MultiploCero(int num)
        {
            for (int i = num +1;i < mivector.Length; i++)
            {
                if (i %num ==0)
                {
                    mivector[i] = 0;
                }
            }
        }
        /// <summary>
        /// Crea el string con los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string resultado ="";
            for (int i = 1; i< mivector.Length;i++)
            {
                if (mivector[i]==1)
                    resultado += i+", " ;
            }
            return resultado;
        }
    }
}
