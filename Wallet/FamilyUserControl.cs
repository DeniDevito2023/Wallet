using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wallet.Model;

namespace Wallet
{
    public partial class FamilyUserControl : UserControl
    {
        public FamilyUserControl(FamilyMember familyMember)
        {
            InitializeComponent();

            FNSLbl.Text = familyMember.Fns;
            AgeLbl.Text = CalculateAge(familyMember.DateBirthday).ToString();
            var job = familyMember.FamilyJobs.FirstOrDefault(j => j.IdFns == familyMember.Id);
            PositionLbl.Text = job?.Doljnost ?? "Безработный";
            OrganizationLbl.Text = job?.Organisation ?? "-";
            OcladLbl.Text = job?.Oclad.ToString() ?? "-";

            ZatratyLbl.Text = CalculateSaleOclad(familyMember, job?.Oclad ?? 0) > 0 ? "Профицит бюджета" : "Дефицет бюджета";
        }

        private static string CalculateAge(DateOnly birthDate)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }
            return age.ToString();

        }
        /// <summary>
        // Здесь коммит 
        /// </summary>
        /// <param name="family"></param>
        /// <param name="sale"></param>
        /// <returns></returns>
        private static int CalculateSaleOclad(FamilyMember family, int sale)
        {
            int cost = 0;

            var expenseList = family.ExpenceProducts;

            foreach (var expense in expenseList) {
                cost += (expense.SalesProductNavigation?.Price ?? 0) * expense.Amount ?? 0;
            }

            return sale - cost;
        }


    }

}
