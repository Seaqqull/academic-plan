using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcademicPlan.UserControls
{
    
    public partial class ChoisePanel : UserControl
    {
        public delegate string ChoiseTextDelegate(object obj);
        public enum ChoiseItems { Item = 0, Delete, Edit, OptionsStart = (int)ChoiseItems.Delete };
        public int item_elements;
        List<Control> Items;
        public int Count
        {
            get { return Items.Count; }
        }
        public ChoiseTextDelegate MakeText;
        public int max_items;
        public bool can_add;
        public event EventHandler Add_Item;
        public event EventHandler Remove_Item;
        public event EventHandler Edit_Item;
        string DefaultText(object o) { return o.ToString(); }
        public ChoisePanel()
        {
            InitializeComponent();
            can_add = true;
            max_items = 5;
            item_elements = 3;
            Items = new List<Control>();
            MakeText = new ChoiseTextDelegate(DefaultText);
        }
        public Point GetAddButtonPos()
        {
            return AddButton.Location;
        }
        public Point GetItemPos(int index)
        {
            return this[index].Location;
        }
        public RadioButton this[int index]
        {
            get
            {
                if (Items.Count > index * item_elements)

                    return (RadioButton)Items[index * item_elements];
                else
                {
                    RadioButton r = new RadioButton();
                    r.Tag = "Error";
                    return r;
                }
            }
            set
            {
                if (Items.Count < index * item_elements)
                    Items[index * item_elements] = value;
            }
        }
        public int IndexOf(RadioButton r)
        {
            return Items.IndexOf(r) / item_elements;
        }
        public void SetVisibleButtons(int index, ChoiseItems button, bool visibility)
        {
            if (!(index >= 0 && index < Items.Count) || (int)button == (int)ChoiseItems.Item) return;
            Items[index * item_elements + (int)button].Visible = visibility;
        }
        public bool AddItem(object Tag)
        {
            int count = Items.Count / item_elements;
            if (max_items <= count) return false;
            RadioButton r = new RadioButton();
            //r.Text = Tag.ToString();
            r.ImageAlign = ContentAlignment.MiddleLeft;
            r.Appearance = Appearance.Button;
            r.Tag = Tag;
            r.TextImageRelation = TextImageRelation.ImageBeforeText;
            r.FlatStyle = FlatStyle.Popup;
            if (imgs.Images.Count != 0)
            {
                r.Image = imgs.Images[count % imgs.Images.Count];
            }
            r.Resize += new EventHandler(ItemResize);
            r.Move += new EventHandler(ItemResize);
            Items.Add(r);
            FlowPanel.Controls.Add(r);
            FlowPanel.Controls.SetChildIndex(AddButton, FlowPanel.Controls.Count - 1);
            for (int i = 1; i < item_elements; i++)
            {
                Button butt = new Button();
                butt.Size = new Size(10, 10);
                butt.Location = new Point(r.Location.X + r.Size.Width - i * butt.Size.Width + 1, r.Location.Y + 2);
                butt.Dock = DockStyle.None;
                //butt.Tag = count;
                if (i == (byte)ChoiseItems.Delete) { butt.BackColor = Color.Maroon; butt.Click += new System.EventHandler(RemoveСlick); }
                else if (i == (byte)ChoiseItems.Edit) { butt.BackColor = Color.Green; butt.Click += new System.EventHandler(EditСlick); }
                Items.Add(butt);
                Controls.Add(butt);
            }
            Controls.SetChildIndex(FlowPanel, Controls.Count - 1);

            if (max_items == count + 1) AddButton.Visible = false;
            if (count == 0) ((RadioButton)Items[0]).Checked = true;
            if (MakeText.GetInvocationList().GetLength(0) != 0) this[count].Text = MakeText(Tag);
            return true;
        }
        public void RemoveItem(int index)
        {
            bool was_checked = ((RadioButton)Items[index * item_elements]).Checked;
            FlowPanel.Controls.Remove(Items[index * item_elements]);

            for (int i = 0; i < item_elements - 1; i++)
            {
                Controls.Remove(Items[index * (item_elements) + (int)ChoiseItems.OptionsStart]);
                Items.RemoveAt(index * item_elements);
            }

            Items.RemoveAt(index * item_elements);

            if (imgs.Images.Count != 0)
                for (int i = index; i < Items.Count / item_elements; i++)
                    this[i].Image = imgs.Images[i % imgs.Images.Count];

            if (can_add) AddButton.Visible = true;
            if (was_checked && Items.Count != 0) ((RadioButton)Items[0]).Checked = true;
        }
        public void EditItem(int index, object tag)
        {
            this[index].Tag = tag;
            this[index].Text = MakeText(tag);
        }
        private void EditСlick(object sender, EventArgs e)
        {
            ReactionArgs a = new ReactionArgs(Items.IndexOf(((Button)sender)) / item_elements);
            if (this.Edit_Item != null)
                this.Edit_Item(sender, a);
        }
        private void RemoveСlick(object sender, EventArgs e)
        {
            ReactionArgs a = new ReactionArgs(Items.IndexOf(((Button)sender)) / item_elements);
            if (this.Remove_Item != null)
                this.Remove_Item(sender, a);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Add_Item != null)
                this.Add_Item(this, e);
        }
        private void ItemResize(object sender, EventArgs e)
        {
            int index = Items.IndexOf(((RadioButton)sender)) / item_elements;
            for (int i = index; i < Items.Count / item_elements; i++)
            {
                RadioButton r = (RadioButton)Items[i * item_elements + (int)ChoiseItems.Item];
                for (int j = 1; j < item_elements; j++)
                {
                    Button butt = (Button)Items[i * item_elements + j];
                    butt.Location = new Point(r.Location.X + r.Size.Width - j * butt.Size.Width + 1, r.Location.Y + 2);
                }
            }
        }
        public int GetActive()
        {
            return Items.IndexOf(FlowPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)) / item_elements + (int)ChoiseItems.Item;
        }
    }
    public class ReactionArgs : EventArgs
    {
        public int index;
        public ReactionArgs() : base() { index = 0; }
        public ReactionArgs(int index)
            : base()
        {
            this.index = index;
        }
    }
}
