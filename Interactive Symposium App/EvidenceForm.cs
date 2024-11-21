using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_Symposium_App
{
    public partial class EvidenceForm : Form
    {
        public EvidenceForm()
        {
            InitializeComponent();
        }

        string numberChoice;
        private void enterButton_Click(object sender, EventArgs e)
        {
            // get the result from the combobox
            numberChoice = comboBox1.Text;

            // convert to int
            int result = Convert.ToInt32(numberChoice);

            if (result == 1) 
            {
                evidenceLabel.Text = "1. Chow, A. R. (2024). \"How meteorologists are using AI to forecast Hurricane Milton and other storms.\"\r\nThis source highlights AI advancements that can improve forecasting, demonstrating the potential for autonomous vehicles to utilize real-time weather predictions.\r\n";
            } else if (result == 2)
            {
                evidenceLabel.Text = "2. Chu, Z. (2024). \"D-YOLO: A robust framework for object detection in adverse weather conditions.\"\r\nThis source Introduces a framework that improves object detection in bad weather, addressing crucial visibility challenges for autonomous vehicle safety.\r\n";
            } else if (result == 3)
            {
                evidenceLabel.Text = "3. Lam, R. (2023). \"GraphCast: AI model for faster and more accurate global weather forecasting.\"\r\nThis source Showcases recent innovations in AI-based weather forecasting, relevant to autonomous systems requiring rapid and precise weather updates.\r\n";
            } else if (result == 4)
            {
                evidenceLabel.Text = "4. Miller, M. (2022). \"Road weather technology ensures driver safety.\"\r\nThis source explores safety technologies currently in use, offering practical examples of technology applications that enhance driver and vehicle safety";
            } else if (result == 5) 
            {
                evidenceLabel.Text = "5. Qiu, Y. et al. (2023). \"ARODNet: Adaptive rain image enhancement object detection network for autonomous driving in adverse weather conditions.\"\r\nThis source provides evidence of improving image clarity during rain, which directly supports object detection and visibility solutions for autonomous vehicles.";
            } else
            {
                evidenceLabel.Text = "6. Karvat, M. & Givigi, S. (2024). \"Adver-City: Open-source multi-modal dataset for collaborative perception under adverse weather conditions.\"\r\nThis source presents an open-source dataset for testing under diverse weather, which is critical for developing robust perception technologies.\r\n";
            }
        }

        private void evidenceLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
