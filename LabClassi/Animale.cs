using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace LabClassi
{
    namespace FaunaGreppi
    {
        public enum TipoPelle
        {
            PellicciaFolta,
            Piume,
            PeloCorto,
            SenzaPeli
        };
        public class Animale:EssereVivente
        {

            //parametri statici 
            //http://stackoverflow.com/questions/408192/why-cant-i-have-public-static-const-string-s-stuff-in-my-class 
            private const double CALORIE_ALLA_CREAZIONE_DEFAULT = 200; //in kcal 
            private const bool VIVO_ALLA_CREAZIONE_DEFAULT = true;
            //http://stackoverflow.com/questions/6231253/how-to-declare-a-class-instance-as-a-constant-in-c  
            private readonly static Color COLORE_OCCHI_ALLA_CREAZIONE_DEFAULT = Color.Aqua;
            //http://www.pesi-e-misure.it/site/formule/formula-calcolo-calorie-nella-corsa 
            private const double KCAL_PER_KM_PER_KG_PER_CAMMINATA = 5.0;//in kcal 
            private const double VELOCITA_CAMMINATA = 4.0;//in Km/h 
            public const string VERSO_ANIMALE_DEFAULT = "Comunica";
            //contatore animali creati
            private static int numeroAnimaliCreati = 0;

            //fields
            private double peso;//in KG
            //struct DateTime par. 12.8.1 degli appunti
            private DateTime dataDiNascita;
            //Classe System.Drawing.Color https://www.dotnetperls.com/color
            private Color coloreOcchi;
            private TipoPelle pelle;
            private bool vivo;
            private double kCalAccumulate;
            private Cervello ilCervello;

            public struct Movimento
            {
                public double distanza;//in Km
                public double velocita;//in Km/h
                public Movimento(double distanza, double velocita)
                {
                    this.distanza = distanza;
                    this.velocita = velocita;
                }
            }
            public class Cervello
            {
                private const double VOLUME_DEFAULT = 1;//litri
                private const long NUMERO_NEURONI_DEFAULT = 1000000;
                private double volume;
                private long numeroNeuroni;

                public long NumeroNeuroni
                {
                    get
                    {
                        return numeroNeuroni;
                    }
                }

                public double Volume
                {
                    get
                    {
                        return volume;
                    }
                }
                public Cervello(double volume, long numeroNeuroni)
                {
                    this.volume = volume;
                    this.numeroNeuroni = numeroNeuroni;
                }
                public Cervello() : this(VOLUME_DEFAULT, NUMERO_NEURONI_DEFAULT) { }
                //public Cervello()
                //{
                //       this.volume = VOLUME_DEFAULT;
                //    this.numeroNeuroni = NUMERO_NEURONI_DEFAULT;
                //}
            }


            public double Peso
            {
                get
                {
                    return peso;
                }
                set
                {
                    if (value >= 0)
                    {
                        peso = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(Peso)}", $"{nameof(Peso)} non può essere negativo");
                    }
                }
            }

            public Color ColoreOcchi { get => coloreOcchi; }
            public TipoPelle Pelle { get => pelle; }
            public DateTime DataDiNascita { get => dataDiNascita; }

            public bool Vivo
            {
                get
                {
                    if (!vivo)
                    {
                        return false;
                    }
                    else
                    {
                        //serve per aggiornare la variabile di stato ogni volta che 
                        //viene fatta la lettura della property
                        vivo = kCalAccumulate > 0;
                        return vivo;
                    }
                }

                set
                {
                    vivo = value;
                }
            }
            public double KCalAccumulate
            {

                get
                {
                    if (vivo)
                    {
                        return kCalAccumulate;
                    }
                    else
                    {
                        kCalAccumulate = 0;
                        return kCalAccumulate;
                    }
                }
                set
                {
                    if (value > 0)
                    {
                        kCalAccumulate = value;
                    }
                    else
                    {
                        vivo = false;//l'animale muore
                        kCalAccumulate = 0;
                    }
                }
            }

            public static int NumeroAnimaliCreati { get => numeroAnimaliCreati; }

            //sezione costruttori
            public Animale(double peso, DateTime dataDiNascita,
                Color coloreOcchi, TipoPelle tipoPelle, bool vivo,
                double kCalAllaNascita, Cervello cervello):base("Animale")
            {
                this.peso = peso;
                this.dataDiNascita = dataDiNascita;
                this.coloreOcchi = coloreOcchi;
                this.pelle = tipoPelle;
                this.vivo = vivo;
                this.kCalAccumulate = kCalAllaNascita;
                this.ilCervello = cervello;
                numeroAnimaliCreati++;
            }
            public Animale(double peso, DateTime dataDiNascita,
                Color coloreOcchi, TipoPelle tipoPelle, bool vivo,
                double kCalAllaNascita) :
                this(peso, dataDiNascita, coloreOcchi, tipoPelle,
                    vivo, kCalAllaNascita, new Cervello())
            { }
            public Animale(double peso, DateTime dataDiNascita, Color coloreOcchi) :
                this(peso, dataDiNascita, coloreOcchi,
                    TipoPelle.SenzaPeli,
                    VIVO_ALLA_CREAZIONE_DEFAULT,
                    CALORIE_ALLA_CREAZIONE_DEFAULT)
            { }
            public Animale(double peso, DateTime dataDiNascita) :
                this(peso, dataDiNascita, COLORE_OCCHI_ALLA_CREAZIONE_DEFAULT)
            { }

            public override string ToString()
            {
                return nameof(Animale) + $"[{nameof(Peso)} ={Peso}, {nameof(ColoreOcchi)}= {ColoreOcchi}....]";
            }

            public void Mangia(Cibo cibo)
            {
                if (Vivo)
                {
                    KCalAccumulate += cibo.Peso * cibo.KcalPerKg;
                }
            }

            public void Muoviti(double km, double velocita)
            {

                KCalAccumulate -=
                    Peso * km * KCAL_PER_KM_PER_KG_PER_CAMMINATA * velocita / VELOCITA_CAMMINATA;

            }

            public void BruciaCalorie(double calorie)
            {
                KCalAccumulate -= calorie;
            }
            public virtual string Comunica()
            {
                return (Vivo ? VERSO_ANIMALE_DEFAULT : "");
            }

            public static string DefaultValues()
            {
                return nameof(CALORIE_ALLA_CREAZIONE_DEFAULT) + ": " + CALORIE_ALLA_CREAZIONE_DEFAULT + ";";
            }

            public override void Respira()
            {
                Console.WriteLine("Sono un Animale e respiro dal naso");
            }
        }
    }

}

