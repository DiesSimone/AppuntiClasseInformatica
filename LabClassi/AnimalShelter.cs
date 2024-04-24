using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    public class AnimalShelter<T>
    {
        private const int DefaultPlacesCount = 20;
        private T[] animalList;
        private int usedPlaces;
        public AnimalShelter() : this(DefaultPlacesCount)
        {
        }
        public AnimalShelter(int placesCount)
        {
            this.animalList = new T[placesCount];
            this.usedPlaces = 0;
        }
        public void Shelter(T newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public T Release(int index)
        {
            if (index < 0 || index >= usedPlaces)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            T releasedAnimal = animalList[index];
            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = default!;
            this.usedPlaces--;
            return releasedAnimal;
        }

        //mettiamo un metodo che stampa i cani nel canile
        public void PrintAnimals()
        {
            for (int i = 0; i < usedPlaces; i++) 
            {
                Console.WriteLine(animalList[i]);
            }
        }

        //mettiamo un metodo che effettua la Release prendendo in
        //input il referece al cane
        public T? Release(T dogToRelease)
        {
            //devo fare una ricerca per vedere se dogToRelease
            //è presente nell'array
            int k = -1;
            for (int i =0;i< usedPlaces;i++) 
            {
                if (animalList[i]!=null && animalList[i]!.Equals(dogToRelease))
                {
                    k= i; break;
                }
            }
            if (k == -1)//non ho trovato il cane
            {
                return default;
            }
            //non c'è bisogno del ramo else perché c'è la return
            //la parte seguente viene eseguita solo se il cane è
            //stato trovato
            int index = k;
            T releasedAnimal = animalList[index];
            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = default!;
            this.usedPlaces--;
            return releasedAnimal;
        }

    }
}
