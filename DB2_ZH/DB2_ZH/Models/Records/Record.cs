using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2_ZH.Models.Records
{
    class Record
    {
       private long id;
       public long Id
       {
           get { return id; }
           set { id = value; }
       }
       
       private string nev;
       public string Nev
       {
           get { return nev; }
           set 
           {
                if (value == null) 
                    throw new ArgumentNullException("A nev nem lehet null!");
                if (value.Length == 0)
                    throw new ArgumentException("A Név hossza nem lehet 0");
                if (250 < value.Length) 
                    throw new ArgumentOutOfRangeException("A nev max 250 karakter");
                nev = value; 
           }
       }

       private string bankartyaszam;
       public string Bankartyaszam
       {
           get { return bankartyaszam; }
           set 
           {
               
                if (value.Length == 0)
                    throw new ArgumentException("A Bankártyaszám hossza nem lehet 0");
                if (16 != value.Length)
                    throw new ArgumentOutOfRangeException("A bankártyaszámnak pontosan 16 számból kell álnia.");
                nev = value;

                bankartyaszam = value; 
           }
       }
       
       private long egyenleg;
       public long Egyenleg
       {
           get { return egyenleg; }
           set { egyenleg = value; }
       }
       

    }
}
