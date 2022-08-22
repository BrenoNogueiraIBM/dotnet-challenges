using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio11
{
    class ArrayOperations
    {
        private int[] _array;

        public ArrayOperations(int[] array)
        {
            _array = array;
        }

        public int MinValue()
        {
            int min = _array[0];
            foreach(int i in _array)
            {
                min = i < min ? i : min; 
            }

            return min;
        }

        public int MinValueIndex()
        {
            int min = MinValue();
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == min) // Permitido pois o problema diz que não há repetição de números
                    return i;
            }

            return -1; // Nao deveria acontecer, mas apenas por desencargo de consciencia
        }
    }
}
