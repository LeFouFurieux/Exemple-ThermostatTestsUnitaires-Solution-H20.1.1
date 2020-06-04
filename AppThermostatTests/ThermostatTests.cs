using Thermostat;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat.Tests
{//ceci est un commentaire
    [TestClass()]
    public class ThermostatTests
    {

        #region TESTS PROPRIÉTÉ Temperature
        [TestMethod()]
        public void TemperatureGetCasTempInitRetourTempInitTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);
            // Agir (Act)
            int valeurRetournee = objThermostat.Temperature;
            // Auditer (Assert)
            int ValeurAttendue = Thermostat.TEMPERATURE_INITIALE;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);
        }

        [TestMethod()]
        public void TemperatureGetCasAuLimiteMinRetourLimiteMinTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MIN_TEMPERATURE);
            // Agir (Act)
            int valeurRetournee = objThermostat.Temperature;

            // Auditer (Assert)
            int ValeurAttendue = Thermostat.MIN_TEMPERATURE;

            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }


        [TestMethod()]
        public void TemperatureGetCasAuLimiteMaxRetourLimiteMaxTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE);
            // Agir (Act)
            int valeurRetournee = objThermostat.Temperature;


            // Auditer
            int ValeurAttendue = Thermostat.MAX_TEMPERATURE;

            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }

        [TestMethod()]
        public void TemperatureSetCasTempInitRetourTempInitTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);
            // Agir (Act)
            objThermostat.Temperature = 15;

            // Auditer
            int ValeurAttendue = 15;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }

        [TestMethod()]
        public void TemperatureSetCasAuLimiteMinRetourLimiteMinTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);
            // Agir (Act)
            objThermostat.Temperature = Thermostat.MIN_TEMPERATURE;

            // Agir (Assert)
            int ValeurAttendue = Thermostat.MIN_TEMPERATURE;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }

        [TestMethod()]
        public void TemperatureSetCasAuLimiteMaxRetourLimiteMaxTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);
            // Agir
            objThermostat.Temperature = Thermostat.MAX_TEMPERATURE;
            // Auditer (Assert)

            int ValeurAttendue = Thermostat.MAX_TEMPERATURE;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TemperatureSetCasHorsLimiteMinMoinsUnRetourExceptionTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);

            // Agir
            objThermostat.Temperature = Thermostat.MIN_TEMPERATURE - 1;
            // Auditer (Assert)
            // ArgumentOutOfRangeException attendue et intercepté au niveau de l'annotation  [ExpectedException(typeof(ArgumentOutOfRangeException))]

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TemperatureSetCasHorsLimiteMaxPlusUnRetourExceptionTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);

            // Agir
            objThermostat.Temperature = Thermostat.MAX_TEMPERATURE + 1;
            // Auditer (Assert)
            // ArgumentOutOfRangeException attendue intercepté au niveau de l'annotation  [ExpectedException(typeof(ArgumentOutOfRangeException))]


        }
        #endregion
        #region TESTS CONSTRUCTEUR AVEC PARAMÈTRE
        [TestMethod()]
        public void ConstrAvecParamCasTempInitRetourTempInitTest()
        {
            // Arranger (Arrange) Agir (Act)
            Thermostat objThermostat = new Thermostat(15);

            // Auditer (Assert)
            int ValeurAttendue = 15;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }
        [TestMethod()]
        public void ConstrAvecParamCasAuLimiteMinRetourLimiteMinTest()
        {
            // Arranger (Arrange) Agir (Act)
            Thermostat objThermostat = new Thermostat(Thermostat.MIN_TEMPERATURE);

            // Auditer (Assert)
            int ValeurAttendue = Thermostat.MIN_TEMPERATURE;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);
        }
        [TestMethod()]
        public void ConstrAvecParamCasAuLimiteMaxRetourLimiteMaxTest()
        {

            // Arranger (Arrange) Agir (Act)
            Thermostat objThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE);

            // Auditer (Assert)
            int ValeurAttendue = Thermostat.MAX_TEMPERATURE;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstrAvecParamCasHorsLimiteMinMoinsUnRetourExceptionTest()
        {
            Thermostat objThermostat = new Thermostat(Thermostat.MIN_TEMPERATURE - 1);
            // ArgumentOutOfRangeException attendue intercepté au niveau de l'annotation  [ExpectedException(typeof(ArgumentOutOfRangeException))]

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstrAvecParamCasHorsLimiteMaxPlusUnRetourExceptionTest()
        {

            // Arranger (Arrange) Agir (Agir)
            Thermostat objThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE + 1);
            // Auditer (Assert)
            // ArgumentOutOfRangeException attendue intercepté au niveau de l'annotation  [ExpectedException(typeof(ArgumentOutOfRangeException))]

        }
        #endregion


        #region TESTS MÉTHODE AugmenterTemperature
        [TestMethod()]
        public void AugmenterTemperatureCasTempInitRetourTempInitPlusUnTest()
        {

            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(15);
            //Agir (Act)
            objThermostat.AugmenterTemperature();
            //Auditer (Assert)
            int ValeurAttendue = 16;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }
        [TestMethod()]
        public void AugmenterTemperatureCasAuLimiteMinRetourLimiteMinPlusUnTest()
        {

            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MIN_TEMPERATURE);
            //Agir (Act)
            objThermostat.AugmenterTemperature();
            //Auditer (Assert)
            int ValeurAttendue = Thermostat.MIN_TEMPERATURE + 1;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);



        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AugmenterTemperatureCasAuLimiteMaxRetourExceptionTest()
        {

            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE);
            //Agir (Act)
            objThermostat.AugmenterTemperature();
            //Auditer (Assert)

            // InvalidOperationException attendue intercepté au niveau de l'annotation  [ExpectedException(typeof(InvalidOperationException))]

        }
        #endregion
        #region TESTS MÉTHODE DiminuerTemperature
        [TestMethod()]
        public void DiminuerTemperatureCasTempInitRetourTempInitMoinsUnTest()
        {

            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(15);
            //Agir (Act)
            objThermostat.DiminuerTemperature();
            //Auditer (Assert)
            int ValeurAttendue = 14;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);

        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DiminuerTemperatureCasAuLimiteMinRetourExceptionTest()
        {

            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MIN_TEMPERATURE);
            //Agir (Act)
            objThermostat.DiminuerTemperature();
            //Auditer (Assert)
            // InvalidOperationException attendue intercepté au niveau de l'annotation  [ExpectedException(typeof(InvalidOperationException))]

        }
        [TestMethod()]
        public void DiminuerTemperatureCasAuLimiteMaxRetourLimiteMaxMoinsUnTest()
        {

            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE);
            //Agir (Act)

            objThermostat.DiminuerTemperature();

            //Auditer (Assert)
            int ValeurAttendue = Thermostat.MAX_TEMPERATURE - 1;
            int valeurRetournee = objThermostat.Temperature;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);

        }


        #endregion

        
    }
}