using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    private double dbl_lbs2lb = 1; //using pounds as a base
    private double dbl_lbs2oz = 16;
    private double dbl_lbs2g = 453.59237;
    private double dbl_lb2kg = 0.45359237;
    

    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";

        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }
    
    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtOunce.Text = "";
        txtKilograms.Text = "";
        txtgGrams.Text = "";
        txtPounds.Text = "";
     
    }
    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtOunce.Text = (KeyValue * dbl_lbs2oz).ToString("g9");
        txtKilograms.Text = (KeyValue * dbl_lb2kg).ToString("g9");
        txtgGrams.Text = (KeyValue * dbl_lbs2g).ToString("g9");
        txtPounds.Text = (KeyValue * dbl_lbs2lb).ToString("g9");

    }

    private void TxtOunce_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //lbs2oz
        double dblNumber;
        var isvalid = Double.TryParse(txtOunce.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_lbs2oz;
        }

        else
        {
            KeyValue = 0;
        }
    }

    private void TxtgGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //lbs2lg
        double dblNumber;
        var isvalid = Double.TryParse(txtgGrams.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_lbs2g;
        }

        else
        {
            KeyValue = 0;
        }
    }    

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //lbs2lb
        double dblNumber;
        var isvalid = Double.TryParse(txtPounds.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_lbs2lb;
        }

        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //lbs2lkg
        double dblNumber;
        var isvalid = Double.TryParse(txtKilograms.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_lb2kg;
        }

        else
        {
            KeyValue = 0;
        }
    }
}
