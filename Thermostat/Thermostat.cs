using System;

namespace Thermostat
{
    /// <summary>
    /// Modélise un thermostat électronique contrôlant la température d'une pièce.
    /// </summary>
    public class Thermostat
    {
        #region Constantes
        /// ======= CHAMPS====== =================================
        public const int MIN_TEMPERATURE = 5;
        public const int MAX_TEMPERATURE = 35;
        public const int TEMPERATURE_INITIALE = 20;
        #endregion

        #region Propriété
        private int m_temperature;
        ///-------------------------------------------------------
        /// <summary>
        ///    Obtient ou définit la température du thermostat
        /// </summary>
        ///-------------------------------------------------------
        public int Temperature
        {
            get { return m_temperature; }
            set
            {
                if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
                    throw new ArgumentOutOfRangeException();

                m_temperature = value;
            }
        }
        #endregion

        #region Constructeur
        ///------------------------------------------------------------
        /// <summary>
        ///   Initialise une nouvelle instance 
        ///   à la température initiale. 
        /// </summary>
        ///------------------------------------------------------------
        public Thermostat()
        {
            Temperature = TEMPERATURE_INITIALE;
        }
        ///------------------------------------------------------------
        /// <summary>
        ///   Initialise une nouvelle instance  
        ///   à la température pTemperature. 
        /// </summary>
        /// <param name="pTemperature">
        ///------------------------------------------------------------
        public Thermostat(int pTemperature)
        {
            Temperature = pTemperature;
        }
        #endregion

        #region Méthodes
        ///-------------------------------------------------------
        /// <summary>
        ///   Augmente la température courante d'un degré.
        /// </summary>
        ///-------------------------------------------------------
        public void AugmenterTemperature()
        {
            if (m_temperature == MAX_TEMPERATURE)
                throw new InvalidOperationException();
            Temperature++;
        }
        ///-------------------------------------------------------
        /// <summary>
        ///   Diminue la température courante d'un degré.
        /// </summary>
        ///-------------------------------------------------------
        public void DiminuerTemperature()
        {
            if (m_temperature == MIN_TEMPERATURE)
                throw new InvalidOperationException();
            Temperature--;
        }
        #endregion
    }
}
