namespace Wallet
{
    partial class FamilyUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            FNSLbl = new Label();
            AgeLbl = new Label();
            PositionLbl = new Label();
            OrganizationLbl = new Label();
            OcladLbl = new Label();
            ZatratyLbl = new Label();
            SuspendLayout();
            // 
            // FNSLbl
            // 
            FNSLbl.AutoSize = true;
            FNSLbl.Location = new Point(128, 61);
            FNSLbl.Name = "FNSLbl";
            FNSLbl.Size = new Size(321, 37);
            FNSLbl.TabIndex = 0;
            FNSLbl.Text = "Фамилия Имя Отчетство";
            // 
            // AgeLbl
            // 
            AgeLbl.AutoSize = true;
            AgeLbl.Location = new Point(128, 130);
            AgeLbl.Name = "AgeLbl";
            AgeLbl.Size = new Size(127, 37);
            AgeLbl.TabIndex = 1;
            AgeLbl.Text = "Возвраст";
            // 
            // PositionLbl
            // 
            PositionLbl.AutoSize = true;
            PositionLbl.Location = new Point(128, 205);
            PositionLbl.Name = "PositionLbl";
            PositionLbl.Size = new Size(262, 37);
            PositionLbl.TabIndex = 2;
            PositionLbl.Text = "Текущая должность";
            // 
            // OrganizationLbl
            // 
            OrganizationLbl.AutoSize = true;
            OrganizationLbl.Location = new Point(128, 289);
            OrganizationLbl.Name = "OrganizationLbl";
            OrganizationLbl.Size = new Size(193, 37);
            OrganizationLbl.TabIndex = 3;
            OrganizationLbl.Text = "Место работы";
            // 
            // OcladLbl
            // 
            OcladLbl.AutoSize = true;
            OcladLbl.Location = new Point(128, 377);
            OcladLbl.Name = "OcladLbl";
            OcladLbl.Size = new Size(245, 37);
            OcladLbl.TabIndex = 4;
            OcladLbl.Text = "Суммарный оклад";
            // 
            // ZatratyLbl
            // 
            ZatratyLbl.AutoSize = true;
            ZatratyLbl.BorderStyle = BorderStyle.FixedSingle;
            ZatratyLbl.Location = new Point(1642, 61);
            ZatratyLbl.Name = "ZatratyLbl";
            ZatratyLbl.Size = new Size(388, 39);
            ZatratyLbl.TabIndex = 5;
            ZatratyLbl.Text = "Соотношение трак к доходам";
            // 
            // FamilyUserControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 232, 75);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ZatratyLbl);
            Controls.Add(OcladLbl);
            Controls.Add(OrganizationLbl);
            Controls.Add(PositionLbl);
            Controls.Add(AgeLbl);
            Controls.Add(FNSLbl);
            Name = "FamilyUserControl";
            Size = new Size(2159, 459);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FNSLbl;
        private Label AgeLbl;
        private Label PositionLbl;
        private Label OrganizationLbl;
        private Label OcladLbl;
        private Label ZatratyLbl;
    }
}
