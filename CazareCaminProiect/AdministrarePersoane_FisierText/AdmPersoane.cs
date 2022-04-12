using System;
using APersoana;
using ACamera;
using System.IO;

namespace AdministrarePersoane_FisierText
{
    public class AdmPersoane
    { 
    private const int NR_MAX_PERSOANE = 500;
    private string numeFisier;

    public AdmPersoane(string numeFisier)
    {
        this.numeFisier = numeFisier;
        // se incearca deschiderea fisierului in modul OpenOrCreate
        // astfel incat sa fie creat daca nu exista
        Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
        streamFisierText.Close();
    }

    public void AddPersoana(Persoana persoana)
    {
        // instructiunea 'using' va apela la final streamWriterFisierText.Close();
        // al doilea parametru setat la 'true' al constructorului StreamWriter indica
        // modul 'append' de deschidere al fisierului
        using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
        {
            streamWriterFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
        }
    }

    public Persoana[] GetPersoane(out int nrPersoane)
    {
        Persoana[] persoane = new Persoana[NR_MAX_PERSOANE];

        // instructiunea 'using' va apela streamReader.Close()
        using (StreamReader streamReader = new StreamReader(numeFisier))
        {
            string linieFisier;
            nrPersoane = 0;

            // citeste cate o linie si creaza un obiect de tip Student
            // pe baza datelor din linia citita
            while ((linieFisier = streamReader.ReadLine()) != null)
            {
                persoane[nrPersoane++] = new Persoana(linieFisier);
            }
        }

        return persoane;
    }
}

    public class AdmCamere

    {
        private const int NR_MAX_CAMERE = 200;
        private string numeFisier;

        public AdmCamere(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddCamera(Camera camera)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(camera.ConversieLaSir_PentruFisier());
            }
        }

        public Camera[] GetCamere(out int nrCamere)
        {
            Camera[] camere = new Camera[NR_MAX_CAMERE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrCamere = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    camere[nrCamere++] = new Camera(linieFisier);
                }
            }

            return camere;
        }
    }
}
