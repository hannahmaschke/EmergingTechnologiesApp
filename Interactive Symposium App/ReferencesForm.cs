using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Interactive_Symposium_App
{
    public partial class ReferencesForm : Form
    {
        public ReferencesForm()
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
                referenceLabel.Text = "1. Chow, A.R. (2024, October 9). How meteorologists are using AI to forecast Hurricane Milton and other storms. TIME.";
            }
            else if (result == 2)
            {
                referenceLabel.Text = "2. Chu, Z. (2024). D-YOLO: A robust framework for object detection in adverse weather conditions. arXiv.";
            }
            else if (result == 3)
            {
                referenceLabel.Text = "3. Hogan, C. (2023, November 16). Autonomous vehicles and weather: What you need to know. Tomorrow.io.";
            }
            else if (result == 4)
            {
                referenceLabel.Text = "4. Jones, R.C. (2024, September). A powerful, new tool in hurricane forecasting. Miami.edu.";
            }
            else if (result == 5)
            {
                referenceLabel.Text = "5. Karvat, M., &Givigi, S. (2024). Adver-City: Open-source multi-modal dataset for collaborative perception under adverse weather conditions. arXiv.";
            }
            else if (result == 6)
            {
                referenceLabel.Text = "6. Lam, R. (2023, November 14). GraphCast: AI model for faster and more accurate global weather forecasting. Google DeepMind.";
            }
            else if (result == 7)
            {
                referenceLabel.Text = "7. Miller, M. (2022, September 30). Road weather technology ensures driver safety. Supply & Demand Chain Executive.";
            }
            else if (result == 8)
            {
                referenceLabel.Text = "8. Perrone, A. (2018, January 12). How will self-driving cars fare in bad weather? Endurance Warranty.";

            }
            else if (result == 9)
            {
                referenceLabel.Text = "9. Q&A: Self - driving vehicles and bad weather. (2023, August 24). Torc Robotics.";
            }
            else if (result == 10)
            {
                referenceLabel.Text = "10. Qiu, Y., Lu, Y., Wang, Y., &Jiang, H. (2023). ARODNet: Adaptive rain image enhancement object detection network for autonomous driving in adverse weather conditions. Optical Engineering.";
            }
            else if (result == 11)
            {
                referenceLabel.Text = "11. Soy, H., Ateş, T.F., &Özkan, A.O. (2024). Feasibility of LoRa-based infrastructure-to-vehicle (I2V) communication for road weather information systems. International Journal of Communication Systems.";
            }
            else if (result == 12)
            {
                referenceLabel.Text = "12. Weatherproofing the future of autonomous driving - Blog. (n.d.). Xweather.";
            }
            else if (result == 13)
            {
                referenceLabel.Text = "13. Yoneda, K., Suganuma, N., Yanase, R., & Aldibaja, M. (2019). Automated driving recognition technologies for adverse weather conditions. IATSS Research, 43(4), 253–262.";
            }
            else if (result == 14)
            {
                referenceLabel.Text = "14. How technology helps fleets mitigate extreme weather. (2021). Platform Science.";
            }
            else if (result == 15)
            {
                referenceLabel.Text = "15. Deep traffic video analysis. (2020, March 5). DataFromSky.";
            }
            else
            {
                referenceLabel.Text = "16. Inclement weather - A full stack challenge. (2023). GetCruise.com.";
            }
        }
    }
}
