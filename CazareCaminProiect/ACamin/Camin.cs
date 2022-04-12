using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACamin
{
    public class Camin
    {
        public enum FacilitatiCamin
        {
            Bucatarie,
            Spalatorie,
            Toalete,
            SalaDeLectura,
            Parcare
        };
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int NUMEC = 0;
        private const int ADRESA = 1;
        private const int ADMINISTRATOR = 2;
      //  private string numeCamin;
      //  private string adresa;
      //  private string administrator;
        
        public Camin()
        {
            numeCamin = adresa = administrator = string.Empty;
           
        }
        public Camin(string numeCamin, string adresa, string administrator)
        {
            this.numeCamin = numeCamin;
            this.adresa = adresa;
            this.administrator = administrator;
           
        }
       
        public string numeCamin
        { get; set; }

        public string adresa
        {
            get;set;
        }

        public string administrator
        {
            get;set;
        }
    }

}
