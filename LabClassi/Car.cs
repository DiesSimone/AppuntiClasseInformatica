using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    class Car
    {
        Door FrontRightDoor;
        Door FrontLeftDoor;
        Door RearRightDoor;
        Door RearLeftDoor;
        Engine engine;
        public Car()
        {
            engine = new Engine();
            engine.horsePower = 2000;
            //dovrei inizializzare gli sportelli
            FrontRightDoor = new Door();
            FrontLeftDoor = new Door();
            RearRightDoor= new Door();
            RearLeftDoor = new Door();
        }
        //questa è una classe innestata
        //la sua definizione è all'interno della classe Car
        public class Engine
        {
            public int horsePower;
        }
    }
}
