using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_echecs
{
    class Pieces
    {
        public string NomPiece { get; set; }
        public char CouleurPiece { get; set; }
        public bool Detruite { get; set; }
        public Coordonee[] Possitions { get; set; }
        public Coordonee Emplacement { get; set; }

        public Pieces(string s,char c,int a,int b)
        {
            NomPiece = s;
            CouleurPiece = c;
            Emplacement = new Coordonee(a, b);
        }

        public void Deplacement()
        {
            if (NomPiece[1] == 'P')// a ajouter si il y a quelqu'un a cote de lui
            {
                if (Emplacement.y == 2)
                {
                    Possitions = new Coordonee[2];
                    Possitions[1] = new Coordonee(Emplacement.x, Emplacement.y + 1);
                    Possitions[2] = new Coordonee(Emplacement.x, Emplacement.y + 2);
                }
                else
                {
                    Possitions = new Coordonee[1];
                    Possitions[1] = new Coordonee(Emplacement.x, Emplacement.y + 1);

                }
            }
            else if (NomPiece[1] == 'T')
            {
                Possitions = new Coordonee[14];
                for (int i=0;i<)
                {

                }
            }
            else if (NomPiece[1] == 'C')
            {

            }
            else if (NomPiece[1] == 'F')
            {

            }
            else if (NomPiece[1] == 'K')
            {

            }
            else if (NomPiece[1] == 'Q')
            {

            }
        }
    }
}
