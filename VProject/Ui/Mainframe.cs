using System;
using System.ComponentModel;
using System.Windows.Forms;
using VProject.Data;

namespace VProject.Ui;

public partial class Mainframe: Form{
    public Mainframe(){
        InitializeComponent();
        if(DesignMode || LicenseManager.UsageMode is LicenseUsageMode.Designtime)return;
        InitData();
    }
    private void InitData(){
        cmbDiam.Items.AddRange(WheelExtension.WheelDiameters());
        cmbWidth.Items.AddRange(WheelExtension.WheelWidths());
        cmbPerc.Items.AddRange(WheelExtension.TiresPercs());
    }

    public void CalculateWheel(){
        if(cmbDiam.SelectedItem is null||cmbWidth.SelectedItem is null||cmbPerc.SelectedItem is null)return;
        
    }
    public void SaveGear(){
        
    }

    #region Wheel Events
    private void cmbDiam_IndexChange(object sender,EventArgs e)=>CalculateWheel();
    private void cmbWidth_IndexChange(object sender,EventArgs e)=>CalculateWheel();
    private void cmbPerc_IndexChange(object sender,EventArgs e)=>CalculateWheel();
    #endregion

    #region Gears Events
    private void cmbGearSelection_SelectedIndexChanged(object sender,EventArgs e)=>SaveGear();
    private void boxGear_TextChanged(object sender,EventArgs e)=>SaveGear();
    private void finalDrive_Changed(object sender,EventArgs e)=>SaveGear();
    #endregion
}