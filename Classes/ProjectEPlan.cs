using AcademicPlan.Interfaces;
using AcademicPlan.UserControls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlan.Classes
{
    enum fields { LK, LZ, PZ, KKS };
    enum mask_params { FIXED_LK = 1, FIXED_LZ = 2, FIXED_PZ = 4, FIXED_KKS = 8, FIXED_ALL = 15 }
    enum DisciplineWarnings { MANY_HOURS = 1, LITTLE_HOURS, MANY_KKS, LITTLE_KKS, STEP_HOURS, STEP_KKS }

    public class ProjectEPlan : ProjectBase
    {
        public int kred;
        public int hours_in_kred;
        public int weeks;
        public decimal max_hours_per_disc;
        public decimal min_hours_per_disc;
        public decimal min_kredits_per_disc;
        public decimal max_kredits_per_disc;
        public int min_srs;
        public int max_srs;
        public Dictionary<Tuple<decimal, decimal>, float> srs_values;
        public List<Discipline> disciplines;

        public void fill_values()
        {
            srs_values.Clear();
            for (decimal i = min_hours_per_disc; i <= max_hours_per_disc; i += 0.5M)
            {
                for (decimal j = min_kredits_per_disc; j <= max_kredits_per_disc; j++)
                {
                    srs_values.Add(new Tuple<decimal, decimal>(i, j), 100.0f * (1.0f - (float)i * weeks / (float)j / hours_in_kred));
                }
            }
        }

        public Discipline this[int key]
        {
            get
            {
                return disciplines[key];
            }
            set
            {
                disciplines[key] = value;
            }
        }

        public ProjectEPlan(WindowMain incomeMain, Panel inWindowContainer, WindowTabControlBase incomeWindow, String incomeTitle, IDataController incomeDataController, IRelation incomeRelation) : base(incomeMain, inWindowContainer, incomeWindow, incomeTitle, incomeDataController, incomeRelation)
        {
            min_srs = 30;
            max_srs = 70;
            kred = 30;
            min_kredits_per_disc = 1;
            max_kredits_per_disc = 8;
            hours_in_kred = 30;
            weeks = 30;
            max_hours_per_disc = 20;
            min_hours_per_disc = 1;
            disciplines = new List<Discipline>();
            srs_values = new Dictionary<Tuple<decimal, decimal>, float>();

            ((WindowTabControlEPlan)incomeWindow).ClassWindow = this;
        }

        public override void ClearDataInView()
        {
            //throw new NotImplementedException();
        }

        public override void LoadDataInView()
        {
            //throw new NotImplementedException();
        }

        public void SetConfig(Parameters p, int weeks)
        {
            kred = p.cred;
            hours_in_kred = p.hour_per_kred;
            max_hours_per_disc = p.max_hours_per_disc;
            min_hours_per_disc = p.min_hours_per_disc;
            max_kredits_per_disc = p.max_cred_per_disc;
            min_kredits_per_disc = p.min_cred_per_disc;
            min_srs = p.min_srs;
            max_srs = p.max_srs;
            this.weeks = weeks;
        }

        public bool srs_inrange(decimal active, decimal kks, Tuple<int, int> vilka)
        {
            if (!srs_values.ContainsKey(new Tuple<decimal, decimal>(active, kks))) return false;
            // MessageBox.Show(srs_values[new Tuple<decimal, decimal>(active, kks)].ToString() + " " + vilka.Item1.ToString() + vilka.Item2.ToString() + " " + (srs_values[new Tuple<decimal, decimal>(active, kks)] >= vilka.Item1
            // && srs_values[new Tuple<decimal, decimal>(active, kks)] <= vilka.Item2).ToString());
            return (srs_values[new Tuple<decimal, decimal>(active, kks)] >= vilka.Item1
              && srs_values[new Tuple<decimal, decimal>(active, kks)] <= vilka.Item2);
        }

        public decimal find_in_kks(decimal active, decimal kks, Tuple<int, int> vilka, bool direction)
        {
            decimal result = 0M;
            if (direction)
            {
                for (decimal i = kks; i >= min_kredits_per_disc; i--)
                    if (srs_inrange(active, i, vilka))
                    {
                        result = i;
                        break;
                    }
            }
            else
            {
                for (decimal i = kks; i <= max_kredits_per_disc; i++)
                    if (srs_inrange(active, i, vilka))
                    {
                        result = i;
                        break;
                    }
            }

            return result;
        }

        private void Raspredelit(DiscDescript cur_disc, decimal result, decimal razn, int NOT_LK)
        {
            if (result <= 1.5M || cur_disc[(int)fields.LK] == 0M) { cur_disc[NOT_LK] = result; }
            else
            {

                //Если отрицательная???Возможно?????Хуй
                razn -= result % 1M;
                cur_disc[NOT_LK] = 1 + result % 1M;
                cur_disc[(int)fields.LK] = 1;
                result -= result % 1M + 2;
                if (result <= razn)
                {
                    cur_disc[NOT_LK] += result % 1M + result;
                }
                else
                {
                    cur_disc[(int)fields.LK] += result / 2 - (((int)(razn + 0.5M)) / 2M);
                    cur_disc[NOT_LK] += result / 2 + (((int)(razn + 0.5M)) / 2M);
                }

            }
        }

        public decimal find_in_hours(decimal kks, Tuple<int, int> vilka, bool direction)
        {
            decimal result = 0M;
            if (direction)
            {
                for (decimal i = max_hours_per_disc; i >= min_hours_per_disc; i -= 0.5M)
                    if (srs_inrange(i, kks, vilka))
                    {
                        result = i;
                        break;
                    }
            }
            else
            {
                for (decimal i = min_hours_per_disc; i <= max_hours_per_disc; i += 0.5M)
                    if (srs_inrange(i, kks, vilka))
                    {
                        result = i;
                        break;
                    }
            }

            return result;
        }

        public Tuple<decimal, decimal> search_in_kks(decimal active, decimal kks, Tuple<int, int> vilka, bool direction)
        {
            Tuple<decimal, decimal> result = new Tuple<decimal, decimal>(0M, 0M);
            decimal res;

            if (direction)
            {
                for (decimal i = active; i >= min_hours_per_disc; i -= 0.5M)
                {
                    res = find_in_kks(i, kks, vilka, direction);
                    if (res != 0M) { result = new Tuple<decimal, decimal>(i, res); break; }
                }
            }
            else
            {
                for (decimal i = active; i <= max_hours_per_disc; i += 0.5M)
                {
                    res = find_in_kks(i, kks, vilka, direction);
                    if (res != 0M) { result = new Tuple<decimal, decimal>(i, res); break; }
                }

            }

            return result;
        }

        public Tuple<decimal, decimal> search_in_hours(decimal kks, Tuple<int, int> vilka, bool direction, bool more_active)
        {
            Tuple<decimal, decimal> result = new Tuple<decimal, decimal>(0M, 0M);
            decimal res;

            if (direction)
            {
                for (decimal i = kks; i >= min_kredits_per_disc; i--)
                {
                    res = find_in_hours(i, vilka, more_active);
                    if (res != 0M) { result = new Tuple<decimal, decimal>(res, i); break; }
                }
            }
            else
            {
                for (decimal i = kks; i <= max_kredits_per_disc; i++)
                {
                    res = find_in_hours(i, vilka, more_active);
                    if (res != 0M) { result = new Tuple<decimal, decimal>(res, i); break; }
                }
            }

            return result;
        }

        public void CalcHours(DiscDescript disc)
        {
            disc.active_hours = weeks * (disc.lk + disc.lz + disc.pz);
            disc.lazy_hours = disc.kks * hours_in_kred - disc.active_hours;
            disc.percent = (float)disc.lazy_hours / (float)(disc.active_hours + disc.lazy_hours) * 100;
        }

        public decimal CreditsSum
        {
            get
            {
                decimal sum = 0M;
                for (int i = 0; i < disciplines.Count; i++)
                    sum += disciplines[i].kks;
                return sum;
            }
        }

        public bool OkSum()
        {
            return CreditsSum == kred;
            /*int i = 0;
            for (; i < disciplines.Count; i++)
               if (disciplines[i].kks == 0)break;
            return CreditsSum == kred && i == disciplines.Count;*/
        }

        public Tuple<int, int> ExtendSRSGroup(decimal kks, Tuple<int, int> vilka)
        {
            int left = -1, right = -1;
            for (decimal i = max_hours_per_disc; i >= min_hours_per_disc; i -= 0.5M)
            {
                float srs_pers = srs_values[new Tuple<decimal, decimal>(i, kks)];
                if (srs_pers >= min_srs && srs_pers <= max_srs)
                {
                    if (srs_pers < vilka.Item1) left = (int)srs_pers;
                    else if (srs_pers > vilka.Item2 && right == -1) right = (int)Math.Ceiling(srs_pers);
                }
            }

            return new Tuple<int, int>(left, right);
        }

        public DiscDescript Recalc(int line, int pole, decimal value, bool change)
        {
            Discipline cur_disc = disciplines[line];
            DiscDescript disc = new DiscDescript(cur_disc);
            disc[pole] = value;
            //byte old_mask=disciplines[line].fixed_mask;

            decimal active_sum;
            if (pole != (int)fields.KKS)
            {
                active_sum = cur_disc.active - cur_disc[pole] + value;
                if (srs_inrange(active_sum, cur_disc.kks, cur_disc.srs))
                {
                    // MessageBox.Show("2");
                }
                else
                {
                    //MessageBox.Show(cur_disc[pole].ToString() + " " + value.ToString());
                    Tuple<decimal, decimal> result = search_in_kks(active_sum, cur_disc.kks, new Tuple<int, int>(cur_disc.srs_percent.Item1, cur_disc.srs_percent.Item2), cur_disc[pole] > value); //decimal result = find_in_kks(active_sum, cur_disc.kks, new Tuple<int, int>(cur_disc.srs_percent.Item1, cur_disc.srs_percent.Item2), cur_disc[pole] > value);
                    if (result.Item2 != 0M)
                    {

                        if (active_sum != result.Item1)
                        {

                            int NOT_LK = cur_disc[(int)fields.LZ] >= cur_disc[(int)fields.PZ] ? (int)fields.LZ : (int)fields.PZ;


                            decimal razn = cur_disc[NOT_LK] - cur_disc[(int)fields.LK];
                            Raspredelit(disc, result.Item1, razn, NOT_LK);
                            disc.error = (byte)DisciplineWarnings.STEP_HOURS;
                        }
                        disc.kks = result.Item2;
                    }
                    else
                    {
                        disc.error = cur_disc[pole] < value ? (byte)DisciplineWarnings.MANY_HOURS : (byte)DisciplineWarnings.LITTLE_HOURS;
                    }
                }
            }
            else
            {

                Tuple<decimal, decimal> result = search_in_hours(value, new Tuple<int, int>(cur_disc.srs_percent.Item1, cur_disc.srs_percent.Item2), cur_disc[pole] > value, true);
                active_sum = disc.active;
                if (result.Item2 != 0M)
                {

                    int NOT_LK = disc[(int)fields.LZ] >= disc[(int)fields.PZ] ? (int)fields.LZ : (int)fields.PZ;
                    decimal razn = disc[NOT_LK] - disc[(int)fields.LK];
                    if (result.Item2 != value) { disc.error = (byte)DisciplineWarnings.STEP_KKS; disc.kks = result.Item2; }
                    Raspredelit(disc, result.Item1, razn, NOT_LK);
                }
                else
                {

                    disc.error = cur_disc[pole] < value ? (byte)DisciplineWarnings.MANY_KKS : (byte)DisciplineWarnings.LITTLE_KKS;
                    MessageBox.Show(disc.kks.ToString());
                }

            }
            if (disc.error == 0 && change) { disciplines[line] = new Discipline(disc); }
            CalcHours(disc);
            return disc;
        }
    }

    public class Parameters
    {
        public int cred = 30;
        public int min_srs = 30;
        public int max_srs = 70;
        public int hour_per_kred = 30;
        public int max_cred_per_disc = 8;
        public int min_cred_per_disc = 1;
        public decimal max_hours_per_disc;
        public decimal min_hours_per_disc = 1;
        public int[] semester_weeks ={14,16,
                                  14,16,
                                  14,16,
                                  14,10,
                                  14,16,
                                  14};
        public Parameters() { }
        public Parameters(Parameters a)
        {
            cred = a.cred;
            min_srs = a.min_srs;
            max_srs = a.max_srs;
            hour_per_kred = a.hour_per_kred;
            max_cred_per_disc = a.max_cred_per_disc;
            min_cred_per_disc = a.min_cred_per_disc;
            max_hours_per_disc = a.max_hours_per_disc;
            min_hours_per_disc = a.min_hours_per_disc;
            semester_weeks = a.semester_weeks;
        }
    };

    
}
