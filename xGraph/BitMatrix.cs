using System;
using System.Collections;
using System.Collections.Generic;

namespace xGraph
{
    public class BitMatrix
    {
        private List<BitArray> data;
        private int Dim;

        public BitMatrix()
        {
            data = new List<BitArray>();
            
            Dim = 0;
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
            return data.Count;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < data.Count; i++)
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
            Dim++;

            data.Add(new BitArray(Dim));
            
            for (int i = 0; i < data.Count; i++)
            {
                data[i].Length++;
            }
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
