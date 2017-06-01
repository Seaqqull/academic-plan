using AcademicPlan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using AcademicPlan.UserControls;

namespace AcademicPlan.Classes
{
    public abstract class ProjectBase
    {
        private WindowMain m_parent;
        protected Panel m_windowConteiner;
        private WindowTabControlBase m_window;
        protected String m_title;
        protected bool m_isActive;

        protected IDataController DataControllerBehaviour;
        protected IRelation RelationBehaviour;

        public string Title
        {
            get
            {
                return m_title;
            }
        }

        public bool IsActive
        {
            get
            {
                return m_isActive;
            }

            set
            {
                m_isActive = value;
            }
        }

        public UserControl Window
        {
            get
            {
                return m_window;
            }            
        }

        public IDataController DataRuler
        {
            get
            {
                return DataControllerBehaviour;
            }          
        }

        public IRelation RelationRuler
        {
            get
            {
                return RelationBehaviour;
            }
        }

        public WindowMain Parent
        {
            get
            {
                return m_parent;
            }
        }

        public ProjectBase(WindowMain incomeMain, Panel inWindowContainer, WindowTabControlBase incomeWindow, String incomeTitle, IDataController incomeDataController, IRelation incomeRelation)
        {
            m_parent = incomeMain;
            m_window = incomeWindow;
            m_title = incomeTitle;
            m_windowConteiner = inWindowContainer;

            DataControllerBehaviour = incomeDataController;
            RelationBehaviour = incomeRelation;
            // class to m_window
        }
        public virtual void ConnectWindow()
        {
            IsActive = true;
            RelationBehaviour.InitWindow(this, m_window);
            DataControllerBehaviour.InitUserData(this);
            

            m_windowConteiner.Controls.Add(m_window);

            m_window.Name = m_title;//"UserWindow"
            m_window.Dock = DockStyle.Fill;

            
        }

        public virtual void DisconnectWindow()
        {
            IsActive = false;
            m_windowConteiner.Controls.Remove(m_window);
            
            DataControllerBehaviour.FinalUserData(this);
            RelationBehaviour.FinalWindow(this, m_window);
        }

        public abstract void LoadDataInView();
        public abstract void ClearDataInView();
    }
}
