using ClassLibraryCrateProduction_v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppToutEmbal_v2
{
    public partial class ToutEmbalForm2 : Form
    {
        #region ############### PROPERTIES ###############
        private CrateProduction ProductionA
        {
            get;
            set;
        }
        private CrateProduction ProductionB
        {
            get;
            set;
        }
        private CrateProduction ProductionC
        {
            get;
            set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public ToutEmbalForm2()
        {
            InitializeComponent();
            ProductionA = new CrateProduction("A", 1000, 60000);
            ProductionB = new CrateProduction("B", 500, 70000);
            ProductionC = new CrateProduction("C", 2000, 80000);

            #region ## EVENT SUBSCRIBING ##
            ProductionA.ProductionStatusChange += ProductionA_ProductionStatusChange;
            ProductionB.ProductionStatusChange += ProductionB_ProductionStatusChange;
            ProductionC.ProductionStatusChange += ProductionC_ProductionStatusChange;
            ProductionA.ValidCrateAdded += ProductionA_ValidCrateAdded;
            ProductionB.ValidCrateAdded += ProductionB_ValidCrateAdded;
            ProductionC.ValidCrateAdded += ProductionC_ValidCrateAdded;
            ProductionA.FaultyCrateAdded += ProductionA_FaultyCrateAdded;
            ProductionB.FaultyCrateAdded += ProductionB_FaultyCrateAdded;
            ProductionC.FaultyCrateAdded += ProductionC_FaultyCrateAdded;
            #endregion

            UpdateHMI();
        }
        #endregion

        #region ############### UPDATE HMI METHODS ###############
        private void UpdateHMI()
        {
        }
        #endregion

        #region ############### PRODUCTION EVENTS ###############
        private void ProductionA_FaultyCrateAdded(double crateNumber)
        {
            throw new NotImplementedException();
        }
        private void ProductionB_FaultyCrateAdded(double crateNumber)
        {
            throw new NotImplementedException();
        }
        private void ProductionC_FaultyCrateAdded(double crateNumber)
        {
            throw new NotImplementedException();
        }

        private void ProductionA_ValidCrateAdded(double crateNumber)
        {
            throw new NotImplementedException();
        }
        
        private void ProductionB_ValidCrateAdded(double crateNumber)
        {
            throw new NotImplementedException();
        }
        
        private void ProductionC_ValidCrateAdded(double crateNumber)
        {
            throw new NotImplementedException();
        }

        private void ProductionA_ProductionStatusChange(CrateProduction sender)
        {
            throw new NotImplementedException();
        }

        private void ProductionB_ProductionStatusChange(CrateProduction sender)
        {
            throw new NotImplementedException();
        }

        private void ProductionC_ProductionStatusChange(CrateProduction sender)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ############### CLICK EVENTS ###############
        private void trafficLightGreenA_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightOrangeA_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightRedA_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightGreenB_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightOrangeB_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightRedB_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightGreenC_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightOrangeC_Click(object sender, EventArgs e)
        {

        }

        private void trafficLightRedC_Click(object sender, EventArgs e)
        {

        }

        private void startProductionA_Click(object sender, EventArgs e)
        {

        }

        private void startProductionB_Click(object sender, EventArgs e)
        {

        }

        private void startProductionC_Click(object sender, EventArgs e)
        {

        }

        private void pauseProductionA_Click(object sender, EventArgs e)
        {

        }

        private void pauseProductionB_Click(object sender, EventArgs e)
        {

        }

        private void pauseProductionC_Click(object sender, EventArgs e)
        {

        }

        private void stopProductionA_Click(object sender, EventArgs e)
        {

        }

        private void stopProductionB_Click(object sender, EventArgs e)
        {

        }

        private void stopProductionC_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusA_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusB_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusC_Click(object sender, EventArgs e)
        {

        }

        private void quitItem_Click(object sender, EventArgs e)
        {

        }

        private void progressBarA_Click(object sender, EventArgs e)
        {

        }

        private void progressBarB_Click(object sender, EventArgs e)
        {

        }

        private void progressBarC_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}