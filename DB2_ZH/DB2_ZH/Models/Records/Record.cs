using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2_ZH.Models.Records
{
    class Record
    {
       private int id;
       public int Id
       {
           get { return id; }
           set { id = value; }
       }
       
       private string nev;
       public string Nev
       {
           get { return nev; }
           set { nev = value; }
       }

       private string bankartyaszam;
       public string Bankartyaszam
       {
           get { return bankartyaszam; }
           set { bankartyaszam = value; }
       }
       
       private int egyenleg;
       public int Egyenleg
       {
           get { return egyenleg; }
           set { egyenleg = value; }
       }
       

    }
}
