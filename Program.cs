using System;
<<<<<<< HEAD
using System.CodeDom.Compiler;
=======
>>>>>>> 0b392e882ca08e7ff47a358b178ec996f42fbcfd
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinozauri
{
<<<<<<< HEAD
=======
    class DinoCarnivor
    {
        private int _inaltime;
        private int _greutate;

        public int Inaltie
        {
            get { return _inaltime; }
            set 
            { 
               if(_inaltime < 0)
                {
                    _inaltime = 0;
                }
                else
                {
                    _inaltime = value;
                }
            }
        }
        public int Greutate
        {
            get { return _greutate; }
            set
            {
                if (_greutate < 0)
                {
                    _greutate = 0;
                }
                else
                {
                    _greutate = value;
                }
            }
        }

    }
    class DinoIerbivor 
    {
        private int _inaltime;
        private int _greutate;

        public int Inaltie
        {
            get { return _inaltime; }
            set
            {
                if (_inaltime < 0)
                {
                    _inaltime = 0;
                }
                else
                {
                    _inaltime = value;
                }
            }
        }
        public int Greutate
        {
            get { return _greutate; }
            set
            {
                if (_greutate < 0)
                {
                    _greutate = 0;
                }
                else
                {
                    _greutate = value;
                }
            }
        }

    }
>>>>>>> 0b392e882ca08e7ff47a358b178ec996f42fbcfd
    class Dino
    {
        private int _inaltime;
        private int _greutate;

        public int Inaltime
        {
            get { return _inaltime; }
            set
            {
                if (_inaltime < 0)
                {
                    _inaltime = 0;
                }
                else
                {
                    _inaltime = value;
                }
            }
        }
        public int Greutate
        {
            get { return _greutate; }
            set
            {
                if (_greutate < 0)
                {
                    _greutate = 0;
                }
                else
                {
                    _greutate = value;
                }
            }
        }
        public Dino(int _inaltime, int _greutate)
        {
            Inaltime = _inaltime;
            Greutate = _greutate;
        }

    }
    class Turma
    {
<<<<<<< HEAD
        public Dino[] dinos;
        public string name;
       
        public void initializareTurma(int nrDino)
        {
            dinos = new Dino[nrDino];
            Random rnd = new Random();
            for (int i = 0; i < nrDino; i++)
            {
                dinos[i] = new Dino(rnd.Next(100),rnd.Next(100));
            }
        }
       
        public double inaltimeMedie()
        {
            int suma = 0;
            foreach(var d in dinos)
            {
                suma += d.Inaltime;
            }
            return suma / dinos.Length;
        }
        public int greutateTotala()
        {
            int suma = 0;
            foreach(var d in dinos)
            {
                suma += d.Greutate;
            }
            return suma;
        }
        public bool atac(Turma turmaAtacata, Turma turmaCareAtaca)
        {
            double inaltimeMedieTurmaAtacata = turmaAtacata.inaltimeMedie();
            double inaltimeMedieTurmaCareAtaca = turmaCareAtaca.inaltimeMedie();
            int greutateTotalaTurmaAtacata = turmaAtacata.greutateTotala();
            int greutateTotalaTurmaCareAtaca = turmaCareAtaca.greutateTotala();

            if((inaltimeMedieTurmaAtacata<=inaltimeMedieTurmaCareAtaca*0.2)&&(greutateTotalaTurmaCareAtaca >= greutateTotalaTurmaAtacata*0.2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void afiseazaDinozauri(Turma turma , int nrDino)
        {
            Console.WriteLine(turma.name.ToString());
            int countDino = 1;
            for(int i = 0; i< nrDino; i++)
            {
                
                Console.WriteLine("Dino {0}: inaltime: {1},  greutate: {2}", countDino, turma.dinos[i].Inaltime, turma.dinos[i].Greutate);
                countDino++;
            }
           
        }
        
    }

=======
        Dino[] dinos;
        public Turma (Dino[] dinos)
        {
            foreach(Dino d in dinos)
            {
                d = new Dino()
            }
        }
    }



>>>>>>> 0b392e882ca08e7ff47a358b178ec996f42fbcfd
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int numarDinozauriTurmaCarnivori = 4;
            Turma turmaCarnivore = new Turma()
            {
                dinos = new Dino[numarDinozauriTurmaCarnivori],
                name = "Carnivori"


            };

            int numarDinozauriTurmaIerbivori = 3;
            Turma turmaIerbivore = new Turma()
            {
                dinos = new Dino[numarDinozauriTurmaIerbivori],
                name = "Ierbivori"
            };

            turmaCarnivore.initializareTurma(numarDinozauriTurmaCarnivori);
            turmaIerbivore.initializareTurma(numarDinozauriTurmaIerbivori);
            turmaCarnivore.afiseazaDinozauri(turmaCarnivore,numarDinozauriTurmaCarnivori);
            turmaIerbivore.afiseazaDinozauri(turmaIerbivore, numarDinozauriTurmaIerbivori);
            Console.WriteLine(turmaCarnivore.atac(turmaIerbivore, turmaCarnivore) +"\n");


=======
            Dino dino1 = new Dino(12, 32);

            Turma carnicore = 
            
>>>>>>> 0b392e882ca08e7ff47a358b178ec996f42fbcfd
        }
    }
}
