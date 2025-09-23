using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinozauri
{
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
        Dino[] dinos;
        public Turma (Dino[] dinos)
        {
            foreach(Dino d in dinos)
            {
                d = new Dino()
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Dino dino1 = new Dino(12, 32);

            Turma carnicore = 
            
        }
    }
}
