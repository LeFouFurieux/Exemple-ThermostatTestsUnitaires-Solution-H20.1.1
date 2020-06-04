using System;
using System.Windows.Forms;

namespace Thermostat
{
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFOS = "(Démo H20.1.0)";

        //===========CHAMPS ===============================================
        private Thermostat m_objThermostat;

        //====Constructeur ================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFOS;
            //---------------------------------------------------------------
            m_objThermostat = new Thermostat();
            lblTemperature.Text = m_objThermostat.Temperature.ToString();
        }
        //=====================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //====================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            if (m_objThermostat.Temperature < Thermostat.MAX_TEMPERATURE)
            {
                m_objThermostat.AugmenterTemperature();
                lblTemperature.Text = m_objThermostat.Temperature.ToString();
            }
        }
        //====================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            if (m_objThermostat.Temperature > Thermostat.MIN_TEMPERATURE)
            {
                m_objThermostat.DiminuerTemperature();
                lblTemperature.Text = m_objThermostat.Temperature.ToString();
            }
        }
        //===================================================================
       
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            
            lblTemperature.Text = Thermostat.MIN_TEMPERATURE.ToString();
        }

        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            
            lblTemperature.Text = Thermostat.MAX_TEMPERATURE.ToString();
        }

        //====================================================================================
        private void mnuAffichageTempCourante_Click(object sender, EventArgs e)
        {
            
            lblTemperature.Text = m_objThermostat.Temperature.ToString();
        }

        //====================================================================================
    }
}