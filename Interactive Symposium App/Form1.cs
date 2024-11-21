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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void introductionLabel_Click(object sender, EventArgs e)
        {
            IntroductionForm introductionForm = new IntroductionForm();
            this.Hide();
            introductionForm.ShowDialog();
            this.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void researchQuestionLabel_Click(object sender, EventArgs e)
        {
            ResearchQuestionForm researchQuestionForm = new ResearchQuestionForm(); 
            this.Hide();
            researchQuestionForm.ShowDialog();
            this.Show();
        }

        private void objectiveLabel_Click(object sender, EventArgs e)
        {
            ObjectiveForm objectiveForm = new ObjectiveForm();
            this.Hide();
            objectiveForm.ShowDialog();
            this.Show();
        }

        private void evidenceLabel_Click(object sender, EventArgs e)
        {
            EvidenceForm evidenceForm = new EvidenceForm();
            this.Hide();
            evidenceForm.ShowDialog();
            this.Show();
        }

        private void solutionsLabel_Click(object sender, EventArgs e)
        {
            SolutionForm solutionForm = new SolutionForm(); 
            this.Hide();
            solutionForm.ShowDialog();
            this.Show();
        }

        private void conclusionLabel_Click(object sender, EventArgs e)
        {
            ConclusionForm conclusionForm = new ConclusionForm();   
            this.Hide();
            conclusionForm.ShowDialog();
            this.Show();
        }

        private void referenceLabel_Click(object sender, EventArgs e)
        {
            ReferencesForm referencesForm = new ReferencesForm();   
            this.Hide();
            referencesForm.ShowDialog();
            this.Show();
        }
    }
}
