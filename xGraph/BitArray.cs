using System;
using System.Collections;

namespace xGraph
{
    class BitMatrix
    {
        private BitArray[] data;
        private int Dim;

        public BitMatrix(int n)
        {
            data = new BitArray[n];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new BitArray(n);
            }

            Dim = n;
        }

        public bool GetValue(int row, int colmn)
        {
            return data[row][colmn];
        }

        public void SetValue(int row, int colmn, bool value)
        {
            data[row][colmn] = value;
        }

        public int GetNumVertex()
        {
            return data.Length;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (data[i][j] == true)
                    {
                        s += "1 ";
                    }
                    else
                    {
                        s += "0 ";
                    }
                }

                s += Environment.NewLine;
            }

            return s;
        }

        //добавление вершины в матрицу
        public void AddVertex()
        {
            Array.Resize(ref data, data.Length + 1);

            for (int i = 0; i < data.Length; i++)
            {
                data[i].Length++;
            }

            Dim++;
        }

        //добавление ребра (связи между двуямя вершинами)
        public void AddEdge(int idVertex1, int idVerxet2)
        {
            if (idVertex1 > -1 && idVertex1 <= Dim && idVerxet2 > -1 && idVerxet2 <= Dim)
            {
                data[idVertex1][idVerxet2] = true;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Такого набора вершин не существует!");
            }
        }
    }
}
