using System;
using System.Collections;
using System.Collections.Generic;

namespace xGraph
{
    public class BitMatrix
    {
        public List<BitArray> Data { get; private set; }
        public int Size { get; private set; }

        public BitMatrix()
        {
            Data = new List<BitArray>();
            
            Size = 0;
        }

        public bool GetValue(int row, int colmn)
        {
            return Data[row][colmn];
        }

        public void SetValue(int row, int colmn, bool value)
        {
            Data[row][colmn] = value;
        }

        public int GetNumVertex()
        {
            return Data.Count;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Data.Count; i++)
            {
                for (int j = 0; j < Data[i].Length; j++)
                {
                    if (Data[i][j] == true)
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
            Data.Add(new BitArray(Size));
            
            for (int i = 0; i < Data.Count; i++)
            {
                Data[i].Length++;
            }

            Size++;
        }

        //добавление ребра (связи между двуямя вершинами), неориентированный граф
        public void AddEdge(int idVertex1, int idVerxet2)
        {
            if (idVertex1 > -1 && idVertex1 <= Size && idVerxet2 > -1 && idVerxet2 <= Size)
            {
                Data[idVertex1][idVerxet2] = true;
                Data[idVerxet2][idVertex1] = true;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Такого набора вершин не существует!");
            }
        }
    }
}
