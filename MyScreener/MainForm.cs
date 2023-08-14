

using System.Configuration;
using System.Net.Http.Headers;

namespace MyScreener
{
    public partial class MainForm : Form
    {
        Point startingPoint = new Point(10, 10);

        int addCriteriaW = 140;
        int addCriteriaH = 300;

        int addCriteriaW2 = 230;

        int editCriteriaW = 400;
        int editCriteriaH = 300;

        int yOffset = 2; // Отступ по вертикали


        public MainForm()
        {
            InitializeComponent();
            InitializeAddCriteria();
            InitializeEditCriteria();
        }

        public void ApplyRadioButtonTemplate(RadioButton radioButton)
        {
            radioButton.Appearance = Appearance.Button;
            radioButton.FlatStyle = FlatStyle.Flat;
            radioButton.FlatAppearance.BorderSize = 0;
            radioButton.FlatAppearance.CheckedBackColor = Color.LightSteelBlue;
            radioButton.Width = addCriteriaW - 20;
            radioButton.Height = 34;
            radioButton.Font = new Font(radioButton.Font.FontFamily, 9, FontStyle.Regular);
            radioButton.TextAlign = ContentAlignment.MiddleLeft;

        }


        private void InitializeAddCriteria()
        {
            //addCriteriaGroupBox = new GroupBox();
            addCriteriaGroupBox.Text = "Add Criteria";
            addCriteriaGroupBox.Location = startingPoint;
            addCriteriaGroupBox.Size = new System.Drawing.Size(addCriteriaW, addCriteriaH);


            // Создание радиокнопок для выбора критериев
            string[] criteria = { "Popular", "Ratios", "Price", "Volume && Volatility", "Fundamental", "Dividends", "Technical Indicators" };

            for (int i = 0; i < criteria.Length; i++)
            {
                RadioButton radioButton = new RadioButton();
                ApplyRadioButtonTemplate(radioButton);
                radioButton.Text = criteria[i];
                radioButton.Location = new System.Drawing.Point(10, (radioButton.Height + yOffset) * (i + 1));

                addCriteriaGroupBox.Controls.Add(radioButton);
            }

            // Добавление группы фильтров на форму
            Controls.Add(addCriteriaGroupBox);
        }
        private void InitializeEditCriteria()
        {
            //editCriteriaGroupBox = new GroupBox();
            editCriteriaGroupBox.Text = "Edit Criteria";
            var thisPoint = startingPoint;
            thisPoint.Offset(new Point(20 + addCriteriaW + addCriteriaW2, 0));
            editCriteriaGroupBox.Location = thisPoint;
            editCriteriaGroupBox.Size = new System.Drawing.Size(editCriteriaW, editCriteriaH);
            Controls.Add(editCriteriaGroupBox);
        }
        private void AddPopularCriteriaControls()
        {
        }

        private void AddRatiosCriteriaControls()
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}