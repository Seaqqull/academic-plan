using AcademicPlan.Classes;
using AcademicPlan.Dialogs;
using AcademicPlan.Interfaces;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AcademicPlan.UserControls
{
    public partial class WindowTabControlEPlan : WindowTabControlBase
    {
        ProjectEPlan UserData;

        public ProjectEPlan ClassWindow
        {
            get
            {
                return UserData;
            }

            set
            {
                UserData = value;
            }
        }

        enum form_fields { DISC, CYCLE, NORM, ACTIVE, SAMOST, LK, LZ, PZ, KKS, PROC, GROUP, DELETE, START = (int)form_fields.LK };//Порядок расположения элементов управления таблицы
        enum general_fields { KKS_STATE };
        enum filters_ids { KAF = 0, YEAR, SEMESTER }
        enum work_mode { NEW, EDIT, VIEW, VIEWSEM };

        Parameters default_config, config;
        DataControllerEPlan basa;
        work_mode mode = work_mode.VIEW;
        
        int year = 2017;
        int weeks = 30;
        int main_fields_count;
        int countSubjects;
        int tmpN;
        int semestr_numb = 1;
        int kaf_id = 1;
        int our_kaf_id = 1;

        bool numeric_autochange;
        bool filter_autochange;

        public List<Control> MainControls;//Элементы управления "типо" таблицы
        public List<ComboBox> filters;

        public WindowTabControlEPlan()
        {
            InitializeComponent();
            this.metroPanelSubjectsData.Controls.SetChildIndex(this.metroPanelSubjectsData.Controls[0], this.metroPanelSubjectsData.Controls.Count - 1);
            this.metroPanelSubjectsData.Controls.SetChildIndex(this.metroPanelSubjectsData.Controls[0], this.metroPanelSubjectsData.Controls.Count - 1);
            metroPanelNewRedact.Visible = false;

            numeric_autochange = false;

            MainControls = new List<Control>();
            main_fields_count = 12;
            countSubjects = 0;
        }

        private void WindowTabControlEPlan_Load(object sender, EventArgs e)
        {
            config = new Parameters();
            default_config = new Parameters();
            filters = new List<ComboBox>();
            filters.Add(DepartmentPicker);
            filters.Add(YearPicker);
            filters.Add(SemesterPicker);
            YearPicker.DisplayMember = "Name";
            YearPicker.ValueMember = "ID";
            DepartmentPicker.DisplayMember = "Name";
            DepartmentPicker.ValueMember = "ID";
            SemesterPicker.DisplayMember = "Name";
            SemesterPicker.ValueMember = "ID";
            numeric_autochange = false;
            filter_autochange = false;

            ValidateConfig("!");

            ChecKKKSSum();
            choisePanel.MakeText = TextMaker;
            choisePanel.Add_Item += new EventHandler(choisePanel_Add_Item);
            choisePanel.Remove_Item += new EventHandler(choisePanel_Remove_Item);
            choisePanel.AddItem(new Tuple<int, int>(config.min_srs, config.max_srs));
            choisePanel.SetVisibleButtons(0, ChoisePanel.ChoiseItems.Delete, false);
            choisePanel.SetVisibleButtons(0, ChoisePanel.ChoiseItems.Edit, false);

            basa = (DataControllerEPlan)UserData.DataRuler;
            basa.SetCycle();
            basa.SetDiscs();
            if (basa.Discs.Rows.Count == 0 || basa.Cycles.Rows.Count == 0) MessageBox.Show("Записей для просмотра нет!!!");
            if (basa.SetStockValues() == false) MessageBox.Show("Не удалось вытащить таблицу!!!");
            UpdateFilters(-1);
            UpdateGrid();
            this.YearPicker.SelectedIndexChanged += new System.EventHandler(this.FilterChange);
            this.DepartmentPicker.SelectedIndexChanged += new System.EventHandler(this.FilterChange);
            this.SemesterPicker.SelectedIndexChanged += new System.EventHandler(this.FilterChange);
            if (basa.SetSemester(kaf_id, year, semestr_numb) == false) MessageBox.Show("Что-то не так!!!");

            ChangeVisibleMode(work_mode.VIEW);

        }

        public bool Find_Closest(int line, decimal value, bool change)
        {
            DiscDescript[] disc = new DiscDescript[3];
            decimal asc_pos = 10000, desc_pos = 10000;
            if (change == false)
            {
                disc[0] = new DiscDescript(UserData[line]);
                UserData.CalcHours(disc[0]);
                if (disc[0].percent <= UserData[line].srs_percent.Item2 && disc[0].percent >= UserData[line].srs_percent.Item1)
                {
                    UpdateData(disc[0], line); return true;
                }

            }
            disc[0] = UserData.Recalc(line, (int)form_fields.KKS - (int)form_fields.START, value, false);
            if (disc[0].error == 0)
            {
                UserData.Recalc(line, (int)form_fields.KKS - (int)form_fields.START, value, true);
                UpdateData(disc[0], line);
                return true;
            }
            disc[1] = UserData.Recalc(line, (int)form_fields.KKS - (int)form_fields.START, value - 1M, false);

            asc_pos = disc[0].error != (int)DisciplineWarnings.LITTLE_KKS && disc[0].error != (int)DisciplineWarnings.MANY_KKS ? Math.Abs(value - disc[0].kks) : 10000;
            desc_pos = disc[1].error != (int)DisciplineWarnings.LITTLE_KKS && disc[1].error != (int)DisciplineWarnings.MANY_KKS ? Math.Abs(value - disc[1].kks) : 10000;
            if (asc_pos == 10000 && desc_pos == 10000) { MessageBox.Show("Хуй"); return false; }//Перерасчет
            disc[0].error = (int)DisciplineWarnings.STEP_KKS;
            disc[2] = UserData.Recalc(line, (int)form_fields.KKS - (int)form_fields.START, asc_pos < desc_pos ? disc[0].kks : disc[1].kks, true);
            UpdateData(disc[2], line);
            return true;
        }

        private void ChangeSRSGroup(int line, Tuple<int, int> vilka)
        {
            NumericUpDown num = (NumericUpDown)MainControls[line * main_fields_count + (int)form_fields.KKS];
            UserData[line].srs_percent = vilka;
            Find_Closest(line, num.Value, true);
        }

        public string TextMaker(object o)
        {
            Tuple<int, int> a = ((Tuple<int, int>)o);
            return a.Item1.ToString() + "<СРС<" + a.Item2.ToString();
        }

        private void FilterChange(object sender, EventArgs e)
        {
            if (filter_autochange) return;

            ComboBox combo = (ComboBox)sender;
            int sender_type = 0;
            if (combo == filters[(int)filters_ids.KAF]) sender_type = (int)filters_ids.KAF;
            else if (combo == filters[(int)filters_ids.SEMESTER]) sender_type = (int)filters_ids.SEMESTER;
            else if (combo == filters[(int)filters_ids.YEAR]) sender_type = (int)filters_ids.YEAR;
            UpdateFilters(sender_type);
            UpdateGrid();
        }

        private void UpdateData(DiscDescript disc, int line)
        {
            if (disc.error == 0)
            {
                bool old_auto = numeric_autochange;
                numeric_autochange = true;
                int start = line * main_fields_count;
                if (((decimal)((NumericUpDown)MainControls[start + (int)form_fields.KKS]).Tag) != disc.kks) ChecKKKSSum();
                ((NumericUpDown)MainControls[start + (int)form_fields.LK]).Value = disc.lk;
                ((NumericUpDown)MainControls[start + (int)form_fields.LZ]).Value = disc.lz;
                ((NumericUpDown)MainControls[start + (int)form_fields.PZ]).Value = disc.pz;
                ((NumericUpDown)MainControls[start + (int)form_fields.KKS]).Value = disc.kks;
                ((NumericUpDown)MainControls[start + (int)form_fields.LK]).Tag = disc.lk;
                ((NumericUpDown)MainControls[start + (int)form_fields.LZ]).Tag = disc.lz;
                ((NumericUpDown)MainControls[start + (int)form_fields.PZ]).Tag = disc.pz;
                ((NumericUpDown)MainControls[start + (int)form_fields.KKS]).Tag = disc.kks;
                ((Label)MainControls[start + (int)form_fields.ACTIVE]).Text = disc.active_hours.ToString();
                ((Label)MainControls[start + (int)form_fields.SAMOST]).Text = disc.lazy_hours.ToString();
                ((Label)MainControls[start + (int)form_fields.PROC]).Text = ((int)disc.percent).ToString() + "%";
                numeric_autochange = old_auto;
            }
        }

        private void ChecKKKSSum()
        {
            SumKKSLabel.Text = "Количество кредитов: " + UserData.CreditsSum + "/" + UserData.kred;
            if (UserData.OkSum()) SumKKSLabel.ForeColor = Color.Green;
            else SumKKSLabel.ForeColor = Color.Red;
        }

        private void SRSGroup_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            RadioButton active = choisePanel[choisePanel.GetActive()];
            int index = MainControls.IndexOf(b);
            int line = index / main_fields_count;
            b.Tag = choisePanel.IndexOf(active);
            b.Image = active.Image;
            ChangeSRSGroup(line, (Tuple<int, int>)active.Tag);
        }

        private void Subject_ClickDelete(object sender, EventArgs e)
        {
            DeleteDiscipline(MainControls.IndexOf((MetroButton)sender)/ main_fields_count );
        }

        private void DeleteDiscipline(int line)
        {
            if (line < 0 || line >= MainControls.Count / main_fields_count) return;
            int index = main_fields_count * line;

            for (int j = 0; j < metroPanelSubjectsData.Controls.Count - 2; j++)
                metroPanelSubjectsData.Controls[j].Controls.RemoveAt(line);

            for (int i = main_fields_count - 1; i >= 0; i--)
                MainControls.RemoveAt(i + index);

            if (UserData.disciplines.Count > line) { UserData.disciplines.RemoveAt(line); ChecKKKSSum(); }
            countSubjects--;
        }

        private void ClearDisciplines()
        {
            for (int i = MainControls.Count / main_fields_count - 1; i >= 0; i--)
            {
                DeleteDiscipline(i);
            }
        }

        private bool UpdateSemesterTable()
        {
            DataTable st = basa.SemesterTable;
            for (int i = 0; i < st.Rows.Count; i++)
            {//Удаление удалённых строк
                int j = 0;
                for (; j < UserData.disciplines.Count; j++)
                {
                    int disc_id = (int)((ComboBox)MainControls[j * main_fields_count + (int)form_fields.DISC]).SelectedValue;
                    //int cycle_id=(int)((ComboBox)MainControls[j*main_fields_count+(int)form_fields.CYCLE]).SelectedValue;
                    if ((int)st.Rows[i]["Year"] == year && (int)st.Rows[i]["Semester"] == semestr_numb
                        && (int)st.Rows[i]["Department_ID"] == kaf_id && (int)st.Rows[i]["Disc_ID"] == disc_id) break;
                }
                if (j == UserData.disciplines.Count) basa.SemesterTable.Rows[i].Delete();
            }
            //Rows.Find(new int[]{year, semestr_numb, kaf_id,disc_id})!=null
            for (int i = 0; i < UserData.disciplines.Count; i++)
            {
                int disc_id = (int)((ComboBox)MainControls[i * main_fields_count + (int)form_fields.DISC]).SelectedValue;
                int cycle_id = (int)((ComboBox)MainControls[i * main_fields_count + (int)form_fields.CYCLE]).SelectedValue;
                bool norm = (bool)((CheckBox)MainControls[i * main_fields_count + (int)form_fields.NORM]).Checked;
                DataRow row = st.Rows.Find(new object[] { year, semestr_numb, kaf_id, disc_id });
                if (row == null)
                {
                    row = st.Rows.Add(year, semestr_numb, kaf_id, disc_id, cycle_id, norm, true, 1, (int)UserData[i][(int)fields.KKS], (int)UserData[i][(int)fields.LK],
                         (int)UserData[i][(int)fields.LZ], (int)UserData[i][(int)fields.PZ], UserData.weeks);
                }
                else
                {
                    if ((int)row["Year"] != year) row["Year"] = year;
                    if ((int)row["Semester"] != semestr_numb) row["Semester"] = semestr_numb;
                    if ((int)row["Department_ID"] != kaf_id) row["Department_ID"] = kaf_id;
                    if ((int)row["Disc_ID"] != disc_id) row["Disc_ID"] = disc_id;
                    if ((int)row["Cycle_ID"] != cycle_id) row["Cycle_ID"] = cycle_id;
                    if ((bool)row["Norm"] != norm) row["Norm"] = norm;
                    if ((bool)row["Bachelor"] != true) row["Bachelor"] = true;
                    if ((int)row["Kursovaya"] != 1) row["Kursovaya"] = 1;
                    if ((int)row["KKS"] != UserData[i][(int)fields.KKS]) row["KKS"] = UserData[i][(int)fields.KKS];
                    if ((int)row["LK"] != UserData[i][(int)fields.LK]) row["LK"] = UserData[i][(int)fields.LK];
                    if ((int)row["LZ"] != UserData[i][(int)fields.LZ]) row["LZ"] = UserData[i][(int)fields.LZ];
                    if ((int)row["PZ"] != UserData[i][(int)fields.PZ]) row["PZ"] = UserData[i][(int)fields.PZ];
                    if ((int)row["Weeks"] != UserData.weeks) row["Weeks"] = UserData.weeks;
                }
            }
            if (!basa.UpdateSemester(kaf_id, year, semestr_numb)) {
                MessageBox.Show("Не апдейтится!!!");
                return false;
            }
            UpdateGrid();
            return true;
        }

        private void UpdateFilters(int not_touch)
        {
            filter_autochange = true;
            Dictionary<int, int> old_id = new Dictionary<int, int>();
            List<int> param = new List<int>();
            for (int i = 0; i < filters.Count; i++)
                if (filters[i].SelectedIndex != -1) old_id[i] = (int)filters[i].SelectedValue;
            BindingSource bs;
            int mask;

            for (int i = 0; i < filters.Count; i++)
            {
                if (i == not_touch) continue;
                param.Clear();
                mask = 0;
                for (int j = 0; j < filters.Count; j++)
                {
                    if (j == i || filters[j].SelectedIndex == -1) continue;
                    int SelectedValue = (int)filters[j].SelectedValue;
                    if (SelectedValue != -1)
                    {
                        mask |= 1 << j;
                        param.Add(SelectedValue);
                    }
                }
                DataTable filter = basa.GenerateFilter((DataFields)Enum.ToObject(typeof(DataFields), 1 << i), basa.FilterValues(mask, param.ToArray()));
                bs = new BindingSource();
                bs.DataSource = filter;
                filters[i].BeginUpdate();
                filters[i].DataSource = bs;
                // filters[i].ValueMember = "ID";
                // filters[i].DisplayMember = "Name";
                DataRow old_element;
                if (old_id.ContainsKey(i) && ((old_element = filter.Rows.Find(old_id[i])) != null)) filters[i].SelectedIndex = filter.Rows.IndexOf(old_element);
                filters[i].EndUpdate();
            }
            filter_autochange = false;
        }

        private void UpdateGrid()
        {
            int mask = 0;
            List<int> param = new List<int>();
            for (int j = 0; j < filters.Count; j++)
            {
                if (filters[j].SelectedIndex == -1) continue;
                int SelectedValue = (int)filters[j].SelectedValue;
                if (SelectedValue != -1)
                {
                    mask |= 1 << j;
                    param.Add(SelectedValue);
                }
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = basa.FilterValues(mask, param.ToArray());
            metroGridView.DataSource = bs;
        }

        private void AddViewDiscipline(DiscDescript dis)
        {
            Discipline disc = new Discipline();

            MetroComboBox combo = new MetroComboBox();
            MetroCheckBox check = new MetroCheckBox();
            MetroLabel lbl = new MetroLabel();

            numeric_autochange = true;
            //
            combo.AutoSize = false;
            combo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            combo.Size = new Size(metroPanelDiscipline.Width, 25);
            combo.Dock = DockStyle.Top;
            MainControls.Add(combo);
            metroPanelDiscipline.Controls.Add(combo);

            DataRow datar;
            if ((datar = basa.Discs.Rows.Find(dis.disc_id)) != null)
            {
                combo.Items.Add(datar["Disc_Name"]);
                combo.SelectedIndex = 0;
            }
            //
            combo = new MetroComboBox();

            combo.AutoSize = false;
            combo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            combo.Size = new Size(metroPanelCycles.Width, 25);
            combo.Dock = DockStyle.Top;
            MainControls.Add(combo);
            metroPanelCycles.Controls.Add(combo);
            if ((datar = basa.Cycles.Rows.Find(dis.cycle_id)) != null)
            {
                combo.Items.Add(datar["Cycle_Name"]);
                combo.SelectedIndex = 0;
            }
            //

            check.Size = new Size(metroPanelNorm.Width, 25);
            check.AutoSize = false;
            check.Dock = DockStyle.Top;
            check.Checked = dis.norm;
            check.CheckAlign = ContentAlignment.MiddleCenter;
            check.AutoSize = false;
            MainControls.Add(check);
            metroPanelNorm.Controls.Add(check);
            //
            lbl.AutoSize = false;
            lbl.Size = new Size(metroPanelAct.Width, 25);
            lbl.Dock = DockStyle.Top;
            lbl.Text = dis.active_hours.ToString();
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            MainControls.Add(lbl);
            metroPanelAct.Controls.Add(lbl);
            //
            lbl = new MetroLabel();

            lbl.AutoSize = false;
            lbl.Size = new Size(metroPanelSm.Width, 25);
            lbl.Dock = DockStyle.Top;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Text = dis.lazy_hours.ToString();
            MainControls.Add(lbl);
            metroPanelSm.Controls.Add(lbl);
            //
            NumericUpDown num;
            Font tmpFnt;
            for (int i = 0; i < 3; i++)
            {
                num = new NumericUpDown();
                num.Maximum = dis[i];
                num.Minimum = dis[i];

                num.DecimalPlaces = 1;
                num.Size = new Size(38, 25);

                num.Value = dis[i];
                MainControls.Add(num);
                tmpFnt = new Font(num.Font.FontFamily, 11.5f, FontStyle.Regular);
                num.Font = tmpFnt;
                num.Location = new Point(0, (24 * countSubjects) + countSubjects + 1);
                metroPanelSubjectsData.Controls[(int)form_fields.START + i].Controls.Add(num);
            }

            num = new NumericUpDown();

            num.Maximum = dis.kks;
            num.Minimum = dis.kks;

            num.DecimalPlaces = 1;
            tmpFnt = new Font(num.Font.FontFamily, 11.5f, FontStyle.Regular);
            num.Font = tmpFnt;
            num.Size = new Size(38, 25);
            num.Location = new Point(0, (24 * countSubjects) + countSubjects + 1);

            num.Tag = num.Value;
            num.Value = dis.kks;
            MainControls.Add(num);
            metroPanelKKC.Controls.Add(num);


            lbl = new MetroLabel();
            lbl.AutoSize = false;
            lbl.Size = new Size(metroPanelPercent.Width, 25);
            lbl.Location = new Point(0, (24 * countSubjects) + countSubjects + 1);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Text = ((int)dis.percent).ToString();
            MainControls.Add(lbl);
            metroPanelPercent.Controls.Add(lbl);
            //

            MetroButton buttonGroup = new MetroButton();
            buttonGroup.BackgroundImage = choisePanel[0].Image;
            buttonGroup.BackgroundImageLayout = ImageLayout.Center;
            buttonGroup.UseCustomBackColor = true;
            buttonGroup.BackColor = Color.White;

            buttonGroup.Tag = 0;
            buttonGroup.Size = new Size(26, 25);
            buttonGroup.FlatAppearance.BorderSize = 0;

            MainControls.Add(buttonGroup);
            metroPanelGroup.Controls.Add(buttonGroup);
            //
            MetroButton buttonClose = new MetroButton();
            buttonClose.BackgroundImage = global::AcademicPlan.Properties.Resources.Close;
            buttonClose.BackgroundImageLayout = ImageLayout.Center;
            buttonClose.UseCustomBackColor = true;
            buttonClose.BackColor = Color.White;

            buttonClose.Tag = 0;
            buttonClose.Size = new Size(26, 25);
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.Click += new EventHandler(Subject_ClickDelete);
            MainControls.Add(buttonClose);

            metroPanelDelete.Controls.Add(buttonClose);
            buttonClose.Location = new System.Drawing.Point(metroPanelDelete.Width / 2 - (buttonClose.Width / 2), (24 * countSubjects) + countSubjects + 1);
            //                        
            numeric_autochange = false;

            for (int i = 0; i < main_fields_count; i++)
                MainControls[i + countSubjects * main_fields_count].Margin = new Padding(2, 2, 2, 2);

            MainControls[(int)form_fields.DISC + countSubjects * main_fields_count].Margin = new Padding(0, 4, 0, 4);
            MainControls[(int)form_fields.CYCLE + countSubjects * main_fields_count].Margin = new Padding(0, 4, 0, 4);

            for (int i = 0; i < main_fields_count; i++)
                MainControls[i + main_fields_count * countSubjects].Enabled = false;


            countSubjects++;
        }

        private void metroButtonAddSubject_Click(object sender, EventArgs e)
        {
            DiscDescript dis = new DiscDescript(0, config.min_hours_per_disc, 0, 3);
            AddDiscipline(dis, true);
        }

        private void AddDiscipline(DiscDescript dis, bool change_dis) {
            if (countSubjects == 11)
                return;

            BindingSource bs = new BindingSource();
            Discipline disc = new Discipline();

            MetroComboBox combo = new MetroComboBox();
            MetroCheckBox check = new MetroCheckBox();
            MetroLabel lbl = new MetroLabel();

            numeric_autochange = true;

            //
            combo.AutoSize = false;
            combo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            combo.Size = new Size(metroPanelDiscipline.Width, 25);
            combo.Dock = DockStyle.Top;
            
            bs.DataSource = basa.Discs;

            combo.DataSource = bs;
            combo.DisplayMember = "Disc_Name";
            combo.ValueMember = "Disc_ID";
            MainControls.Add(combo);
            metroPanelDiscipline.Controls.Add(combo);
            DataRow datar;
            combo.CreateControl();
            if ((datar = basa.Discs.Rows.Find(dis.disc_id)) != null)
                combo.SelectedIndex = basa.Discs.Rows.IndexOf(datar);            
            //
            combo = new MetroComboBox();

            combo.AutoSize = false;
            combo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            combo.Size = new Size(metroPanelCycles.Width, 25);
            combo.Dock = DockStyle.Top;

            bs = new BindingSource();
            bs.DataSource = basa.Cycles;
            combo.DataSource = bs;
            combo.DisplayMember = "Cycle_Name";
            combo.ValueMember = "Cycle_ID";

            MainControls.Add(combo);
            metroPanelCycles.Controls.Add(combo);
            combo.CreateControl();
            if ((datar = basa.Discs.Rows.Find(dis.cycle_id)) != null)
                combo.SelectedIndex = basa.Discs.Rows.IndexOf(datar);
            //

            check.Size = new Size(metroPanelNorm.Width, 25);
            check.AutoSize = false;
            check.Dock = DockStyle.Top;
            check.Checked = dis.norm;
            check.CheckAlign = ContentAlignment.MiddleCenter;
            check.AutoSize = false;
            MainControls.Add(check);
            metroPanelNorm.Controls.Add(check);
            //
            lbl.AutoSize = false;
            lbl.Size = new Size(metroPanelAct.Width, 25);
            lbl.Dock = DockStyle.Top;
            lbl.Text = tmpN++.ToString();///
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            MainControls.Add(lbl);
            metroPanelAct.Controls.Add(lbl);
            //
            lbl = new MetroLabel();

            lbl.AutoSize = false;
            lbl.Size = new Size(metroPanelSm.Width, 25);
            lbl.Dock = DockStyle.Top;
            lbl.Text = tmpN++.ToString();///
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            MainControls.Add(lbl);
            metroPanelSm.Controls.Add(lbl);
            //
            NumericUpDown num;
            Font tmpFnt;
            for (int i = 0; i < 3; i++)
            {
                num = new NumericUpDown();
                num.Maximum = config.max_hours_per_disc;
                num.Minimum = 0M;
                num.Increment = 0.5M;

                num.DecimalPlaces = 1;
                num.Size = new Size(38, 25);

                if (i == (int)fields.LZ) { num.Value = dis.lz; num.MouseDown += Numeric_MouseClick; }
                else if (i == (int)fields.PZ) { num.Value = dis.pz; num.Enabled = false; num.MouseDown += Numeric_MouseClick; }
                else if (i == (int)fields.LK) { num.Value = dis.lk; }
                num.Tag = num.Value;
                MainControls.Add(num);
                tmpFnt = new Font(num.Font.FontFamily, 11.5f, FontStyle.Regular);
                num.Font = tmpFnt;
                num.Location = new Point(0, (24 * countSubjects) + countSubjects + 1);
                metroPanelSubjectsData.Controls[(int)form_fields.START + i].Controls.Add(num);
                disc[(int)fields.LK + i] = num.Value;
                num.ValueChanged += numericUpDown_ValueChanged;
            }

            num = new NumericUpDown();

            num.Maximum = config.max_cred_per_disc;
            num.Minimum = config.min_cred_per_disc;
            num.Increment = 1M;

            num.DecimalPlaces = 1;
            tmpFnt = new Font(num.Font.FontFamily, 11.5f, FontStyle.Regular);
            num.Font = tmpFnt;
            num.Size = new Size(38, 25);
            num.Location = new Point(0, (24 * countSubjects) + countSubjects + 1);

            num.Value = dis.kks;
            num.Tag = num.Value;
            MainControls.Add(num);
            metroPanelKKC.Controls.Add(num);
            num.ValueChanged += numericUpDown_ValueChanged;
            
            lbl = new MetroLabel();
            lbl.AutoSize = false;
            lbl.Size = new Size(metroPanelPercent.Width, 25);
            lbl.Location = new Point(0, (24 * countSubjects) + countSubjects + 1);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            MainControls.Add(lbl);
            metroPanelPercent.Controls.Add(lbl);
            //

            MetroButton buttonGroup = new MetroButton();
            buttonGroup.BackgroundImage = choisePanel[0].Image;
            buttonGroup.BackgroundImageLayout = ImageLayout.Center;
            buttonGroup.UseCustomBackColor = true;
            buttonGroup.BackColor = Color.White;

            buttonGroup.Tag = 0;
            buttonGroup.Size = new Size(26, 25);
            buttonGroup.FlatAppearance.BorderSize = 0;
            buttonGroup.Click += new EventHandler(SRSGroup_Click);

            MainControls.Add(buttonGroup);
            metroPanelGroup.Controls.Add(buttonGroup);
            buttonGroup.Location = new System.Drawing.Point(metroPanelGroup.Width / 2 - (buttonGroup.Width / 2), (24 * countSubjects) + countSubjects + 1);
            //
            MetroButton buttonClose = new MetroButton();
            buttonClose.BackgroundImage = global::AcademicPlan.Properties.Resources.Close;
            buttonClose.BackgroundImageLayout = ImageLayout.Center;
            buttonClose.UseCustomBackColor = true;
            buttonClose.BackColor = Color.White;

            buttonClose.Tag = 0;
            buttonClose.Size = new Size(26, 25);
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.Click += new EventHandler(Subject_ClickDelete);
            MainControls.Add(buttonClose);

            metroPanelDelete.Controls.Add(buttonClose);
            buttonClose.Location = new System.Drawing.Point(metroPanelDelete.Width / 2 - (buttonClose.Width / 2), (24 * countSubjects) + countSubjects + 1);
            //

            disc[(int)fields.KKS] = num.Value;
            disc.fixed_mask = (int)mask_params.FIXED_PZ;
            disc.srs = new Tuple<int, int>(((Tuple<int, int>)choisePanel[0].Tag).Item1, ((Tuple<int, int>)choisePanel[0].Tag).Item2);
            UserData.disciplines.Add(disc);

            Find_Closest((MainControls.Count - 1) / main_fields_count, num.Value, change_dis);
            numeric_autochange = false;

            for (int i = 0; i < main_fields_count; i++)
                MainControls[i + countSubjects * main_fields_count].Margin = new Padding(2, 2, 2, 2);

            MainControls[(int)form_fields.DISC + countSubjects * main_fields_count].Margin = new Padding(0, 4, 0, 4);
            MainControls[(int)form_fields.CYCLE + countSubjects * main_fields_count].Margin = new Padding(0, 4, 0, 4);


            ChecKKKSSum();
            countSubjects++;
        }

        private bool Edit_SRS_Ext(int line, Tuple<int, int> advice)
        {
            int group_index = (int)((Button)MainControls[main_fields_count * line + (int)form_fields.GROUP]).Tag;
            NumericUpDown num = (NumericUpDown)MainControls[line * main_fields_count + (int)form_fields.KKS];
            SetRangeExt setRangeExt = new SetRangeExt(((Tuple<int, int>)(choisePanel[group_index].Tag)).Item1, ((Tuple<int, int>)(choisePanel[group_index].Tag)).Item2, config.min_srs, config.max_srs, advice, num.Value, UserData);
            setRangeExt.StartPosition = FormStartPosition.Manual;
            //a.Owner = this;
            setRangeExt.Location = PointToScreen(new Point(choisePanel.GetItemPos(group_index).X + choisePanel.Location.X, choisePanel.GetItemPos(group_index).Y + choisePanel.Location.Y));
            DialogResult res = setRangeExt.ShowDialog();
            if (res == DialogResult.OK)
            {
                Tuple<int, int> vilka = new Tuple<int, int>((int)setRangeExt.num_min.Value, (int)setRangeExt.num_max.Value);
                choisePanel.EditItem(group_index, vilka);
                UserData[line].srs_percent = vilka;
                UserData.Recalc(line, (int)fields.KKS, num.Value, true);
                for (int i = 0; i < MainControls.Count; i += main_fields_count)
                {
                    if ((int)MainControls[i + (int)form_fields.GROUP].Tag == group_index)
                    {
                        ChangeSRSGroup(i / main_fields_count, vilka);
                    }
                }
                return true;
            }
            MessageBox.Show("Слишком " + (num.Value > (decimal)num.Tag ? "много" : "мало") + " кредитов");
            num.Value = (decimal)num.Tag;
            return false;

        }

        private void ValidateConfig(string filepath)
        {
            if (filepath != "")
            {
                List<int> sem_weeks = new List<int>();
                for (int i = 0; i < 9; i++)
                {
                    int w_count;
                    if (weeks % 2 != 0)
                        w_count = 14;
                    else
                        w_count = 16;
                    sem_weeks.Add(w_count > 0 && w_count < 30 ? w_count : default_config.semester_weeks[i]);
                }
                for (int i = 0; i < 11 - sem_weeks.Count(); i++)
                    sem_weeks.Add(default_config.semester_weeks[sem_weeks.Count()]);

                config.semester_weeks = sem_weeks.ToArray();
                config.hour_per_kred = -1; config.max_cred_per_disc = -1; config.min_srs = -1; config.max_srs = -1; config.cred = -1; config.max_hours_per_disc = -1;
                config.min_hours_per_disc = -1; config.min_cred_per_disc = -1;
                config.hour_per_kred = config.hour_per_kred > 0 && config.hour_per_kred < 100 ? config.hour_per_kred : default_config.hour_per_kred;
                if (!(config.min_srs > 0 && config.max_srs <= 100 && config.min_srs < config.max_srs))
                {
                    config.min_srs = default_config.min_srs;
                    config.max_srs = default_config.max_srs;
                }

                config.cred = config.cred > 0 && config.cred < 50 ? config.cred : default_config.cred;

                config.max_cred_per_disc = config.max_cred_per_disc > 0 && config.max_cred_per_disc <= (config.cred / 2) ? config.max_cred_per_disc : config.cred / 2;
                config.min_cred_per_disc = config.min_cred_per_disc > 0 && config.min_cred_per_disc <= config.max_cred_per_disc ? config.min_cred_per_disc : default_config.min_cred_per_disc;
            }
            if (mode == work_mode.NEW) UserData.weeks = weeks = config.semester_weeks[semestr_numb];
            default_config.max_hours_per_disc = (decimal)(1 - config.min_srs / 100f) * config.max_cred_per_disc * config.hour_per_kred / weeks;

            config.max_hours_per_disc = config.max_hours_per_disc > config.min_hours_per_disc && config.max_hours_per_disc < default_config.max_hours_per_disc ? config.max_hours_per_disc : default_config.max_hours_per_disc;
            config.min_hours_per_disc = config.min_hours_per_disc < config.max_hours_per_disc && config.min_hours_per_disc > default_config.min_hours_per_disc ? config.min_hours_per_disc : default_config.min_hours_per_disc;

            UserData.SetConfig(config, weeks);
            UserData.fill_values();
            if (UserData.search_in_hours(config.min_cred_per_disc, new Tuple<int, int>(config.min_srs, config.max_srs), false, true).Item2 == -1)
            {
                MessageBox.Show("При даном файле конфигурации работа невозможна!!!\n" +
                    "Возвращение к конфигурации по умолчанию...");
                config = new Parameters(default_config);
                weeks = mode == work_mode.NEW ? config.semester_weeks[semestr_numb] : weeks;
            UserData.SetConfig(config, weeks);
            UserData.fill_values();
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_autochange) return;
            NumericUpDown num = (NumericUpDown)sender;
            int index = MainControls.IndexOf((Control)num);
            int type = index % main_fields_count;
            int line = index / main_fields_count;
            int start = line * main_fields_count;
            numeric_autochange = true;

            if (type == (int)form_fields.LK || type == (int)form_fields.LZ || type == (int)form_fields.PZ)//Контроль ввода данных в NumericUpDown
            {
                if ((num.Value * 2M) % 1M != 0
                    || ((NumericUpDown)MainControls[start + (int)form_fields.LK]).Value >
                    (((NumericUpDown)MainControls[start + (int)form_fields.LZ]).Value
                    + ((NumericUpDown)MainControls[start + (int)form_fields.PZ]).Value))
                { num.Value = (decimal)num.Tag; numeric_autochange = false; return; }

            }
            DiscDescript disc = UserData.Recalc(line, type - (int)form_fields.START, num.Value, true);

            if (disc.error == (byte)DisciplineWarnings.STEP_HOURS)
            {
                MessageBoxButtons YesNo = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Невозможно установить даное количество активных часов при даном СРС." +
                " Увеличить диапазон СРС?(Нет - перескочить на " + disc.active.ToString() + " активных часов)", "", YesNo);
                if (res == DialogResult.Yes) { }//Изменение диапазона СРС
                else
                {
                    disc = UserData.Recalc(line, type - (int)form_fields.LK, disc[type - (int)form_fields.START], true);
                }
            }
            else if (disc.error == (byte)DisciplineWarnings.STEP_KKS)
            {
                MessageBoxButtons YesNo = MessageBoxButtons.YesNo;
                Tuple<int, int> ExtendResult = UserData.ExtendSRSGroup(num.Value, UserData[line].srs_percent);
                DialogResult res = MessageBox.Show("Невозможно установить " + num.Value.ToString() + " кредитов при даном СРС." +
                " Увеличить диапазон СРС?(Нет - перескочить на " + disc.kks.ToString() + " кредитов)", "", YesNo);
                if (res == DialogResult.Yes) { Edit_SRS_Ext(line, ExtendResult); }//Изменение диапазона СРС
                else
                {
                    disc = UserData.Recalc(line, type - (int)form_fields.LK, disc[type - (int)form_fields.START], true);
                }
            }
            else if (disc.error == (byte)DisciplineWarnings.LITTLE_HOURS) { MessageBox.Show("Слишком мало часов"); num.Value = (decimal)num.Tag; }
            else if (disc.error == (byte)DisciplineWarnings.MANY_HOURS) { MessageBox.Show("Слишком много часов"); num.Value = (decimal)num.Tag; }

            else if (disc.error == (byte)DisciplineWarnings.LITTLE_KKS || disc.error == (byte)DisciplineWarnings.MANY_KKS)
            {
                Tuple<int, int> ExtendResult = UserData.ExtendSRSGroup(num.Value, UserData[line].srs_percent);
                if (ExtendResult.Item1 == -1 && ExtendResult.Item2 == -1) { MessageBox.Show("Слишком " + (num.Value > (decimal)num.Tag ? "много" : "мало") + " кредитов"); num.Value = (decimal)num.Tag; }
                else
                {
                    DialogResult res = MessageBox.Show("Невозможно установить " + num.Value.ToString() + " кредитов при даном диапазоне СРС. Хотите расширить диапазон???", "Вопрос", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes) { Edit_SRS_Ext(line, ExtendResult); }
                    else { num.Value = (decimal)num.Tag; }
                }
            }
            UpdateData(disc, line);
            num.Tag = num.Value;//Сохраняем предыдущее значение
            numeric_autochange = false;

        }

        void choisePanel_Add_Item(object sender, EventArgs e)
        {
            SetRange a = new SetRange(config.min_srs, config.max_srs, UserData);
            a.StartPosition = FormStartPosition.Manual;
            //a.Owner = this;
            a.Location = PointToScreen(new Point(choisePanel.GetAddButtonPos().X + choisePanel.Location.X, choisePanel.GetAddButtonPos().Y + choisePanel.Location.Y));
            DialogResult res = a.ShowDialog();
            if (res == DialogResult.OK) choisePanel.AddItem(new Tuple<int, int>((int)a.num_min.Value, (int)a.num_max.Value));
        }

        void choisePanel_Edit_Item(object sender, EventArgs e)
        {
            ReactionArgs reactionArgs = (ReactionArgs)e;
            SetRange dialogRange = new SetRange(((Tuple<int, int>)(choisePanel[reactionArgs.index].Tag)).Item1, ((Tuple<int, int>)(choisePanel[reactionArgs.index].Tag)).Item2, config.min_srs, config.max_srs, UserData);
            dialogRange.StartPosition = FormStartPosition.Manual;
            //a.Owner = this;
            dialogRange.Location = PointToScreen(new Point(choisePanel.GetItemPos(reactionArgs.index).X + choisePanel.Location.X, choisePanel.GetItemPos(reactionArgs.index).Y + choisePanel.Location.Y));
            DialogResult res = dialogRange.ShowDialog();
            if (res == DialogResult.OK)
            {
                Tuple<int, int> vilka = new Tuple<int, int>((int)dialogRange.num_min.Value, (int)dialogRange.num_max.Value);
                choisePanel.EditItem(reactionArgs.index, vilka);
                for (int i = 0; i < MainControls.Count; i += main_fields_count)
                {
                    if ((int)MainControls[i + (int)form_fields.GROUP].Tag == reactionArgs.index)
                    {
                        ChangeSRSGroup(i / main_fields_count, vilka);
                    }
                }
            }
        }

        void choisePanel_Remove_Item(object sender, EventArgs e)
        {
            ReactionArgs r = (ReactionArgs)e;
            choisePanel.RemoveItem(r.index);
            for (int i = (int)form_fields.GROUP; i < MainControls.Count; i += main_fields_count)
            {
                if ((int)MainControls[i].Tag > r.index)
                {
                    MainControls[i].Tag = (int)MainControls[i].Tag - 1;
                    ((Button)MainControls[i]).Image = choisePanel[(int)MainControls[i].Tag].Image;
                }
                else if ((int)MainControls[i].Tag == r.index)
                {
                    ((Button)MainControls[i]).PerformClick();
                }
            }
        }

        private void ViewMode_Click(object sender, EventArgs e)
        {
            ChangeVisibleMode(work_mode.VIEW);
            mode = work_mode.VIEW;
        }

        private void ViewSemestrFromGrid_Click(object sender, EventArgs e)
        {
            
            if (metroGridView.SelectedRows.Count < 1) {
                ViewMode_Click(sender, e);
                return;
            }
            
            ClearDisciplines();
            mode = work_mode.VIEWSEM;
            kaf_id = (int)metroGridView.SelectedRows[0].Cells["Department_ID"].Value;
            year = (int)metroGridView.SelectedRows[0].Cells["Year"].Value;
            semestr_numb = (int)metroGridView.SelectedRows[0].Cells["Semester"].Value;
            borderedCellInfoYearSemestr.MakeTitle(year.ToString(), semestr_numb.ToString(), kaf_id.ToString());

            if (basa.SetSemester(kaf_id, year, semestr_numb) == false) {
                ViewMode_Click(sender, e);
                return;
            } 
            weeks = (int)basa.SemesterTable.Rows[0]["Weeks"];
            ValidateConfig("");

            DataRowCollection rows = basa.SemesterTable.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                DiscDescript dis = new DiscDescript((int)rows[i]["LK"], (int)rows[i]["LZ"], (int)rows[i]["PZ"], (int)rows[i]["KKS"]);
                dis.disc_id = (int)rows[i]["Disc_ID"];
                dis.cycle_id = (int)rows[i]["Cycle_ID"];
                dis.norm = (bool)rows[i]["Norm"];
                UserData.CalcHours(dis);
                AddViewDiscipline(dis);
            }
            ChangeVisibleMode(work_mode.VIEWSEM);
        }

        private void NewMode_Click(object sender, EventArgs e)
        {
            NewSemestr dialog = new NewSemestr(our_kaf_id, basa.StockValues);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.Cancel) { ViewMode_Click(sender, e); return; }
            year = (int)dialog.Year.Value;
            semestr_numb = (int)dialog.Semester.Value;
            if (!basa.SetSemester(our_kaf_id, year, semestr_numb)) { ViewMode_Click(sender, e); return; }
            ClearDisciplines();
            for (int i = 0; i < (int)dialog.DiscCount.Value; i++)
            {
                DiscDescript dis = new DiscDescript(0, config.min_hours_per_disc, 0, 3);
                AddDiscipline(dis, true);
            }
            ChangeVisibleMode(work_mode.NEW);
        }

        private void EditSemesterFromGrid_Click(object sender, EventArgs e)
        {
            
            if (metroGridView.SelectedRows.Count < 1) { ViewMode_Click(sender, e); return; }
            

            kaf_id = (int)metroGridView.SelectedRows[0].Cells["Department_ID"].Value;
            if (kaf_id != our_kaf_id) { ViewMode_Click(sender, e); return; }            
            year = (int)metroGridView.SelectedRows[0].Cells["Year"].Value;
            semestr_numb = (int)metroGridView.SelectedRows[0].Cells["Semester"].Value;

            borderedCellInfoYearSemestr.MakeTitle(year.ToString(), semestr_numb.ToString(), kaf_id.ToString());
            ClearDisciplines();
            if (basa.SetSemester(kaf_id, year, semestr_numb) == false) { MessageBox.Show("Шо-то не так!!!"); ViewMode_Click(sender, e); return; } //Возврат к просмотру
            mode = work_mode.EDIT;
            weeks = (int)basa.SemesterTable.Rows[0]["Weeks"];
            ValidateConfig("");
            DataRowCollection rows = basa.SemesterTable.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                DiscDescript dis = new DiscDescript((int)rows[i]["LK"], (int)rows[i]["LZ"], (int)rows[i]["PZ"], (int)rows[i]["KKS"]);
                dis.disc_id = (int)rows[i]["Disc_ID"];
                dis.cycle_id = (int)rows[i]["Cycle_ID"];
                dis.norm = (bool)rows[i]["Norm"];
                AddDiscipline(dis, false);
            }
            ChangeVisibleMode(work_mode.EDIT);
        }

        private void ChangeMode_Click(object sender, EventArgs e)
        {
            ChangeVisibleMode(work_mode.EDIT);
        }

        private void SaveRedactedData_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> disc_povtor = new Dictionary<int, int>();
            for (int i = 0; i < UserData.disciplines.Count; i++)
            {
                int id = (int)((ComboBox)MainControls[i * main_fields_count + (int)form_fields.DISC]).SelectedValue;
                if (disc_povtor.ContainsKey(id)) disc_povtor[id]++;
                else disc_povtor.Add(id, 1);
            }
            bool err = false;
            foreach (var elem in disc_povtor)
            {
                if (elem.Value > 1) err = true;
            }
            if (!err)
                if (UpdateSemesterTable()){
                    ChangeMode.Visible = false;
                    ViewMode.PerformClick();
                }
                else MessageBox.Show("Есть повторяющиеся дисциплины!!! Исправьте это!!! Бистра!!!");
        }

        private void Numeric_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                NumericUpDown num = ((NumericUpDown)(sender));
                int index = MainControls.IndexOf((Control)num);
                int type = index % main_fields_count;
                int line = index / main_fields_count;
                int start = line * main_fields_count;
                int second_type = type == (int)form_fields.LZ ? (int)form_fields.PZ : (int)form_fields.LZ;
                numeric_autochange = true;
                NumericUpDown ne_sender = (NumericUpDown)MainControls[start + second_type];
                if (num.Value == 0)
                {
                    num.Value = ne_sender.Value;
                    num.Enabled = true;
                    ne_sender.Value = 0;
                    ne_sender.Enabled = false;
                }
                else
                {
                    ne_sender.Value = num.Value;
                    ne_sender.Enabled = true;
                    num.Value = 0;
                    num.Enabled = false;
                }
                ne_sender.Tag = ne_sender.Value;
                UserData[line][second_type - (int)form_fields.START] = ne_sender.Value;
                num.Tag = num.Value;
                UserData[line][type - (int)form_fields.START] = num.Value;
                numeric_autochange = false;
            }

        }

        private void ReturnToView_Click(object sender, EventArgs e)
        {
            ChangeVisibleMode(work_mode.VIEW);
        }

        private void metroGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridView.SelectedRows.Count == 1 && ((int)metroGridView.SelectedRows[0].Cells["Department_ID"].Value == our_kaf_id))
                EditSemesterFromGrid.Visible = true;
            else
                EditSemesterFromGrid.Visible = false;
        }

        private void ChangeVisibleMode(work_mode incomeMode) {
            switch (incomeMode)
            {
                case work_mode.NEW:
                    metroPanelFilter.Visible = false;
                    metroPanelViewGrid.Visible = false;

                    metroPanelSubjectsInput.Visible = true;
                    metroButtonAddSubject.Visible = true;
                    choisePanel.Visible = true;
                    SumKKSLabel.Visible = true;
                    ReturnToView.Visible = false;

                    metroPanelNewRedact.Visible = true;
                    SaveRedactedData.Visible = true;
                    ChangeMode.Visible = true;
                    break;
                case work_mode.EDIT:
                    metroPanelFilter.Visible = false;
                    metroPanelViewGrid.Visible = false;

                    metroPanelSubjectsInput.Visible = true;
                    metroButtonAddSubject.Visible = true;
                    choisePanel.Visible = true;
                    SumKKSLabel.Visible = true;
                    ReturnToView.Visible = false;

                    metroPanelNewRedact.Visible = true;
                    SaveRedactedData.Visible = true;
                    ChangeMode.Visible = true;
                    break;
                case work_mode.VIEW:
                    metroPanelFilter.Visible = true;
                    metroPanelViewGrid.Visible = true;

                    metroPanelSubjectsInput.Visible = false;
                    metroPanelNewRedact.Visible = false;
                    SaveRedactedData.Visible = false;
                    break;
                case work_mode.VIEWSEM:
                    metroPanelFilter.Visible = false;
                    metroPanelViewGrid.Visible = false;

                    metroPanelSubjectsInput.Visible = true;
                    metroButtonAddSubject.Visible = false;
                    choisePanel.Visible = false;
                    SumKKSLabel.Visible = false;
                    ReturnToView.Visible = true;
                  
                    metroPanelNewRedact.Visible = true;
                    
                    break;
                default:
                    break;
            }
        }
    }
}
