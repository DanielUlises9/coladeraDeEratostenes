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

        private void InicializarVerd ()
        {
            for (int i = 0; i < mivector.Length; i++)
                mivector[i] = 1;
        }

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
