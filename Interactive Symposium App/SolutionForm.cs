using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Interactive_Symposium_App
{
    public partial class SolutionForm : Form
    {
        public SolutionForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                solutionData.Text = " 1. Chu, Z. (2024). D - YOLO: A robust framework for object detection in adverse weather conditions.This source is essential for the Solutions section as it directly addresses the issue of visibility in poor weather, presenting a robust object detection framework designed for autonomous vehicles to navigate safely despite adverse conditions.";
            }
            else if (result == 2)
            {
                solutionData.Text = "2.Qiu, Y.et al. (2023). ARODNet: Adaptive rain image enhancement object detection network for autonomous driving in adverse weather conditions. This source is critical for the Solutions section because ARODNet enhances object detection during rain, providing a practical solution to one of the major visibility challenges autonomous vehicles face in inclement weather.";
            }
            else if (result == 3)
            {
                solutionData.Text = "3.Karvat, M. & Givigi, S. (2024). Adver-City: Open-source multi-modal dataset for collaborative perception under adverse weather conditions. This source is valuable for the Solutions section as it offers a multi - modal dataset that supports the development and testing of autonomous systems in various weather conditions, laying the groundwork for more resilient perception technologies.";
            } 
            else
            {
                solutionData.Text = "4.Lam, R. (2023). GraphCast: AI model for faster and more accurate global weather forecasting. This source is relevant for the Solutions section because GraphCast’s advancements in AI - based weather forecasting could help autonomous vehicles anticipate and respond to changing weather conditions in real - time.";

            }
        }
    }
    }

