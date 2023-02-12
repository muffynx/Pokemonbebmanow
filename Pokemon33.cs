using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon3
{
    internal class Pokemon33
    {
        protected string name;
        protected int HP;
        protected int Atk;
        protected Bitmap _image;
        public Bitmap getImage() { return _image; }
        public string GetName() { return this.name; }
        public int GetHP() { return this.HP; }
        public int GetAtk() { return this.Atk; }
        public void setHP(int hp) { HP= hp; }
    }
}
