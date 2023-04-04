using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public class Calculation
    {
        public double speed;
        public bool dry;
        public bool rain;
        public bool snow;
        public bool ice;
        public bool summerTires;
        public bool winterTires;
        public bool skinTires;
        public bool asphalt;
        public bool gravel;
        public bool primming;

        public Calculation(double speed, bool dry, bool rain, bool snow, bool ice, bool summerTires, bool winterTires, bool skinTires, bool asphalt, bool gravel, bool primming)
        {
            this.speed = speed;
            this.dry = dry;
            this.rain = rain;
            this.snow = snow;
            this.ice = ice;
            this.summerTires = summerTires;
            this.winterTires = winterTires;
            this.skinTires = skinTires;
            this.asphalt = asphalt;
            this.gravel = gravel;
            this.primming = primming;
        }

        public override string ToString()
        {
            string str = $"Входные данные:   Скорость - {speed} км/ч";

            str += "   Погода - ";

            if (dry) str += "сухая";
            else if (rain) str += "дождь";
            else if (snow) str += "снег";
            else if (ice) str += "гололед";

            str += "   Шины - ";

            if (summerTires) str += "летние";
            else if (winterTires) str += "зимние";
            else if (skinTires) str += "лысые";

            str += "   Дорожное покрытие - ";

            if (asphalt) str += "асфальт";
            else if (gravel) str += "гравий";
            else if (primming) str += "грунт";

            return str + "\n";
        }

        public static bool operator==(in Calculation f, in Calculation s)
        {
            return f.speed == s.speed && f.dry == s.dry && f.rain == s.rain && f.ice == s.ice
                && f.summerTires == s.summerTires && f.winterTires == s.winterTires && f.skinTires == s.skinTires
                && f.asphalt == s.asphalt && f.gravel == s.gravel && f.primming == s.primming;
        }

        public static bool operator !=(in Calculation f, in Calculation s)
        {
            return !(f == s);
        }
    }
}
