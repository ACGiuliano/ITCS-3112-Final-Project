using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class DayEditor : Form
    {
        private MainForm mainForm;
        private Day selectedDay;
        public DayEditor(MainForm mainForm, Day selectedDay)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.selectedDay = selectedDay;
        }

        private void DayEditor_Load(object sender, EventArgs e)
        {
            LabelDayInfo.Text = $"{selectedDay.dayOfWeek}, {selectedDay.date.ToShortDateString()}\nCalorie Limit: {selectedDay.calorieLimit}";
        }
    }
}
