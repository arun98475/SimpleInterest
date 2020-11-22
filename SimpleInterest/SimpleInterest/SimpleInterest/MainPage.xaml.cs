using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleInterest
{
    public partial class MainPage : ContentPage
    {
        public float m_PrincAmt;
        public float m_rtIntrest;
        public int m_NoYears;
        public MainPage()
        {
            InitializeComponent();
            m_PrincAmt=0;
            m_rtIntrest=0;
            m_NoYears=0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            m_PrincAmt = float.Parse(PrinciAmt.Text);
            m_rtIntrest = float.Parse(RateOfInt.Text);
            m_NoYears = int.Parse(NoYears.Text);
            var result = m_PrincAmt * m_NoYears * m_rtIntrest / 100;
            resultValue.Text = result.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PrinciAmt.Text = "0";
            RateOfInt.Text = "0";
            NoYears.Text = "0";
            resultValue.Text = "0";
        }
    }
    
}
