using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VProject.Data;
using VProject.Services;

namespace VProject.Ui;

public partial class Mainframe: Form {
    private Calculator _calculator;
    [Category("Appearance"), Description(@"Gets or sets a value that defines the type of icon to be displayed alongside the ToolTip text. Cannot set if the property 'OwnerDraw' is true.")]
    public double TestSubject { get; set; }

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
        _calculator.SetWheel(cmbDiam.SelectedItem.ToString(),cmbWidth.SelectedItem.ToString(),cmbPerc.SelectedItem.ToString());
        boxWtot.Text=$"{_calculator.Wheel.TotalDiameter()}";
    }
    public void ChangeCar(){
        string[] carData=cmbCar.SelectedItem.ToString().Split(' ');
        _calculator.Car=CarContainer.Instance().Cars.Find(c=>c.Brand.Equals(carData[0]) && c.Model.Equals(carData[1]));
        boxFDrive.Text=$"{_calculator.Gears.FinalDrive}";
    }
    public void SaveGear(){
        if(cmbGearSelection.SelectedItem is "")return;
        try{
            _calculator.SetGear(cmbGearSelection.SelectedItem.ToString());
            boxGear.Text=$"{_calculator.SelectedGear()}";
        }catch(ArgumentOutOfRangeException ex){
            MessageBox.Show("The selected gear is not owned by the car");
            Log.Error(ex.Message);
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

    private void boxV_TextChanged(object sender,EventArgs e){
        StringHelper.CheckNumber(boxV.Text,out string val);
        boxV.Text=val;
        double result=_calculator.RPMs(double.Parse(val));
        boxRPMs.Text=$"{Math.Round(result,1)}";
        Log.Info($"{_calculator.Car.Name}: {result}");
    }
}