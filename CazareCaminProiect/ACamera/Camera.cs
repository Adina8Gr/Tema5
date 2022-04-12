using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACamera
{
    public class Camera
    {
        public enum Facilitati
        {
            Baie=1,
            Frigider=2,
            Televizor=3,
            Wi_Fi=4,
            PatSupraetajat=5,
            PatSimplu=6,
            Birou=7,
            Sifonier=8,
            Noptiera=9,
            Scaun=10,
            Balcon
        };
        public enum Tip
        {
           dubla,
           tripla,    
           cvadrupla
           
        };
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int NR = 0;
        private const int TIP = 1;
       // private const int PRET= 2;
        private const int FACILITATI = 3;
      //  private int nrCam;
       // private int pretCam;
      //  private string tipCamera;
      //  private string facilitatiCamera;
        public Camera()
        {
            tipCamera=facilitatiCamera=string.Empty;
            nrCam = 0;
            //pretCam = 0;
             

        }
        public Camera(int nrCam, string tipCamera, string facilitatiCamera)

        {
            this.nrCam = nrCam;
           // this.pretCam = pretCam;
            this.tipCamera = tipCamera;     
            this.facilitatiCamera = facilitatiCamera;
        }
        public Camera(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            nrCam = Convert.ToInt32(dateFisier[NR]);
            tipCamera = dateFisier[TIP];
            facilitatiCamera = dateFisier[FACILITATI];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectCameraPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                nrCam.ToString(),
                (tipCamera ?? " NECUNOSCUT "),
                (facilitatiCamera ?? " NECUNOSCUT "));

            return obiectCameraPentruFisier;
        }

        public int nrCam
        {
            get; set;
        }
        
        public string tipCamera
        {
            get; set;
        }

        public string facilitatiCamera
        {
            get;set;
        }

    }
}
