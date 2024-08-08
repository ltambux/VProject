using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VProject.Data;

namespace VProject.Ui;

public partial class Mainframe: Form {
    private Calculator _calculator;

    public Mainframe(){
        InitializeComponent();
        if(DesignMode || LicenseManager.UsageMode is LicenseUsageMode.Designtime)return;
        InitData();
    }
    private void InitData(){
        _calculator=new();
        cmbDiam.Items.AddRange(WheelExtension.WheelDiameters());
        cmbWidth.Items.AddRange(WheelExtension.WheelWidths());
        cmbPerc.Items.AddRange(WheelExtension.TiresPercs());

        cmbCar.Items.AddRange(CarContainer.Instance().Cars.Select(c=>$"{c.Brand} {c.Model}").ToArray());
        cmbGearSelection.Items.AddRange(GearRatio.GetGears());
    }

    public void CalculateWheel(){
        if(cmbDiam.SelectedItem is null||cmbWidth.SelectedItem is null||cmbPerc.SelectedItem is null)return;
        _calculator.SetWheel();
    }
    public void ChangeCar(){
        string[] carData=cmbCar.SelectedItem.ToString().Split(' ');
        var car=CarContainer.Instance().Cars.Find(c=>c.Brand.Equals(carData[0]) && c.Model.Equals(carData[1]));
        _calculator.Gears=car.GearRatios;
        boxFDrive.Text=$"{car.GearRatios.FinalDrive}";
    }
    public void SaveGear(){
        if(cmbGearSelection.SelectedItem is "")return;
        try{
            _calculator.SetGear(cmbGearSelection.SelectedItem.ToString());
        }catch(ArgumentOutOfRangeException e){
            MessageBox.Show("The selected gear is not owned by the car");
        }
    }

    #region Wheel Events
    private void cmbDiam_IndexChange(object sender,EventArgs e)=>CalculateWheel();
    private void cmbWidth_IndexChange(object sender,EventArgs e)=>CalculateWheel();
    private void cmbPerc_IndexChange(object sender,EventArgs e)=>CalculateWheel();
    #endregion

    #region Gears Events
    private void cmbCar_Change(object sender,EventArgs e)=>ChangeCar();
    private void cmbGear_Change(object sender,EventArgs e)=>SaveGear();
    #endregion
}