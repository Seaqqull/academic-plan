using AcademicPlan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AcademicPlan.Classes
{
    public abstract class ProjectBase
    {
        private MetroForm m_parent;
        protected Panel m_windowConteiner;
        private WindowTabControlBase m_window;
        protected String m_title;
        protected bool m_isActive;

        private IDataController DataControllerBehaviour;
        private IRelation RelationBehaviour;

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

        public MetroForm Parent
        {
            get
            {
                return m_parent;
            }
        }

        public ProjectBase(MetroForm incomeMain, Panel inWindowContainer, WindowTabControlBase incomeWindow, String incomeTitle, IDataController incomeDataController, IRelation incomeRelation)
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
            RelationBehaviour.InitWindow(this, m_window);
            DataControllerBehaviour.InitUserData(this);
            

            m_windowConteiner.Controls.Add(m_window);

            m_window.Name = "UserWindow";
            m_window.Dock = DockStyle.Fill;

            IsActive = true;
        }

        public virtual void DisconnectWindow()
        {
            m_windowConteiner.Controls.Remove(m_window);
            IsActive = false;
            //DataControllerBehaviour.FinalWindow(m_window);
        }

        public abstract void LoadDataInView();
        public abstract void ClearDataInView();
    }
}
