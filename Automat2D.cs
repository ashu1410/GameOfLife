using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    enum structure
    {
        Immutable,
        Oscilator, //krynci
        Glider, //szybowiec
        Dakota //leci w lewo
    }
    class Automat2D
    {
        private int[,] cells;
        private int ibound;
        private int jbound;
       private volatile bool work = false;

        public int[,] Cells
        {
            get
            {
                return cells;
            }

            set
            {
                cells = value;
            }
        }

        public int Ibound
        {
            get
            {
                return ibound;
            }

            set
            {
                ibound = value;
            }
        }

        public int Jbound
        {
            get
            {
                return jbound;
            }

            set
            {
                jbound = value;
            }
        }


        public void stop() { work = false; }

        public void setStructure( structure structure)
        {
            int xmid = ibound / 2;
            int ymid = jbound / 2;

            switch(structure)
            {
                case structure.Immutable:
                    cells[xmid, ymid] = 1;
                    cells[xmid, ymid+1] = 1;
                    cells[xmid+1, ymid-1] = 1;
                    cells[xmid+1, ymid+2] = 1;
                    cells[xmid+2, ymid] = 1;
                    cells[xmid+2, ymid+1] = 1;
                    break;
                case structure.Oscilator:
                    cells[xmid, ++ymid] = 1;
                    cells[xmid, ++ymid] = 1;
                    cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    break;
                case structure.Glider:
                    cells[xmid, ymid] = 1;
                    cells[xmid+1, ymid] = 1;
                    cells[xmid+2, ymid] = 1;
                    cells[xmid, ymid+1] = 1;
                    cells[xmid+1, ymid+2] = 1;
                    break;
                case structure.Dakota:
                    cells[xmid, ymid] = 1;
                    cells[xmid, ymid-1] = 1;
                    cells[xmid, ymid-2] = 1;
                    cells[xmid+1, ymid] = 1;
                    cells[xmid + 2, ymid] = 1;
                    cells[xmid +3 , ymid] = 1;
                    cells[xmid + 1, ymid - 3] = 1;
                    cells[xmid + 4, ymid - 1] = 1;
                    cells[xmid + 4, ymid - 3] = 1;
                    break;
            }
        }
        public void setStructure(structure structure, int x,int y)
        {
            int xmid = x;
            int ymid = y;

            switch (structure)
            {
                case structure.Immutable:
                    cells[xmid, ymid] = 1;
                    cells[xmid, ymid + 1] = 1;
                    cells[xmid + 1, ymid - 1] = 1;
                    cells[xmid + 1, ymid + 2] = 1;
                    cells[xmid + 2, ymid] = 1;
                    cells[xmid + 2, ymid + 1] = 1;
                    break;
                case structure.Oscilator:
                    cells[xmid, ++ymid] = 1;
                    cells[xmid, ++ymid] = 1;
                    cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    //cells[xmid, ++ymid] = 1;
                    break;
                case structure.Glider:
                    cells[xmid, ymid] = 1;
                    cells[xmid + 1, ymid] = 1;
                    cells[xmid + 2, ymid] = 1;
                    cells[xmid, ymid + 1] = 1;
                    cells[xmid + 1, ymid + 2] = 1;
                    break;
                case structure.Dakota:
                    cells[xmid, ymid] = 1;
                    cells[xmid, ymid - 1] = 1;
                    cells[xmid, ymid - 2] = 1;
                    cells[xmid + 1, ymid] = 1;
                    cells[xmid + 2, ymid] = 1;
                    cells[xmid + 3, ymid] = 1;
                    cells[xmid + 1, ymid - 3] = 1;
                    cells[xmid + 4, ymid - 1] = 1;
                    cells[xmid + 4, ymid - 3] = 1;
                    break;
            }
        }

        public Automat2D(int N,int M)
        {
            cells = new int[N, M];

            ibound = cells.GetUpperBound(0);
            jbound = cells.GetUpperBound(1);

            //cells[23, 24] = 1;
            //cells[23, 25] = 1;
            //cells[23, 26] = 1;
            //cells[24, 24] = 1;
            //cells[25, 25] = 1;
            //cells[100, 100] = 1;
            //cells[100, 101] = 1;
            //cells[100, 102] = 1;
            //cells[100, 103] = 1;
            //cells[100, 104] = 1;
            //cells[100, 105] = 1;
            //cells[100, 106] = 1;
            //cells[100, 107] = 1;
            //cells[100, 108] = 1;
            //cells[100, 109] = 1;
            //cells[100, 110] = 1;
            //cells[100, 111] = 1;

        }

        public void Iterate(Action oniterate)
        {
                    
            work = true;
            while (work)
            {
               
                cells = GetnextIterationCells();
                oniterate();
            }
        }
            
        
        private int[,] GetnextIterationCells()
        {
           
            int[,] newCells = new int[cells.GetLength(0), cells.GetLength(1)];
            //Parallel.For(0, ibound + 1, index =>
            //   {
            //       for (int j = 0; j < newCells.GetLength(1); j++)
            //           newCells[index, j] = CheckNeighboursState(index, j);
            //   });
            for (int i = 0; i < newCells.GetLength(0); i++)
                for (int j = 0; j < newCells.GetLength(1); j++)
                    newCells[i, j] = CheckNeighboursState(i, j);

            return newCells;
        }
        private int CheckNeighboursState(int i,int j)
        {
            List<int> neighbours = new List<int>();

            if(i==0 && j!=0 && j!=jbound)
            {
                for (int k = j - 1; k <= j + 1; k++)
                    neighbours.Add(cells[ibound, k]);
                for (int k = j - 1; k <= j + 1; k++)
                    neighbours.Add(cells[i+1, k]);
                neighbours.Add(cells[i, j - 1]);
                neighbours.Add(cells[i, j + 1]);
            }
           else if(i==ibound && j != 0 && j != jbound)
            {
                for (int k = j - 1; k <= j + 1; k++)
                    neighbours.Add(cells[0, k]);
                for (int k = j - 1; k <= j + 1; k++)
                    neighbours.Add(cells[ibound - 1, k]);
                neighbours.Add(cells[i, j - 1]);
                neighbours.Add(cells[i, j + 1]);
            }
          else  if(j==0 && i!=0 && i!=ibound)
            {
                for (int k = i - 1; k <= i + 1; k++)
                    neighbours.Add(cells[k, jbound]);
                for (int k = i - 1; k <= i + 1; k++)
                    neighbours.Add(cells[k, j+1]);
                neighbours.Add(cells[i-1, j]);
                neighbours.Add(cells[i+1, j]);
            }
           else if (j == jbound && i != 0 && i != ibound)
            {
                for (int k = i - 1; k <= i + 1; k++)
                    neighbours.Add(cells[k, 0]);
                for (int k = i - 1; k <= i + 1; k++)
                    neighbours.Add(cells[k, j -1]);
                neighbours.Add(cells[i - 1, j]);
                neighbours.Add(cells[i + 1, j]);
            }
           else if(i == 0 && j==0)
            {
                neighbours.Add(cells[i, j + 1]);
                neighbours.Add(cells[i+1, j + 1]);
                neighbours.Add(cells[i+1, j]);
                neighbours.Add(cells[i, jbound]);
                neighbours.Add(cells[i+1, jbound]);
                neighbours.Add(cells[ibound, j]);
                neighbours.Add(cells[ibound, j + 1]);
                neighbours.Add(cells[ibound, jbound]);

            }
           else if(i == ibound && j==0)
            {
                neighbours.Add(cells[i-1, j +1 ]);
                neighbours.Add(cells[i-1, j]);
                neighbours.Add(cells[i, j + 1]);
                neighbours.Add(cells[0, j]);
                neighbours.Add(cells[0, j+1]);
                neighbours.Add(cells[i-1, jbound]);
                neighbours.Add(cells[i, jbound]);
                neighbours.Add(cells[0, jbound]);
            }
           else if(i==ibound && j==jbound)
            {
                neighbours.Add(cells[i, j - 1]);
                neighbours.Add(cells[i-1, j - 1]);
                neighbours.Add(cells[i-1, j]);
                neighbours.Add(cells[i-1, 0]);
                neighbours.Add(cells[i, 0]);
                neighbours.Add(cells[0, j -1]);
                neighbours.Add(cells[0, jbound]);
                neighbours.Add(cells[0, 0]);
            }
           else if(i==0 && j==jbound)
            {
                neighbours.Add(cells[i, j - 1]);
                neighbours.Add(cells[i+1, j -1 ]);
                neighbours.Add(cells[i+1, j ]);
                neighbours.Add(cells[ibound, j - 1]);
                neighbours.Add(cells[ibound, j ]);
                neighbours.Add(cells[i, 0]);
                neighbours.Add(cells[i+1, 0]);
                neighbours.Add(cells[ibound, 0]);

            }
            else
            {
                neighbours.Add(cells[i-1, j - 1]);
                neighbours.Add(cells[i-1, j]);
                neighbours.Add(cells[i-1, j + 1]);
                neighbours.Add(cells[i, j - 1]);
                neighbours.Add(cells[i, j + 1]);
                neighbours.Add(cells[i+1, j - 1]);
                neighbours.Add(cells[i+1, j ]);
                neighbours.Add(cells[i+1, j + 1]);
            }
            int count = (from x in neighbours
                         where x != 0
                         select x).Count();
            switch(cells[i,j])
            {
                case 0:
                    return count == 3 ? 1 : 0;
                case 1:
                    if (count == 2 || count == 3)
                        return 1;
                  else  if (count > 3 || count < 2)
                        return 0;
                    break;
            }

            return 0;
        }
    }
}
