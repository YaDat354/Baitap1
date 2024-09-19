using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1___NET.DataAccessLayer.DataClass
{
    public class Animal
    {
        public int AnimalID;
        public string AnimalType;
        public string Sound;

        public Animal()
        {
            AnimalID = 0;
            AnimalType = Sound = string.Empty;
        }

        public virtual int ProduceMilk() { return 0; }
        public virtual int GiveBirth() { return 0; }
        public virtual void MakeSound() { }
    }
    public class Cow: Animal, IMilkable, IGiveBirth, ISoundable
    {
        private int maxProduceMilk = 21;
        private int maxGiveBirth = 2;
        private Random random = new Random();
        public override int ProduceMilk()
        {
            return random.Next(0,maxProduceMilk);
        }
        public override int GiveBirth()
        {
            return random.Next(0,maxGiveBirth);
        }
        public override void MakeSound()
        {
            Debug.WriteLine(Sound);
        }
    }
    public class Sheep : Animal, IMilkable, IGiveBirth, ISoundable
    {
        private int maxProduceMilk = 6;
        private int maxGiveBirth = 3;
        private Random random = new Random();

        public override int ProduceMilk()
        {
            return random.Next(0, maxProduceMilk);
        }
        public override int GiveBirth()
        {
            return random.Next(0, maxGiveBirth);
        }
        public override void MakeSound()
        {
            Debug.WriteLine(Sound);
        }
    }
    public class Goat : Animal, IMilkable, IGiveBirth, ISoundable
    {
        private int maxProduceMilk = 11;
        private int maxGiveBirth = 4;
        private Random random = new Random();

        public override int ProduceMilk()
        {
            return random.Next(0, maxProduceMilk);
        }
        public override int GiveBirth()
        {
            return random.Next(0, maxGiveBirth);
        }
        public override void MakeSound()
        {
            Debug.WriteLine(Sound);
        }
    }
}
