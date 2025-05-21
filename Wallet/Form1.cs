using Microsoft.EntityFrameworkCore;
using Wallet.Model;

namespace Wallet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FamilyLayoutPanel.Controls.Clear();

            using ProbnicV2Context context = new ProbnicV2Context();

            var familyMembers = context.FamilyMembers
                .Include(f => f.FamilyJobs)
                .Include(f => f.ExpenceProducts)
                .ThenInclude(e => e.SalesProductNavigation)
                .ToList();


            foreach (var familyMember in familyMembers) { 
                FamilyUserControl familyUserControl = new FamilyUserControl(familyMember);
                FamilyLayoutPanel.Controls.Add(familyUserControl);

            
            }

        }
    }
}
