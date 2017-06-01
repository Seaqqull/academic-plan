using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Classes
{
    public class DiscDescript : Discipline
    {

        public decimal active_hours;
        public decimal lazy_hours;
        public float percent;
        public int disc_id = -1;
        public int cycle_id = -1;
        public bool norm = true;
        public byte error;

        public DiscDescript() { error = 0; }
        public DiscDescript(byte error) { this.error = error; }
        public DiscDescript(Discipline d) : base(d)
        {
            error = 0;
        }
        public DiscDescript(decimal lk, decimal lz, decimal pz, decimal kks)
        {
            error = 0;
            this.lk = lk;
            this.lz = lz;
            this.pz = pz;
            this.kks = kks;
        }
        public DiscDescript(decimal lk, decimal lz, decimal pz, decimal kks, decimal active_hours, decimal lazy_hours, float percent)
        {
            error = 0;
            this.lk = lk;
            this.lz = lz;
            this.pz = pz;
            this.kks = kks;
            this.active_hours = active_hours;
            this.lazy_hours = lazy_hours;
            this.percent = percent;
        }
        public DiscDescript(decimal lk, decimal lz, decimal pz, decimal kks, int disc_id, int cycle_id, bool norm)
        {
            error = 0;
            this.lk = lk;
            this.lz = lz;
            this.pz = pz;
            this.kks = kks;
            this.disc_id = disc_id;
            this.cycle_id = cycle_id;
            this.norm = norm;
        }

    }

    public class Discipline
    {
        public decimal lk;
        public decimal lz;
        public decimal pz;
        public decimal kks;
        public byte fixed_mask;
        public Tuple<int, int> srs_percent;
        public decimal this[int i]
        {
            get
            {
                switch (i)
                {
                    case (int)fields.LK:
                        return lk;
                    case (int)fields.LZ:
                        return lz;
                    case (int)fields.PZ:
                        return pz;
                    default:
                        return kks;
                }
            }
            set
            {
                switch (i)
                {
                    case (int)fields.LK:
                        lk = value; break;
                    case (int)fields.LZ:
                        lz = value; break;
                    case (int)fields.PZ:
                        pz = value; break;
                    default:
                        kks = value; break;
                }
            }

        }
        public decimal active
        {
            get { return lk + lz + pz; }
        }
        public Tuple<int, int> srs
        {
            get { return srs_percent; }
            set { if (value.Item1 < value.Item2) srs_percent = value; }
        }
        public Discipline() { }
        public Discipline(Discipline a)
        {
            this.lk = a.lk;
            this.lz = a.lz;
            this.pz = a.pz;
            this.kks = a.kks;
            srs = new Tuple<int, int>(a.srs_percent.Item1, a.srs_percent.Item2);
        }
        public Discipline(DiscDescript a)
        {
            this.lk = a.lk;
            this.lz = a.lz;
            this.pz = a.pz;
            this.kks = a.kks;
            srs = new Tuple<int, int>(a.srs_percent.Item1, a.srs_percent.Item2);
        }
        public Discipline(decimal lk, decimal lz, decimal pz, decimal kks, Tuple<int, int> srs_percent)
        {
            this.lk = lk;
            this.lz = lz;
            this.pz = pz;
            this.kks = kks;
            srs = srs_percent;
        }
    }

}
